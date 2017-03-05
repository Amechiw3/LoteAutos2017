using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoteAutos2017.Modelo
{
    [Table(name:"Clientes")]
    public class Cliente
    {
        [Key]
        public int pkCliente { get; set; }

        [Required(ErrorMessage = "Se requiere el Nombre")]
        public String sNombre { get; set; }

        [Required(ErrorMessage = "Se requiere el Apellido")]
        public String sApellidos { get; set; }

        public String sEmail { get; set; }
        public String sTelefono { get; set; }

        public Boolean bStatus { get; set; }

        public Cliente() {
            this.bStatus = true;
        }

    }
}
