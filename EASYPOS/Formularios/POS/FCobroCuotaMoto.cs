using EASYPOS.Controladores;
using EASYPOS.Entidades;
using ESC_POS_USB_NET.Printer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using con = EASYPOS.Entidades.Contratos;
namespace EASYPOS.Formularios.POS
{
    public partial class FCobroCuotaMoto : Form
    {
        int contrato;
        int idcuota;
        con c;
        Cuotas cuota;
        Boolean solouna = false;
        List<int> idcuotas= new List<int>();
        decimal cacumulado, iacumulado, mora;
        public FCobroCuotaMoto(int idcuota, int id, List<int> idcuotas=null, decimal cacumulado=0M, decimal iacumulado=0M , decimal mora=0M)
        {
            this.contrato = id;
            this.idcuota = idcuota;
            CCuota cCuota = new CCuota();
            if (this.idcuota>0)
            {
                this.cuota = cCuota.ObtenerUna(this.idcuota);
            }
            this.cacumulado = cacumulado;
            this.iacumulado = iacumulado;
            this.mora = mora;
          //  this.solouna = solouna;
            this.idcuotas = idcuotas;
            InitializeComponent();
            txtpago.Focus();
        }

        public FCobroCuotaMoto(int idcuota, int id, Boolean solouna,decimal mora = 0M)
        {
           
            this.contrato = id;
            this.idcuota = idcuota;
            CCuota cCuota = new CCuota();
            this.solouna = solouna;
            this.cuota = cCuota.ObtenerUna(this.idcuota);
            this.mora = this.cuota.Capital.Value*0.05M;
            //  this.solouna = solouna;
            InitializeComponent();
            txtpago.Focus();
        }

