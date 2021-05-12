using EASYPOS.Controladores;
using EASYPOS.Entidades;
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
    public partial class fPOS : Form
    {
        List<ProductoPOS> listado = new List<ProductoPOS>();
        List<ProductoPOS> listadoCompra = new List<ProductoPOS>();
        CProductoPOS cProductoPOS = new CProductoPOS();
        ProductoPOS productoActual = new ProductoPOS();

        decimal subtotal;
        decimal iva;
        decimal total;
        public fPOS()
        {
            InitializeComponent();
        }

        private void fPOS_Load(object sender, EventArgs e)
        {
            listado = cProductoPOS.Listado(1);


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


            productoActual = new ProductoPOS();

            //dataGridViewProductos.DataSource = listadoCompra;

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
            try
            {
                string busqueda = textBoxBusqueda.Text.Trim();
                productoActual = listado.Where(x => x.Codigo == busqueda || x.Nombre==busqueda).FirstOrDefault();
                if (productoActual!=null)
                {
                    textBoxNombre.Text = productoActual.Nombre;
                    textBoxPrecio.Text = productoActual.Precio.ToString("c");
                }  else
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
            int cantidad = int.Parse(textBoxCantidad.Text);
            productoActual.Total = Math.Round(cantidad * productoActual.Precio, 2);
            productoActual.Cantidad = cantidad;
            listadoCompra.Add(productoActual);
            productoPOSBindingSource.DataSource = null;
            productoPOSBindingSource.DataSource = listadoCompra;
            /*
            productoPOSBindingSource.MoveLast();
            productoPOSBindingSource.Add(productoActual);
            productoPOSBindingSource.EdEdit();
            */
            textBoxBusqueda.Text = "";
            textBoxBusqueda.Focus();
            limpiar();


            calculos();
            


        }

        private void calculos()
        {
            subtotal = listadoCompra.Sum(x => x.Total)/1.13m;
            iva = Math.Round(subtotal * 0.13m,2);
            total = listadoCompra.Sum(x => x.Total);

            textBoxSubtotal.Text = subtotal.ToString("c");
            textBoxIva.Text = iva.ToString("c");
            textBoxTotal.Text = total.ToString("c");


        }

        private void limpiar()
        {
            productoActual = new ProductoPOS();
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            textBoxCantidad.Text = "";
        }
    }
}
