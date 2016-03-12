using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;


namespace SqliteTest
{
    class Program
    {
        static SQLiteConnection sqlite_connection;
        static SQLiteCommand sqlite_command;
        static DataTable dt;
        static void Main(string[] args)
        {
            if (!File.Exists("converted.db"))
            {
                SQLiteConnection.CreateFile("converted.db");
            }
            dt = new DataTable();
            sqlite_connection = new SQLiteConnection("Data Source=converted.db;Version=3;");
            string query = "SELECT * FROM acquisition";
            sqlite_command = new SQLiteCommand(query, sqlite_connection);


            //doSomething(query);
            //sqlite_connection = new SQLiteConnection("Data Source=converted.db;Version=3;");
            //query = "SELECT * FROM bankaccount";
            
            sqlite_connection = new SQLiteConnection("Data Source=converted.db;Version=3;");
            query = "SELECT * FROM product";
            doSomething(query);
            //sqlite_connection = new SQLiteConnection("Data Source=converted.db;Version=3;");
            //query = "SELECT * FROM locations";
            //doSomething(query);
            //sqlite_connection = new SQLiteConnection("Data Source=converted.db;Version=3;");
            //query = "SELECT * FROM income";
            //doSomething(query);
            //sqlite_connection = new SQLiteConnection("Data Source=converted.db;Version=3;");
            //query = "SELECT * FROM locations";
            //doSomething(query);
            //sqlite_connection = new SQLiteConnection("Data Source=converted.db;Version=3;");
            //query = "SELECT * FROM product";
            //doSomething(query);
            //sqlite_connection = new SQLiteConnection("Data Source=converted.db;Version=3;");
            Console.ReadKey();
        }



        static void doSomething(string query)
        {

            sqlite_command = new SQLiteCommand(query, sqlite_connection);

            sqlite_connection.Open();



            dt.Clear();

            try {
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_command))
                {
                    da.Fill(dt);
                }
            }
            catch(SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            sqlite_connection.Close();
            sqlite_connection.Dispose();

            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}:", column.ColumnName);
            }

            Console.WriteLine("\t");

            foreach (DataRow row in currentRows)
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", row[column]);

                Console.WriteLine("\t");
            }
        }
    }

}

