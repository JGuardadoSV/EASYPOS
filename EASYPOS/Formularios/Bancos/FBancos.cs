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

namespace EASYPOS.Formularios.Bancos
{
    public partial class FBancos : Form
    {
        public FBancos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FNuevaCuenta f = new FNuevaCuenta();
            f.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            CCuenta cCuentas = new CCuenta();
            cuentasBindingSource.DataSource = cCuentas.Listado();
        }

        private void FBancos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cuentasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cuentas c = new Cuentas();
            c = (Cuentas)cuentasBindingSource.Current;
            FNuevaCuenta f = new FNuevaCuenta(c);
            f.ShowDialog();
            cargar();
        }
    }
}
