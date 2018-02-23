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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarRRHH_Click(object sender, EventArgs e)
        {
            // Opens the select directory Dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] lineas = System.IO.File.ReadAllLines(openFileDialog1.FileName);
                foreach (var linea in lineas)
                {
                    Console.WriteLine(linea);
                }
            }
        }
    }
}
