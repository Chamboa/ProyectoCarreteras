using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using ENT;
using DAL;

namespace BLL
{
    public class BllAfectacion
    {
        DalAfectacion dalAfectacion;

        public BllAfectacion()
        {
            dalAfectacion = new DalAfectacion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(Afectacion afectacion)
        {
            return dalAfectacion.insertar(afectacion);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<Afectacion> lstAfectacion)
        {
            return dalAfectacion.insertar(lstAfectacion);
        }

        ///METODO ACTUALIZAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int actualizar(Afectacion afectacion)
        {
            return dalAfectacion.actualizar(afectacion);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<Afectacion> lstAfectacion)
        {
            return dalAfectacion.actualizar(lstAfectacion);
        }

        ///METODO ELIMINAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int eliminar(Afectacion afectacion)
        {
            return dalAfectacion.eliminar(afectacion);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<Afectacion> lstAfectacion)
        {
            return dalAfectacion.eliminar(lstAfectacion);
        }

        ///METODO BUSCAR DE ACUERDO A LAS PROPIEDADES INICIALIZADAS

        public List<Afectacion> buscar(Afectacion afectacion, string _ordenarPor = null, int? _mostrarN = null)
        {
            return dalAfectacion.buscar(afectacion, _ordenarPor, _mostrarN);
        }
    }
}
