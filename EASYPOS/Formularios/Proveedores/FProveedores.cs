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

namespace EASYPOS.Formularios.Proveedores
{
    public partial class FProveedores : Form
    {
        CProveedor cProveedor = new CProveedor();
        Boolean actualizacion = false;
        public FProveedores()
        {
            InitializeComponent();
        }

        private void FProveedores_Load(object sender, EventArgs e)
        {
            cargarListado();
        }

        private void cargarListado()
        {
            proveedorBindingSource.DataSource = cProveedor.Listado();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            activarcontroles();
            proveedorBindingSource.EndEdit();
            if (actualizacion==false)
            {
                proveedorBindingSource.RemoveCurrent();
            }
            
            actualizacion = false;
            cargarListado();
        }

        private void activarcontroles()
        {
            this.Fpanel.Visible = !this.Fpanel.Visible;
            this.Registrarbutton.Enabled = !this.Fpanel.Visible;
            this.proveedorDataGridView.Enabled= !this.Fpanel.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proveedorBindingSource.MoveLast();
            proveedorBindingSource.AddNew();

            activarcontroles();


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedorBindingSource.EndEdit();
            proveedor = (Proveedor) proveedorBindingSource.Current;
            cProveedor.Insertar(proveedor);
            if (actualizacion)
            {
                MessageBox.Show("Proveedor actualizado con éxito");
            }
            else
            {
                MessageBox.Show("Proveedor registrado con éxito");
            }
            actualizacion = false;
            activarcontroles();
        }

        private void proveedorDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            activarcontroles();
            actualizacion = true;
        }

       

        private void eliminarEstaCategoríaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea eliminar este proveedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Proveedor proveedor = new Proveedor();
                proveedor = (Proveedor)proveedorBindingSource.Current;

                try
                {
                    cProveedor.Eliminar(proveedor);
                    cargarListado();
                    MessageBox.Show("Proveedor eliminado con éxito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la eliminación del proveedor. " + ex.Message);
                }
            }
        }

        private void proveedorDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                proveedorDataGridView.ClearSelection();
                proveedorDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                proveedorBindingSource.Position = e.RowIndex; //actualizar la pos del bindigsource del objeto seleccionado


            }
        }
    }
}
