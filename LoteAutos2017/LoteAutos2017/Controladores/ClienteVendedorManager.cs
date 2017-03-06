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
    class ClienteVendedorManager
    {
        

        public static List<string> getColoniasRegistradas(string valor) {
            List<string> colonias =new List<string>();
            try
            {
                using (var ctx = new DataModel()) {
                    var clientes = ctx.ClientesVendedor.Where(r=>r.sColonia.Contains(valor)).GroupBy(r => r.sColonia).ToList();
                    foreach (var item in clientes) {
                        colonias.Add(item.Key.ToUpper());
                    }
                    return colonias;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<string> geCiudadesRegistradas(string valor)
        {
            List<string> ciudades = new List<string>();
            try
            {
                using (var ctx = new DataModel())
                {
                    var clientes = ctx.ClientesVendedor.Where(r => r.sCiudad.Contains(valor)).GroupBy(r => r.sCiudad).ToList();
                    foreach (var item in clientes)
                    {
                        ciudades.Add(item.Key.ToUpper());
                    }
                    return ciudades;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<string> getEstadoRegistradas(string valor)
        {
            List<string> estados = new List<string>();
            try
            {
                using (var ctx = new DataModel())
                {
                    var clientes = ctx.ClientesVendedor.Where(r => r.sEstado.Contains(valor)).GroupBy(r => r.sEstado).ToList();
                    foreach (var item in clientes)
                    {
                        estados.Add(item.Key.ToUpper());
                    }
                    return estados;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
