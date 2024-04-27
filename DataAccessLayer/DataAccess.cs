using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Clase que posee los métodos necesarios para acceder a la base de datos.
    /// </summary>
    public class DataAccess
    {
        private readonly SqlConnection _connection; // Los atributos que son de solo lectura solo pueden ser inicializados o asignados desde un constructor para evitar ser sobreescritos en un método.
        private SqlCommand _command;
        private SqlDataReader _reader;
        private string _connectionString;

        /// <value>
        /// La propiedad <c>Reader</c> devuelve el resultado luego de una consulta de lectura.
        /// </value>
        public SqlDataReader Reader
        {
            get { return _reader; }
        }

        /// <summary>
        /// <c>DataAccess</c> Crea una conexión usando una de las cadenas de conexión de App.config.
        /// </summary>
        public DataAccess()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["facu"].ToString(); // Modificar en esta línea el argumento de ConnectionString["ana ó facu ó maxi"] para elegir la base de datos.
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
        }

        /// <summary>
        /// <c>SetQuery</c> establece el comando de consulta.
        /// </summary>
        /// <param name="query">Consulta SQL.</param>
        public void SetQuery(string query)
        {
            _command.CommandType = System.Data.CommandType.Text;
            _command.CommandText = query;
        }

        /// <summary>
        /// Define un parámetro que se puede escribir dentro de un string anteponiendo el operador @.
        /// </summary>
        /// <param name="key">Nombre del parámetro.</param>
        /// <param name="value">Valor que se va a reemplazar por el parámetro al ejecutar una consulta.</param>
        public void SetParameter(string key, object value)
        {
            _command.Parameters.AddWithValue(key, value);
        }

        /// <summary>
        /// <c>ExecuteRead</c> ejecuta un comando de lectura y setea al reader con el resultado de la consulta.
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
            finally
            {
                _command.Parameters.Clear();
            }
        }

        /// <summary>
        /// <c>ExecuteRead</c> ejecuta un comando que devuelve un unico valor numérico.
        /// </summary>
        public Int32 ExecuteScalar()
        {
            Int32 result;
            _command.Connection = _connection;

            try
            {
                _connection.Open();
                result = (Int32)_command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _command.Parameters.Clear();
            }
            return result;
        }

        /// <summary>
        /// <c>ExecuteAction</c> ejecuta un comando de escritura.
        /// </summary>
        public void ExecuteAction()
        {
            _command.Connection = _connection;

            try
            {
                _connection.Open();
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _command.Parameters.Clear();
            }
        }

        /// <summary>
        /// <c>CloseConnection</c> Cierra la conexión y el lector en caso de haberse utilizado.
        /// </summary>
        public void CloseConnection()
        {
            _reader?.Close(); // El operador ? comprueba que el atributo no sea NULL, y de ser así ejecuta el método Close().
            _connection.Close();
        }
    }
}
