using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using ENT;
using DAL;

namespace BLL
{
    public class BllTipoDocumentoIdentificacion
    {
        DalTipoDocumentoIdentificacion dalTipoDocumentoIdentificacion;

        public BllTipoDocumentoIdentificacion()
        {
            dalTipoDocumentoIdentificacion = new DalTipoDocumentoIdentificacion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(TipoDocumentoIdentificacion tipoDocumentoIdentificacion)
        {
            return dalTipoDocumentoIdentificacion.insertar(tipoDocumentoIdentificacion);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<TipoDocumentoIdentificacion> lstTipoDocumentoIdentificacion)
        {
            return dalTipoDocumentoIdentificacion.insertar(lstTipoDocumentoIdentificacion);
        }

        ///METODO ACTUALIZAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int actualizar(TipoDocumentoIdentificacion tipoDocumentoIdentificacion)
        {
            return dalTipoDocumentoIdentificacion.actualizar(tipoDocumentoIdentificacion);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<TipoDocumentoIdentificacion> lstTipoDocumentoIdentificacion)
        {
            return dalTipoDocumentoIdentificacion.actualizar(lstTipoDocumentoIdentificacion);
        }

        ///METODO ELIMINAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int eliminar(TipoDocumentoIdentificacion tipoDocumentoIdentificacion)
        {
            return dalTipoDocumentoIdentificacion.eliminar(tipoDocumentoIdentificacion);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<TipoDocumentoIdentificacion> lstTipoDocumentoIdentificacion)
        {
            return dalTipoDocumentoIdentificacion.eliminar(lstTipoDocumentoIdentificacion);
        }

        ///METODO BUSCAR DE ACUERDO A LAS PROPIEDADES INICIALIZADAS

        public List<TipoDocumentoIdentificacion> buscar(TipoDocumentoIdentificacion tipoDocumentoIdentificacion, string _ordenarPor = null, int? _mostrarN = null)
        {
            return dalTipoDocumentoIdentificacion.buscar(tipoDocumentoIdentificacion, _ordenarPor, _mostrarN);
        }
    }
}