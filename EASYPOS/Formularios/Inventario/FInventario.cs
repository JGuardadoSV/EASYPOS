using EASYPOS.Controladores;
using EASYPOS.Entidades;
using EASYPOS.Formularios.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPOS.Formularios.Inventario
{
    public partial class FInventario : Form
    {
        int idinventario;
        CDetallesInventario cDetalles = new CDetallesInventario();
        int idactual;
        public FInventario(int idinventario=0)
        {
            this.idinventario = idinventario;
            InitializeComponent();
        }

        private void FInventario_Load(object sender, EventArgs e)
        {
            cargarDetalle(0);

        }

        private void cargarDetalle(int tipo)
        {
            if (tipo==0)
            {
                detallesInventarioBindingSource.DataSource = cDetalles.Listado(idinventario);
            }
            if (tipo==1)
            {
                detallesInventarioBindingSource.DataSource = cDetalles.ListadoPropio(idinventario);
            }
            if (tipo ==2)
            {
                detallesInventarioBindingSource.DataSource = cDetalles.ListadoConsignacion(idinventario);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FProductos f = new FProductos();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Text = "Administración de productos";
            f.ShowDialog();

            if (radioButtonTodos.Checked)
            {
                cargarDetalle(0);
            }
            if (radioButtonPropio.Checked)
            {
                cargarDetalle(1);
            }
            if (radioButtonConsignacion.Checked)
            {
                cargarDetalle(2);
            }
        }

        private void detallesInventarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            DetallesInventario det = new DetallesInventario();
            det = (DetallesInventario)detallesInventarioBindingSource.Current;
            textBoxExistencias.Text = det.Existencias.ToString();
            idactual = det.IdDetalle;
            labelNombre.Text = det.Nombre;
            textBoxExistencias.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            idactual = 0;
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cDetalles.actualizarExistencias(idactual, textBoxExistencias.Text);
            idactual = 0;
            groupBox1.Visible = false;
            if (radioButtonTodos.Checked)
            {
                cargarDetalle(0);
            }
            if (radioButtonPropio.Checked)
            {
                cargarDetalle(1);
            }
            if (radioButtonConsignacion.Checked)
            {
                cargarDetalle(2);
            }

        }

        private void radioButtonPropio_CheckedChanged(object sender, EventArgs e)
        {
            cargarDetalle(1);
        }

        private void radioButtonConsignacion_CheckedChanged(object sender, EventArgs e)
        {
            cargarDetalle(2);
        }

        private void radioButtonTodos_CheckedChanged(object sender, EventArgs e)
        {
            cargarDetalle(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (radioButtonConsignacion.Checked)
            {
                tipo = 2;
            }
            else if(radioButtonPropio.Checked)
            {
                tipo = 1;
            }

            FReporteInventario f = new FReporteInventario(tipo, idinventario);
            f.ShowDialog();
        }
    }
}
