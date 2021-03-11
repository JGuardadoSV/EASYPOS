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

namespace EASYPOS.Formularios.Presentaciones
{
    public partial class FSeleccionDePresentaciones : Form
    {
        CPresentacion cPresentacion = new CPresentacion();
        public Presentacion presentacion;
        public FSeleccionDePresentaciones()
        {
            InitializeComponent();
        }

        private void FSeleccionDePresentaciones_Load(object sender, EventArgs e)
        {
            presentacionBindingSource.DataSource = cPresentacion.Listado();
        }

        private void presentacionDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void presentacionDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            presentacion = (Presentacion)presentacionBindingSource.Current;
            this.Close();
        }
    }
}
