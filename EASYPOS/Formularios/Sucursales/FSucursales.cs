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

namespace EASYPOS.Formularios.Sucursales
{
    public partial class FSucursales : Form
    {
        CSucursal cSucursal = new CSucursal();
        Boolean actualizacion = false;
        public FSucursales()
        {
            InitializeComponent();
        }

        private void Fpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FSucursales_Load(object sender, EventArgs e)
        {
            cargarListado();
        }

        private void cargarListado()
        {
            sucursalBindingSource.DataSource = cSucursal.Listado();
        }

        private void activarcontroles()
        {
            this.Fpanel.Visible = !this.Fpanel.Visible;
            this.Registrarbutton.Enabled = !this.Fpanel.Visible;
            this.sucursalDataGridView.Enabled = !this.Fpanel.Visible;
        }

        private void deseaEliminarEstaSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea eliminar esta sucursal?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Sucursal sucursal = new Sucursal();
                sucursal = (Sucursal)sucursalBindingSource.Current;

                try
                {
                    cSucursal.Eliminar(sucursal);
                    cargarListado();
                    MessageBox.Show("Sucursal eliminada con éxito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la eliminación de la sucursal. " + ex.Message);
                }
            }

        }

        private void sucursalDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                sucursalDataGridView.ClearSelection();
                sucursalDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                sucursalBindingSource.Position = e.RowIndex; //actualizar la pos del bindigsource del objeto seleccionado


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            
            sucursalBindingSource.EndEdit();
            sucursal = (Sucursal)sucursalBindingSource.Current;
            cSucursal.Insertar(sucursal);
            if (actualizacion)
            {
                MessageBox.Show("Sucursal actualizada con éxito");
            }
            else
            {
                MessageBox.Show("Sucursal registrada con éxito.\nAdicionalmente se ha creado el inventario en blanco para esta sucursal.");
            }
            actualizacion = false;
            activarcontroles();
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            sucursalBindingSource.MoveLast();
            sucursalBindingSource.AddNew();
            actualizacion = false;

            activarcontroles();
        }

        private void sucursalDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizacion = true;
            activarcontroles();
            Sucursal sucursal = new Sucursal();
            sucursal = (Sucursal)sucursalBindingSource.Current;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activarcontroles();
            sucursalBindingSource.EndEdit();
            if (actualizacion == false)
            {
                sucursalBindingSource.RemoveCurrent();
            }

            actualizacion = false;
            cargarListado();
        }
    }
}
