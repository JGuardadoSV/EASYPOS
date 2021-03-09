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

namespace EASYPOS.Formularios.Productos
{
    public partial class FProductos : Form
    {
        CProducto cProducto = new CProducto();
        CProveedor cProveedor = new CProveedor();
        CCategoria cCategoria = new CCategoria();
        Boolean actualizacion = false;

        public FProductos()
        {
            InitializeComponent();
        }

        private void FProductos_Load(object sender, EventArgs e)
        {
            cargarListado();
            categoriaBindingSource.DataSource = cCategoria.Listado();
            proveedorBindingSource.DataSource = cProveedor.Listado();
        }

        private void cargarListado()
        {
            productoBindingSource.DataSource = cProducto.Listado();
        }

        private void activarcontroles()
        {
            this.Fpanel.Visible = !this.Fpanel.Visible;
            this.Registrarbutton.Enabled = !this.Fpanel.Visible;
            this.productoDataGridView.Enabled = !this.Fpanel.Visible;
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                productoBindingSource.MoveLast();
                productoBindingSource.AddNew();
                ((Producto)productoBindingSource.Current).TieneVariasPresentaciones = 0;
                
                activarcontroles();

                if (!actualizacion)
                {
                    tieneVariasPresentacionesCheckBox.Checked = false;
                    
                }
                    
            }
            catch (Exception)
            {

                
            }
            
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            productoBindingSource.EndEdit();
            if (actualizacion == false)
            {
                productoBindingSource.RemoveCurrent();
            }

            actualizacion = false;
            cargarListado();
            activarcontroles();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            productoBindingSource.EndEdit();
            producto = (Producto)productoBindingSource.Current;


            if (tieneVariasPresentacionesCheckBox.Checked)
                producto.TieneVariasPresentaciones = 1;
            else
                producto.TieneVariasPresentaciones = 0;
           
            //asignando la  cat y el pro elegido
            producto.IdCategoria_FK = ((Categoria)categoriaBindingSource.Current).IdCategoria;
            producto.IdProveedor_FK = ((Proveedor)proveedorBindingSource.Current).IdProveedor;

            cProducto.Insertar(producto);

            if (actualizacion)
                MessageBox.Show("Producto actualizado con éxito");
            else
                MessageBox.Show("Producto registrado con éxito");
            
            actualizacion = false;
            activarcontroles();
            cargarListado();

        }

        private void productoDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                productoDataGridView.ClearSelection();
                productoDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                productoBindingSource.Position = e.RowIndex; //actualizar la pos del bindigsource del objeto seleccionado


            }
        }

        private void eliminarEsteProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea eliminar este producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Producto producto = new Producto();
                producto = (Producto)productoBindingSource.Current;

                try
                {
                    cProducto.Eliminar(producto);
                    cargarListado();
                    MessageBox.Show("Producto eliminado con éxito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la eliminación del producto. " + ex.Message);
                }
            }
        }

        private void productoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizacion = true;
            activarcontroles();
            Producto producto = new Producto();
            producto = (Producto)productoBindingSource.Current;

            if (producto.TieneVariasPresentaciones == 1)
                tieneVariasPresentacionesCheckBox.Checked = true;
            else
                tieneVariasPresentacionesCheckBox.Checked = false;

            
        }

        private void productoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }
    }
}
