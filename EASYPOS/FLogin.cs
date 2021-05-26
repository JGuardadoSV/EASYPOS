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

namespace EASYPOS
{
    public partial class FLogin : Form
    {
        public bool autenticacion = false, cancelar = false;
        public string user;
        
        public FLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CConfiguracion cConfiguracion = new CConfiguracion();
            
            string usuario = textBoxUsuario.Text;
            string clave = textBoxClave.Text;

            Configuracion config = cConfiguracion.Autenticacion(usuario,clave);

            if (config!=null && config.Usuario.Length>0)
            {
                autenticacion = true;
                this.user = config.Usuario;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void textBoxClave_Enter(object sender, EventArgs e)
        {
            textBoxClave.SelectAll();
        }

        private void textBoxUsuario_Click(object sender, EventArgs e)
        {
            textBoxUsuario.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            cancelar = true;
            this.Close();
        }
    }
}
