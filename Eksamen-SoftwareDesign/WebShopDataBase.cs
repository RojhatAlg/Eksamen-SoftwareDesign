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
                    productName TEXT NOT NULL
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

        public int InsertProduct(string productName)
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
				INSERT INTO product (productName)
				VALUES ($productName);
			";
            command.Parameters.AddWithValue("$productName", productName);
            
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
				WHERE productName = 'product';
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

        public string ReadProductName(int id)
        {
            string productName = "";

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
				SELECT productName
				FROM product
				WHERE id = $id
			";
            try
            {
                command.Parameters.AddWithValue("$id", id);
                using SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    productName = reader.GetString(0);
                }
            }

            catch(Exception)
            {

            }
            

            return productName;
        }

        public void DropDb()
        {
            File.Delete("exampleSqlite.db");
        }

    }
}
