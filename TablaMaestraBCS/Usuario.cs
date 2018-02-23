using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMaestraBCS
{
    /// <summary>
    /// Un usuario del banco que será agregado al OIM.
    /// </summary>
    class Usuario
    {

        public string NombreCompleto { get; set; }
        public string Login { get; set; }
        public string Cedula { get; set; }
        public string Organizacion { get; set; }
        public string Ciudad { get; set; }
        public string Cargo { get; set; }
        public bool Activada{ get; set; }
        /// <summary>
        /// El usuario está en RRHH?
        /// </summary>
        public bool RRHH { get; set; }
        /// <summary>
        /// El usuario está en FS del DA?
        /// </summary>
        public bool DA_FS { get; set; }
        /// <summary>
        /// El usuario está en ARP del DA?
        /// </summary>
        public bool DA_ARP { get; set; }
        /// <summary>
        /// El usuario está en OFBCSC del DA?
        /// </summary>
        public bool DA_OFBCSC { get; set; }

        /// <summary>
        /// Constructor de la clase. Inicia todo en null y el atributo Activa en True.
        /// </summary>
        public Usuario()
        {
            NombreCompleto = null;
            Login = null;
            Cedula = null;
            Organizacion = null;
            Ciudad = null;
            Cargo = null;
            Activada = true;

        }

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public Usuario(string nombreCompleto, string login, string cedula, string organizacion, string ciudad, string cargo, bool activada, bool rrhh, bool da_fs, bool da_arp, bool da_ofcbsb)
        {
            NombreCompleto = nombreCompleto;           
            Login = login;
            Cedula = cedula;
            Organizacion = organizacion;
            Ciudad = ciudad;
            Cargo = cargo;
            Activada = activada;
            RRHH = rrhh;
            DA_FS = da_fs;
            DA_OFBCSC = da_ofcbsb;
            DA_ARP = da_arp;
        }

        /// <summary>
        /// Imprie el usuario como una línea separada por comas.
        /// </summary>
        /// <returns></returns>
        public string ToCSV()
        {
            return NombreCompleto + ',' + Login + ',' + Cedula + ',' + Organizacion + ',' + Cargo + ',' + Ciudad + ',' + Activada + ',' + RRHH + ',' + DA_FS + ',' + DA_ARP + ',' + DA_OFBCSC;
        }


    }
}
