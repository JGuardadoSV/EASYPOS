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

namespace EASYPOS.Formularios.Cajas
{
    public partial class FCajas : Form
    {
        CCaja cCaja = new CCaja();
        CSucursal cSucursal = new CSucursal();
        CEmpleado cEmpleado = new CEmpleado();

        Boolean actualizacion = false;
        public FCajas()
        {
            InitializeComponent();
        }

        private void FCajas_Load(object sender, EventArgs e)
        {
            sucursalBindingSource.DataSource = cSucursal.Listado();
            empleadoBindingSource.DataSource = cEmpleado.Listado();
            empleadoBindingSource1.DataSource = cEmpleado.Listado();
            cargarListado();
        }

        private void deseaEliminarEsteRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea eliminar esta caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Caja caja = new Caja();
                caja = (Caja)cajaBindingSource.Current;

                try
                {
                    cCaja.Eliminar(caja);
                    cargarListado();
                    MessageBox.Show("Caja eliminada con éxito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la eliminación de la caja. " + ex.Message);
                }
            }
        }

        private void cajaDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                cajaDataGridView.ClearSelection();
                cajaDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                cajaBindingSource.Position = e.RowIndex; //actualizar la pos del bindigsource del objeto seleccionado


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Caja caja = new Caja();
            cajaBindingSource.EndEdit();
            caja = (Caja)cajaBindingSource.Current;
            if (EstadocomboBox.Text=="Activa")
            {
                caja.Estado = 1;
            }
            else
            {
                caja.Estado = 2;
            }
            cCaja.Insertar(caja);
            if (actualizacion)
            {
                MessageBox.Show("Caja actualizada con éxito");
            }
            else
            {
                MessageBox.Show("Caja registrada con éxito");
            }
            actualizacion = false;
            activarcontroles();
        }

        private void Registrobutton_Click(object sender, EventArgs e)
        {
            cajaBindingSource.MoveLast();
            cajaBindingSource.AddNew();
            actualizacion = false;

            activarcontroles();
        }

        private void activarcontroles()
        {
            this.Fpanel.Visible = !this.Fpanel.Visible;
            this.Registrarbutton.Enabled = !this.Fpanel.Visible;
            this.cajaDataGridView.Enabled = !this.Fpanel.Visible;
        }

        private void cajaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizacion = true;
            activarcontroles();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            activarcontroles();
            cajaBindingSource.EndEdit();
            if (actualizacion == false)
            {
                cajaBindingSource.RemoveCurrent();
            }

            actualizacion = false;
            cargarListado();
        }

        private void cargarListado()
        {
            cajaBindingSource.DataSource = cCaja.Listado();
        }

        private void cajaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
