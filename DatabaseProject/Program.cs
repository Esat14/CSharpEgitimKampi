using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("C# veritabanlı listeleme");
            //Console.WriteLine("");

            //string tableNumber;
            //string selectedTable = "";

            //Console.WriteLine("**************");
            //Console.WriteLine("1 - Kategori");
            //Console.WriteLine("2 - Siparişler");
            //Console.WriteLine("3 - Ürünler");

            //Console.Write("Getirmek istediğiniz tablo numarasını giriniz: ");
            //tableNumber = Console.ReadLine();
            //Console.WriteLine("**************");


            //switch (tableNumber)
            //{
            //    case "1":
            //        selectedTable = "CategoryTable";
            //        break;
            //    case "2":
            //        selectedTable = "OrderTable";
            //        break;
            //    case "3":
            //        selectedTable = "ProductsTable";
            //        break;
            //    default:
            //        Console.WriteLine("Geçersiz tablo numarası.");
            //        return;
            //}

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HN6GBKF;Initial Catalog=C#EgitimKampi;Integrated Security=True"))
                {
                    connection.Open();
                    Console.WriteLine("Veritabanına başarıyla bağlandı.");

                    SqlCommand komut1 = new SqlCommand("SELECT Count(distinct (ProductPrice)) FROM ProductsTable", connection);
                    SqlDataReader reader = komut1.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString());
                    }

                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
