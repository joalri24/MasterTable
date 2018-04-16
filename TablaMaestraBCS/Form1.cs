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

        public static RecursoAD AD_FS;
        public static RecursoAD AD_OFBCSC;
        public static RecursoAD AD_ARP;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCorrer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Procesando...");
            if (!string.IsNullOrWhiteSpace(nombreArchivoRRHH))
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
            Console.WriteLine("Fin.");
            //maestra.ImprimirEnConsola();
            maestra.ImprimirCSV();
        }

        private void LeerArchivo(Usuario.Fuentes fuente, string nombreArchivo)
        {
            int inicio = 0;
            string encabezado;
            switch (fuente)
            {
                case Usuario.Fuentes.RRHH:
                    inicio = 1;
                    break;
                case Usuario.Fuentes.Temporales:
                    inicio = 1;
                    break;
                case Usuario.Fuentes.AD_FS:
                    var archivo = new System.IO.StreamReader(nombreArchivo);
                    encabezado = archivo.ReadLine(); // Lee la primera línea del archivo: la línea de encabezado. 
                    archivo.Close();
                    AD_FS = new RecursoAD() // Obtiene los índices de inicio y las longitudes de los campos.
                    {
                        Nombre = ObtenerPropiedades(encabezado, "Name"),
                        Cedula = ObtenerPropiedades(encabezado, "extensionAttribute1"),
                        Login = ObtenerPropiedades(encabezado, "SamAccountName"),
                        Organizacion = ObtenerPropiedades(encabezado, "Company"),
                        Cargo = ObtenerPropiedades(encabezado, "Title")
                    };
                    inicio = 2;
                    break;
                case Usuario.Fuentes.AD_ARP:
                    inicio = 2;
                    break;
                case Usuario.Fuentes.AD_OFBCSC:
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


        private ColumnaAD ObtenerPropiedades(string encabezado,string nombreColumna )
        {
            int indice = encabezado.IndexOf(nombreColumna); // Encuentra el inicio.
            int longitud = 0;
            char i = encabezado[indice];
            int j = indice;
            while(j < encabezado.Length)
            {
                if (longitud > nombreColumna.Length && encabezado[j] != ' ')
                    break;
                longitud++;
                j++;
            }
            //Console.WriteLine($"Inicio: {indice}, Longitud: {longitud}");
            return new ColumnaAD() { Inicio=indice, Longitud= longitud};
        }
    }


    #region clases auxiliares

    /// <summary>
    /// Se utiliza para saber donde está la información relevante en los archivos de AD.
    /// Contiene los indices de inicio y las longitudes de los campos relevantes.
    /// </summary>
    public class RecursoAD
    {
        public ColumnaAD Nombre { get; set; }
        public ColumnaAD Cedula { get; set; }
        public ColumnaAD Login { get; set; }
        public ColumnaAD Organizacion { get; set; }
        public ColumnaAD Cargo { get; set; }

    }

    /// <summary>
    /// Contiene la dupla de índice de inicio y de longitud de un campo.
    /// </summary>
    public class ColumnaAD
    {
        /// <summary>
        /// Índice donde inica la columna.
        /// </summary>
        public int Inicio { get; set; }

        /// <summary>
        /// Longitud en caracteres de la columna.
        /// </summary>
        public int Longitud { get; set; }
    }
    #endregion
}
