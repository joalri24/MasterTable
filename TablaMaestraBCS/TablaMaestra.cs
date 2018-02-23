using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaMaestraBCS
{
    /// <summary>
    /// Contiene la información consolidad de los usuarios.
    /// </summary>
    class TablaMaestra
    {

        private Dictionary<string, int> diccionarioLogins;
        private Dictionary<string, int> diccionarioCedulas;
        private Dictionary<int, Usuario> diccionarioUsuarios;
        private int contadorUsuarios = 0;

        public TablaMaestra()
        {
            diccionarioUsuarios = new Dictionary<int, Usuario>();
            diccionarioLogins = new Dictionary<string, int>();
            diccionarioCedulas = new Dictionary<string, int>();
        }

        public void CargarUsuario(UsuarioRRHH usuario)
        {
            // si no tiene ni login no cedula, ¿a que jugamos, parce?
            if (string.IsNullOrWhiteSpace(usuario.Login) && string.IsNullOrWhiteSpace(usuario.CodigoEmpleado) )
                return;

            if (!string.IsNullOrWhiteSpace(usuario.Login) ) // si la entrada tiene login
            {
                if(diccionarioLogins.ContainsKey(usuario.Login))
                {
                    Usuario usuarioExistente = diccionarioUsuarios[diccionarioLogins[usuario.Login]];

                }
                else // si  el login no está en el diccionario
                {
                    // Probar con la cédula 
                    if (diccionarioCedulas.ContainsKey(usuario.CodigoEmpleado))
                    {
                        Usuario usuarioExistente = diccionarioUsuarios[diccionarioCedulas[usuario.CodigoEmpleado]];
                    }

                    else // No está en ningún lado 
                    {
                        // Crear la entrada en los diccionarios
                        if(!string.IsNullOrWhiteSpace(usuario.CodigoEmpleado))
                            diccionarioCedulas.Add(usuario.CodigoEmpleado, contadorUsuarios);
                        if (!string.IsNullOrWhiteSpace(usuario.CodigoEmpleado))
                            diccionarioLogins.Add(usuario.Login, contadorUsuarios);
                        contadorUsuarios++;

                        // Crea el usuario
                        string nombre = usuario.Nombre + " " + usuario.Apellido1 + " " +usuario.Apellido2;
                        Usuario nuevoUsuario = new Usuario(nombreCompleto:nombre, login:usuario.Login, cedula: usuario.CodigoEmpleado, organizacion:usuario.Empresa, ciudad:usuario.Ciudad, cargo:usuario.Cargo, activada:true, rrhh: true, da_fs: false, da_ofcbsb: false, da_arp: false) ;
                        diccionarioUsuarios.Add(contadorUsuarios, nuevoUsuario);
                    } 
                }
                return;
            }

            // La entrada no tiene login
            if (diccionarioCedulas.ContainsKey(usuario.CodigoEmpleado)) // Si la cédula esta en el diccionario
            {
                Usuario usuarioExistente = diccionarioUsuarios[diccionarioCedulas[usuario.CodigoEmpleado]];
            }
            else // La cédula no está en el diccionario
            {
                // Crear la entrada en los diccionarios
                diccionarioCedulas.Add(usuario.CodigoEmpleado, contadorUsuarios);
                contadorUsuarios++;
                // Crea el usuario
                string nombre = usuario.Nombre + " " + usuario.Apellido1 + " " + usuario.Apellido2;
                Usuario nuevoUsuario = new Usuario(nombreCompleto: nombre, login: usuario.Login, cedula: usuario.CodigoEmpleado, organizacion: usuario.Empresa, ciudad: usuario.Ciudad, cargo: usuario.Cargo, activada:true, rrhh:true, da_fs:false, da_ofcbsb:false, da_arp:false);
                diccionarioUsuarios.Add(contadorUsuarios, nuevoUsuario);
            }

        }

        /// <summary>
        /// Imprime en consola todos los usuarios en el diccionario de usuarios.
        /// </summary>
        public void ImprimirEnConsola()
        {
            foreach (var usuario in diccionarioUsuarios.Values)
            {
                Console.WriteLine(usuario.ToCSV());
            }
        }

    }


}
