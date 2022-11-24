using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NettButikk
{
    class WebShopDataBase
    {
        public void CreateDbAndTable()
        {
            using SqliteConnection connection = new("Data Source = exampleSqlite.db");
            try
            {
                connection.Open();
            }

            catch(Exception)
            {

            }

            SqliteCommand command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE product (
                    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    productName TEXT NOT NULL,
                    productPrice TEXT NOT NULL
                );
            ";
            try
            {
                command.ExecuteNonQuery();
            }

            catch (Exception)
            {

            }
            
        }

        public int InsertProduct(string productName, string productPrice)
        {
            int generatedId = -1;

            using SqliteConnection connection = new("Data Source = exampleSqlite.db");

            try
            {
                connection.Open();
            }

            catch (Exception)
            {

            }
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = @"
				INSERT INTO product (productName, productPrice)
				VALUES ($productName, $productPrice);
			";
            command.Parameters.AddWithValue("$productName", productName);
            command.Parameters.AddWithValue("$productPrice", productPrice);

            try
            {
                command.ExecuteNonQuery();
            }

            catch (Exception)
            {

            }
            command.CommandText = @"
				SELECT seq
				FROM sqlite_sequence
				WHERE name = 'product';
			";

            try
            {
                using SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    generatedId = reader.GetInt32(0);
                }
            }

            catch (Exception)
            {
                
            }
            

            return generatedId;
        }

        public Product ReadProduct(int id)
        {
            string productName = "";
            string productPrice = "";

            using SqliteConnection connection = new("Data Source = exampleSqlite.db");
            try
            {
                connection.Open();
            }

            catch (Exception e)
            {
                Console.Write(e.ToString(), "Error");
            }
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = @"
				SELECT productName, productPrice FROM product WHERE id = $id
			";

            
            
            command.Parameters.AddWithValue("$id", id);
            using SqliteDataReader reader = command.ExecuteReader();

            

            if (reader.Read())
             
            {

                Product product = new Product(productName, productPrice);
                productName = reader.GetString(0);
                productPrice = reader.GetString(1);
                product.ProductPrice = productPrice;
                product.ProductName = productName;


                return product;

                
            }

            return null;

 
        }

        public void DropDb()
        {
            File.Delete("exampleSqlite.db");
        }

    }
}
