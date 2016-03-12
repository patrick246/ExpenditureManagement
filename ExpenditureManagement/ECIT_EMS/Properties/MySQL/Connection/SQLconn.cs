using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ECIT_EMS
{
    class SQLconn
    {

        MySqlConnection conn;
        string connstr;
        public SQLconn(string connStr)
        {
            connstr = connStr;
            conn = new MySqlConnection(connStr);  // ein Connection Objekt erzeugen mit entsprechendem "connection String" ( erstellt im Controller )
        }

        public MySqlConnection getConnector()
        {
            return conn;
        }
        public void Connect()
        {
            try // versuchen, Verbindung aufzubauen
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                // MessageBox.Show("Success!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {                                                   // Fehlermeldungen mit Beschreibung des Problemes ausgeben, falls etwas schief geht
                MessageBox.Show(ex.Message, "MySQL Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unknown Exception",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnect();
            }
        }


        public void Disconnect()
        {
            try // versuchen, Verbindung zu trennen
            {
                conn.Close();
                //MessageBox.Show("Closed connection successful!");
            }
            catch
            {
                MessageBox.Show("Failed Disconnecting. Are you even connected??");
            }
        }

        //public void restoreDatabase(string path)
        //{
        //    if (path == null)
        //    {
        //        return;
        //    }
        //    MessageBox.Show(path);
        //    using (MySqlConnection conn = new MySqlConnection(connstr))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand())
        //        {
        //            using (MySqlBackup mb = new MySqlBackup(cmd))
        //            {
        //                cmd.Connection = conn;
        //                conn.Open();
        //                mb.ImportFromFile(path);
        //                conn.Close();
        //            }
        //        }
        //    }
        //}
        //public void backupDatabase()
        //{
        //    try
        //    {
        //        DateTime Time = DateTime.Now;
        //        int year = Time.Year;
        //        int month = Time.Month;
        //        int day = Time.Day;
        //        int hour = Time.Hour;
        //        int minute = Time.Minute;
        //        int second = Time.Second;
        //        int millisecond = Time.Millisecond;

        //        //Save file to C:\ with the current date as a filename
        //        string path;
        //        path = "E:\\Backup\\MySqlBackup_" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
        //        //StreamWriter file = new StreamWriter(path);



        //        using (MySqlConnection conn = new MySqlConnection(connstr))
        //        {
        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                using (MySqlBackup mb = new MySqlBackup(cmd))
        //                {
        //                    cmd.Connection = conn;
        //                    conn.Open();
        //                    mb.ExportToFile(path);
        //                    conn.Close();
        //                }
        //            }
        //        }
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show(ex + "Error , unable to backup!");
        //    }
        //}

    }
}

