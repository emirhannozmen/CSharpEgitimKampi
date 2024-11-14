using System.Data.SqlClient;
using System.Data;
using System;

namespace _09_DatabaseProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("*** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ***");
            Console.WriteLine();
            Console.WriteLine();

            string tablenumber;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tablenumber = Console.ReadLine();
            Console.WriteLine("--------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source = EMIR;initial Catalog = EgitimKampiDb;integrated security = true");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From Categories", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + "\t");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
