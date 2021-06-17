using EASYPOS.Controladores;
using EASYPOS.Entidades;
using ESC_POS_USB_NET.Printer;
using Itenso.TimePeriod;
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
    public partial class FCobroCuotaMoto:Form
    {
        int contrato;
        int idcuota;
        con c;
        Cuotas cuota;
        Boolean solouna = false, pagartodo = false, soloACapital=false;
        List<int> idcuotas = new List<int>();
        decimal cacumulado, iacumulado, mora = 0;
        public FCobroCuotaMoto(Cuotas cuota, decimal CapitalAcumulado, decimal InteresAcumulado, decimal mora, bool pagartodo)
        {
            // si la fecha de cuota ya paso cobrar!!

           
            CCuota cCuota = new CCuota();
            //averiguando la cuota anterior
            Cuotas c1 = new Cuotas();
            c1 = cCuota.CuotaAnterior(cuota.IdCuota);
            
            if (c1 != null)
            {// Si hay cuota anterior
                //DateDiff comparacion = new DateDiff(c1.Fecha.Value.Date, DateTime.Now.Date);
                //var mesesTranscurridos = comparacion.Months;
                if ( DateTime.Now.Date >c1.Fecha.Value.Date  )
                {
                    
                }
                else
                {
                    soloACapital = true;
                }
                if (c1.Cancelada==1  && (c1.Fecha.Value.Date<cuota.Fecha.Value.Date) )
                {
                  //  soloACapital = true;
                }
            }
            else
            {
                if (cuota.Fecha.Value.Date > DateTime.Now.Date)
                {
                  //  soloACapital = true;
                }
            }
            

            if (DateTime.Now<cuota.Fecha.Value)
            {
             //   soloACapital = true; 
            }


            this.contrato = cuota.IdContrato_FK;
            this.idcuota = cuota.IdCuota;
            this.cuota = cuota;
            this.cacumulado = CapitalAcumulado;
            this.iacumulado = InteresAcumulado;
            if (mora>0)
            {
                this.mora = Math.Round(cuota.Capital.Value * 0.05M, 2);
            }
            else
            {
                this.mora = 0;
            }
            

            InitializeComponent();
            txtpago.Focus();
        }



        private void FCobroCuotaMoto_Load(object sender, EventArgs e)
        {

            dateTimePickerFechaPago.Value = cuota.Fecha.Value;
            textBoxMora1.Text = mora.ToString("F");
            CContratos cContratos = new CContratos();
            //c = new con();
            c = cContratos.uno(contrato);


            txtcliente.Text = c.NombreCompleto;
            txtfecha.Text = c.FechaInicio.ToString();
            txtfinanciamiento.Text = c.Financiamiento.Value.ToString("F");
            txtsaldoactual.Text = c.Restante.Value.ToString("F");
            if (this.idcuota > 0)
            {
                txtmonto.Text = (mora + cuota.Monto.Value).ToString("F");
                txtpago.Text = (mora + cuota.Monto.Value).ToString("F");
            }
            else
            {
                txtmonto.Text = (cacumulado + iacumulado + mora).ToString("F");
                txtpago.Text = (cacumulado + iacumulado + mora).ToString("F");
            }
            txtmora.Text = mora.ToString("F");

            if (solouna)
            {
                txtpago.Text = cuota.Monto.Value.ToString("F");
                txtpago.ReadOnly = true;

            }
            txtpago.Focus();

            if (soloACapital)
            {
                txtmonto.Text = "0.00";
            }
        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            decimal ainteres = 0, amora = 0, acapital = 0, acapitalextra = 0;

            try
            {
                decimal pago = decimal.Parse(txtpago.Text);
                if (soloACapital == true)
                {
                    acapitalextra = pago;
                }
                else
                {
                    //MORA
                    if (pago > mora)
                    {
                        amora = mora;
                        pago = pago - mora;
                    }
                    else
                    {
                        amora = pago;
                        pago = 0;
                    }
                    //INTERESES

                    if (pago > cuota.Intereses)
                    {
                        ainteres = cuota.Intereses.Value;
                        pago = pago - cuota.Intereses.Value;
                    }
                    else
                    {
                        ainteres = pago;
                        pago = 0;
                    }

                    //CAPITAL

                    if (pago > cuota.Capital.Value)
                    {
                        acapital = cuota.Capital.Value;
                        pago = pago - cuota.Capital.Value;
                    }
                    else
                    {
                        acapital = pago;
                        pago = 0;
                    }
                    //CAPITALEXTRA

                    if (pago > 0)
                    {
                        acapitalextra = pago;

                    }
                }



                txtmora.Text = amora.ToString("F");
                txtaintereses.Text = ainteres.ToString("F");
                txtacapital.Text = acapital.ToString("F");
                txtcapitalextra.Text = acapitalextra.ToString("F");

                decimal suma = decimal.Parse(txtacapital.Text) + decimal.Parse(txtcapitalextra.Text);
                txtcapitaldespues.Text = (c.Restante - suma).ToString();

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

                CCuota cCuota = new CCuota();
                Cuotas cuota = this.cuota;

                if (soloACapital)
                {
                    //averiguando la cuota anterior
                    Cuotas c1 = new Cuotas();
                    c1 = cCuota.CuotaAnterior(cuota.IdCuota);

                    if (c1!=null)
                    {
                        cuota = c1;
                    }
                    
                }



                Pagos pago = new Pagos();
                pago.IdCuota_FK = cuota.IdCuota;
                pago.FechaPago = fecha;
                pago.Correlativo = correlativo;
                pago.IdCorrelativo_FK = 1;
                pago.Recibido = f.recibe;
                pago.Cambio = f.cambio;
                pago.Monto = total;
                pago.AMora = mora;
                pago.ACapital = decimal.Parse(txtacapital.Text);
                pago.AIntereses = decimal.Parse(txtaintereses.Text);
                pago.ACApitalExtra = decimal.Parse(txtcapitalextra.Text);
                pago.CapitalRestante = decimal.Parse(txtcapitaldespues.Text);
                if (otrafecha.Checked )
                {
                    pago.FechaPago = dateTimePickerFechaPago.Value;
                }

                cuota.CapitalPendiente = pago.CapitalRestante;

                if (pago.Monto >= cuota.Monto && soloACapital == false)
                {
                    cuota.FechaDePago = pago.FechaPago;
                    cuota.Cancelada = 1;
                }
                

                    if (soloACapital == false)
                    {



                        cuota.mora = pago.AMora;
                        cuota.AIntereses = pago.AIntereses;
                        cuota.ACapital = pago.ACapital;
                        cuota.ACapitalExtra = pago.ACApitalExtra;
                        cuota.CapitalPendiente = pago.CapitalRestante;
                        cuota.Intereses = cuota.Intereses - cuota.AIntereses;
                        cuota.Capital = cuota.Capital - cuota.ACapital;
                        cuota.Monto = cuota.Intereses + cuota.Capital;
                    }
                    else
                    {

                        cuota.ACapitalExtra = pago.ACApitalExtra;
                    }

                


                
                

                CPagos cPagos = new CPagos();
                cPagos.Insertar(pago);
               int si = cCuota.Insertar(cuota);
                CContratos cContratos = new CContratos();
                con contrato = new con();
                contrato = cContratos.uno(cuota.IdContrato_FK);
                contrato.Restante = pago.CapitalRestante;
                cContratos.ActualizarRestante(contrato);

                MessageBox.Show("Pago realizado con éxito");
                try
                {
                    if (!checkBoxNoTicket.Checked)
                    {
                        imprimirTicket(pago);
                    }
                    
                }
                catch (Exception)
                {

                }
               
                this.Close();



            }
        }
        void imprimirTicket(Pagos pago)
        {
            CContratos cContratos = new CContratos();
            con contrato = new con();
            CCuota cCuota = new CCuota();
            Cuotas c = new Cuotas();
            c = cCuota.ObtenerUna(pago.IdCuota_FK);
            contrato = cContratos.uno(c.IdContrato_FK);


            CConfiguracion cConfiguracion = new CConfiguracion();
            Configuracion config = cConfiguracion.ObtenerConfiguracion();
            Printer printer = new Printer(config.Impresora);

            CCorrelativo ccorrelativo = new CCorrelativo();
            Correlativo correlativo = ccorrelativo.ObtenerUna(pago.IdCorrelativo_FK);

            printer.AlignCenter();
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.BoldMode(config.NombreEmpresa);
            printer.BoldMode(config.municipio);
            //Bitmap image = new Bitmap(Bitmap.FromFile("Icon.bmp"));
            //printer.Image(image);
            printer.Append(config.Direccion);
            printer.Append("TELEFONO: "+config.Telefono);
            printer.Append("NIT:" + config.NIT);
            printer.Append("NRC:" + config.NRC);
            printer.Append("Fecha:" + pago.FechaPago);
            printer.Append("Ticket #" + pago.Correlativo);
            printer.Append("Cliente:" + contrato.NombreCompleto);
            printer.Append("--------------------------------------");

            printer.AlignLeft();
            printer.Append("Descripción del pago");


            printer.Append("Total cancelado = $" + pago.Monto.ToString("F"));
           // printer.Append("Cuota con vencimiento al " + c.Fecha.Value.ToString());
            if (pago.Comentario != null)
            {
                printer.Append("--------------");
                printer.Append("Información:" + pago.Comentario);
                printer.Append("--------------");
            }
            printer.Append("A intereses = $" + pago.AIntereses.ToString("F"));
            printer.Append("A capital = $" + pago.ACapital.ToString("F"));
            printer.Append("Abono extra a capital = $" + pago.ACApitalExtra.ToString("F"));
            printer.Append("--------------");
            printer.Append("Capital pendiente = $" + pago.CapitalRestante.ToString("F"));

            printer.AlignCenter();
            printer.Append("--------------------------------------");
            printer.AlignLeft();
            printer.Append("Ventas Afectas:" + pago.Monto);
            printer.Append("Ventas Exentas:" + "0.00");
            printer.AlignCenter();
            printer.Append("--------------------------------------");
            printer.AlignLeft();
            printer.Append("Recibido:" + pago.Recibido);
            printer.Append("Cambio:" + pago.Cambio);
            printer.AlignCenter();
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("Gracias por su pago");
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (mora > 0)
            {
                FDescuentoMora f = new FDescuentoMora(mora);
                f.ShowDialog();

                if (f.DialogResult == DialogResult.OK)
                {

                    //this.mora = f.nuevamora;
                    if (f.nuevamora == 0)
                    {
                        txtmonto.Text = (decimal.Parse(txtmonto.Text) - mora).ToString();
                        this.mora = 0;
                        txtpago.Text = txtmonto.Text;
                        txtmora.Text = this.mora.ToString("F");
                    }
                    else
                    {
                        decimal quitar = this.mora - f.nuevamora;
                        this.mora = f.nuevamora;
                        txtmonto.Text = (decimal.Parse(txtmonto.Text) - quitar).ToString();
                        txtpago.Text = txtmonto.Text;
                        txtmora.Text = this.mora.ToString("F");
                    }

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtpago.Text = (c.Restante.Value + cuota.Intereses.Value+this.mora).ToString();
        }
    }
}
