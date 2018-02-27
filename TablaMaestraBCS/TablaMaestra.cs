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

        /// <summary>
        /// Carga un usuario a la tabla maestra. Reconoce si debe crear un nuevo usuario o si solo
        /// debe actualizar una ya existente.
        /// </summary>
        /// <param name="usuario"></param>
        public void CargarUsuario(Usuario usuario)
        {
            // si no tiene ni login no cedula, ¿a que jugamos, parce?
            if (string.IsNullOrWhiteSpace(usuario.Login) && string.IsNullOrWhiteSpace(usuario.Cedula) )
                return;

            // si la entrada tiene login
            if (!string.IsNullOrWhiteSpace(usuario.Login)) 
            {
                if (diccionarioLogins.ContainsKey(usuario.Login))
                {
                    // TODO: Actualizar usuario
                    Usuario usuarioExistente = diccionarioUsuarios[diccionarioLogins[usuario.Login]];
                    usuarioExistente.Combinar(usuario);
                    // Agregar al diccionario de cédulas.
                    if (string.IsNullOrWhiteSpace(usuario.Cedula))
                    {
                        if (!diccionarioCedulas.ContainsKey(usuario.Cedula))
                            diccionarioCedulas.Add(usuario.Cedula, diccionarioLogins[usuario.Login]);                      
                        else
                            diccionarioCedulas[usuario.Cedula] = diccionarioLogins[usuario.Login];
                    }
                    return;
                }

                // Probar con la cédula
                if (!string.IsNullOrWhiteSpace(usuario.Cedula) && diccionarioCedulas.ContainsKey(usuario.Cedula))
                {
                    // TODO: Actualizar usuario
                    // Agregar al diccionario de logines
                    diccionarioLogins.Add(usuario.Login, diccionarioCedulas[usuario.Cedula]);
                    return;
                }

                // Si no está en ningún diccionario:
                diccionarioLogins.Add(usuario.Login, contadorUsuarios);
                if (!string.IsNullOrWhiteSpace(usuario.Cedula)) diccionarioCedulas.Add(usuario.Cedula, contadorUsuarios);
                diccionarioUsuarios.Add(contadorUsuarios, usuario);
                contadorUsuarios++;
                return;
            }

            // Si no hay login:
            if(diccionarioCedulas.ContainsKey(usuario.Cedula)) // Buscar por cc.
            {
                // TODO: Actualizar datos
                Console.WriteLine("Duplicado: " + usuario.Cedula);
                return;
            }
            diccionarioCedulas.Add(usuario.Cedula, contadorUsuarios);
            diccionarioUsuarios.Add(contadorUsuarios, usuario);
            contadorUsuarios++;
           
        }




        /// <summary>
        /// Imprime en consola todos los usuarios en el diccionario de usuarios.
        /// </summary>
        public void ImprimirEnConsola()
        {
            Console.WriteLine("NombreCompleto" + ',' + "Login" + ',' + "Cedula" + ',' + "Organizacion" + ',' + "Cargo" + ',' + "Ciudad" + ',' + "Activada" + ',' + "RRHH" + ',' + "DA_FS" + ',' + "DA_ARP" + ',' + "DA_OFBCSC" + ',' + "Temporales");
            foreach (var usuario in diccionarioUsuarios.Values)
            {
                Console.WriteLine(usuario.ToCSV());
            }
        }

        public void ImprimirCSV()
        {
            string[] datos = new string[diccionarioUsuarios.Count+1];
            datos[0] = "NombreCompleto" + ',' + "Login" + ',' + "Cedula" + ',' + "Organizacion" + ',' + "Cargo" + ',' + "Ciudad" + ',' + "Activada" + ',' + "RRHH" + ',' + "DA_FS" + ',' + "DA_ARP" + ',' + "DA_OFBCSC" + ',' + "Temporales";
            int i = 1;
            foreach (var usuario in diccionarioUsuarios.Values)
            {
                datos[i++] = usuario.ToCSV();
            }
            System.IO.File.WriteAllLines("MasterTable.csv", datos);
        }
    }


}
