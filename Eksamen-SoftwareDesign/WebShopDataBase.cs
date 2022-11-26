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

            catch (Exception)
            {

            }

            SqliteCommand command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE product (
                    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    productName TEXT NOT NULL,
                    productPrice TEXT NOT NULL,
                    productDesc TEXT NOT NULL,
                    productHeight TEXT NOT NULL,
                    productLenght TEXT NOT NULL,
                    productWidth TEXT NOT NULL
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

        public int InsertProduct(string productName, string productPrice, string productDesc, string productHeight, string productLenght, string productWidth)
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
				INSERT INTO product (productName, productPrice, productDesc, productHeight, productLenght, productWidth)
				VALUES ($productName, $productPrice, $productDesc, $productHeight, $productLenght, $productWidth);
			";
            command.Parameters.AddWithValue("$productName", productName);
            command.Parameters.AddWithValue("$productPrice", productPrice);
            command.Parameters.AddWithValue("$productDesc", productDesc);
            command.Parameters.AddWithValue("$productHeight", productHeight);
            command.Parameters.AddWithValue("$productLenght", productLenght);
            command.Parameters.AddWithValue("$productWidth", productWidth);

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
            string productDesc = "";
            string productHeight = "";
            string productLenght = "";
            string productWidth = "";

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
				SELECT productName, productPrice, productDesc, productHeight, productLenght, productWidth FROM product WHERE id = $id
			";



            command.Parameters.AddWithValue("$id", id);
            using SqliteDataReader reader = command.ExecuteReader();



            if (reader.Read())

            {

                Product product = new Product(productName, productPrice, productDesc, productHeight, productLenght, productWidth);
                productName = reader.GetString(0);
                productPrice = reader.GetString(1);
                productDesc = reader.GetString(2);
                productHeight = reader.GetString(3);
                productLenght = reader.GetString(4);
                productWidth = reader.GetString(5);
                product.ProductPrice = productPrice;
                product.ProductName = productName;
                product.ProductDesc = productDesc;
                product.ProductHeight = productHeight;
                product.ProductLenght = productLenght;
                product.ProductWidth = productWidth;


                return product;


            }

            return null;


        }

        public void DropDb()
        {
            File.Delete("exampleSqlite.db");
        }

    }

    internal class CustomerDataBase
    {

        public void CreateDbAndTable()
        {
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
                CREATE TABLE customer (
                    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    customerName TEXT NOT NULL,
                    customerWallet INT NOT NULL
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

        public int InsertCustomer(string customerName, int customerWallet)
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
				INSERT INTO customer (customerName, customerWallet)
				VALUES ($customerName, $customerWallet);
			";
            command.Parameters.AddWithValue("$customerName", customerName);
            command.Parameters.AddWithValue("$customerWallet", customerWallet);
            

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
				WHERE name = 'customer';
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

        public Customer ReadCustomer(int id)
        {
            string customerName = "";
            int customerWallet = 0;
            

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
				SELECT customerName, customerWallet FROM customer WHERE id = $id
			";



            command.Parameters.AddWithValue("$id", id);
            using SqliteDataReader reader = command.ExecuteReader();



            if (reader.Read())

            {

                Customer customer = new Customer(customerName, customerWallet);
                customerName = reader.GetString(0);
                customerWallet = reader.GetInt32(1);
                customer.CustomerName = customerName;
                customer.CustomerWallet = customerWallet;
                


                return customer;


            }

            return null;


        }

    }
}
