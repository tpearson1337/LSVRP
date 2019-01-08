using System;
using GTANetworkAPI;
using MyCustomGamemode.character;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using MyCustomGamemode.jobs;

namespace MyCustomGamemode.database
{
    class DBConnection :Script
    {

        private String connection_string = null;

        //Constructor
        public DBConnection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            MySqlBaseConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();

            conn_string.Server = "localhost";
            conn_string.Database = "lsvrpdatabase";
            conn_string.UserID = "new_user";
            conn_string.Password = "with_password";
            connection_string = conn_string.ToString();
            NAPI.Util.ConsoleOutput(conn_string.ToString());
        }

        //Insert statement
        public void Insert(string Squery)
        {
            string query = Squery;

            //open connection
            using (var connection = new MySqlConnection(connection_string))
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();
            }
        }

        //Update statement
        public void Update(string Squery)
        {
            string query = Squery;

            using (var connection = new MySqlConnection(connection_string))
            {
                //create mysql command

                // Cleaner
                MySqlCommand cmd = new MySqlCommand(query,connection);
                /*//Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;*/

                //Execute query
                cmd.ExecuteNonQuery();
            }
        }
        //Delete statement
        public void Delete(string Squery)
        {
            string query = Squery;

            using (var connection = new MySqlConnection(connection_string))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
        }
        public bool chkpswd( string playerName,string password)
        {
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open();

                MySqlCommand query = new MySqlCommand($"SELECT COUNT(*) FROM `players` WHERE `name` = '{playerName}' AND `password` = sha1('{password}')", connection);
                int exists = int.Parse(query.ExecuteScalar().ToString());
                if (exists > 0)
                {
                    if (exists == 1)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {

                    }
                }
                else
                {

                }
                connection.Close();
                return false;
            }
        }

        public bool playerExists(string playerName)
        {
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT COUNT(*) FROM `players` WHERE `name` = '{playerName}'", connection);
                int exists = int.Parse(cmd.ExecuteScalar().ToString());
                if (exists > 0)
                {
                    if (exists == 1)
                    {
                     //
                        connection.Close();
                        return true;
                    }
                    else
                    {
                    //
                    }
                }
                else
                {

                }
                connection.Close();
                return false;
            }
        }

        public void createUser(string playerName,string password)
        {
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO `players` (`name`,`password`) VALUES ('{playerName}',sha1('{password}'))", connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        
        public Player pullUser(Client client, string username)
        {
            Player p = new Player();
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `players` WHERE `name` = '{username}'", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    p.id = Convert.ToInt32(dataReader["id"]);
                    p.pName = dataReader["name"].ToString();
                    p.pAdmin = Convert.ToInt32(dataReader["adminlvl"]);
                    p.pMoney = Convert.ToInt32(dataReader["pmoney"]);
                    p.pMats = Convert.ToInt32(dataReader["pmaterials"]);
                    NAPI.Util.ConsoleOutput($"Data pulled");
                    
                }
                dataReader.Close();
                connection.Close();
            }
            return p;
        }


        public List<MatRun> getMaterialRuns()
        {
            Player p = new Player();
            using (var connection = new MySqlConnection(connection_string))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `material_runs`", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                List<MatRun> list = new List<MatRun>();

                while (dataReader.Read())
                {
                    MatRun m = new MatRun();

                    m.id = Convert.ToInt32(dataReader["matrun_id"]);
                    m.name = dataReader["matrun_name"].ToString();
                    m.setPayment(Convert.ToInt32(dataReader["matrun_payment"]));
                    m.matamount = Convert.ToInt32(dataReader["matrun_material_amount"]);
                    // Pickup Location
                    m.pposX = Convert.ToDouble(dataReader["matrun_p_pos_x"]);
                    m.pposY = Convert.ToDouble(dataReader["matrun_p_pos_y"]);
                    m.pposZ = Convert.ToDouble(dataReader["matrun_p_pos_z"]);
                    // Delivery Location
                    m.dposX = Convert.ToDouble(dataReader["matrun_d_pos_x"]);
                    m.dposY = Convert.ToDouble(dataReader["matrun_d_pos_y"]);
                    m.dposZ = Convert.ToDouble(dataReader["matrun_d_pos_z"]);

                    list.Add(m);
                }
                dataReader.Close();
                connection.Close();

                return list;
            }
        }

    }
}
