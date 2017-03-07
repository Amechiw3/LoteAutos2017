using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos2017.Modelo;

namespace LoteAutos2017.Controladores
{
    class ClienteManager
    {
        public static List<Cliente> BuscarPorApellidos(String valor)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Clientes
                        .Where(r => r.sApellidos.Contains(valor) 
                        && r.bStatus==true)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Cliente BuscarPorID(int Id) {
            try
            {
                using (var ctx = new DataModel()) {
                    return ctx.Clientes
                        .Where(r => r.pkCliente == Id)
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int  GuardarCliente(Cliente nCliente) {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.Clientes.Add(nCliente);
                    ctx.SaveChanges();
                }
                return nCliente.pkCliente;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
