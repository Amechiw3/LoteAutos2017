using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutos2017.Modelo;

namespace LoteAutos2017.Controladores
{
    class VentaManager
    {
        //TODO: SOLICITAR EL USUARIO QUIEN REALIZA LA VENTA
        public static int RegistrarVenta(Auto aVender,Cliente Comprador) {
            try
            {
                using (var ctx = new DataModel()) {
                    Venta nVenta = new Venta();
                    nVenta.TipoMovimiento = CONCEPTO.VENTA;
                    nVenta.fkAuto = aVender.pkAuto;
                    nVenta.PrecioVenta = aVender.PrecioVenta;
                    nVenta.cliente = Comprador;

                    ctx.Ventas.Add(nVenta);
                    ctx.Clientes.Attach(Comprador);
                    ctx.SaveChanges();
                    return nVenta.pkVenta;
                }                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
