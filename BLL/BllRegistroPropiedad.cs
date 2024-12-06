using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using ENT;
using DAL;

namespace BLL
{
    public class BllRegistroPropiedad
    {
        DalRegistroPropiedad dalRegistroPropiedad;

        public BllRegistroPropiedad()
        {
            dalRegistroPropiedad = new DalRegistroPropiedad();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(RegistroPropiedad registroPropiedad)
        {
            return dalRegistroPropiedad.insertar(registroPropiedad);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<RegistroPropiedad> lstRegistroPropiedad)
        {
            return dalRegistroPropiedad.insertar(lstRegistroPropiedad);
        }

        ///METODO ACTUALIZAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int actualizar(RegistroPropiedad registroPropiedad)
        {
            return dalRegistroPropiedad.actualizar(registroPropiedad);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<RegistroPropiedad> lstRegistroPropiedad)
        {
            return dalRegistroPropiedad.actualizar(lstRegistroPropiedad);
        }

        ///METODO ELIMINAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int eliminar(RegistroPropiedad registroPropiedad)
        {
            return dalRegistroPropiedad.eliminar(registroPropiedad);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<RegistroPropiedad> lstRegistroPropiedad)
        {
            return dalRegistroPropiedad.eliminar(lstRegistroPropiedad);
        }

        ///METODO BUSCAR DE ACUERDO A LAS PROPIEDADES INICIALIZADAS

        public List<RegistroPropiedad> buscar(RegistroPropiedad registroPropiedad, string _ordenarPor = null, int? _mostrarN = null)
        {
            return dalRegistroPropiedad.buscar(registroPropiedad, _ordenarPor, _mostrarN);
        }
    }
}