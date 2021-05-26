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

namespace EASYPOS.Formularios.Contratos
{
    public partial class FCuotasPagar : Form
    {
        int id;
        public Cuotas cuota;
        public FCuotasPagar(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void cuotasBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            

        }

        private void FCuotasPagar_Load(object sender, EventArgs e)
        {
            CCuota cCuotas = new CCuota();
            cuotasBindingSource.DataSource = cCuotas.Listado(id);
            
        }

        private void cuotasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cuota = (Cuotas)cuotasBindingSource.Current;
            if (cuota.FechaDePago.HasValue)
            {
                MessageBox.Show("Seleccione otra cuota, esta ya esta cancelada");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
    }
}
