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
                        colonias.Add(item.ToString());
                    }
                    return colonias;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }        
    }
}
