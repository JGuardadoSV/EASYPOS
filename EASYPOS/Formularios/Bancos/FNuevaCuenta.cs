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
    public partial class FNuevaCuenta : Form
    {
        Cuentas cuentaUp = null;
        public FNuevaCuenta(Cuentas c = null)
        {
            cuentaUp = c;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void FNuevaCuenta_Load(object sender, EventArgs e)
        {
            cuentasBindingSource.MoveLast();
            if (cuentaUp==null)
            {
                cuentasBindingSource.AddNew();
            }
            else
            {
                cuentasBindingSource.DataSource = cuentaUp;
                if (cuentaUp.Tipo==1)
                {
                    comboBoxTiposCuenta.SelectedIndex = 0;
                }
                else
                {
                    comboBoxTiposCuenta.SelectedIndex = 1;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                cuentasBindingSource.EndEdit();
                Cuentas cuenta = (Cuentas)cuentasBindingSource.Current;

                if (comboBoxTiposCuenta.SelectedIndex == -1 || cuenta.Numero.Length == 0 || cuenta.Banco.Length == 0)
                {
                    MessageBox.Show("Todos los campos son requeridos");
                    return;
                }


                cuenta.Tipo = comboBoxTiposCuenta.SelectedIndex == 0 ? 1 : 2;
                
               
                
                CCuenta cCuentas = new CCuenta();

                cCuentas.Insertar(cuenta);
                MessageBox.Show("Cuenta registrada con éxito");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Establezca una fecha para la apertura de la cuenta");
            }

           
        }
    }
}
