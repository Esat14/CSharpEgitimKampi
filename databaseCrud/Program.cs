using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName;
            decimal productPrice;
            bool productStatus;

            Console.Write("eklemek istediğin ürün ismi gir: ");
            productName = Console.ReadLine();
            Console.Write("eklemek istediğin ürün fiyatı gir: ");
            productPrice = Convert.ToDecimal(Console.ReadLine());
            Console.Write("eklemek istediğin ürün durumu gir: ");
            productStatus = Convert.ToBoolean(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-HN6GBKF;Initial Catalog=C#EgitimKampi;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("insert into ProductsTable (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", productStatus);
            command.ExecuteNonQuery();

            connection.Close();

            Console.Write("eklendi");
            Console.Read();
        }
    }
}
