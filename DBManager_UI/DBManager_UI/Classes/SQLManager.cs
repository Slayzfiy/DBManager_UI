using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Console;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;

namespace Datenbanken___Tabelle_erstellen__Daten
{
    class SQLManager
    {

        #region constructor

        public string Database
        {
            get
            {
                return _database;
            }
            set
            {
                _database = value;
            }
        }

        public string ServerName
        {
            get
            {
                return _servername;
            }
            set
            {
                _servername = value;
            }
        }
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public string Security
        {
            get
            {
                return _security;
            }
            set
            {
                _security = value;
            }
        }

        #endregion

        #region variables
        public static SqlConnection con;
        private static SqlCommand com;
        private static SqlDataReader dataReader;
        private static string _database, _servername, _username, _password, _security;
        #endregion

        public SQLManager()
        {
            this.Password = _password;
            this.Database = _database;
            this.Password = _password;
            this.Username = _username;
            this.Security = _security;
        }


        #region Connection
        public static void createConnection(string server, string integratedSecurity, string database)
        {
            try
            {
                SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder()
                {
                    DataSource = "(" + server + ")\\MSSQLLocalDb",
                    IntegratedSecurity = true,
                    InitialCatalog = database,
                };

                con = new SqlConnection(conBuilder.ConnectionString);
                con.Open();

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void createConnection(string server, string integratedSecurity, bool wantMessageBox)
        {
            try
            {
                SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder()
                {
                    DataSource = "(" + server + ")\\MSSQLLocalDb",
                    IntegratedSecurity = true,
                };

                if (wantMessageBox)
                {
                    MessageBox.Show(conBuilder.ConnectionString);
                }
                

                con = new SqlConnection(conBuilder.ConnectionString);
                con.Open();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void createConnection(string server, string database, string integratedSecurity, string username, string password)
        {
            try
            {
                SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder()
                {
                    DataSource = server,
                    InitialCatalog = database,
                    UserID = username,
                    Password = password,                
                };

                if (integratedSecurity.Equals("sspi"))
                {
                    conBuilder.IntegratedSecurity = true;
                }

                con = new SqlConnection(conBuilder.ConnectionString);
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region getDataBaseANDTables
        public List<string> GetDatabaseList(string database)
        {
            SQLManager mng = new SQLManager();
            List<string> list = new List<string>();
            SQLManager.createConnection(mng.ServerName, mng.Security, false);


            SqlCommand cmd = new SqlCommand("SELECT name from " + database + ";", con);
            IDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            return list;          
        }

        public BindingList<string> GetTableList(string database)
        {
            SQLManager.createConnection(SQLManager._servername, SQLManager._security, database);

            BindingList<string> tables = new BindingList<string>();
            DataTable dt = con.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);
            }
            con.Close();           
            return tables;       
        }


        public static BindingSource bindingSource1 = new BindingSource();
        public static SqlDataAdapter dataAdapter = new SqlDataAdapter();
        public static DataTable dt;
        public static void GetData(string source)
        {
            string query = "SELECT * FROM " + source;
            dataAdapter = new SqlDataAdapter(query, con);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            bindingSource1.DataSource = dt;
            }

        #endregion

        #region databaseMethods

        public static void createDatabase(string dbName)
        {
            try
            {
                con.Open();
                com = new SqlCommand("CREATE DATABASE " + dbName + ";", con);
                com.ExecuteNonQuery();
                con.Close();
            
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void dropDatabase()
        {
            try
            {
                System.Data.Entity.Database.Delete(con);
            }
            catch (Exception)
            {
                throw;
            }
        }

       

        #endregion

        #region tableMethods
        public static void createTable(string tableName)
        {
            try
            {
                con.Open();
                com = new SqlCommand("CREATE TABLE " + tableName + " (id int PRIMARY KEY)", con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public static void deleteTable(string tableName)
        {
            try
            {
                con.Open();
                com = new SqlCommand("DROP Table " + tableName + ";", con);
                com.ExecuteNonQuery();
             
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        #endregion

        public static void executeCommand(string query)
        {
            try
            {
                con.Open();
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
            }
            catch (Exception)
            {


            }

            finally
            {
                con.Close();
            }
        }

        public static void newColumn(string columnName, string tableName)
        {
            try
            {
                con.Open();
                com = new SqlCommand("ALTER TABLE " + tableName + " ADD " + columnName + " varchar(50)", con);
                com.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;              
            }


        }
    }
}
