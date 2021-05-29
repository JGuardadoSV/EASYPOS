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
using con = EASYPOS.Entidades.Contratos;
namespace EASYPOS.Formularios.POS
{
    public partial class FCobroCuotaMoto : Form
    {
        int contrato;
        int idcuota;
        con c;
        Cuotas cuota;
        public FCobroCuotaMoto(int idcuota,int id)
        {
            this.contrato = id;
            this.idcuota = idcuota;
            InitializeComponent();
        }

        private void FCobroCuotaMoto_Load(object sender, EventArgs e)
        {

            CContratos cContratos = new CContratos();
            //c = new con();
            c = cContratos.uno(contrato);
            CCuota cCuota = new CCuota();
            cuota = cCuota.ObtenerUna(idcuota);

            txtcliente.Text = c.NombreCompleto;
            txtfecha.Text = c.FechaInicio.ToString();
            txtfinanciamiento.Text = c.Financiamiento.Value.ToString("F");
            txtsaldoactual.Text = c.Restante.Value.ToString("F");
            txtmonto.Text = cuota.Monto.Value.ToString("F");
        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal pago = decimal.Parse(txtpago.Text);
                if (pago<cuota.Monto)
                {
                    aviso.Visible = true;
                    txtacapital.Text = ("0.00");
                    txtaintereses.Text = ("0.00");
                    txtcapitalextra.Text = ("0.00");
                    txtcapitaldespues.Text = ("0.00");
                }
                else if(pago>=cuota.Monto) {
                    aviso.Visible = false;
                    txtacapital.Text = cuota.Capital.ToString();
                    txtaintereses.Text = cuota.Intereses.ToString();

                    if (pago>cuota.Monto)
                    {
                        txtcapitalextra.Text = (pago - cuota.Monto).ToString();
                    }
                    else {
                        txtcapitalextra.Text = "0.00";
                    }

                    decimal suma = decimal.Parse(txtacapital.Text) + decimal.Parse(txtcapitalextra.Text);

                    txtcapitaldespues.Text = (c.Restante - suma).ToString();
                }
            }
            catch (Exception)
            {

                
            }
        }
    }
}
