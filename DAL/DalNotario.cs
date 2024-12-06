using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using ENT;

namespace DAL
{
    public class DalNotario
    {
        Conexion cnn;

        public DalNotario()
        {
            cnn = new Conexion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(Notario notario)
        {
            cnn.Com.CommandText = "tbl_Notario";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

            try { cnn.Com.Parameters.Add("@Id_Notario", SqlDbType.Int).Value = notario.Id_Notario; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = notario.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = notario.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = notario.Usuario; } catch { }

            return cnn.Ejecutar(true);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<Notario> lstNotario)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Notario";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (Notario notario in lstNotario)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

                try { cnn.Com.Parameters.Add("@Id_Notario", SqlDbType.Int).Value = notario.Id_Notario; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = notario.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = notario.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = notario.Usuario; } catch { }

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

        public int actualizar(Notario notario)
        {
            cnn.Com.CommandText = "tbl_Notario";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

            try { cnn.Com.Parameters.Add("@Id_Notario", SqlDbType.Int).Value = notario.Id_Notario; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = notario.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = notario.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = notario.Usuario; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<Notario> lstNotario)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Notario";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (Notario notario in lstNotario)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

                try { cnn.Com.Parameters.Add("@Id_Notario", SqlDbType.Int).Value = notario.Id_Notario; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = notario.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = notario.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = notario.Usuario; } catch { }

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

        public int eliminar(Notario notario)
        {
            cnn.Com.CommandText = "tbl_Notario";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

            try { cnn.Com.Parameters.Add("@Id_Notario", SqlDbType.Int).Value = notario.Id_Notario; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<Notario> lstNotario)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Notario";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (Notario notario in lstNotario)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

                try { cnn.Com.Parameters.Add("@Id_Notario", SqlDbType.Int).Value = notario.Id_Notario; } catch { }

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


        public List<Notario> buscar(Notario parNotario, string _ordenarPor = null, int? _mostrarN = null)
        {
            cnn.Com.CommandText = "tbl_Notario";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "buscar";
            cnn.Com.Parameters.Add("@_ordenarPor", SqlDbType.VarChar).Value = _ordenarPor;
            cnn.Com.Parameters.Add("@_mostrarN", SqlDbType.Int).Value = _mostrarN;

            try { cnn.Com.Parameters.Add("@Id_Notario", SqlDbType.Int).Value = parNotario.Id_Notario; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = parNotario.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = parNotario.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = parNotario.Usuario; } catch { }

            DataTable dt = cnn.Seleccionar();  //Definiendo el depósito temporal de datos 

            List<Notario> lstNotario = new List<Notario>();

            if (dt != null)
            {
                //Listas correspondientes a las llaves foráneas

                foreach (DataRow dr in dt.Rows)
                {
                    Notario notario = new Notario();

                    try
                    {
                        notario.Id_Notario = Convert.ToInt32(dr["Id_Notario"]);
                    }
                    catch
                    {
                        notario.Id_Notario = null;
                    }
                    try
                    {
                        notario.Descripcion = Convert.ToString(dr["Descripcion"]);
                    }
                    catch
                    {
                        notario.Descripcion = null;
                    }
                    try
                    {
                        notario.Fecha_Registro = Convert.ToDateTime(dr["Fecha_Registro"]);
                    }
                    catch
                    {
                        notario.Fecha_Registro = null;
                    }
                    try
                    {
                        notario.Usuario = Convert.ToString(dr["Usuario"]);
                    }
                    catch
                    {
                        notario.Usuario = null;
                    }

                    lstNotario.Add(notario);
                }

            }
            return lstNotario;
        }
    } //FIN DE LA CLASE

}