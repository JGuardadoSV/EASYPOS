using EASYPOS.Controladores;
using EASYPOS.Entidades;
using EASYPOS.Formularios.POS;
using EASYPOS.Modelos;
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

namespace EASYPOS
{
    public partial class fPOS : Form
    {
        List<ProductoPOS> listado = new List<ProductoPOS>();
        List<ProductoPOS> listadoCompra = new List<ProductoPOS>();
        CProductoPOS cProductoPOS = new CProductoPOS();
        ProductoPOS productoActual = new ProductoPOS();
        DatosCliente cliente = new DatosCliente();
        decimal subtotal;
        decimal iva;
        decimal total;
        public fPOS()
        {
            InitializeComponent();
        }

        private void fPOS_Load(object sender, EventArgs e)
        {
            ObtenerCorrelativo();
            
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
                productoActual = listado.Where(x => x.Codigo == busqueda || x.Nombre == busqueda).FirstOrDefault();
                if (productoActual != null)
                {
                    textBoxNombre.Text = productoActual.Nombre;
                    textBoxPrecio.Text = productoActual.Precio.ToString("c");
                    
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
            int cantidad = int.Parse(textBoxCantidad.Text);
            ProductoPOS producto = new ProductoPOS();
            producto = productoActual;
            producto.Total = Math.Round(cantidad * producto.Precio, 2);
            producto.Cantidad = cantidad;

            listadoCompra.Add(
                new ProductoPOS { 
                Cantidad=producto.Cantidad, 
                Codigo=producto.Codigo, 
                IdDetalleInventario=producto.IdDetalleInventario, 
                IdInventario=producto.IdInventario, 
                IdProducto=producto.IdProducto, 
                Nombre=producto.Nombre, 
                Precio=producto.Precio, 
                Total=producto.Total,
                Numero=listadoCompra.Count+1
            });
            productoPOSBindingSource.DataSource = null;
            productoPOSBindingSource.DataSource = listadoCompra;
            
            textBoxBusqueda.Text = "";
            textBoxBusqueda.Focus();
            limpiar();


            calculos();
            


        }

        private void calculos()
        {
            if (listadoCompra.Count>0)
            {

            
            subtotal = listadoCompra.Sum(x => x.Total)/1.13m;
            iva = Math.Round(subtotal * 0.13m,2);
            total = listadoCompra.Sum(x => x.Total);

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
            productoActual = new ProductoPOS();
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            textBoxCantidad.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FListadoProductosPOS formulario = new FListadoProductosPOS(1);
            formulario.ShowDialog();
            textBoxBusqueda.Text = formulario.productoPos.Codigo;
            Busqueda();
            textBoxCantidad.Focus();
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

                    Venta venta = new Venta();
                    venta.Total = f.total;
                    venta.Efectivo = f.recibe;
                    venta.Cambio = f.cambio;
                    venta.Fecha = fecha;
                    venta.IdEmpleado_FK = 1;
                    venta.TipoDocumento = documento;
                    venta.IdCliente_FK = 1;
                    venta.Correlativo = correlativo;
                    venta.IdCorrelativo_FK = 1;
                    CVenta cVentas = new CVenta();
                    int id = cVentas.Insertar(venta, listadoCompra);

                    if (id >0)
                    {
                        MessageBox.Show(this, "Venta realizada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        imprimirTicket(id);
                        this.Close();
                    }
                }


                
                





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listadoCompra.Count==0 )
            {
                MessageBox.Show(this, "Seleccione un artículo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            
                ProductoPOS p = new ProductoPOS();
                p = (ProductoPOS)productoPOSBindingSource.Current;

                listadoCompra.Remove(p);
                productoPOSBindingSource.DataSource = null;
                productoPOSBindingSource.DataSource = listadoCompra;
                calculos();
            }



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

        void imprimirTicket(int idventa)
        {
            CVenta cVenta = new CVenta();
            Venta venta = new Venta();
            venta = cVenta.ObtenerUna(idventa);
            CConfiguracion cConfiguracion = new CConfiguracion();
            Configuracion config = cConfiguracion.ObtenerConfiguracion();
            Printer printer = new Printer(config.Impresora);

            CCorrelativo ccorrelativo = new CCorrelativo();
            Correlativo correlativo= ccorrelativo.ObtenerUna(venta.IdCorrelativo_FK);

            printer.AlignCenter();
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.BoldMode(config.NombreEmpresa);
            //Bitmap image = new Bitmap(Bitmap.FromFile("Icon.bmp"));
            //printer.Image(image);
            printer.Append(config.Direccion);
            printer.Append("NIT:"+config.NIT);
            printer.Append("NRC:"+config.NRC);
            printer.Append("Fecha:"+venta.Fecha);
            printer.Append("Ticket #"+venta.Correlativo);
            printer.Append("--------------------------------------");
            
            printer.AlignLeft();
            printer.Append("PRODUCTO     CANT.    PRECIO    TOTAL");
            foreach (ProductoPOS ps in listadoCompra)
            {
                printer.Append(ps.Nombre);
                printer.Append("                " + ps.Cantidad + "        $" + ps.Precio.ToString("F") + "   $" + ps.Total.ToString("F"));
            }
            printer.AlignCenter();
            printer.Append("--------------------------------------");
            printer.AlignLeft();
            printer.Append("Ventas Afectas:" + venta.Total);
            printer.Append("Ventas Exentas:" + "0.00");
            printer.AlignCenter();
            printer.Append("--------------------------------------");
            printer.AlignLeft();
            printer.Append("Recibido:" + venta.Efectivo);
            printer.Append("Cambio:" + venta.Cambio);
            printer.AlignCenter();
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("Gracias por su compra");
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.Append("                                        ");

            printer.Append("Resolución: "+ correlativo.Resolucion);
            printer.Append("Del " + "0000001 al " + correlativo.Fin);
            printer.Append("Autorización:" + correlativo.Autorizacion);
            printer.Append("Fecha de resolución:" + correlativo.FechaDeAutorizacion.ToString());
            printer.Append("                                        ");
            printer.Append("                                        ");
            printer.FullPaperCut();
            printer.PrintDocument();


        }
    }
}
