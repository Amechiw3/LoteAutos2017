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
    class AutoManager
    {
        public static List<Auto> ListarContenido() {
            try
            {
                using (var ctx = new DataModel()) {
                    return ctx.Autos.Where(r => r.bStatus == true).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void GuardarNuevoAuto(Auto nAuto, int pkCliente) {
            ClienteVendedor cliente = ClienteVendedorManager.BuscarPorID(pkCliente);
            try
            {
                using (var ctx = new DataModel()) {
                    nAuto.clienteVendedor = cliente;
                    ctx.Autos.Add(nAuto);
                    ctx.ClientesVendedor.Attach(cliente);
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void VenderAuto(int IdAuto) {
            try
            {
                using (var ctx = new DataModel()) {
                    Auto aVendido = BuscarPorId(IdAuto);
                    aVendido.bStatus = false;

                    ctx.Entry(aVendido).State = EntityState.Modified;
                    ctx.SaveChanges();

                    //TODO: REGISTRAR LA VENTA DE LA UNIDAD
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Auto BuscarPorId(int Id) {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.Autos
                        .Where(r => r.pkAuto == Id)
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
