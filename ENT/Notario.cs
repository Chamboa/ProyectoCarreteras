using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Notario
    {

        public int? Id_Notario { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha_Registro { get; set; }
        public string Usuario { get; set; }


        public Notario()
        {

        }
    }
}
