using System;

namespace _10_DatabaseCrud
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Crud  : Create - Read - Update - Delete 

            Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            Console.WriteLine();

            Console.WriteLine("----------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = EMIR;initial Catalog = EgitimKampiDb;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Categories (CategoryName) values (@p1)",
            //    connection);

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = EMIR; initial Catalog = EgitimKampiDb;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Products (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Başarıyla Eklendi");
            #endregion

            #region Ürün Listeleme İşi

            //SqlConnection connection = new SqlConnection("Data Source = EMIR;initial Catalog = EgitimKampiDb;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From Products", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID: ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = EMIR;initial Catalog = EgitimKampiDb;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from Products Where ProductID = @productID", connection);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme işlemi tamamlandı");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID: ");
            //int productID = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = EMIR;initial Catalog = EgitimKampiDb;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update Products set ProductName = @productName,ProductPrice=@productPrice where ProductID = @productID", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Güncelleme İşlemi Başarılı");

            #endregion

            Console.Read();
        }
    }
}
