using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using ENT;
using DAL;

namespace BLL
{
    public class BllNotario
    {
        DalNotario dalNotario;

        public BllNotario()
        {
            dalNotario = new DalNotario();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(Notario notario)
        {
            return dalNotario.insertar(notario);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<Notario> lstNotario)
        {
            return dalNotario.insertar(lstNotario);
        }

        ///METODO ACTUALIZAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int actualizar(Notario notario)
        {
            return dalNotario.actualizar(notario);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<Notario> lstNotario)
        {
            return dalNotario.actualizar(lstNotario);
        }

        ///METODO ELIMINAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int eliminar(Notario notario)
        {
            return dalNotario.eliminar(notario);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<Notario> lstNotario)
        {
            return dalNotario.eliminar(lstNotario);
        }

        ///METODO BUSCAR DE ACUERDO A LAS PROPIEDADES INICIALIZADAS

        public List<Notario> buscar(Notario notario, string _ordenarPor = null, int? _mostrarN = null)
        {
            return dalNotario.buscar(notario, _ordenarPor, _mostrarN);
        }
    }
}