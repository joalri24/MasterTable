using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMaestraBCS
{
    /// <summary>
    /// Representa un reporte obtenido de RRHH  del banco.
    /// </summary>
    class UsuarioRRHH
    {

        // -------------------------------------------------------------------------------------------
        // Atributos y propiedades
        // -------------------------------------------------------------------------------------------        

        /// <summary>
        /// Código del empleado. Normalmente es la cédula.
        /// </summary>
        public string CodigoEmpleado { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre { get; set; }
        public string Login { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public string Ciudad { get; set; }


        // -------------------------------------------------------------------------------------------
        // Constructores
        // ------------------------------------------------------------------------------------------- 

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        /// <param name="codigoEmpleado"></param>
        /// <param name="apellido1"></param>
        /// <param name="apellido2"></param>
        /// <param name="nombre"></param>
        /// <param name="login"></param>
        /// <param name="cargo"></param>
        /// <param name="empresa"></param>
        /// <param name="ciudad"></param>
        public UsuarioRRHH(string codigoEmpleado, string apellido1, string apellido2, string nombre, string login, string cargo, string empresa, string ciudad)
        {
            CodigoEmpleado = codigoEmpleado;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Nombre = nombre;
            Login = login;
            Cargo = cargo;
            Empresa = empresa;
            Ciudad = ciudad;
        }

        /// <summary>
        /// Constructor de la clase. Inicializa todas las propiedades en null.
        /// </summary>
        public UsuarioRRHH()
        {
            CodigoEmpleado = null;
            Apellido1 = null;
            Apellido2 = null;
            Nombre = null;
            Login = null;
            Cargo = null;
            Empresa = null;
            Ciudad = null;
        }





    }
}
