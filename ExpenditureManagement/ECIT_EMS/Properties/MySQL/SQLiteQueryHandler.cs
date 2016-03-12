using System;
using System.Data.SQLite;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace ECIT_EMS
{
    class SQLiteQueryHandler
    {
        SQLiteConnection sqlite_conn;
        SQLiteConn theConnector;
        SQLiteCommand aCommand;
        Controller theController;
        private ArrayList value = new ArrayList();

        long Last_ID;

        DataTable dt = new DataTable();

        public SQLiteQueryHandler(ref SQLiteConnection connection, SQLiteConn SQLite_connector, Controller controller)
        {
            sqlite_conn = connection;
            theConnector = SQLite_connector;
            theController = controller;
        }


        public void create_Command(string query, string queryName)
        {
            value.Clear();
            aCommand = new SQLiteCommand(query, sqlite_conn);
            //aCommand.CommandText
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
                SQLiteDataReader reader = null;

                reader = aCommand.ExecuteReader();

                while (reader.Read())
                {
                    //MessageBox.Show(reader.GetFieldType(0).ToString());
                    switch (reader.GetFieldType(0).ToString())
                    {
                        case "System.Int64":
                            value.Add(reader.GetInt64(0));
                            break;
                        case "System.String":
                            value.Add(reader.GetString(0));
                            break;
                        case "System.Double":
                            value.Add(reader.GetDouble(0));
                            break;
                        case "System.Int32":
                            value.Add(reader.GetInt32(0));
                            break;
                    }

                }
                theConnector.Disconnect();

                return value;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            catch
            {
                return null;
            }

        }

        public DataTable copy()
        {
            dt.Clear();
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(aCommand))
            {
                da.Fill(dt);
            }
            return dt;
        }

        public ArrayList sendQuery(int repeat)
        {
            //int i = 0;
            theConnector.Connect();             // Verbindungsaufbau 
            //             string state = conn.State.ToString();
            //             MessageBox.Show(state);
            try
            {
                SQLiteDataReader reader = null;

                reader = aCommand.ExecuteReader();
                while (reader.Read())
                {
                    Object[] values = new Object[reader.FieldCount + 1];
                    //value.Capacity = reader.FieldCount + 2;
                    // value.Add(reader[i]);
                    reader.GetValues(values);
                    for (int f = 0; f < values.Length; f++)
                    {
                        value.Add(values[f]);
                        //    // MessageBox.Show(values[f].ToString());
                        //    // MessageBox.Show(value[f].ToString());
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
            return Last_ID;
        }
        public void sendInsert()
        {
            try
            {
                theConnector.Connect();
                //MessageBox.Show(sqlite_conn.State.ToString());
                //theConnector.Connect();
                aCommand.ExecuteNonQuery();
                //MessageBox.Show("Inserting Done!");
                // aCommand.Connection.Close();
                Last_ID = sqlite_conn.LastInsertRowId;
                //MessageBox.Show(Last_ID.ToString());
                theConnector.Disconnect();

                //MessageBox.Show(sqlite_conn.State.ToString());
            }
            catch (SQLiteException e)
            {
                theConnector.Disconnect();
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed Inserting, check your Query, Command or Sourcecode.  Disconnected...");
            }

        }
    }
}
