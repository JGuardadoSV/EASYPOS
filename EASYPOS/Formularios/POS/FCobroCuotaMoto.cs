using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using con = EASYPOS.Entidades.Contratos;
namespace EASYPOS.Formularios.POS
{
    public partial class FCobroCuotaMoto : Form
    {
        con contrato;
        public FCobroCuotaMoto(con id)
        {
            this.contrato = id;
            InitializeComponent();
        }

        private void FCobroCuotaMoto_Load(object sender, EventArgs e)
        {
            txtcliente.Text = contrato.NombreCompleto;
            txtfecha.Text = contrato.FechaInicio.ToString();
            txtfinanciamiento.Text = contrato.Financiamiento.Value.ToString("F");
        }
    }
}
