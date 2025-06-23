using Microsoft.Data.SqlClient;
namespace HandsOnAdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fetching data from SQL Server using ADO.NET
            //Fetching Employee details from SQL Server Database
            string connectionString= "Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=ADMDOTNET;Integrated Security=True;Trust Server Certificate=True";
           
            try
            {
                //initiate connection to the database
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();//open connection to the database
                //create command to execute SQL query
                SqlCommand command=new SqlCommand("Select * from Employee where Designation='Programmer'", connection);
                //execute command and fetch data
                SqlDataReader reader=command.ExecuteReader();
                //SqlDataReader is used to read data in a forward-only stream
                if(reader.HasRows) //check if there are any rows returned
                {
                   // reader.Read(); //read the first row
                   while(reader.Read()) //read all rows
                    {
                        //Accessing data using column names
                        Console.WriteLine($"Id:{reader["EmployeeId"]} Name:{reader["Name"]} Salary:{reader[4]}");
                    }
                    //Close the reader
                    reader.Close();
                    //Close the connection
                    connection.Close();

                }
                
                else
                {
                    Console.WriteLine("No rows found.");
                }
                

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error in connection: " + ex.Message);
                return;
            }
        }
    }
}
