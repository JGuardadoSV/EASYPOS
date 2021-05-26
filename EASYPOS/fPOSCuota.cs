using EASYPOS.Controladores;
using EASYPOS.Entidades;
using EASYPOS.Formularios.Contratos;
using EASYPOS.Formularios.POS;
using EASYPOS.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPOS
{
    public partial class fPOSCuota : Form
    {
        List<Contratos> listado = new List<Contratos>();
        List<Cuotas> listadoCompra = new List<Cuotas>();
        List<Cuotas> listadoCuotas = new List<Cuotas>();
        CContratos cContratos = new CContratos();
        Cuotas cuotaActual = new Cuotas();
        Contratos contratoActual = new Contratos();
        int idContrato;
        Cuotas cuota;
        DatosCliente cliente = new DatosCliente();
        decimal subtotal;
        decimal iva;
        decimal total;
        public fPOSCuota()
        {
            InitializeComponent();
        }

        private void fPOSCuota_Load(object sender, EventArgs e)
        {
            ObtenerCorrelativo();
            
            listado = cContratos.Listado(false);


            TXTNombre.Text = "Nombre del cliente";
            TXTNombre.Enter += new EventHandler(RemoveText);
            TXTNombre.Leave += new EventHandler(AddText);

            TXTDui.Text = "DUI";
            TXTDui.Enter += new EventHandler(RemoveText);
            TXTDui.Leave += new EventHandler(AddText);

            TXTNit.Text = "NIT";
            TXTNit.Enter += new EventHandler(RemoveText);
            TXTNit.Leave += new EventHandler(AddText);

            TXTNrc.Text = "NRC";
            TXTNrc.Enter += new EventHandler(RemoveText);
            TXTNrc.Leave += new EventHandler(AddText);

            TXTTelefono.Text = "Teléfono";
            TXTTelefono.Enter += new EventHandler(RemoveText);
            TXTTelefono.Leave += new EventHandler(AddText);

            TXTGiro.Text = "Giro";
            TXTGiro.Enter += new EventHandler(RemoveText);
            TXTGiro.Leave += new EventHandler(AddText);

            TXTDireccion.Text = "Dirección";
            TXTDireccion.Enter += new EventHandler(RemoveText);
            TXTDireccion.Leave += new EventHandler(AddText);


            contratoActual = new Contratos();

            //dataGridViewProductos.DataSource = listadoCompra;

        }

        private void ObtenerCorrelativo()
        {
            CCorrelativo cCorrelativo = new CCorrelativo();
            textBoxCorrelativo.Text = cCorrelativo.ObtenerCorrelativo(1).ToString();
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (sender.Equals(TXTNombre))
                if (TXTNombre.Text == "Nombre del cliente") TXTNombre.Text = "";
            if (sender.Equals(TXTTelefono))
                if (TXTTelefono.Text == "Teléfono") TXTTelefono.Text = "";
            if (sender.Equals(TXTDui))
                if (TXTDui.Text == "DUI") TXTDui.Text = "";
            if (sender.Equals(TXTDireccion))
                if (TXTDireccion.Text == "Dirección") TXTDireccion.Text = "";
            if (sender.Equals(TXTNit))
                if (TXTNit.Text == "NIT") TXTNit.Text = "";
            if (sender.Equals(TXTNrc))
                if (TXTNrc.Text == "NRC") TXTNrc.Text = "";
            if (sender.Equals(TXTGiro))
                if (TXTGiro.Text == "Giro") TXTGiro.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTNombre.Text))TXTNombre.Text = "Nombre del cliente";
            if (string.IsNullOrWhiteSpace(TXTTelefono.Text)) TXTTelefono.Text = "Teléfono";
            if (string.IsNullOrWhiteSpace(TXTDui.Text)) TXTDui.Text = "DUI";
            if (string.IsNullOrWhiteSpace(TXTDireccion.Text)) TXTDireccion.Text = "Dirección";
            if (string.IsNullOrWhiteSpace(TXTNit.Text)) TXTNit.Text = "NIT";
            if (string.IsNullOrWhiteSpace(TXTNrc.Text)) TXTNrc.Text = "NRC";
            if (string.IsNullOrWhiteSpace(TXTGiro.Text)) TXTGiro.Text = "Giro";
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
           Busqueda();
            

        }

        private void Busqueda()
        {
            try
            {
                string busqueda = textBoxBusqueda.Text.Trim();
                contratoActual = listado.Where(x => x.NombreCompleto == busqueda || x.Dui == busqueda).FirstOrDefault();
                if (contratoActual != null)
                {
                    textBoxNombre.Text = contratoActual.NombreCompleto;
                    textBoxPrecio.Text = "$"+contratoActual.Cuota.ToString();
                    TXTNombre.Text= contratoActual.NombreCompleto;
                    TXTDui.Text = contratoActual.Dui;
                    TXTNit.Text = contratoActual.Nit;
                    TXTTelefono.Text = contratoActual.Celular;
                    TXTDireccion.Text = contratoActual.DireccionCasa;
                }
                else
                {
                    limpiar();
                }
            }
            catch (NullReferenceException ex)
            {

                limpiar();
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (cuotasBindingSource.Count==0)
            {

           
            int cantidad = 1;
            Contratos producto = new Contratos();
          //  producto = contratoActual;
           // producto.Cuota = Math.Round(cantidad * contratoActual.Cuota.Value, 2);
            //producto.Cantidad = cantidad;
            idContrato = contratoActual.IdContrato;
            listadoCompra.Add(
                new Cuotas { 
                  Monto=cuota.Monto,
                  Fecha=cuota.Fecha,
                  IdCuota=cuota.IdCuota
                  
            });
            cuotasBindingSource.DataSource = null;
            cuotasBindingSource.DataSource = listadoCompra;
            
            textBoxBusqueda.Text = "";
            textBoxBusqueda.Focus();
            limpiar();


            calculos();

            }
            else
            {
                MessageBox.Show("Solo se permite agregar una cuota por pago");
            }

        }

        private void calculos()
        {
            if (listadoCompra.Count>0)
            {

            
            subtotal = listadoCompra.Sum(x => x.Monto.Value)/1.13m;
            iva = Math.Round(subtotal * 0.13m,2);
            total = listadoCompra.Sum(x => x.Monto.Value);

            textBoxSubtotal.Text = subtotal.ToString("c");
            textBoxIva.Text = iva.ToString("c");
            textBoxTotal.Text = total.ToString("c");
            }
            else
            {
                textBoxSubtotal.Text = "";
                textBoxIva.Text = "";
                textBoxTotal.Text = "";
            }
            
        }

        private void limpiar()
        {
            //contratoActual = new Contratos();
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            //textBoxCantidad.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (cuotasBindingSource.Count==0)
            {

          
            FContratos formulario = new FContratos(true);
            formulario.ShowDialog();
            if (formulario.DialogResult==DialogResult.OK)
            {
                
                if (formulario.cuota != null)
                {
                    textBoxBusqueda.Text = formulario.c.Dui;
                    this.cuota = formulario.cuota;
                    //cuotasBindingSource.DataSource = cuota;
                      Busqueda();
                }
            }

            }
            else
            {
                MessageBox.Show("Solo se puede procesar una cuota a la vez");
            }
            //textBoxCantidad.Focus();
        }

        private void buttonCobrar_Click(object sender, EventArgs e)
        {
            
            if (TXTNombre.Text.Equals("Nombre del cliente") )
            {
                MessageBox.Show(this,"Introduzca el nombre del cliente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }else if(listadoCompra.Count == 0)
            {
                MessageBox.Show(this, "No hay artículos agregados a la venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                FCobro f = new FCobro(total);
                f.ShowDialog();

                if (f.DialogResult==DialogResult.OK)
                {
                    int documento = 1, correlativo = int.Parse(textBoxCorrelativo.Text);
                    DateTime fecha = dateTimePickerFecha.Value;
                    if (textBoxDocumento.Text == "CONSUMIDOR") documento = 2;
                    if (textBoxDocumento.Text == "C. FISCAL") documento = 3;
                    GenCliente();

                    Cuotas cuota = this.cuota;
                    cuota.FechaDePago = fecha;
                    //venta.IdEmpleado_FK = 1;
                    cuota.Correlativo = correlativo;
                    cuota.IdCorrelativo_FK = 1;
                    //cuota.IdContrato_FK = idContrato;
                    
                    CCuota cCuota = new CCuota();
                  int si = cCuota.Insertar(cuota);

                    if (si == 1)
                    {
                        MessageBox.Show(this, "Cuota registrada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }


                
                





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void GenCliente()
        {
            cliente.Nombre = TXTNombre.Text;
            cliente.DUI = TXTDui.Text;
            cliente.NIT = TXTNit.Text;
            cliente.NRC = TXTNrc.Text;
            cliente.Telefono = TXTTelefono.Text;
            cliente.Direccion = TXTDireccion.Text;
            cliente.Giro = TXTGiro.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.cuota = null;
            cuotasBindingSource.DataSource = null;
        }
    }
}
