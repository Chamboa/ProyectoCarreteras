using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using ENT;

namespace DAL
{
    public class DalTipoAdquisicion
    {
        Conexion cnn;

        public DalTipoAdquisicion()
        {
            cnn = new Conexion();
        }

        ///METODO INSERTAR DE ACUERDO A LA LLAVE DE LA TABLA

        public int insertar(TipoAdquisicion tipoAdquisicion)
        {
            cnn.Com.CommandText = "pa_tbl_tipo_adquisicion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

            try { cnn.Com.Parameters.Add("@Id_Tipo_Adquisicion", SqlDbType.Int).Value = tipoAdquisicion.Id_Tipo_Adquisicion; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoAdquisicion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = tipoAdquisicion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = tipoAdquisicion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = tipoAdquisicion.Usuario; } catch { }

            return cnn.Ejecutar(true);
        }

        ///METODO INSERTAR UNA LISTA DE ENTIDADES

        public int insertar(List<TipoAdquisicion> lstTipoAdquisicion)
        {
            int i = 0;
            cnn.Com.CommandText = "pa_tbl_tipo_adquisicion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (TipoAdquisicion tipoAdquisicion in lstTipoAdquisicion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "insertar";

                try { cnn.Com.Parameters.Add("@Id_Tipo_Adquisicion", SqlDbType.Int).Value = tipoAdquisicion.Id_Tipo_Adquisicion; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoAdquisicion.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = tipoAdquisicion.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = tipoAdquisicion.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = tipoAdquisicion.Usuario; } catch { }

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

        public int actualizar(TipoAdquisicion tipoAdquisicion)
        {
            cnn.Com.CommandText = "pa_tbl_tipo_adquisicion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

            try { cnn.Com.Parameters.Add("@Id_Tipo_Adquisicion", SqlDbType.Int).Value = tipoAdquisicion.Id_Tipo_Adquisicion; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoAdquisicion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = tipoAdquisicion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = tipoAdquisicion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = tipoAdquisicion.Usuario; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ACTUALIZAR UNA LISTA DE ENTIDADES

        public int actualizar(List<TipoAdquisicion> lstTipoAdquisicion)
        {
            int i = 0;
            cnn.Com.CommandText = "pa_tbl_tipo_adquisicion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (TipoAdquisicion tipoAdquisicion in lstTipoAdquisicion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "actualizar";

                try { cnn.Com.Parameters.Add("@Id_Tipo_Adquisicion", SqlDbType.Int).Value = tipoAdquisicion.Id_Tipo_Adquisicion; } catch { }
                try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = tipoAdquisicion.Descripcion; } catch { }
                try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = tipoAdquisicion.Estado; } catch { }
                try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = tipoAdquisicion.Fecha_Registro; } catch { }
                try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = tipoAdquisicion.Usuario; } catch { }

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

        public int eliminar(TipoAdquisicion tipoAdquisicion)
        {
            cnn.Com.CommandText = "pa_tbl_tipo_adquisicion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

            try { cnn.Com.Parameters.Add("@Id_Tipo_Adquisicion", SqlDbType.Int).Value = tipoAdquisicion.Id_Tipo_Adquisicion; } catch { }

            return cnn.Ejecutar(false);
        }

        ///METODO ELIMINAR UNA LISTA DE ENTIDADES

