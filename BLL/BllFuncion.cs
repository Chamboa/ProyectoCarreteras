using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using ENT;
using DAL;

namespace BLL
{
    public class BllFuncion
    {
        DalFuncion dalFuncion;

        public BllFuncion()
        {
            dalFuncion = new DalFuncion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(Funcion funcion)
        {
            return dalFuncion.insertar(funcion);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<Funcion> lstFuncion)
        {
            return dalFuncion.insertar(lstFuncion);
        }

        ///METODO ACTUALIZAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int actualizar(Funcion funcion)
        {
            return dalFuncion.actualizar(funcion);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<Funcion> lstFuncion)
        {
            return dalFuncion.actualizar(lstFuncion);
        }

        ///METODO ELIMINAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int eliminar(Funcion funcion)
        {
            return dalFuncion.eliminar(funcion);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<Funcion> lstFuncion)
        {
            return dalFuncion.eliminar(lstFuncion);
        }

        ///METODO BUSCAR DE ACUERDO A LAS PROPIEDADES INICIALIZADAS

        public List<Funcion> buscar(Funcion funcion, string _ordenarPor = null, int? _mostrarN = null)
        {
            return dalFuncion.buscar(funcion, _ordenarPor, _mostrarN);
        }
    }
}