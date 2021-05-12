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

namespace EASYPOS.Formularios.POS
{
    public partial class FListadoProductosPOS : Form
    {
        CProductoPOS cProductoPOS = new CProductoPOS();
        public ProductoPOS productoPos = new ProductoPOS();
        int id;
        public FListadoProductosPOS(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void FListadoProductosPOS_Load(object sender, EventArgs e)
        {
            productoPOSBindingSource.DataSource = cProductoPOS.Listado(id);
        }

        private void productoPOSDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            productoPos = (ProductoPOS)productoPOSBindingSource.Current;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
