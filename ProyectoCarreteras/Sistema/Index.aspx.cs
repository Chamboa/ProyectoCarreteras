using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoCarreteras.Sistema
{
    public partial class Index : System.Web.UI.Page
    {
        [System.Web.Services.WebMethod]
        public static List<TipoAdquisicion> ObtenerTiposAdquisicion()
        {
            // Crear una instancia de la clase BLL (lógica de negocio)
            BllTipoAdquisicion bllTipoAdquisicion = new BllTipoAdquisicion();

            // Llamar al método que obtiene los registros de tipos de adquisición
            return bllTipoAdquisicion.ObtenerTiposAdquisicion();
        }
    }
}