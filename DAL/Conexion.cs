using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    /// <summary>
    /// Clase de conexion a la base de datos
    /// </summary>
    public class Conexion
    {
        #region "ATRIBUTOS DE LA CLASE"
        public static bool Produccion { get { return true; } }
        private string strCnn //= "Data Source=DESKTOP-LBFDGJM\\DEVSERVER;Initial Catalog=db_practicaMop;User ID=OscarRauda; PASSWORD=Rauda; Persist Security Info=True;";
        = "Data Source = LAPTOPJONY\\SQLEXPRESS; Initial Catalog = mopractica; User ID = Gamboa; PASSWORD=josue.900; Persist Security Info = True;";
        //= "server=172.17.1.52;database=db_maestra;user id=aristides.sanchez;password=sanchezh;Persist Security Info=True;";
        private SqlConnection cnn;  //Objeto para definir la conexi?n a la base de datos.
        private SqlCommand com;     //Objeto para ejecutar comandos en la base de datos.
        private SqlTransaction tra; //Objeto para ejecutar transacciones en la base de datos.
        public List<SqlParameter> Pk { get; set; }

        #endregion

        #region "PROPIEDADES"
        /// <summary>
        /// Objeto de conexion
        /// </summary>
        public SqlConnection Cnn
        {
            get { return cnn; }
            set { cnn = value; }
        }

        /// <summary>
        /// Objeto para ejecutar instrucciones en la base de datos.
        /// </summary>
        public SqlCommand Com
        {
            get { return com; }
            set { com = value; }
        }

        /// <summary>
        /// Objeto para ejecutar transacciones en la base de datos.
        /// </summary>
        public SqlTransaction Tra
        {
            get { return tra; }
            set { tra = value; }
        }
        #endregion  

        #region "METODOS CONSTRUCTORES"
        public Conexion(string strCnn)
        {
            this.strCnn = strCnn;
            iniciarObjetos();
        }

        //public Conexion()
        //{
        //    //this.strCnn = ConfigurationManager.AppSettings["db"].ToString();
        //    iniciarObjetos();
        //}

        public Conexion(int bd = 1)
        {
            string strCnn = "";
            switch (bd)
            {
                case 1:
                    strCnn = "Data Source = LAPTOPJONY\\SQLEXPRESS; Initial Catalog = mopractica; User ID = Gamboa;  PASSWORD=josue.900; Persist Security Info = True;";

                    //strCnn = "Data Source=DESKTOP-LBFDGJM\\DEVSERVER;Initial Catalog=db_practicaMop;User ID=OscarRauda; PASSWORD=Rauda; Persist Security Info=True;";
                    /* "server=172.17.1.62\\moptvdu;database=db_DiezCallesPorDia;user id=usr_moptvdu;password=usr.moptvdu;Persist Security Info=True;";*/
                    //strCnn = "server=172.17.1.62\\moptvdu;database=db_Embargos;user id=usr_embargos;password=usr.embargos;Persist Security Info=True;";
                    break;
                    //case 2:
                    //    strCnn = "server=172.17.1.62\\moptvdu;database=db_sistema_uaci;user id=sa;password=.281607;Persist Security Info=True;";
                    //    break;

            }

            this.strCnn = strCnn;
            iniciarObjetos();
        }

        private void iniciarObjetos()
        {
            cnn = new SqlConnection(this.strCnn);
            com = new SqlCommand();
            com.Connection = cnn;
            com.CommandType = CommandType.StoredProcedure;
            Pk = new List<SqlParameter>();
        }

        #endregion

        #region "METODOS DE LA CLASE"
        /// <summary>
        /// M?todo para extraer datos de la base de datos.
        /// </summary>
        /// <returns>Retornar el conjunto de datos en un DataTable.</returns>
        public DataTable Seleccionar()
        {
            DataTable dt = new DataTable(); //Definir el de dep?sito de datos a retornar.
            try
            {
                //Objeto de comandos a ejecutar.
                com.CommandType = CommandType.StoredProcedure;
                com.Connection.Open();
                SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr); //Llenar el dep?sito de datos con la instrucci?n a ejecutar.
                             // Auditar.RegistrarActividad(com);
                             //Auditar.RegistrarActividadBD(com);
            }
            catch (SqlException ex)
            {
                //throw new Exception(ex.Message + cnn.ConnectionString.ToString());
                dt = null;
                //Auditar.RegistrarError(ex, com);
            }
            finally
            {
                if (com.Connection != null)
                    com.Connection.Close();
            }
            return dt;
        }


        /// <summary>
        /// M?todo para extraer datos de la base de datos.
        /// </summary>
        /// <returns>Retornar el conjunto de datos en un DataTable.</returns>
        public DataTable Seleccionar(string query)
        {
            DataTable dt = new DataTable(); //Definir el de dep?sito de datos a retornar.
            try
            {
                //Objeto de comandos a ejecutar.
                com.CommandText = query;
                com.CommandType = CommandType.Text;
                com.Connection.Open();
                SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr); //Llenar el dep?sito de datos con la instrucci?n a ejecutar.
               // Auditar.RegistrarActividad(com);
            }
            catch (SqlException ex)
            {
                dt = null;
               // Auditar.RegistrarError(ex, com);
            }
            finally
            {
                if (com.Connection != null)
                    com.Connection.Close();
            }
            return dt;
        }


        /// <summary>
        /// M?todo para ejecutar instrucciones SQL en la base de datos.
        /// </summary>
        /// <param name="auto">Inidica si si va a insertar en una tabla con autonum?rico.</param>
        /// <returns>Retorna el n?meor de registros afectados al ejecutar el comando.</returns>
        public int Ejecutar(bool auto)
        {
            int resultado;

            try
            {
                com.Connection.Open();
                //this.Tra = com.Connection.BeginTransaction();
                if (auto)
                    resultado = Convert.ToInt32(com.ExecuteScalar());
                else

                    resultado = com.ExecuteNonQuery();
                //Auditar.RegistrarActividad(com);
            }
            catch (SqlException ex)
            {
                resultado = ex.ErrorCode;
                //Auditar.RegistrarError(ex, com);
            }
            finally
            {
                if (com.Connection != null) com.Connection.Close();
            }
            return resultado;
        }

        /// <summary>
        /// M?todo para ejecutar instrucciones SQL en la base de datos.
        /// </summary>
        /// <param name="auto">Inidica si si va a insertar en una tabla con autonum?rico.</param>
        /// <returns>Retorna el n?meor de registros afectados al ejecutar el comando.</returns>
        public int EjecutarTransaccion()
        {
            try
            {
                //Auditar.RegistrarActividad(com);
                return com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //Auditar.RegistrarError(ex, com);
                return ex.ErrorCode;
            }
        }
        #endregion
    }
}