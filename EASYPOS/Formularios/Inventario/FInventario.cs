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
            cargarDetalle();

        }

        private void cargarDetalle()
        {
            detallesInventarioBindingSource.DataSource = cDetalles.Listado(idinventario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FProductos f = new FProductos();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Text = "Administración de productos";
            f.ShowDialog();

            cargarDetalle();
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
            cargarDetalle();
        }
    }
}
