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
    [Table(name: "Compradores")]
    public class Comprador
    {
        [Key]
        public int pkComprador { get; set; }
        [Required(ErrorMessage = "Se requiere el Nombre")]
        public String sNombre { get; set; }

        [Required(ErrorMessage = "Se requiere el Apellido")]
        public String sApellidos { get; set; }

        public String sEmail { get; set; }
        public String sTelefono { get; set; }

        public Boolean bStatus { get; set; }

        [Required(ErrorMessage ="Se requiere el RFC")]
        public String sINE { get; set; }
        [Required(ErrorMessage = "Se requiere el Calle")]
        public String sCalle { get; set; }
        [Required(ErrorMessage = "Se requiere el Numero")]
        public String sNumero { get; set; }
        public String sEntreCalle { get; set; }
        [Required(ErrorMessage = "Se requiere la Colonia")]
        public String sColonia { get; set; }
        [Required(ErrorMessage = "Se requiere la Ciudad ")]
        public String sCiudad { get; set; }
                
        public String sEstado { get; set; }

        [Required(ErrorMessage = "Se requiere la Fotografia")]
        public String sImagen { get; set; }


        public Comprador() {
            this.sEstado = "SONORA";
            this.sImagen = ToolImagen.CargarImagenDefault("cliente_silueta.jpg");            
        }

    }
}
