using System;
using System.Linq;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=true";
        string sql = "SELECT Category, ProductName, Price FROM Products ORDER BY Category";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            var groupedData = reader.Cast<System.Data.Common.DbDataRecord>()
                                    .Select(x => new {
                                        Category = x["Category"].ToString(),
                                        ProductName = x["ProductName"].ToString(),
                                        Price = Convert.ToDecimal(x["Price"])
                                    })
                                    .GroupBy(x => x.Category);

            foreach (var group in groupedData)
            {
                Console.WriteLine("Category: {0}", group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("\tProduct: {0} ({1},00 UAH)", item.ProductName, item.Price);
                }
                Console.WriteLine();
            }
        }
    }
}
