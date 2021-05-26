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

namespace EASYPOS.Formularios.Ventas
{
    
    public partial class FVenta : Form
    {
        string cliente, fecha, ticket;
        List<ProductoPOS> listado;

        private void FVenta_Load(object sender, EventArgs e)
        {
           
            textBox2.Text = ticket;
            textBox3.Text = fecha;
            productoPOSBindingSource.DataSource = listado;
        }

        public FVenta( string fecha, string ticket,List<ProductoPOS> listado)
        {
            this.fecha = fecha;this.ticket = ticket;
            this.listado = listado;
            InitializeComponent();
        }
    }
}
