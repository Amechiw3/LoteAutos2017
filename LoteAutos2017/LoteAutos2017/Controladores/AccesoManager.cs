using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq;
using LoteAutos2017.Modelo;

namespace LoteAutos2017.Controladores
{
    public class AccesoManager
    {
        public static void RegistrarAcceso(Acceso acceso) {
            try
            {
                using (var ctx = new DataModel()) {

                    ctx.Accesos.Add(acceso);
                    ctx.Usuarios.Attach(acceso.usuario);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }                            
        }
    }
}
