using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
namespace Pos_System
{
    static class DatabaseHandling
    {
        private static string ConnectionString
        {
            get
            {
                return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\POS dataset.accdb";
            }
        }

        public static List<string> GetPINs(string SQL, string entered_PIN)
        {
            List<string> results = [];//will store the list of PINS found
            using OleDbConnection connection = new(ConnectionString);//creates connection string
                                                                                     // Create a command and set its connection  
            OleDbCommand command = new(SQL, connection);//creates command string
            OleDbParameter idparam = new()
            {
                ParameterName = "@PIN",//adds a paramater with the PIN entered this is to secure the code against SQL injection
                Value = entered_PIN
            };
            command.Parameters.Add(idparam);
            try//catches errors
            {
                // Open connecton  
                connection.Open();
                // Execute command  
                using OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(reader["PIN"].ToString());
                }
            }
            catch (Exception)
            {
                connection.Close();
                return results;
            }
            connection.Close();
            return results;
        }
        public static List<Button> GetFoodButtons(string SQL, Button pressed)
        {
            List<Button> result = [];
            using OleDbConnection connection = new(ConnectionString);//creates connection string
                                                                                     // Create a command and set its connection  
            OleDbCommand command = new(SQL, connection);//creates command string
            OleDbParameter idparam = new()
            {
                ParameterName = "@type",//adds a paramater with the PIN entered this is to secure the code against SQL injection
                Value = pressed.Text[..^1]
            };
            command.Parameters.Add(idparam);
            try//catches errors
            {
                // Open connecton  
                connection.Open();
                // Execute command  
                using OleDbDataReader reader = command.ExecuteReader();
                int loop = 0;
                while (reader.Read())
                {
                    Button b = new()
                    {
                        Text = reader["Food Name"].ToString(),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = pressed.BackColor
                    };//makes a new clickable food button to be used on the form
                    POS_system pressed_event_get = new(string.Empty);
                    b.Click += pressed_event_get.FoodButton_click;
                    b.Name = pressed.Text[..^1] + loop + "_btn";
                    b.Size = new Size(136, 46);
                    result.Add(b);
                    loop++;
                }
            }
            catch (Exception)
            {
                connection.Close();
                return result;
            }
            connection.Close();
            return result;
        }
        public static List<string> GetEmplyeeDetails(string SQL, string PIN)
        {
            List<string> results = [];//stores the results
            using OleDbConnection connection = new(ConnectionString);//creates connection string
                                                                                     // Create a command and set its connection  
            OleDbCommand command = new(SQL, connection);//creates command string
            OleDbParameter idparam = new()
            {
                ParameterName = "@PIN",//adds a paramater with the PIN entered this is to secure the code against SQL injection
                Value = PIN
            };
            command.Parameters.Add(idparam);
            try//catches errors
            {
                // Open connecton  
                connection.Open();
                // Execute command  
                using OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(reader["Employee Position"].ToString());
                    results.Add(reader["Employee Name"].ToString());
                }
            }
            catch (Exception)
            {
                connection.Close();
                return results;
            }
            connection.Close();
            return results;
        }
        public static List<string> GetJobName(string SQL, string PIN)
        {
            //uses nested functions to fetch all job and employee data
            List<string> result = GetEmplyeeDetails("SELECT [Employee Name], [Employee Position] FROM Employees WHERE [PIN]=@PIN", PIN);//stores data collected by previous function and this function
            using OleDbConnection connection = new(ConnectionString);//creates connection string
                                                                                     // Create a command and set its connection  
            OleDbCommand command = new(SQL, connection);//creates command string
            OleDbParameter idparam = new()
            {
                ParameterName = "@jobid",//adds a paramater with the PIN entered this is to secure the code against SQL injection
                Value = result[0]
            };
            command.Parameters.Add(idparam);
            try//catches errors
            {
                // Open connecton  
                connection.Open();
                // Execute command  
                using OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(reader["Job Name"].ToString());
                }
            }
            catch (Exception)
            {
                connection.Close();
                return result;
            }
            connection.Close();
            return result;
        }
        public static List<string> FetchInfo(string SQL, string food_name) //fetches the food description and price for a food item
        {
            List<string> results = [];//will store the results of the database fetching
            using OleDbConnection connection = new(ConnectionString);//creates connection string
                                                                                     // Create a command and set its connection  
            OleDbCommand command = new(SQL, connection);//creates command string
            OleDbParameter idparam = new()
            {
                ParameterName = "@food",//adds a paramater with the PIN entered this is to secure the code against SQL injection
                Value = food_name
            };
            command.Parameters.Add(idparam);
            try//catches errors
            {
                // Open connecton  
                connection.Open();
                // Execute command  
                using OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(reader["Description"].ToString());
                    results.Add(reader["Cost"].ToString());//adds data to results list
                }
            }
            catch (Exception)
            {
                connection.Close();
                return [];
            }
            connection.Close();
            return results;//returns results
        }
        public static int RecieveDataForSending(string SQL)
        {
            //fetches previous order ID so it can be +1'd
            int Result = 0;
            using OleDbConnection connection = new(ConnectionString);//creates connection string
                                                                                     // Create a command and set its connection  
            OleDbCommand command = new(SQL, connection);//creates command string
            try//catches errors
            {
                // Open connecton  
                connection.Open();
                // Execute command  
                using OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Result = Convert.ToInt32(reader["Order ID"].ToString());
                }
            }
            catch (Exception)
            {
                connection.Close();
                return Result;
            }
            connection.Close();
            return Result;
        }
        public static void SendData(string SQL, List<List<string>> data)
        {
            int previous_order = RecieveDataForSending("SELECT TOP 1 * FROM Orders ORDER BY [Order ID] DESC");
            foreach (List<string> item in data)
            {
                //loops through and inserts each ordered item's required info into the database
                using OleDbConnection cnn = new(ConnectionString);//initialises connection
                cnn.Open();//opens connection
                using OleDbCommand cmd = new(SQL, cnn);//initialises query
                cmd.Parameters.AddWithValue("@first", previous_order + 1);//adds parameters to string
                string foodid = "";
                //fetches food ID of each item for insertion into database
                string strSQL2 = "SELECT [Food ID] FROM Item WHERE [Food Name]='" + item[0] + "'";//the SQL code to be executed
                using (OleDbConnection connection = new(ConnectionString))//creates connection string
                {
                    // Create a command and set its connection  
                    OleDbCommand command = new(strSQL2, connection);//creates command string
                    try//catches errors
                    {
                        // Open connecton  
                        connection.Open();
                        // Execute command  
                        using OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            foodid = reader["Food ID"].ToString();
                        }
                    }
                    catch (Exception)
                    {
                        connection.Close();
                        return;
                    }
                    connection.Close();
                }
                cmd.Parameters.AddWithValue("@second", Convert.ToInt32(foodid));
                cmd.Parameters.AddWithValue("@last", Convert.ToInt32(item[2]));
                cmd.ExecuteNonQuery();//Executes string
                cnn.Close();//closes connection
            }
        }
    }
}