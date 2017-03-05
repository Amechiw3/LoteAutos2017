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
    public class Auto
    {
        [Key]
        public int pkAuto { get; set; }

        public String sMarca { get; set; }
        public String sModelo { get; set; }
        public int iAnio { get; set; }
        public String sNumeroSerie { get; set; }
        public String sDescripcion { get; set; }
        public String sFotoPrincipal { get; set; }
        public String sFotoSecundaria { get; set; }
        public String sFotoTercearia { get; set; }

        public Boolean bStatus { get; set; }

        public Auto(){
            this.bStatus = true;
            this.sFotoPrincipal = this.sFotoSecundaria= this.sFotoTercearia = ToolImagen.CargarImagenDefault();           
        }


    }
}
