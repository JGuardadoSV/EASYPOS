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

namespace EASYPOS.Formularios.Clientes
{
    public partial class FClientes : Form
    {
        CCliente cCliente = new CCliente();
        Boolean actualizacion = false;
        public FClientes()
        {
            InitializeComponent();
        }

        private void deseaEliminarEsteClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "¿Desea eliminar este cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Cliente cliente = new Cliente();
                cliente = (Cliente)clienteBindingSource.Current;

                try
                {
                    cCliente.Eliminar(cliente);
                    cargarListado();
                    MessageBox.Show("Cliente eliminado con éxito");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error en la eliminación del cliente. " + ex.Message);
                }
            }
        }

        private void cargarListado()
        {
            clienteBindingSource.DataSource = cCliente.Listado();
        }

        private void clienteDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)

            {
                // para que se seleccione el row donde se hizo clic derecho
                clienteDataGridView.ClearSelection();
                clienteDataGridView[e.ColumnIndex, e.RowIndex].Selected = true;
                clienteBindingSource.Position = e.RowIndex; //actualizar la pos del bindigsource del objeto seleccionado


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente();
            clienteBindingSource.EndEdit();
            cliente = (Cliente)clienteBindingSource.Current;

            if (cliente.NombreCliente == null)
            {
                MessageBox.Show("El nombre del cliente no puede estar vacío"); return;
            }
            

            cCliente.Insertar(cliente);
            if (actualizacion)
            {
                MessageBox.Show("Cliente actualizado con éxito");
            }
            else
            {
                MessageBox.Show("Cliente registrado con éxito");
            }
            actualizacion = false;
            activarcontroles();
        }

        private void activarcontroles()
        {
            this.Fpanel.Visible = !this.Fpanel.Visible;
            this.Registrarbutton.Enabled = !this.Fpanel.Visible;
            this.clienteDataGridView.Enabled = !this.Fpanel.Visible;
        }

        private void Registrarbutton_Click(object sender, EventArgs e)
        {
            clienteBindingSource.MoveLast();
            clienteBindingSource.AddNew();
            actualizacion = false;

            activarcontroles();
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizacion = true;
            activarcontroles();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activarcontroles();
            clienteBindingSource.EndEdit();
            if (actualizacion == false)
            {
                clienteBindingSource.RemoveCurrent();
            }

            actualizacion = false;
            cargarListado();
        }

        private void FClientes_Load(object sender, EventArgs e)
        {
            cargarListado();
        }
    }
}
