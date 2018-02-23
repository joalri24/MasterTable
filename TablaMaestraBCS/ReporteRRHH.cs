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
    class ReporteRRHH
    {
        //EMP_CODIGO,APELLIDO1,APELLIDO2,NOMBRE,LOGIN,CARGO,EMPRESA,OFICINA,GERENCIA,REGIONAL,AREA,TIPO_NOMIN,CIUDAD,F_INGRESO,FIN_CONTRA,NIVEL
        
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

        public ReporteRRHH(string codigoEmpleado, string apellido1, string apellido2, string nombre, string login, string cargo, string empresa, string ciudad)
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



    }
}
