using EASYPOS.Formularios.Categorias;
using EASYPOS.Formularios.Config;
using EASYPOS.Formularios.Contratos;
using EASYPOS.Formularios.Correlativos;
using EASYPOS.Formularios.Intereses_formulario;
using EASYPOS.Formularios.Inventario;
using EASYPOS.Formularios.Productos;
using EASYPOS.Formularios.Proveedores;
using EASYPOS.Formularios.Reportes;
using EASYPOS.Formularios.Ventas;
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
        string usuario;
        public FPrincipal(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vender();
        }

        private void vender()
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

        private void contratosVigentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contratos();
        }

        private void contratos()
        {
            FContratos f = new FContratos();

            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void nuevoContratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cotizar();
        }

        private void cotizar()
        {
            FNuevoContrato f = new FNuevoContrato();

            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void pagoDeCuotaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //fPOSCuota f = new fPOSCuota();
            cuotas();
        }

        private void cuotas()
        {
            FContratos f = new FContratos(pago: true);
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void correlativosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCorrelativos f = new FCorrelativos();
            f.StartPosition = FormStartPosition.CenterParent;
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            this.labelUsuario.Text = this.labelUsuario.Text + " " + usuario ;
            pictureBox1.ImageLocation = "logo.jpg";
        }

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FConfiguraciones f = new FConfiguraciones();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void reportesDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FFechas f = new FFechas();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void historialDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHistorialVentas f = new FHistorialVentas();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void cotizacionesRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FContratos f = new FContratos(false,true);

            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void contratosConPagosAtrasadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FContratosAtrasados f = new FContratosAtrasados();
            f.ShowDialog();
        }

        private void creditosVigentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FReporteContrato f = new FReporteContrato(1); //vigentes
            f.ShowDialog();
        }

        private void creditosPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FReporteContrato f = new FReporteContrato(2); //atrasados
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vender();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cuotas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cotizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contratos();
        }

        private void reporteFinancieroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FFechasCuotas f = new FFechasCuotas();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void contratosConPagosParaEsteMesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FContratosPaganEsteMes f = new FContratosPaganEsteMes();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FContratosAtrasados f = new FContratosAtrasados();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FContratosPaganEsteMes f = new FContratosPaganEsteMes();
            f.ShowDialog();
        }

        private void tasasDeInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIntereses f = new FIntereses();
            f.ShowDialog();
        }
    }
}
