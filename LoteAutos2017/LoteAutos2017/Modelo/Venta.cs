using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoteAutos2017.Modelo
{
    [Table(name:"Ventas")]
   public class Venta
    {
        [Key]
        public int pkVenta { get; set; }
        public DateTime dFechaVenta { get; set; }        
        
        [Required(ErrorMessage = "Dene indicar la Unidad")]
        public int fkAuto { get; set; }
        [Required(ErrorMessage ="Debe indicar el Total de la Venta")]
        public double PrecioVenta { get; set; }
        public Boolean bStatus { get; set; }        
        public CONCEPTO TipoMovimiento { get; set; }

        public virtual Cliente cliente { get; set; }

        public Venta() {
            this.bStatus = true;
            this.dFechaVenta = DateTime.Now;
        }
        //TODO: PONER QUIEN REALIZA LA VENTA
    }

    public enum CONCEPTO {
        VENTA=1,
        COMISION=2
    }
}
