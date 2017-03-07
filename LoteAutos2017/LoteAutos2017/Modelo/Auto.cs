using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using LoteAutos2017.Comun;
namespace LoteAutos2017.Modelo
{
    [Table(name: "Autos")]
    public class Auto
    {
        [Key]
        public int pkAuto { get; set; }

        [Required(ErrorMessage ="Se requiere la Marca")]
        public String sMarca { get; set; }
        [Required(ErrorMessage = "Se requiere el Modelo")]
        public String sModelo { get; set; }
        [Required(ErrorMessage = "Se requiere el Año")]
        public int iAnio { get; set; }
        [Required(ErrorMessage = "El numero de serie no puede quedar vacio")]
        public String sNumeroSerie { get; set; }
        public String sDescripcion { get; set; }
        [Required(ErrorMessage = "Se requiere la fotografia principal")]
        public String sFotoPrincipal { get; set; }
        [Required(ErrorMessage = "Se requiere la imagen")]
        public String sFotoSecundaria { get; set; }
        [Required(ErrorMessage = "Se requiere la imagen")]
        public String sFotoTercearia { get; set; }

        [Required(ErrorMessage ="Se require el costro de la unidad")]
        public double Costo { get; set; }

        [Required(ErrorMessage = "Se require el Precio de Venta")]
        public double PrecioVenta { get; set; }

        public Boolean bStatus { get; set; }

        public Auto(){
            this.bStatus = true;
            this.sFotoPrincipal = this.sFotoSecundaria= this.sFotoTercearia = ToolImagen.CargarImagenDefault();
            this.Costo = 0;
            this.PrecioVenta = 0;
        }
        //RELACIONES
        public virtual ClienteVendedor clienteVendedor { get; set; }

    }
}
