using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TestovoeZadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create sqlConnection
            SqlConnection sqlConnection = 
                new SqlConnection(ConfigurationManager.ConnectionStrings["DataBaseConnectionString"].ConnectionString);

            // Open Connection 
            sqlConnection.Open();

            // Create and execute command
            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT Products.ProductName, ISNULL(Categories.CategoryName, 'No Category') AS CategoryName FROM Products LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID", 
                sqlConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            // Show answer
            for (int i = 0; i < dataSet.Tables.Count; i++)
            {
                DataTable thisTable = dataSet.Tables[i];

                for (int j = 0; j < thisTable.Rows.Count; j++)
                {
                    DataRow row = thisTable.Rows[j];
                    Console.WriteLine($"{row[0]} {row[1]}");
                }
            }

            // Lock console
            Console.Read();
        }
    }
}