        private void FCobroCuotaMoto_Load(object sender, EventArgs e)
        {
            if (idcuota<0 || solouna)
            {
                button3.Visible = false;
            }
            CContratos cContratos = new CContratos();
            //c = new con();
            c = cContratos.uno(contrato);
            

            txtcliente.Text = c.NombreCompleto;
            txtfecha.Text = c.FechaInicio.ToString();
            txtfinanciamiento.Text = c.Financiamiento.Value.ToString("F");
            txtsaldoactual.Text = c.Restante.Value.ToString("F");
            if (this.idcuota>0)
            {
                txtmonto.Text = cuota.Monto.Value.ToString("F");
                txtpago.Text = cuota.Monto.Value.ToString("F");
            }
            else
            {
                txtmonto.Text = (cacumulado+iacumulado+mora).ToString("F");
                txtpago.Text = (cacumulado + iacumulado + mora).ToString("F");
            }
            txtmora.Text = mora.ToString("F");

            if (solouna)
            {
                txtpago.Text = cuota.Monto.Value.ToString("F");
                txtpago.ReadOnly = true;
                labelAviso.Visible = true;
            }
            txtpago.Focus();
        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal pago = decimal.Parse(txtpago.Text);
                if (idcuota > 0 && pago <cuota.Monto)
                {
                    aviso.Visible = true;
                    txtacapital.Text = ("0.00");
                    txtaintereses.Text = ("0.00");
                    txtcapitalextra.Text = ("0.00");
                    txtcapitaldespues.Text = ("0.00");
                }
                else if(idcuota > 0 &&  pago >=cuota.Monto) {
                    aviso.Visible = false;
                    txtacapital.Text = cuota.Capital.ToString();
                    txtaintereses.Text = cuota.Intereses.ToString();

                    if (pago>cuota.Monto)
                    {
                        txtcapitalextra.Text = (pago - cuota.Monto).ToString();
                    }
                    else {
                        txtcapitalextra.Text = "0.00";
                    }

                    decimal suma = decimal.Parse(txtacapital.Text) + decimal.Parse(txtcapitalextra.Text);

                    txtcapitaldespues.Text = (c.Restante - suma).ToString();
                }
                else
                {
                    //cuando se paga todo lo atrasado
                    aviso.Visible = false;
                    txtacapital.Text = cacumulado.ToString();
                    txtaintereses.Text = iacumulado.ToString();
                    txtcapitalextra.Text = "0.00";
                    decimal suma = cacumulado;
                    txtcapitaldespues.Text = (c.Restante - suma).ToString();

                }
            }
            catch (Exception)
            {

                
            }
        }
        private int ObtenerCorrelativo()
        {
            CCorrelativo cCorrelativo = new CCorrelativo();
            return cCorrelativo.ObtenerCorrelativo(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(txtpago.Text);
            FCobro f = new FCobro(total);
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                int documento = 1, correlativo = ObtenerCorrelativo();
                DateTime fecha = DateTime.Now;
                //if (textBoxDocumento.Text == "CONSUMIDOR") documento = 2;
                //  if (textBoxDocumento.Text == "C. FISCAL") documento = 3;
                //  GenCliente();
                if (idcuota<0)
                {
                    int contador = 1;
                    decimal pendiente = decimal.Parse(txtsaldoactual.Text);
                    foreach (int idc in idcuotas)
                    {
                        Cuotas cuota = new Cuotas();
                        CCuota cCuota = new CCuota();
                        cuota = cCuota.ObtenerUna(idc);
                        cuota.FechaDePago = fecha;
                        //venta.IdEmpleado_FK = 1;
                        cuota.Correlativo = correlativo;
                        cuota.IdCorrelativo_FK = 1;
                        //cuota.IdContrato_FK = idContrato;
                        if (contador==1)
                        {
                            cuota.EfectivoRecibido = f.recibe;
                            cuota.Cambio = f.cambio;
                            cuota.MontoCancelado = total;
                            cuota.mora = mora;
                            cuota.comentario = "Cuota pagada en conjunto, en esta se registró el monto pagado, efectivo recibido y cambio.";
                        }
                        else
                        {
                            cuota.EfectivoRecibido = 0;
                            cuota.Cambio = 0;
                            cuota.MontoCancelado = 0;
                            cuota.comentario = "Cuota pagada en conjunto, revise la cuota anterior para los detalles del pago";
                        }
                        
                        
                        cuota.ACapital = cuota.Capital;
                        cuota.AIntereses = cuota.Intereses;
                        cuota.ACapitalExtra = 0;
                        pendiente = pendiente - cuota.Capital.Value;
                        cuota.CapitalPendiente = pendiente;
                        if (otrafecha.Checked)
                        {
                           // cuota.FechaDePago = dateTimePickerFechaPago.Value;
                        }

                       // CCuota cCuota = new CCuota();
                        int si = cCuota.Insertar(cuota);
                        CContratos cContratos = new CContratos();
                        con contrato = new con();
                        contrato = cContratos.uno(cuota.IdContrato_FK);
                        contrato.Restante = cuota.CapitalPendiente;
                        cContratos.ActualizarRestante(contrato);
                        if (si >= 1)
                        {
                            
                            imprimirTicket(si);
                            //this.Close();
                        }
                        contador++;
                        correlativo = ObtenerCorrelativo();
                    }
                    MessageBox.Show(this, "Cuotas registradas con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    Cuotas cuota = this.cuota;
                    cuota.FechaDePago = fecha;
                    //venta.IdEmpleado_FK = 1;
                    cuota.Correlativo = correlativo;
                    cuota.IdCorrelativo_FK = 1;
                    //cuota.IdContrato_FK = idContrato;
                    cuota.EfectivoRecibido = f.recibe;
                    cuota.Cambio = f.cambio;
                    cuota.MontoCancelado = total;
                    cuota.ACapital = decimal.Parse(txtacapital.Text);
                    cuota.AIntereses = decimal.Parse(txtaintereses.Text);
                    cuota.ACapitalExtra = decimal.Parse(txtcapitalextra.Text);
                    cuota.CapitalPendiente = decimal.Parse(txtcapitaldespues.Text);
                    if (otrafecha.Checked)
                    {
                        cuota.FechaDePago = dateTimePickerFechaPago.Value;
                    }

                    CCuota cCuota = new CCuota();
                    int si = cCuota.Insertar(cuota);
                    CContratos cContratos = new CContratos();
                    con contrato = new con();
                    contrato = cContratos.uno(cuota.IdContrato_FK);
                    contrato.Restante = cuota.CapitalPendiente;
                    cContratos.ActualizarRestante(contrato);
                    if (si >= 1)
                    {
                        MessageBox.Show(this, "Cuota registrada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        imprimirTicket(si);
                        this.Close();
                    }
                }
                
            }
        }
        void imprimirTicket(int id)
        {
            CContratos cContratos = new CContratos();
            CCuota cCuota = new CCuota();
            Cuotas c = new Cuotas();
            c = cCuota.ObtenerUna(id);
            con contrato = new con();
            contrato = cContratos.uno(c.IdContrato_FK);


            CConfiguracion cConfiguracion = new CConfiguracion();
            Configuracion config = cConfiguracion.ObtenerConfiguracion();
            Printer printer = new Printer(config.Impresora);

            CCorrelativo ccorrelativo = new CCorrelativo();
            Correlativo correlativo = ccorrelativo.ObtenerUna(c.IdCorrelativo_FK);

            printer.AlignCenter();
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.BoldMode(config.NombreEmpresa);
            //Bitmap image = new Bitmap(Bitmap.FromFile("Icon.bmp"));
            //printer.Image(image);
            printer.Append(config.Direccion);
            printer.Append("NIT:" + config.NIT);
            printer.Append("NRC:" + config.NRC);
            printer.Append("Fecha:" + c.FechaDePago);
            printer.Append("Ticket #" + c.Correlativo);
            printer.Append("Cliente:" + contrato.NombreCompleto);
            printer.Append("--------------------------------------");

            printer.AlignLeft();
            printer.Append("Descripción del pago");

            
            printer.Append("Total cancelado = $" + c.MontoCancelado.Value.ToString("F"));
            printer.Append("A intereses = $" + c.AIntereses.Value.ToString("F"));
            printer.Append("A capital = $" + c.ACapital.Value.ToString("F"));
            printer.Append("Abono extra a capital = $" + c.ACapitalExtra.Value.ToString("F"));
            printer.Append("--------------");
            printer.Append("Capital pendiente = $" + c.CapitalPendiente.Value.ToString("F"));

            printer.AlignCenter();
            printer.Append("--------------------------------------");
            printer.AlignLeft();
            printer.Append("Ventas Afectas:" + c.Monto);
            printer.Append("Ventas Exentas:" + "0.00");
            printer.AlignCenter();
            printer.Append("--------------------------------------");
            printer.AlignLeft();
            printer.Append("Recibido:" + c.EfectivoRecibido.Value);
            printer.Append("Cambio:" + c.Cambio.Value);
            printer.AlignCenter();
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("Gracias por su compra");
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("                                        ");

            printer.Append("Resolución: " + correlativo.Resolucion);
            printer.Append("Del " + "0000001 al " + correlativo.Fin);
            printer.Append("Autorización:" + correlativo.Autorizacion);
            printer.Append("Fecha de resolución:" + correlativo.FechaDeAutorizacion.ToString());
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.FullPaperCut();
            try
            {
                printer.PrintDocument();
            }
            catch (Exception)
            {

                
            }
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtpago.Text = (c.Restante.Value + cuota.Intereses.Value).ToString();
        }
    }
}
