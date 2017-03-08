using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos2017.Modelo;
using LoteAutos2017.Controladores.Helpers;
using LoteAutos2017.Comun;

namespace LoteAutos2017.Controladores
{
    class UsuarioManeger
    {
        public static UsuarioHelper Autentificar(String sUsuario, String sPassword) {
            UsuarioHelper uHelper = new UsuarioHelper();
            Usuario user = BuscarPorEmail(sUsuario);
            if (user!=null){
                if (user.sPassword == LoginTool.GetMD5(sPassword))
                {
                    uHelper.usuario = user;
                    uHelper.esValido = true;
                }
                else {
                    uHelper.sMensaje = "Datos Incorrectos";
                }
            }
            return uHelper;
        }

        private static Usuario BuscarPorEmail(string Email) {
            try
            {
                using (var ctx = new DataModel()) {
                    return ctx.Usuarios.Include("rol")
                        .Include("rol.PermisosNegados")
                        .Include("rol.PermisosNegados.permiso")
                        .Where(r => r.sUsuario == Email).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void RegistrarNuevoUsuario(Usuario nUsuario) {
            try
            {
                using (var ctx = new DataModel()) {
                    ctx.Usuarios.Add(nUsuario);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }                           
        }

    }


}
