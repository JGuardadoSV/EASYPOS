using EASYPOS.Controladores;
using EASYPOS.Entidades;
using EASYPOS.Formularios.Presentaciones;
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

            PresentacionesdataGridView.Rows.Clear();


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
            int existencias = int.Parse(txtExistencias.Text);
            cProducto.Insertar(producto, existencias);



            //*******************************************

            // REGISTRO DE PRESENTACIONES

            if (tieneVariasPresentacionesCheckBox.Checked)
            {

                int idproducto = producto.IdProducto;
                if (!actualizacion) idproducto = cProducto.MaximoId();
                CProducto_Presentacion cpresentaciones = new CProducto_Presentacion();
                List<Producto_Presentacion> listado = new List<Producto_Presentacion>();
                listado = cpresentaciones.listado(idproducto);

                if (listado.Count == 0)
                {

                    foreach (DataGridViewRow i in PresentacionesdataGridView.Rows)
                    {
                        Producto_Presentacion producto_Presentacion = new Producto_Presentacion();
                        producto_Presentacion.IdPresentacion_FK = int.Parse(i.Cells[0].Value.ToString());
                        producto_Presentacion.IdProducto_FK = idproducto;

                        cpresentaciones.Insertar(producto_Presentacion);
                    }
                }
                else
                {
                    foreach (DataGridViewRow i in PresentacionesdataGridView.Rows)
                    {
                        bool existe = false;
                        Producto_Presentacion producto_Presentacion = new Producto_Presentacion();
                        foreach (var item in listado)
                        {
                          //  MessageBox.Show("Id producto = " + idproducto + "Id presentacion=" + i.Cells[0].Value.ToString());
                            producto_Presentacion.IdPresentacion_FK = int.Parse(i.Cells[0].Value.ToString());
                            producto_Presentacion.IdProducto_FK = idproducto;

                            if (item.IdProducto_FK == idproducto && item.IdPresentacion_FK == producto_Presentacion.IdPresentacion_FK)
                            { existe = true; break; } 
                        }
                        if (!existe)
                        {
                            cpresentaciones.Insertar(producto_Presentacion);
                        } 
                       


                    }

                }

            }
            if (actualizacion)
                MessageBox.Show("Producto actualizado con éxito");
            else
                MessageBox.Show("Producto registrado con éxito");


            actualizacion = false;
            activarcontroles();
            cargarListado();
            PresentacionesdataGridView.Rows.Clear();




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
            {
                tieneVariasPresentacionesCheckBox.Checked = true;
                cargarpresentaciones(producto);
            }
               
            else
            {
                tieneVariasPresentacionesCheckBox.Checked = false;
            }
                

            
        }

        private void cargarpresentaciones(Producto producto)
        {
            PresentacionesdataGridView.Rows.Clear();
            CProducto_Presentacion cpresentaciones = new CProducto_Presentacion();
            List<Producto_Presentacion> listado = new List<Producto_Presentacion>();
            listado = cpresentaciones.listado(producto.IdProducto);

            foreach (var item in listado)
            {


                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(PresentacionesdataGridView);

                row.Cells[0].Value = item.IdPresentacion_FK;
                CPresentacion cpresentacion = new CPresentacion();
                Presentacion presentacion = new Presentacion();
                presentacion = cpresentacion.ObtenerUna((int)item.IdPresentacion_FK);
                row.Cells[1].Value = presentacion.NombrePresentacion + " X " + presentacion.CantidadPresentacion;
                PresentacionesdataGridView.Rows.Add(row);
            }
        }

        private void productoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void tieneVariasPresentacionesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if (((CheckBox) sender).Checked)
            // {
            PresentacionesgroupBox.Enabled = !PresentacionesgroupBox.Enabled;
           // }
           // else
            //{
              //  MessageBox.Show("Es no");
           // }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FSeleccionDePresentaciones f = new FSeleccionDePresentaciones();
            f.ShowDialog();
            Presentacion presentacion = new Presentacion();
            presentacion = f.presentacion;


            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(PresentacionesdataGridView);

            row.Cells[0].Value =presentacion.IdPresentacion;
            row.Cells[1].Value = presentacion.NombrePresentacion + " X " + presentacion.CantidadPresentacion;
            PresentacionesdataGridView.Rows.Add(row);

        }

        private void PresentacionesdataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                PresentacionesdataGridView.ClearSelection();
                PresentacionesdataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                


            }
        }

        private void eliminarPresentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!actualizacion)
            {
               // MessageBox.Show("Tiene que guardar el producto, cerrar la ventana y realizar el proceso de actualización antes de eliminar las presentaciones");
                PresentacionesdataGridView.Rows.Remove(PresentacionesdataGridView.CurrentRow);
            }
            else
            {
                
                CProducto_Presentacion cpresentaciones = new CProducto_Presentacion();
                Producto_Presentacion producto_Presentacion = new Producto_Presentacion();
                
                producto_Presentacion.IdPresentacion_FK = int.Parse(PresentacionesdataGridView.CurrentRow.Cells[0].Value.ToString());
                producto_Presentacion.IdProducto_FK = ((Producto)productoBindingSource.Current).IdProducto; 
                cpresentaciones.Eliminar(producto_Presentacion);

                MessageBox.Show("Presentación eliminada con éxito");

                cargarpresentaciones((Producto)productoBindingSource.Current);
            }
        }
    }
}