        public int eliminar(List<TipoAdquisicion> lstTipoAdquisicion)
        {
            int i = 0;
            cnn.Com.CommandText = "pa_tbl_tipo_adquisicion";
            cnn.Com.Connection.Open();
            cnn.Com.Transaction = cnn.Com.Connection.BeginTransaction();

            foreach (TipoAdquisicion tipoAdquisicion in lstTipoAdquisicion)
            {
                cnn.Com.Parameters.Clear();
                //Acción a Ejecutar en el Procedimiento Almacenado
                cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "eliminar";

                try { cnn.Com.Parameters.Add("@Id_Tipo_Adquisicion", SqlDbType.Int).Value = tipoAdquisicion.Id_Tipo_Adquisicion; } catch { }

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

        public List<TipoAdquisicion> buscar(TipoAdquisicion parTipoAdquisicion, string _ordenarPor = null, int? _mostrarN = null)
        {
            cnn.Com.CommandText = "pa_tbl_tipo_adquisicion";
            cnn.Com.Parameters.Clear();

            //Acción a Ejecutar en el Procedimiento Almacenado
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "buscar";
            cnn.Com.Parameters.Add("@_ordenarPor", SqlDbType.VarChar).Value = _ordenarPor;
            cnn.Com.Parameters.Add("@_mostrarN", SqlDbType.Int).Value = _mostrarN;

            try { cnn.Com.Parameters.Add("@Id_Tipo_Adquisicion", SqlDbType.Int).Value = parTipoAdquisicion.Id_Tipo_Adquisicion; } catch { }
            try { cnn.Com.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = parTipoAdquisicion.Descripcion; } catch { }
            try { cnn.Com.Parameters.Add("@Estado", SqlDbType.Bit).Value = parTipoAdquisicion.Estado; } catch { }
            try { cnn.Com.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = parTipoAdquisicion.Fecha_Registro; } catch { }
            try { cnn.Com.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = parTipoAdquisicion.Usuario; } catch { }

            DataTable dt = cnn.Seleccionar();  //Definiendo el depósito temporal de datos 

            List<TipoAdquisicion> lstTipoAdquisicion = new List<TipoAdquisicion>();

            if (dt != null)
            {
                //Listas correspondientes a las llaves foráneas

                foreach (DataRow dr in dt.Rows)
                {
                    TipoAdquisicion tipoAdquisicion = new TipoAdquisicion();

                    try
                    {
                        tipoAdquisicion.Id_Tipo_Adquisicion = Convert.ToInt32(dr["Id_Tipo_Adquisicion"]);
                    }
                    catch
                    {
                        tipoAdquisicion.Id_Tipo_Adquisicion = null;
                    }
                    try
                    {
                        tipoAdquisicion.Descripcion = Convert.ToString(dr["Descripcion"]);
                    }
                    catch
                    {
                        tipoAdquisicion.Descripcion = null;
                    }
                    try
                    {
                        tipoAdquisicion.Estado = Convert.ToBoolean(dr["Estado"]);
                    }
                    catch
                    {
                        tipoAdquisicion.Estado = null;
                    }
                    try
                    {
                        tipoAdquisicion.Fecha_Registro = Convert.ToDateTime(dr["Fecha_Registro"]);
                    }
                    catch
                    {
                        tipoAdquisicion.Fecha_Registro = null;
                    }
                    try
                    {
                        tipoAdquisicion.Usuario = Convert.ToString(dr["Usuario"]);
                    }
                    catch
                    {
                        tipoAdquisicion.Usuario = null;
                    }

                    lstTipoAdquisicion.Add(tipoAdquisicion);
                }

            }
            return lstTipoAdquisicion;
        }

        public List<TipoAdquisicion> ObtenerTiposAdquisicion()
        {
            // Configurar el comando para el procedimiento almacenado
            cnn.Com.CommandText = "pa_tbl_tipo_adquisicion";
            cnn.Com.Parameters.Clear();
            cnn.Com.Parameters.Add("@_accion", SqlDbType.VarChar).Value = "mostrar_todos";

            // Ejecutar el procedimiento y obtener los datos en un DataTable
            DataTable dt = cnn.Seleccionar();

            // Verificar si el DataTable es null o no contiene filas
            if (dt == null || dt.Rows.Count == 0)
            {
                throw new Exception("No se encontraron datos en el procedimiento almacenado.");
            }

            List<TipoAdquisicion> listaAdquisiciones = new List<TipoAdquisicion>();

            // Iterar por las filas del DataTable y mapear a la lista de objetos
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    TipoAdquisicion item = new TipoAdquisicion
                    {
                        Descripcion = row["Descripcion"].ToString(),
                        Estado = Convert.ToBoolean(row["Estado"]),
                        Fecha_Registro = Convert.ToDateTime(row["Fecha_Registro"]),
                        Usuario = row["Usuario"].ToString()
                    };

                    listaAdquisiciones.Add(item);
                }
                catch (Exception e)
                {
                    // Manejar errores si ocurre algún problema al procesar una fila
                    throw new Exception("Error al procesar los datos de tipo de adquisición.", e);
                }
            }

            return listaAdquisiciones;
        }

    } //FIN DE LA CLASE

} //FIN DE
