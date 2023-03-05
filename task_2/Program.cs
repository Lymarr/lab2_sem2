using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using task_2;

namespace SortingEmployees
{


    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=master;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM employees";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Name = reader["Name"].ToString();
                employee.Salary = Convert.ToDecimal(reader["Salary"]);
                employees.Add(employee);
            }
            reader.Close();

            employees = employees.OrderBy(e => e.Salary).ToList();

            foreach (Employee employee in employees)
            {
                Console.WriteLine("Name: {0}, Salary: {1}",  employee.Name, employee.Salary);
            }

            connection.Close();
        }
    }
}