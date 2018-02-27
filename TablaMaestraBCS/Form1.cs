using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaMaestraBCS
{
    public partial class Form1 : Form
    {

        private TablaMaestra maestra;
        private string nombreArchivoRRHH;
        private string nombreArchivoTemporales;
        private string nombreArchivoFS;
        private string nombreArchivoOFBCSC;
        private string nombreArchivoARP;
        


        public Form1()
        {
            InitializeComponent();
            maestra = new TablaMaestra();
        }


        // -------------------------------------------------------------------------------------------
        // Métodos
        // -------------------------------------------------------------------------------------------
        
        /// <summary>
        /// Carga Usuarios del archivo RRHH.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCargarRRHH_Click(object sender, EventArgs e)
        {
            // Opens the select file Dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombreArchivoRRHH = openFileDialog1.FileName;
                textBoxRRHH.Text = nombreArchivoRRHH;
            }
                
        }

        private void buttonCargarFS_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombreArchivoFS= openFileDialog1.FileName;
                textBoxFS.Text = nombreArchivoFS;
            }
        }

        private void buttonCargarOFBCSC_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombreArchivoOFBCSC = openFileDialog1.FileName;
                textBoxOFCBC.Text = nombreArchivoOFBCSC;
            }
        }

        private void buttonCargarARP_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombreArchivoARP = openFileDialog1.FileName;
                textBoxARP.Text = nombreArchivoARP;
            }
        }

        private void buttonCargarTemps_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nombreArchivoTemporales = openFileDialog1.FileName;
                textBoxTemps.Text = nombreArchivoTemporales;
            }
        }

        private void ButtonCorrer_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(nombreArchivoRRHH))
            {
                LeerArchivo(Usuario.Fuentes.RRHH, nombreArchivoRRHH);
            }
            if (!string.IsNullOrWhiteSpace(nombreArchivoTemporales))
            {
                LeerArchivo(Usuario.Fuentes.Temporales, nombreArchivoTemporales);
            }
            if (!string.IsNullOrWhiteSpace(nombreArchivoFS))
            {
                LeerArchivo(Usuario.Fuentes.AD_FS, nombreArchivoFS);
            }
            if (!string.IsNullOrWhiteSpace(nombreArchivoOFBCSC))
            {
                LeerArchivo(Usuario.Fuentes.AD_OFBCSC, nombreArchivoOFBCSC);
            }
            if (!string.IsNullOrWhiteSpace(nombreArchivoARP))
            {
                LeerArchivo(Usuario.Fuentes.AD_ARP, nombreArchivoARP);
            }


            maestra.ImprimirEnConsola();
        }

        private void LeerArchivo(Usuario.Fuentes fuente, string nombreArchivo)
        {
            int inicio = 0;
            switch (fuente)
            {
                case Usuario.Fuentes.RRHH:
                    inicio = 1;
                    break;
                case Usuario.Fuentes.Temporales:
                    break;
                case Usuario.Fuentes.AD_FS:
                    inicio = 2;
                    break;
                default:
                    break;
            }
            string[] lineas = System.IO.File.ReadAllLines(nombreArchivo);
            Usuario usuario;
            for (int i = inicio; i < lineas.Length; i++)
            {
                usuario = Usuario.CrearUsuario(fuente, lineas[i]);
                maestra.CargarUsuario(usuario);
            }
        }


    }
}
