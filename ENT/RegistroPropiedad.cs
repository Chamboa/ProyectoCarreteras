using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class RegistroPropiedad
    {

        public int? Id_Registro { get; set; }
        public string Descripcion { get; set; }
        public Boolean? Estado { get; set; }
        public DateTime? Fecha_Registro { get; set; }
        public string Usuario { get; set; }


        public RegistroPropiedad()
        {

        }
    }
}
