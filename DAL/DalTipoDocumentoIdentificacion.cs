using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using ENT;

namespace DAL
{
    public class DalTipoDocumentoIdentificacion
    {
        Conexion cnn;

        public DalTipoDocumentoIdentificacion()
        {
            cnn = new Conexion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(TipoDocumentoIdentificacion tipoDocumentoIdentificacion)
        {
            cnn.Com.CommandText = "tbl_Funcion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

            try { cnn.Com.Parameters.Add("@Id_Tipo_Documento", SqlDbType.Int).Value = tipoDocumentoIdentificacion.Id_Tipo_Documento; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoDocumentoIdentificacion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = tipoDocumentoIdentificacion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = tipoDocumentoIdentificacion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = tipoDocumentoIdentificacion.Usuario; } catch { }

            return cnn.Ejecutar(true);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<TipoDocumentoIdentificacion> lstTipoDocumentoIdentificacion)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Tipo_Documento_Identificacion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (TipoDocumentoIdentificacion tipoDocumentoIdentificacion in lstTipoDocumentoIdentificacion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

                try { cnn.Com.Parameters.Add("@Id_Tipo_Documento", SqlDbType.Int).Value = tipoDocumentoIdentificacion.Id_Tipo_Documento; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoDocumentoIdentificacion.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = tipoDocumentoIdentificacion.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = tipoDocumentoIdentificacion.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = tipoDocumentoIdentificacion.Usuario; } catch { }

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

        public int actualizar(TipoDocumentoIdentificacion tipoDocumentoIdentificacion)
        {
            cnn.Com.CommandText = "tbl_Tipo_Documento_Identificacion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

            try { cnn.Com.Parameters.Add("@Id_Tipo_Documento", SqlDbType.Int).Value = tipoDocumentoIdentificacion.Id_Tipo_Documento; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoDocumentoIdentificacion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = tipoDocumentoIdentificacion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = tipoDocumentoIdentificacion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = tipoDocumentoIdentificacion.Usuario; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<TipoDocumentoIdentificacion> lstTipoDocumentoIdentificacion)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Tipo_Documento_Identificacion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (TipoDocumentoIdentificacion tipoDocumentoIdentificacion in lstTipoDocumentoIdentificacion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

                try { cnn.Com.Parameters.Add("@Id_Tipo_Documento", SqlDbType.Int).Value = tipoDocumentoIdentificacion.Id_Tipo_Documento; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoDocumentoIdentificacion.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = tipoDocumentoIdentificacion.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = tipoDocumentoIdentificacion.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = tipoDocumentoIdentificacion.Usuario; } catch { }

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

        public int eliminar(TipoDocumentoIdentificacion tipoDocumentoIdentificacion)
        {
            cnn.Com.CommandText = "tbl_Tipo_Documento_Identificacion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

            try { cnn.Com.Parameters.Add("@Id_Tipo_Documento", SqlDbType.Int).Value = tipoDocumentoIdentificacion.Id_Tipo_Documento; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<TipoDocumentoIdentificacion> lstTipoDocumentoIdentificacion)
        {
            int i = 0;
            cnn.Com.CommandText = "tbl_Tipo_Documento_Identificacion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (TipoDocumentoIdentificacion tipoDocumentoIdentificacion in lstTipoDocumentoIdentificacion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

                try { cnn.Com.Parameters.Add("@Id_Tipo_Documento", SqlDbType.Int).Value = tipoDocumentoIdentificacion.Id_Tipo_Documento; } catch { }

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


        public List<TipoDocumentoIdentificacion> buscar(TipoDocumentoIdentificacion parTipoDocumentoIdentificacion, string _ordenarPor = null, int? _mostrarN = null)
        {
            cnn.Com.CommandText = "tbl_Tipo_Documento_Identificacion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "buscar";
            cnn.Com.Parameters.Add("@_ordenarPor", SqlDbType.VarChar).Value = _ordenarPor;
            cnn.Com.Parameters.Add("@_mostrarN", SqlDbType.Int).Value = _mostrarN;

            try { cnn.Com.Parameters.Add("@Id_Tipo_Documento", SqlDbType.Int).Value = parTipoDocumentoIdentificacion.Id_Tipo_Documento; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = parTipoDocumentoIdentificacion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = parTipoDocumentoIdentificacion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = parTipoDocumentoIdentificacion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = parTipoDocumentoIdentificacion.Usuario; } catch { }

            DataTable dt = cnn.Seleccionar();  //Definiendo el depósito temporal de datos 

            List<TipoDocumentoIdentificacion> lstTipoDocumentoIdentificacion = new List<TipoDocumentoIdentificacion>();

            if (dt != null)
            {
                //Listas correspondientes a las llaves foráneas

                foreach (DataRow dr in dt.Rows)
                {
                    TipoDocumentoIdentificacion tipoDocumentoIdentificacion = new TipoDocumentoIdentificacion();

                    try
                    {
                        tipoDocumentoIdentificacion.Id_Tipo_Documento = Convert.ToInt32(dr["Id_Tipo_Documento"]);
                    }
                    catch
                    {
                        tipoDocumentoIdentificacion.Id_Tipo_Documento = null;
                    }
                    try
                    {
                        tipoDocumentoIdentificacion.Descripcion = Convert.ToString(dr["Descripcion"]);
                    }
                    catch
                    {
                        tipoDocumentoIdentificacion.Descripcion = null;
                    }

                    try
                    {
                        tipoDocumentoIdentificacion.Estado = Convert.ToBoolean(dr["Estado"]);
                    }
                    catch
                    {
                        tipoDocumentoIdentificacion.Estado = null;
                    }
                    try
                    {
                        tipoDocumentoIdentificacion.Fecha_Registro = Convert.ToDateTime(dr["Fecha_Registro"]);
                    }
                    catch
                    {
                        tipoDocumentoIdentificacion.Fecha_Registro = null;
                    }
                    try
                    {
                        tipoDocumentoIdentificacion.Usuario = Convert.ToString(dr["Usuario"]);
                    }
                    catch
                    {
                        tipoDocumentoIdentificacion.Usuario = null;
                    }

                    lstTipoDocumentoIdentificacion.Add(tipoDocumentoIdentificacion);
                }

            }
            return lstTipoDocumentoIdentificacion;
        }
    } //FIN DE LA CLASE

}
