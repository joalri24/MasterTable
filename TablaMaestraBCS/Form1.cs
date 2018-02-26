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
            // Opens the select directory Dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lineas = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                Usuario usuario;
                for (int i = 1; i< lineas.Length; i++)
                {
                    //usuario = new UsuarioRRHH(codigoEmpleado: linea[0], apellido1: linea[1], apellido2:linea[2], nombre:linea[3], login:linea[4], cargo: linea[5], empresa:linea[6], ciudad: linea[12]);
                    usuario = Usuario.CrearUsuario(Usuario.Fuentes.RRHH, lineas[i]);
                    maestra.CargarUsuario(usuario);                   
                }
            }

            maestra.ImprimirEnConsola();
        }

    }
}
