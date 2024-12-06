using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using ENT;
using DAL;

namespace BLL
{
    public class BllTipoAdquisicion
    {
        DalTipoAdquisicion dalTipoAdquisicion;

        public BllTipoAdquisicion()
        {
            dalTipoAdquisicion = new DalTipoAdquisicion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(TipoAdquisicion tipoAdquisicion)
        {
            return dalTipoAdquisicion.insertar(tipoAdquisicion);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<TipoAdquisicion> lstTipoAdquisicion)
        {
            return dalTipoAdquisicion.insertar(lstTipoAdquisicion);
        }

        ///METODO ACTUALIZAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int actualizar(TipoAdquisicion tipoAdquisicion)
        {
            return dalTipoAdquisicion.actualizar(tipoAdquisicion);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<TipoAdquisicion> lstTipoAdquisicion)
        {
            return dalTipoAdquisicion.actualizar(lstTipoAdquisicion);
        }

        ///METODO ELIMINAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int eliminar(TipoAdquisicion tipoAdquisicion)
        {
            return dalTipoAdquisicion.eliminar(tipoAdquisicion);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<TipoAdquisicion> lstTipoAdquisicion)
        {
            return dalTipoAdquisicion.eliminar(lstTipoAdquisicion);
        }

        public List<TipoAdquisicion> ObtenerTiposAdquisicion()
        {
            return dalTipoAdquisicion.ObtenerTiposAdquisicion();
        }


        ///METODO BUSCAR DE ACUERDO A LAS PROPIEDADES INICIALIZADAS

        public List<TipoAdquisicion> buscar(TipoAdquisicion tipoAdquisicion, string _ordenarPor = null, int? _mostrarN = null)
        {
            return dalTipoAdquisicion.buscar(tipoAdquisicion, _ordenarPor, _mostrarN);
        }


    }
}