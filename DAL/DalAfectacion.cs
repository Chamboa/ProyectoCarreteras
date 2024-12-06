﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;


namespace DAL
{
    public class DalAfectacion
    {
        Conexion cnn;

        public DalAfectacion()
        {
            cnn = new Conexion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(Afectacion afectacion)
        {
            cnn.Com.CommandText = "tbl_Afectacion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

            try { cnn.Com.Parameters.Add("@Id_Afectacion", SqlDbType.Int).Value = afectacion.Id_Afectacion; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = afectacion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Id_Padre", SqlDbType.Int).Value = afectacion.Id_Padre; } catch { }
            try { cnn.Com.Parameters.Add("@Nivel", SqlDbType.Int).Value = afectacion.Nivel; } catch { }
            try { cnn.Com.Parameters.Add("@Jerarquia", SqlDbType.VarChar).Value = afectacion.Jerarquia; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = afectacion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = afectacion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = afectacion.Usuario; } catch { }

            return cnn.Ejecutar(true);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<Afectacion> lstAfectacion)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Afectacion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (Afectacion afectacion in lstAfectacion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

                try { cnn.Com.Parameters.Add("@Id_Afectacion", SqlDbType.Int).Value = afectacion.Id_Afectacion; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = afectacion.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Id_Padre", SqlDbType.Int).Value = afectacion.Id_Padre; } catch { }
                try { cnn.Com.Parameters.Add("@Nivel", SqlDbType.Int).Value = afectacion.Nivel; } catch { }
                try { cnn.Com.Parameters.Add("@Jerarquia", SqlDbType.VarChar).Value = afectacion.Jerarquia; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = afectacion.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = afectacion.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = afectacion.Usuario; } catch { }

                try
                {
                    if (cnn.Com.ExecuteNonQuery() > 0) i++;
                }
                catch
                {
                }
            }
            cnn.Com.Transaction.Commit();
            cnn.Cnn.Close();
            return i;
        }

        ///METODO ACTUALIZAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int actualizar(Afectacion afectacion)
        {
            cnn.Com.CommandText = "tbl_Afectacion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

            try { cnn.Com.Parameters.Add("@Id_Afectacion", SqlDbType.Int).Value = afectacion.Id_Afectacion; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = afectacion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Id_Padre", SqlDbType.Int).Value = afectacion.Id_Padre; } catch { }
            try { cnn.Com.Parameters.Add("@Nivel", SqlDbType.Int).Value = afectacion.Nivel; } catch { }
            try { cnn.Com.Parameters.Add("@Jerarquia", SqlDbType.VarChar).Value = afectacion.Jerarquia; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = afectacion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = afectacion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = afectacion.Usuario; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<Afectacion> lstAfectacion)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Afectacion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (Afectacion afectacion in lstAfectacion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

                try { cnn.Com.Parameters.Add("@Id_Afectacion", SqlDbType.Int).Value = afectacion.Id_Afectacion; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = afectacion.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Id_Padre", SqlDbType.Int).Value = afectacion.Id_Padre; } catch { }
                try { cnn.Com.Parameters.Add("@Nivel", SqlDbType.Int).Value = afectacion.Nivel; } catch { }
                try { cnn.Com.Parameters.Add("@Jerarquia", SqlDbType.VarChar).Value = afectacion.Jerarquia; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = afectacion.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = afectacion.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = afectacion.Usuario; } catch { }

                try
                {
                    if (cnn.Com.ExecuteNonQuery() > 0) i++;
                }
                catch
                {
                }
            }
            cnn.Com.Transaction.Commit();
            cnn.Cnn.Close();
            return i;
        }

        ///METODO ELIMINAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int eliminar(Afectacion afectacion)
        {
            cnn.Com.CommandText = "tbl_Afectacion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

            try { cnn.Com.Parameters.Add("@Id_Afectacion", SqlDbType.Int).Value = afectacion.Id_Afectacion; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<Afectacion> lstAfectacion)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Afectacion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (Afectacion afectacion in lstAfectacion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

                try { cnn.Com.Parameters.Add("@Id_Afectacion", SqlDbType.Int).Value = afectacion.Id_Afectacion; } catch { }

                try
                {
                    if (cnn.Com.ExecuteNonQuery() > 0) i++;
                }
                catch
                {
                }
            }
            cnn.Com.Transaction.Commit();
            cnn.Cnn.Close();
            return i;
        }


        public List<Afectacion> buscar(Afectacion parAfectacion, string _ordenarPor = null, int? _mostrarN = null)
        {
            cnn.Com.CommandText = "tbl_Afectacion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "buscar";
            cnn.Com.Parameters.Add("@_ordenarPor", SqlDbType.VarChar).Value = _ordenarPor;
            cnn.Com.Parameters.Add("@_mostrarN", SqlDbType.Int).Value = _mostrarN;

            try { cnn.Com.Parameters.Add("@Id_Afectacion", SqlDbType.Int).Value = parAfectacion.Id_Afectacion; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = parAfectacion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Id_Padre", SqlDbType.Int).Value = parAfectacion.Id_Padre; } catch { }
            try { cnn.Com.Parameters.Add("@Nivel", SqlDbType.Int).Value = parAfectacion.Nivel; } catch { }
            try { cnn.Com.Parameters.Add("@Jerarquia", SqlDbType.VarChar).Value = parAfectacion.Jerarquia; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = parAfectacion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = parAfectacion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = parAfectacion.Usuario; } catch { }

            DataTable dt = cnn.Seleccionar();  //Definiendo el depósito temporal de datos 

            List<Afectacion> lstAfectacion = new List<Afectacion>();

            if (dt != null)
            {
                //Listas correspondientes a las llaves foráneas

                foreach (DataRow dr in dt.Rows)
                {
                    Afectacion afectacion = new Afectacion();

                    try
                    {
                        afectacion.Id_Afectacion = Convert.ToInt32(dr["Id_Afectacion"]);
                    }
                    catch
                    {
                        afectacion.Id_Afectacion = null;
                    }
                    try
                    {
                        afectacion.Descripcion = Convert.ToString(dr["Descripcion"]);
                    }
                    catch
                    {
                        afectacion.Descripcion = null;
                    }
                    try
                    {
                        afectacion.Id_Padre = Convert.ToInt32(dr["Id_Padre"]);
                    }
                    catch
                    {
                        afectacion.Id_Padre = null;
                    }
                    try
                    {
                        afectacion.Nivel = Convert.ToInt32(dr["Nivel"]);
                    }
                    catch
                    {
                        afectacion.Nivel = null;
                    }
                    try
                    {
                        afectacion.Jerarquia = Convert.ToString(dr["Jerarquia"]);
                    }
                    catch
                    {
                        afectacion.Jerarquia = null;
                    }
                    try
                    {
                        afectacion.Estado = Convert.ToBoolean(dr["Estado"]);
                    }
                    catch
                    {
                        afectacion.Estado = null;
                    }
                    try
                    {
                        afectacion.Fecha_Registro = Convert.ToDateTime(dr["Fecha_Registro"]);
                    }
                    catch
                    {
                        afectacion.Fecha_Registro = null;
                    }
                    try
                    {
                        afectacion.Usuario = Convert.ToString(dr["Usuario"]);
                    }
                    catch
                    {
                        afectacion.Usuario = null;
                    }

                    lstAfectacion.Add(afectacion);
                }

            }
            return lstAfectacion;
        }
    } //FIN DE LA CLASE

}
