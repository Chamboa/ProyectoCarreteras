using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using ENT;

namespace DAL
{
    public class DalRegistroPropiedad
    {
        Conexion cnn;

        public DalRegistroPropiedad()
        {
            cnn = new Conexion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(RegistroPropiedad registroPropiedad)
        {
            cnn.Com.CommandText = "tbl_Registro_Propiedad";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

            try { cnn.Com.Parameters.Add("@Id_Registro", SqlDbType.Int).Value = registroPropiedad.Id_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = registroPropiedad.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = registroPropiedad.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = registroPropiedad.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = registroPropiedad.Usuario; } catch { }

            return cnn.Ejecutar(true);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<RegistroPropiedad> lstRegistroPropiedad)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Registro_Propiedad";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (RegistroPropiedad registroPropiedad in lstRegistroPropiedad)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

                try { cnn.Com.Parameters.Add("@Id_Registro", SqlDbType.Int).Value = registroPropiedad.Id_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = registroPropiedad.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = registroPropiedad.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = registroPropiedad.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = registroPropiedad.Usuario; } catch { }

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

        public int actualizar(RegistroPropiedad registroPropiedad)
        {
            cnn.Com.CommandText = "tbl_Registro_Propiedad";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

            try { cnn.Com.Parameters.Add("@Id_Registro", SqlDbType.Int).Value = registroPropiedad.Id_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = registroPropiedad.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = registroPropiedad.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = registroPropiedad.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = registroPropiedad.Usuario; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<RegistroPropiedad> lstRegistroPropiedad)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Registro_Propiedad";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (RegistroPropiedad registroPropiedad in lstRegistroPropiedad)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

                try { cnn.Com.Parameters.Add("@Id_Registro", SqlDbType.Int).Value = registroPropiedad.Id_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = registroPropiedad.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = registroPropiedad.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = registroPropiedad.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = registroPropiedad.Usuario; } catch { }

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

        public int eliminar(RegistroPropiedad registroPropiedad)
        {
            cnn.Com.CommandText = "tbl_Registro_Propiedad";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

            try { cnn.Com.Parameters.Add("@Id_Registro", SqlDbType.Int).Value = registroPropiedad.Id_Registro; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<RegistroPropiedad> lstRegistroPropiedad)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Registro_Propiedad";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (RegistroPropiedad registroPropiedad in lstRegistroPropiedad)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

                try { cnn.Com.Parameters.Add("@Id_Registro", SqlDbType.Int).Value = registroPropiedad.Id_Registro; } catch { }

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


        public List<RegistroPropiedad> buscar(RegistroPropiedad parRegistroPropiedad, string _ordenarPor = null, int? _mostrarN = null)
        {
            cnn.Com.CommandText = "tbl_Registro_Propiedad";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "buscar";
            cnn.Com.Parameters.Add("@_ordenarPor", SqlDbType.VarChar).Value = _ordenarPor;
            cnn.Com.Parameters.Add("@_mostrarN", SqlDbType.Int).Value = _mostrarN;

            try { cnn.Com.Parameters.Add("@Id_Registro", SqlDbType.Int).Value = parRegistroPropiedad.Id_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = parRegistroPropiedad.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = parRegistroPropiedad.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = parRegistroPropiedad.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = parRegistroPropiedad.Usuario; } catch { }

            DataTable dt = cnn.Seleccionar();  //Definiendo el depósito temporal de datos 

            List<RegistroPropiedad> lstRegistroPropiedad = new List<RegistroPropiedad>();

            if (dt != null)
            {
                //Listas correspondientes a las llaves foráneas

                foreach (DataRow dr in dt.Rows)
                {
                    RegistroPropiedad registroPropiedad = new RegistroPropiedad();

                    try
                    {
                        registroPropiedad.Id_Registro = Convert.ToInt32(dr["Id_Registro"]);
                    }
                    catch
                    {
                        registroPropiedad.Id_Registro = null;
                    }
                    try
                    {
                        registroPropiedad.Descripcion = Convert.ToString(dr["Descripcion"]);
                    }
                    catch
                    {
                        registroPropiedad.Descripcion = null;
                    }

                    try
                    {
                        registroPropiedad.Estado = Convert.ToBoolean(dr["Estado"]);
                    }
                    catch
                    {
                        registroPropiedad.Estado = null;
                    }
                    try
                    {
                        registroPropiedad.Fecha_Registro = Convert.ToDateTime(dr["Fecha_Registro"]);
                    }
                    catch
                    {
                        registroPropiedad.Fecha_Registro = null;
                    }
                    try
                    {
                        registroPropiedad.Usuario = Convert.ToString(dr["Usuario"]);
                    }
                    catch
                    {
                        registroPropiedad.Usuario = null;
                    }

                    lstRegistroPropiedad.Add(registroPropiedad);
                }

            }
            return lstRegistroPropiedad;
        }
    } //FIN DE LA CLASE

} //FIN