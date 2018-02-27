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

        public enum Fuentes
        {
            RRHH,
            Temporales,
            AD_FS,
            AD_ARP,
            AD_OFBCSC
        }
       

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
        /// El usuario está en RRHH?
        /// </summary>
        public bool Temporales { get; set; }
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
            RRHH = false;
            DA_FS = false;
            DA_OFBCSC = false;
            DA_ARP = false;
            Temporales = false;

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

        public static Usuario CrearUsuario(Fuentes fuente, string datos)
        {           
            Usuario usuario = new Usuario();
            switch (fuente)
	        {
		        case Fuentes.RRHH:
                    string[] linea = datos.Split(',');
                    //EMP_CODIGO,APELLIDO1,APELLIDO2,NOMBRE,LOGIN,CARGO,EMPRESA,OFICINA,GERENCIA,REGIONAL,AREA,TIPO_NOMIN,CIUDAD,F_INGRESO,FIN_CONTRA,NIVEL
                    //usuario = new UsuarioRRHH(codigoEmpleado: linea[0], apellido1: linea[1], apellido2: linea[2], nombre: linea[3], login: linea[4], cargo: linea[5], empresa: linea[6], ciudad: linea[12]);
                    usuario.Cedula = linea[0];
                    usuario.NombreCompleto = linea[3] + " " + linea[1] + " " + linea[2];
                    usuario.Login = linea[4];
                    usuario.Organizacion = linea[6];
                    usuario.Cargo = linea[5];
                    usuario.Ciudad = linea[12];
                    usuario.RRHH = true;                    
                    break;

                case Fuentes.Temporales:
                    break;

                case Fuentes.AD_FS:
                    // Los datos están separados por ancho fijo
                    //Name                                                             extensionAttribute1 SamAccountName       Company                                                    Department                                                       Title                                                            SamAccountName       Enabled Created                AccountExpirationDate  LastLogonDate         .
                    usuario.NombreCompleto = datos.Substring(0, 65).Trim();
                    usuario.Cedula = datos.Substring(65, 20).Trim();
                    usuario.Login = datos.Substring(85, 21).Trim();
                    usuario.Organizacion = datos.Substring(106, 59).Trim();
                    usuario.Cargo = datos.Substring(230, 65).Trim();
                    //usuario.Activada = bool.Parse(datos.Substring(316, 7).Trim());
                    usuario.Activada = true;
                    usuario.DA_FS = true;
                    break;

                case Fuentes.AD_ARP:
                    // Los datos están separados por ancho fijo                   
                    usuario.NombreCompleto = datos.Substring(0, 59).Trim();
                    usuario.Cedula = datos.Substring(58, 20).Trim();
                    usuario.Login = datos.Substring(78, 20).Trim();
                    usuario.Organizacion = datos.Substring(98, 52).Trim();
                    usuario.Cargo = datos.Substring(198, 64).Trim();
                    //usuario.Activada = bool.Parse(datos.Substring(316, 7).Trim());
                    usuario.Activada = true;
                    usuario.DA_ARP = true;
                    break;

                case Fuentes.AD_OFBCSC:
                    // Los datos están separados por ancho fijo
                    //Name                                                             extensionAttribute1 SamAccountName       Company                                                    Department                                                       Title                                                            SamAccountName       Enabled Created                AccountExpirationDate  LastLogonDate         .
                    usuario.NombreCompleto = datos.Substring(0, 49).Trim();
                    usuario.Cedula = datos.Substring(48, 20).Trim();
                    usuario.Login = datos.Substring(68, 19).Trim();
                    usuario.Organizacion = datos.Substring(87, 41).Trim();
                    usuario.Cargo = datos.Substring(193, 50).Trim();
                    //usuario.Activada = bool.Parse(datos.Substring(316, 7).Trim());
                    usuario.Activada = true;
                    usuario.DA_OFBCSC = true;
                    break;

                default:
                    break;
	        }
            return usuario;
        }

        /// <summary>
        /// Imprime el usuario como una línea separada por comas.
        /// </summary>
        /// <returns></returns>
        public string ToCSV()
        {
            return NombreCompleto + ',' + Login + ',' + Cedula + ',' + Organizacion + ',' + Cargo + ',' + Ciudad + ',' + Activada + ',' + RRHH + ',' + DA_FS + ',' + DA_ARP + ',' + DA_OFBCSC + ',' + Temporales;
        }

        public void Combinar(Usuario otroUsuario)
        {
            RRHH = RRHH || otroUsuario.RRHH;
            DA_FS = DA_FS || otroUsuario.DA_FS;
            DA_OFBCSC = DA_OFBCSC || otroUsuario.DA_OFBCSC;
            DA_ARP = DA_ARP || otroUsuario.DA_ARP;
        }
    }
}
