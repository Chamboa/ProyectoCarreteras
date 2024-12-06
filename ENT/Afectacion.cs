using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Afectacion
    {

        public int? Id_Afectacion { get; set; }
        public string Descripcion { get; set; }
        public int? Id_Padre { get; set; }
        public int? Nivel { get; set; }
        public string Jerarquia { get; set; }
        public Boolean? Estado { get; set; }
        public DateTime? Fecha_Registro { get; set; }
        public string Usuario { get; set; }


        public Afectacion()
        {

        }
    }
}
