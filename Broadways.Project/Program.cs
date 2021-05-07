using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadways.Project
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Broadway_43;"
            + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString1 =
                "select * from Student";
            string queryString2 = "select* from StudentParent";
            string queryString3 = "select* from StudentNew";



            // Specify the parameter value.
            //int paramValue = 5;

            //Create and open the connection in a using block.This
            //ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection1 =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString1, connection1);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                //Open the connection in a try/catch block.
                //Create and execute the DataReader, writing the result
                // set to the console window.
                connection1.Open();

                try
                {

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        var readers = new string[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };

                        Console.WriteLine("\t{0}\t\t\t{1}\t\t\t{2}\t\t\t{3}\n\n\n\n",
                            readers);
                        
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection1.Close();
                }
              //  Console.ReadLine();
            }

            using (SqlConnection connection2 =
              new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command2 = new SqlCommand(queryString2, connection2);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                connection2.Open();

                try
                {
                  
                    SqlDataReader reader = command2.ExecuteReader();
                    while (reader.Read())
                    {

                        var readers = new string[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };

                        Console.WriteLine("\t{0}\t{1}\t\t{2}\t\t\t{3}\n\n\n\n",
                            readers);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection2.Close();
                }
               // Console.ReadLine();
            }


            using (SqlConnection connection3 =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command3 = new SqlCommand(queryString3, connection3);
                //command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                connection3.Open();

                try
                {

                    SqlDataReader reader = command3.ExecuteReader();
                    while (reader.Read())
                    {

                        var readers = new string[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };

                        Console.WriteLine("\t\t{0}\t\t{1}\t\t{2}\n\n",
                            readers);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection3.Close();
                }
                Console.ReadLine();
            }



        }

    }
    
}
