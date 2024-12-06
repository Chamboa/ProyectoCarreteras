using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using ENT;

namespace DAL
{
    public class DalFuncion
    {
        Conexion cnn;

        public DalFuncion()
        {
            cnn = new Conexion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(Funcion funcion)
        {
            cnn.Com.CommandText = "tbl_Funcion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

            try { cnn.Com.Parameters.Add("@Id_Funcion", SqlDbType.Int).Value = funcion.Id_Funcion; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = funcion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = funcion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = funcion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = funcion.Usuario; } catch { }

            return cnn.Ejecutar(true);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<Funcion> lstFuncion)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Funcion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (Funcion funcion in lstFuncion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

                try { cnn.Com.Parameters.Add("@Id_Funcion", SqlDbType.Int).Value = funcion.Id_Funcion; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = funcion.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = funcion.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = funcion.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = funcion.Usuario; } catch { }

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

        public int actualizar(Funcion funcion)
        {
            cnn.Com.CommandText = "tbl_Funcion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

            try { cnn.Com.Parameters.Add("@Id_Funcion", SqlDbType.Int).Value = funcion.Id_Funcion; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = funcion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = funcion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = funcion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = funcion.Usuario; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<Funcion> lstFuncion)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Funcion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (Funcion funcion in lstFuncion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

                try { cnn.Com.Parameters.Add("@Id_Funcion", SqlDbType.Int).Value = funcion.Id_Funcion; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = funcion.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = funcion.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = funcion.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = funcion.Usuario; } catch { }

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

        public int eliminar(Funcion funcion)
        {
            cnn.Com.CommandText = "tbl_Funcion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

            try { cnn.Com.Parameters.Add("@Id_Funcion", SqlDbType.Int).Value = funcion.Id_Funcion; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<Funcion> lstFuncion)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Funcion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (Funcion funcion in lstFuncion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

                try { cnn.Com.Parameters.Add("@Id_Funcion", SqlDbType.Int).Value = funcion.Id_Funcion; } catch { }

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


        public List<Funcion> buscar(Funcion parFuncion, string _ordenarPor = null, int? _mostrarN = null)
        {
            cnn.Com.CommandText = "tbl_Funcion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "buscar";
            cnn.Com.Parameters.Add("@_ordenarPor", SqlDbType.VarChar).Value = _ordenarPor;
            cnn.Com.Parameters.Add("@_mostrarN", SqlDbType.Int).Value = _mostrarN;

            try { cnn.Com.Parameters.Add("@Id_Funcion", SqlDbType.Int).Value = parFuncion.Id_Funcion; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = parFuncion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = parFuncion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = parFuncion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = parFuncion.Usuario; } catch { }

            DataTable dt = cnn.Seleccionar();  //Definiendo el depósito temporal de datos 

            List<Funcion> lstFuncion = new List<Funcion>();

            if (dt != null)
            {
                //Listas correspondientes a las llaves foráneas

                foreach (DataRow dr in dt.Rows)
                {
                    Funcion funcion = new Funcion();

                    try
                    {
                        funcion.Id_Funcion = Convert.ToInt32(dr["Id_Funcion"]);
                    }
                    catch
                    {
                        funcion.Id_Funcion = null;
                    }
                    try
                    {
                        funcion.Descripcion = Convert.ToString(dr["Descripcion"]);
                    }
                    catch
                    {
                        funcion.Descripcion = null;
                    }

                    try
                    {
                        funcion.Estado = Convert.ToBoolean(dr["Estado"]);
                    }
                    catch
                    {
                        funcion.Estado = null;
                    }
                    try
                    {
                        funcion.Fecha_Registro = Convert.ToDateTime(dr["Fecha_Registro"]);
                    }
                    catch
                    {
                        funcion.Fecha_Registro = null;
                    }
                    try
                    {
                        funcion.Usuario = Convert.ToString(dr["Usuario"]);
                    }
                    catch
                    {
                        funcion.Usuario = null;
                    }

                    lstFuncion.Add(funcion);
                }

            }
            return lstFuncion;
        }
    } //FIN DE LA CLASE

} //FIN DE NAM