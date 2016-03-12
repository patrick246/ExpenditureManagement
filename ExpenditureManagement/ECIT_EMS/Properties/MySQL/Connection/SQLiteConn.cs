using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace ECIT_EMS
{
    class SQLiteConn
    {
        SQLiteConnection conn;
        string connstr;
        public SQLiteConn(string connStr, string filename)
        {
            connstr = connStr;
            if (!File.Exists(filename))
            {
                SQLiteConnection.CreateFile(filename);
                //string sql = "CREATE TABLE 'acquisition' ( 'A_ID' int(11) NOT NULL,  'A_product' int(11) NOT NULL,  'A_shop' int(11) NOT NULL,  'A_date' date NOT NULL,  'A_loc' int(11) NOT NULL)";

            }
            //ERSTELLUNG VON CONN
            conn = new SQLiteConnection(connStr);
        }

        public SQLiteConnection getConnector()
        {
            return conn;
        }

        public void Connect()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                else
                {
                    conn.Close();
                    System.Threading.Thread.Sleep(200);
                    conn.Open();
                }

                //MessageBox.Show(conn.State.ToString());
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message, "Error!");
                Disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "  " + e.InnerException, "Uknown Exception!");
                Disconnect();
            }
        }

        public void Disconnect()
        {
            try
            {
                conn.Close();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show(e.Message, "Error!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Uknown Exception while disconnecting");
            }
        }

    }
}


