using System.Data.SqlClient;

namespace SistemaBancario.Data
{
    public class DataContext
    {
        private static string connectionString = "Data Source=DESKTOP-59O6R81\\SQLEXPRESS;Initial Catalog=SistemaBancario;Integrated Security=True;";

        public static void conction()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
