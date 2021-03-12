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

namespace EASYPOS.Formularios.Empleados
{
    public partial class FEmpleados : Form
    {
        CEmpleado cEmpleado = new CEmpleado();
        CRol cRol = new CRol();
        CSucursal cSucursal = new CSucursal();
        Boolean actualizacion = false;
        public FEmpleados()
        {
            InitializeComponent();
        }

        private void deseaEliminarEsteEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea eliminar este empleado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Empleado empleado = new Empleado();
                empleado = (Empleado)empleadoBindingSource.Current;

                try
                {
                    cEmpleado.Eliminar(empleado);
                    cargarListado();
                    MessageBox.Show("Empleado eliminado con éxito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la eliminación del empleado. " + ex.Message);
                }
            }
        }

        private void cargarListado()
        {
            empleadoBindingSource.DataSource = cEmpleado.Listado();
        }

        private void empleadoDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                empleadoDataGridView.ClearSelection();
                empleadoDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                empleadoBindingSource.Position = e.RowIndex; //actualizar la pos del bindigsource del objeto seleccionado


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleadoBindingSource.EndEdit();
            empleado = (Empleado)empleadoBindingSource.Current;
            cEmpleado.Insertar(empleado);
            if (actualizacion)
            {
                MessageBox.Show("Empleado actualizado con éxito");
            }
            else
            {
                MessageBox.Show("Empleado registrado con éxito");
            }
            actualizacion = false;
            activarcontroles();
        }

        private void activarcontroles()
        {
            this.Fpanel.Visible = !this.Fpanel.Visible;
            this.Registrarbutton.Enabled = !this.Fpanel.Visible;
            this.empleadoDataGridView.Enabled = !this.Fpanel.Visible;
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            empleadoBindingSource.MoveLast();
            empleadoBindingSource.AddNew();
            actualizacion = false;
            activarcontroles();
        }

        private void empleadoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizacion = true;
            activarcontroles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activarcontroles();
            empleadoBindingSource.EndEdit();
            if (actualizacion == false)
            {
                empleadoBindingSource.RemoveCurrent();
            }

            actualizacion = false;
            cargarListado();
        }

        private void FEmpleados_Load(object sender, EventArgs e)
        {
            rolBindingSource.DataSource = cRol.Listado();
            sucursalBindingSource.DataSource = cSucursal.Listado();
            cargarListado();
        }

        private void empleadoDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}
