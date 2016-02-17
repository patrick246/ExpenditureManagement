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

namespace ECIT_EMS
{
    public class Controller
    {
        FrmView frmSurface;
        //Calculator theCalculator;
        SQLconn theSQLconnector;
        QueryHandler theQueryHandler;
        MySqlConnection conn;
       

        private ArrayList outcome;

        public void pushData()
        {
            

        }

        public Controller(FrmView FrmSurface)
        {
            frmSurface = FrmSurface;
            //theCalculator = new Calculator();
            theSQLconnector = new SQLconn(CreateConnStr("localhost", "root", "", "ems_db", "Convert Zero Datetime = True")); // server, benutzer, passwort und Datenbankbezeichnung eingeben
            conn = theSQLconnector.setConnector();
            theQueryHandler = new QueryHandler(ref conn, theSQLconnector, this);
        }


        private string CreateConnStr(string server, string user, string password, string database, string ConvertZERO)
        {
            string connStr = "server=" + server + ";database=" + database + ";uid=" + user + ";password=" + password + ";" + ConvertZERO + ";";    // erstellt den, für die Verbindung notwendige,
            return connStr;                                                                                                     // Connection String
        }

        public void TakeQuery(string query, string assignment) // Nimmt Datenbankfrage entgegen, erstellt das Command dazu und speichert das Array von Ergebnissen
        {                                                                   // Sodass man sie von dort aus abrufen kann ( Line 60 )
            theQueryHandler.create_Command(query, assignment);

            outcome = theQueryHandler.sendQuery();
            if (outcome == null) return;
            /* theSQLconnector.getValues();*/
        }


        public void TakeQueryMoreColumn(string query, string assignment, int repeat) // Nimmt Abfragen entgegen, die sich über mehrere Spalten auswirkt
        {
            theQueryHandler.create_Command(query, assignment);

            outcome = theQueryHandler.sendQuery(repeat);
            
            // if(outcome[0] != null) MessageBox.Show(Convert.ToString(outcome[0]));
            /* theSQLconnector.getValues();*/
        }

        public void TakeInsert(string insert, string assignment) // Nimmt Insert und Update Anweisungen entgegen und führt sie aus
        {
            theQueryHandler.create_Command(insert, "insertData");
            theQueryHandler.sendInsert();
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

        //public int getArrayLength() // falls nötig, länge des Arrays abfragen
        //{
        //    return outcome.Length;
        //}

        public string getLastInsert()
        {
            return Convert.ToString(theQueryHandler.LastInsert());
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
