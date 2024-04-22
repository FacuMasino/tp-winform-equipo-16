using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// Clase que posee los métodos necesarios para acceder
    /// a la información de la base de datos
    /// </summary>
    public class DataAccess
    {
        // Los atributos que son de solo lectura solo pueden ser inicializados o
        // asignados desde un constructor para evitar ser sobreescritos en un método
        private readonly SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;

        /// <value>La propiedad <c>Reader</c> devuelve el resultado luego de ejecutar
        /// una consulta de lectura</value>
        public SqlDataReader Reader
        {
            get { return _reader; }
        }

        /// <summary>
        /// <c>DataAccess</c> Crea una conexión usando la cadena de conexión por defecto
        /// </summary>
        public DataAccess()
        {
            // connectionString por defecto
            _connection = new SqlConnection(
                "\"server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true\""
            );
            _command = new SqlCommand();
        }

        /// <summary>
        /// <c>DataAccess</c> Crea una conexión usando la cadena pasada por parámetro
        /// </summary>
        /// <param name="connectionString">Cadena de conexión</param>
        public DataAccess(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _command = new SqlCommand();
        }

        /// <summary>
        /// <c>SetQuery</c> establece el comando de consulta
        /// </summary>
        /// <param name="query">Consulta SQL</param>
        public void SetQuery(string query)
        {
            _command.CommandType = System.Data.CommandType.Text;
            _command.CommandText = query;
        }

        /// <summary>
        /// <c>ExecuteRead</c> ejecuta un comando y setea al reader con el resultado de la consulta
        /// </summary>
        public void ExecuteRead()
        {
            _command.Connection = _connection;
            try
            {
                _connection.Open();
                _reader = _command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// <c>CloseConnection</c> Cierra la conexión y el lector en caso de haberse utilizado
        /// </summary>
        public void CloseConnection()
        {
            // El operador ? comprueba si el atributo es NULL, de ser así
            // se ejecuta el método Close()
            _reader?.Close();
            _connection.Close();
        }
    }
}
