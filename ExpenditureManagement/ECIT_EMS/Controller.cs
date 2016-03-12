using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace ECIT_EMS
{
    public class Controller
    {
        FrmView frmSurface;
        //Calculator theCalculator;
        SQLconn theSQLconnector;
        SQLiteConn theSQLiteconnector;
        QueryHandler theQueryHandler;
        SQLiteQueryHandler theSQLiteQueryHandler;


        private ArrayList outcome;

        public Controller(FrmView FrmSurface, string Db)
        {
            frmSurface = FrmSurface;
            if (Db == "sqlite")
            {
                theSQLiteconnector = new SQLiteConn("Data Source=converted.db;", "converted.db");
                //theSQLiteconnector = new SQLiteConn("Data Source=ems.sqlite; Version=3;", "ems.");
                SQLiteConnection Conn = theSQLiteconnector.getConnector();
                theSQLiteQueryHandler = new SQLiteQueryHandler(ref Conn, theSQLiteconnector, this);
            }
            else
            {
                //theCalculator = new Calculator();
                theSQLconnector = new SQLconn(CreateConnStr("localhost", "root", "", "ems_db", "Convert Zero Datetime = True")); // server, benutzer, passwort und Datenbankbezeichnung eingeben
                MySqlConnection conn = theSQLconnector.getConnector();
                theQueryHandler = new QueryHandler(ref conn, theSQLconnector, this);
            }
        }


        private string CreateConnStr(string server, string user, string password, string database, string ConvertZERO)
        {
            string connStr = "server=" + server + ";database=" + database + ";uid=" + user + ";password=" + password + ";" + ConvertZERO + ";";
            return connStr;
        }

        public void TakeQuery(string query, string assignment) // MySQL
        {
            theQueryHandler.create_Command(query, assignment);

            outcome = theQueryHandler.sendQuery();
            if (outcome == null) return;
        }

        public void TakeQuery(string query) // SQLITE
        {
            theSQLiteQueryHandler.create_Command(query, "sqlite_");

            outcome = theSQLiteQueryHandler.sendQuery();
            if (outcome == null) return;
        }


        public void TakeQueryMoreColumn(string query, string assignment, int repeat)
        {
            theQueryHandler.create_Command(query, assignment);

            outcome = theQueryHandler.sendQuery(repeat);

        }

        public void TakeInsert(string insert, string assignment) // Nimmt Insert und Update Anweisungen entgegen und führt sie aus
        {
            theQueryHandler.create_Command(insert, "insertData");
            theQueryHandler.sendInsert();
        }

        public void TakeInsert(string insert) // Nimmt Insert und Update Anweisungen entgegen und führt sie aus
        {
            theSQLiteQueryHandler.create_Command(insert, "insertData");
            theSQLiteQueryHandler.sendInsert();
        }

        public string getOutcome(int x)         // gibt ein Ergebnis als String zurück, an " x " stelle im Array
        {
            try
            {
                if (outcome == null)
                {
                    throw new ArgumentNullException();
                    //return null;
                }
                else
                {
                    return Convert.ToString(outcome[x]);
                }
            }
            catch
            {
                MessageBox.Show("Kein Eintrag!");
                return null;
            }
        }

        public ArrayList getAll()
        {
            return outcome;
        }

        public string getFullOutcome(int pz)
        {
            int z = pz;
            string result = "";

            for (int i = 0; i < z; i++)
            {
                if (outcome[i] != null || Convert.ToString(outcome[i]) != "")
                {
                    result += outcome[i] + " ";
                }
                else
                {
                    if (result != null)
                    {
                        return result;
                    }
                    else
                    {
                        throw new ArgumentNullException();
                    }
                }
            }
            return result;
        }

        public string getLastInsert()
        {
            return Convert.ToString(theQueryHandler.LastInsert());
        }
        public string getSQLiteLastInsert()
        {
            return Convert.ToString(theSQLiteQueryHandler.LastInsert());
        }

        //public void doBackup()
        //{
        //    theSQLconnector.backupDatabase();
        //}

        //public void doRestore(string path)
        //{
        //    if (dropDatabase())
        //        theSQLconnector.restoreDatabase(path);
        //    else
        //    {
        //        MessageBox.Show("Vorgang abgebrochen.", "Abbruch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //}

        public DataTable fetch(string query, string assignment)
        {
            theQueryHandler.create_Command(query, assignment);
            return theQueryHandler.copy();
        }
        public DataTable fetch(string query)
        {
            theSQLiteQueryHandler.create_Command(query, "");
            return theSQLiteQueryHandler.copy();
        }

        public bool dropDatabase()
        {
            if (MessageBox.Show("Sie sind dabei die Datenbank zu löschen und anschließend das ausgewählte Backup einzuspielen, sollte es zu Fehlern kommen ist der bisherige Status für immer verloren!", "Sind sie sicher?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    TakeInsert("DROP TABLE administrator, arrival, costumers, employees, locations, products, sale", "DROP DB");

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
