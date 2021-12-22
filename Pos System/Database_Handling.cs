using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Pos_System
{
    class Database_Handling
    {
        public List<string> get_PINs(string SQL,string entered_PIN) 
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\POS dataset.accdb";//gets the provider and source of the connection
            List<string> results = new List<string>();//will store the list of PINS found
            using (OleDbConnection connection = new OleDbConnection(connectionString))//creates connection string
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(SQL, connection);//creates command string
                OleDbParameter idparam = new OleDbParameter();
                idparam.ParameterName = "@PIN";//adds a paramater with the PIN entered this is to secure the code against SQL injection
                idparam.Value = entered_PIN;
                command.Parameters.Add(idparam);
                try//catches errors
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["PIN"].ToString());
                        }
                    }
                }
                catch (Exception)
                {
                }
                connection.Close();
                return results;
            }
        }
        public List<Button> get_food_buttons(string SQL,Button pressed) 
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\POS dataset.accdb";//gets the provider and source of the connection
            List<Button> result = new List<Button>();
            using (OleDbConnection connection = new OleDbConnection(connectionString))//creates connection string
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(SQL, connection);//creates command string
                OleDbParameter idparam = new OleDbParameter();
                idparam.ParameterName = "@type";//adds a paramater with the PIN entered this is to secure the code against SQL injection
                idparam.Value = pressed.Text.Substring(0, pressed.Text.Length - 1);
                command.Parameters.Add(idparam);
                try//catches errors
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        int loop = 0;
                        while (reader.Read())
                        {
                            Button b = new Button();//makes a new clickable food button to be used on the form
                            b.Text = reader["Food Name"].ToString();
                            b.FlatStyle = FlatStyle.Flat;
                            b.BackColor = pressed.BackColor;
                            POS_system pressed_event_get = new POS_system(string.Empty);
                            b.Click += pressed_event_get.FoodButton_click;
                            b.Name = pressed.Text.Substring(0, pressed.Text.Length - 1) + loop + "_btn";
                            b.Size = new Size(136, 46);
                            result.Add(b);
                            loop++;
                        }
                    }
                }
                catch (Exception)
                {
                }
                connection.Close();
                return result;
            }
        }
        public List<string> get_emplyee_details(string SQL,string PIN) 
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\POS dataset.accdb";//gets the provider and source of the connection
            List<string> results = new List<string>();//stores the results
            using (OleDbConnection connection = new OleDbConnection(connectionString))//creates connection string
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(SQL, connection);//creates command string
                OleDbParameter idparam = new OleDbParameter();
                idparam.ParameterName = "@PIN";//adds a paramater with the PIN entered this is to secure the code against SQL injection
                idparam.Value = PIN;
                command.Parameters.Add(idparam);
                try//catches errors
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["Employee Position"].ToString());
                            results.Add(reader["Employee Name"].ToString());
                        }
                    }
                }
                catch (Exception)
                {
                }
                connection.Close();
                return results;
            }
        }
        public List<string> get_job_name(string SQL, string PIN)
        {
            //uses nested functions to fetch all job and employee data
            List<string> result = get_emplyee_details("SELECT [Employee Name], [Employee Position] FROM Employees WHERE [PIN]=@PIN", PIN);//stores data collected by previous function and this function
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\POS dataset.accdb";//gets the provider and source of the connection
            using (OleDbConnection connection = new OleDbConnection(connectionString))//creates connection string
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(SQL, connection);//creates command string
                OleDbParameter idparam = new OleDbParameter();
                idparam.ParameterName = "@jobid";//adds a paramater with the PIN entered this is to secure the code against SQL injection
                idparam.Value = result[0];
                command.Parameters.Add(idparam);
                try//catches errors
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(reader["Job Name"].ToString());
                        }
                    }
                }
                catch (Exception)
                {
                }
                connection.Close();
                return result;
            }
        }
        public List<string> fetch_info(string SQL,string food_name) //fetches the food description and price for a food item
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\POS dataset.accdb";//gets the provider and source of the connection
            List<string> results = new List<string>();//will store the results of the database fetching
            using (OleDbConnection connection = new OleDbConnection(connectionString))//creates connection string
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(SQL, connection);//creates command string
                OleDbParameter idparam = new OleDbParameter();
                idparam.ParameterName = "@food";//adds a paramater with the PIN entered this is to secure the code against SQL injection
                idparam.Value = food_name;
                command.Parameters.Add(idparam);
                try//catches errors
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(reader["Description"].ToString());
                            results.Add("Cost: " + reader["Cost"].ToString());//adds data to results list
                        }
                    }
                }
                catch (Exception)
                {
                }
                connection.Close();
                return results;//returns results
            }
        }
        public int recieve_data_for_sending(string SQL)
        {
            //fetches previous order ID so it can be +1'd
            int Result = 0;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\POS dataset.accdb";//gets the provider and source of the connection
            using (OleDbConnection connection = new OleDbConnection(connectionString))//creates connection string
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(SQL, connection);//creates command string
                try//catches errors
                {
                    // Open connecton  
                    connection.Open();
                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Result= Convert.ToInt32(reader["Order ID"].ToString());
                        }
                    }
                }
                catch (Exception)
                {
                }
                connection.Close();
                return Result;
            }
        }
        public void Send_data(string SQL, List<List<string>> data)
        {
            int previous_order=recieve_data_for_sending("SELECT TOP 1 * FROM Orders ORDER BY [Order ID] DESC");
            foreach (List<string> item in data)
            {
                //loops through and inserts each ordered item's required info into the database
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\POS dataset.accdb";//gets the provider and source of the connection
                using (OleDbConnection cnn = new OleDbConnection(connectionString))//initialises connection
                {
                    cnn.Open();//opens connection
                    using (OleDbCommand cmd = new OleDbCommand(SQL, cnn))//initialises query
                    {
                        cmd.Parameters.AddWithValue("@first", previous_order + 1);//adds parameters to string
                        string foodid = "";
                        //fetches food ID of each item for insertion into database
                        string strSQL2 = "SELECT [Food ID] FROM Item WHERE [Food Name]='" + item[0] + "'";//the SQL code to be executed
                        using (OleDbConnection connection = new OleDbConnection(connectionString))//creates connection string
                        {
                            // Create a command and set its connection  
                            OleDbCommand command = new OleDbCommand(strSQL2, connection);//creates command string
                            try//catches errors
                            {
                                // Open connecton  
                                connection.Open();
                                // Execute command  
                                using (OleDbDataReader reader = command.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        foodid = reader["Food ID"].ToString();
                                    }
                                }
                            }
                            catch (Exception)
                            {
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
    }
}