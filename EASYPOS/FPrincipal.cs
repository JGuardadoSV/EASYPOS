using EASYPOS.Formularios.Categorias;
using EASYPOS.Formularios.Inventario;
using EASYPOS.Formularios.Productos;
using EASYPOS.Formularios.Proveedores;
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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPOS f = new fPOS();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FInventario f = new FInventario(1);
            f.StartPosition = FormStartPosition.CenterParent;
            f.Text = "Administración de inventario";
            f.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCategorias f = new FCategorias();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Text = "Administración de categorías";
            f.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProveedores f = new FProveedores();
            f.Text = "Administración de proveedores";
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }
    }
}
