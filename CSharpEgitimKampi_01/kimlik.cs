using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_01
{
    internal class kimlik
    {
        using System;
using System.Data.SqlClient;

namespace SqlBaglantiOrnegi
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Bağlantı dizesi (Connection String)
                string connectionString = "Server=DESKTOP-HN6GBKF; Database=C#EgitimKampi;";

                // SqlConnection ile veritabanı bağlantısını açıyoruz.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Bağlantıyı aç
                        connection.Open();
                        Console.WriteLine("Veritabanına bağlandı.");

                        // SQL sorgusunu belirtiyoruz
                        string query = "SELECT * FROM TabloAdi";

                        // SqlCommand ile komutu yürüt
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // SqlDataReader ile verileri okuyalım
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Veritabanı kolonlarını okuyalım, örneğin "KolonAdi"
                                    Console.WriteLine(reader["KolonAdi"].ToString());
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
        }
    }

}
}
