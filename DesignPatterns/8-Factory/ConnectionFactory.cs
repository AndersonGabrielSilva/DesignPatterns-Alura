using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns._8_Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection();

            connection.ConnectionString = "User if=root;Password=123456;Server=localhost;DataBase=meubanco";
            connection.Open();

            return connection;
        }
    }
}
