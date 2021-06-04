using EASYPOS.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYPOS.Formularios.Config
{
    public partial class FConfiguraciones : Form
    {
        Configuracion config;
        CConfiguracion cConfig = new CConfiguracion();
        string logo="";
        public FConfiguraciones()
        {
            InitializeComponent();
        }

        private void FConfiguraciones_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "logo.jpg";
            logo= cConfig.ObtenerConfiguracion().logo;
            configuracionBindingSource.DataSource = cConfig.ObtenerConfiguracion(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();

        }

        private void guardar()
        {
            configuracionBindingSource.EndEdit();
            config = (Configuracion)configuracionBindingSource.Current;

            if (config.Usuario.Length == 0 || config.Clave.Length == 0 || config.Impresora.Length == 0)
            {
                MessageBox.Show("Todos los campos de configuración son requeridos");
            }
            else
            {
                config.logo = logo;
                cConfig.Guardar(config);
                MessageBox.Show("Cambios guardados correctamente");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            string carpeta = System.AppDomain.CurrentDomain.BaseDirectory;
            f.Filter = "Imagenes JPG (*.jpg)|*.jpg";
            f.FilterIndex = 1;
            f.ShowDialog();
            if (f.FileName.Length>0)
            {
                File.Copy(f.FileName, carpeta + "\\logo.jpg", true);
                logo = carpeta + "\\logo.jpg";
            }
            pictureBox1.ImageLocation = "logo.jpg";



        }
    }
}
