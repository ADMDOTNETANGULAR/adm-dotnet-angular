using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
namespace HandsOnAdo
{
    //Dataset is a collection of DataTables

    internal class Demo2
    {
        static void Main()
        {
            SqlConnection sqlConnection=new SqlConnection("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=ADMDOTNET;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Employee", sqlConnection);
            DataSet dataSet = new DataSet();// Create a new DataSet
            // Fill the DataSet with data from the database
            sqlDataAdapter.Fill(dataSet, "Employee");// Fill the DataSet with data from the Employee table
            //Read 4th row from the Employee table
            if (dataSet.Tables["Employee"].Rows.Count > 3) // Check if there are at least 4 rows
            {
                DataRow row = dataSet.Tables["Employee"].Rows[3]; // Get the 4th row (index 3)
                Console.WriteLine($"Id: {row["EmployeeId"]}, Name: {row["Name"]}, Salary: {row["Salary"]}");
            }
            else
            {
                Console.WriteLine("There are less than 4 rows in the Employee table.");
            }
            //Read all rows from the Employee table
            foreach (DataRow row in dataSet.Tables["Employee"].Rows)
            {
                Console.WriteLine($"Id: {row["EmployeeId"]}, Name: {row["Name"]}, Salary: {row["Salary"]}");
            }
            //holding Product data to same DataSet object
            sqlDataAdapter = new SqlDataAdapter("Select * from Product", sqlConnection);
            sqlDataAdapter.Fill(dataSet, "Product"); // Fill the DataSet with data from the Product table
           sqlConnection.Close(); // Close the connection after filling the DataSet
            Console.WriteLine("\nProduct Table Data:");
            //Read all rows from the Product table
            foreach (DataRow row in dataSet.Tables["Product"].Rows)
            {
                Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Price: {row["Price"]}, Stock: {row["Stock"]}");
            }

        }
    }
}
