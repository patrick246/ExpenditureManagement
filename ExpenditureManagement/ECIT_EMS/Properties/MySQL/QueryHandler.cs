using System;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ECIT_EMS
{ 
    class QueryHandler
    {
        MySqlConnection conn;
        SQLconn theConnector;
        MySqlCommand aCommand;
        Controller theController;
        private ArrayList value = new ArrayList();

        public QueryHandler(ref MySqlConnection connection, SQLconn MySql_connector, Controller controller)
        {
            conn = connection;
            theConnector = MySql_connector;
            theController = controller;
        }





        public void create_Command(string query, string queryName)
        {
            value.Clear();
            aCommand = new MySqlCommand(query, conn);
            /*string result = sendQuery(getString_Int);*/
            //theController.getOutcome(result);
        }

        public ArrayList sendQuery()
        {
            theConnector.Connect();
            //             string state = conn.State.ToString();
            //             MessageBox.Show(state);
            try
            {
                MySqlDataReader reader = null;

                reader = aCommand.ExecuteReader();

                while (reader.Read())
                {
                    value.Add(reader.GetString(0));
                }
                theConnector.Disconnect();

                return value;
            }
            catch
            {
                return null;
            }

        }

        public ArrayList sendQuery(int repeat)
        {
            //int i = 0;
            theConnector.Connect();             // Verbindungsaufbau 
            //             string state = conn.State.ToString();
            //             MessageBox.Show(state);
            try
            {
                MySqlDataReader reader = null;

                reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    Object[] values = new Object[reader.FieldCount+1];
                    value.Capacity = reader.FieldCount +1;
                    // value.Add(reader[i]);
                    reader.GetValues(values);
                    for (int f = 0; f <= values.Length; f++)
                    {
                        value.Add(values[f]);
                        // MessageBox.Show(values[f].ToString());
                        // MessageBox.Show(value[f].ToString());
                    }

                    //for (int i = 0; i < reader.FieldCount; i++) //next Value
                    //{
                    // holt den nächsten Wert und Speichert ihn in ein Array
                }
                theConnector.Disconnect();
                return value; // ArrayList wird zurückgegeben
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
                return value;
            }
        }

        public long LastInsert()
        {
            long imageId;
            return imageId = aCommand.LastInsertedId;
        }
        public void sendInsert()
        {
            theConnector.Connect();

            try
            {
                aCommand.ExecuteNonQuery();
                //MessageBox.Show("Inserting Done!");
                aCommand.Connection.Close();
                theConnector.Disconnect();
            }
            catch
            {
                theConnector.Disconnect();
                MessageBox.Show("Failed Inserting, check your Query, Command or Sourcecode.  Disconnected...");
            }

        }




    }
}
