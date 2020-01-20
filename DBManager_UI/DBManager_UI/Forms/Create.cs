using Datenbanken___Tabelle_erstellen__Daten;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Microsoft.ApplicationBlocks.Data;
using MySql.Data.MySqlClient;

namespace DBManager_UI
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private void Main_Load(object sender, EventArgs e)
        {
            SQLManager mng = new SQLManager();
            foreach (var dbName in mng.GetDatabaseList("master.sys.databases")) // gets all Database names from master.sys
            {
                lB_databases.Items.Add(dbName);
            }
        }
        // HAVE FUN! The datatype-changer is in the last region 

        #region Variables
        private static System.Windows.Forms.Timer aTimer;
        private BindingList<string> listOfTables; // private list, which provides that I can change the datasource anywhere in the class
        private BindingSource bs;
        private DataTable dt;
        private SqlDataAdapter dataadapter;
        private int rowIndex = 0;
        private static string currentTable, currentColumn;
        #endregion

        #region unnecessary
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit(); // closes all forms if the create form has closed
        }
        private void Main_Shown(object sender, EventArgs e)
        {
        }
        public void InfoEmpfang(EreignisArgumente e)
        {
            MessageBox.Show("Connecting");
            this.Show();
        }
        #endregion
     
        #region loadTableContent
        private void lB_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = lB_tables.SelectedItem.ToString();
            string query = "SELECT * FROM " + selectedTable;

            dataadapter = new SqlDataAdapter(query, SQLManager.con);
            dt = new DataTable();
            try
            {             
                dataadapter.Fill(dt); // fill datatable with the current selected table values             
            }
            catch (Exception)
            {                
            }

            finally
            {
                SQLManager.con.Close();            
            }
            dg_data.DataSource = dt; 
                  
        }
        #endregion

        #region addColumns&Rows
        private void btn_addrow_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows.Add(); // adds a row to the datatable
            }
            catch (Exception)
            {

                throw;
            }
       
        }

        private string columnName;
        private void btn_addcolumn_Click(object sender, EventArgs e)
        {
            columnName = Microsoft.VisualBasic.Interaction.InputBox("Please enter your column name:", "Column Name");
            if (columnName.Equals(""))
            {
                MessageBox.Show("No Column name!");
            }
            else
            {              
                try
                {
                    SQLManager.con.Close();
                    SQLManager.newColumn(columnName, lB_tables.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            columnName = null;
        }
        #endregion

        #region ifDatabasesChanged
        private void lB_databases_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SQLManager mng = new SQLManager();
                string currentDatabase = lB_databases.SelectedItem.ToString(); // get the current selected database in the listbox 'databases'

                listOfTables = mng.GetTableList(currentDatabase);

                bs = new BindingSource();
                bs.DataSource = listOfTables;  // sets a new bindingsource with the list of the tables
                lB_tables.DataSource = bs;
            }
            catch (Exception)
            {
                // no selected Index
            }
        }
        #endregion
     
        #region addNewDatabase
        private void metroButton2_Click(object sender, EventArgs e)
        {
            // A VB-method to create a messagebox with user input for the DB-Name
            string insertedDBName = Microsoft.VisualBasic.Interaction.InputBox("Please enter your database name:", "Database Name");
            if (string.IsNullOrEmpty(insertedDBName))
            {
                MessageBox.Show("No Column name!");
            }
            else 
            {
                SQLManager.createDatabase(insertedDBName);
                lB_databases.Items.Add(insertedDBName);
            }        
        }
        #endregion

        #region dropDatabase
        private void btn_dropDB_Click(object sender, EventArgs e)
        {
            SQLManager.dropDatabase();
            lB_databases.Items.Remove(lB_databases.SelectedItem);
        }
        #endregion

        #region addTable
        private void btn_addTable_Click(object sender, EventArgs e)
        {
            if (lB_databases.SelectedItem != null)
            {
                string insertedTableName = Microsoft.VisualBasic.Interaction.InputBox("Please enter your table name:", "Table Name");
                if (string.IsNullOrEmpty(insertedTableName))
                {
                    MessageBox.Show("No Table name!");
                }
                else
                {
                    SQLManager.createTable(insertedTableName);
                    bs.Add(insertedTableName);                                       
                }
            }
            else
            {
                MessageBox.Show("First you need to select a Database!");
            }               
        }
        #endregion

        #region deleteTable
        private void btn_deleteTable_Click(object sender, EventArgs e)
        {
            SQLManager.deleteTable(lB_tables.SelectedItem.ToString());
            bs.Remove(lB_databases.SelectedItem.ToString());
            lB_databases.Items.Remove(lB_tables.SelectedItem);
        }


        #endregion

        #region Toolstrip
        
        private void dg_data_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {       
            // opens a contextmenustrip if the user right-clicks on a header
            switch (e.Button)
            {
                case MouseButtons.Right:                 
                    contextMenuStrip1.Show(Cursor.Position);                 
                    break;              
            }
            
            currentTable = lB_tables.SelectedItem.ToString();
            //get current column
            currentColumn = dg_data.Columns[e.ColumnIndex].Name;
        }


        private void deleteColumnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {             
                List<string> columnsToDelete = new List<string>();
                columnsToDelete.Add(dg_data.Columns.ToString());
              
                foreach (var ColName in columnsToDelete)
                {
                   

                    if (dt.Columns.Contains(ColName))
                    {
                        dg_data.Columns.Remove(ColName);
                        MessageBox.Show("Column will be deleted after a restart!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }          
        }

        #endregion

        #region changeDatatype
        // two methods because I need a user input with the length of char
        private void AlterTable(string currentTable, string currentColumn, string clickedDatatype)
        {                   
            try
            {
                SQLManager.executeCommand("ALTER TABLE " + currentTable + " ALTER COLUMN " + currentColumn + " " + clickedDatatype + ";");
                //MessageBox.Show("ALTER TABLE '" + currentTable + "' ALTER COLUMN '" + currentColumn + "' " + clickedDatatype + ";");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong datatype for this column!");
            }
            finally
            {
                SQLManager.con.Close();
            }
        }
        private void AlterTableWithChar(string currentTable, string currentColumn, string clickedDatatype, string charLength)
        {
            try
            {
                SQLManager.executeCommand(@"ALTER TABLE '" + currentTable + "' ALTER COLUMN '" + currentColumn + "' " + clickedDatatype + "(" + charLength.ToString() + ");");
                MessageBox.Show(@"ALTER TABLE '" + currentTable + "' ALTER COLUMN '" + currentColumn + "' " + clickedDatatype + "(" + charLength.ToString() + ");");
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong datatype for this column!");
            }
            finally
            {
                SQLManager.con.Close();
            }
        }
        private void CharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertedCharLength = Microsoft.VisualBasic.Interaction.InputBox("Please enter the char-length :", "Char length");
            if (string.IsNullOrEmpty(insertedCharLength))
            {
                MessageBox.Show("No length entered! Please try again.");
            }
            else
            {
                AlterTableWithChar(currentTable, currentColumn, sender.ToString(), insertedCharLength);
            }      
        }

        private void VarcharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string insertedCharLength = Microsoft.VisualBasic.Interaction.InputBox("Please enter the varchar-length :", "Char length");
            if (string.IsNullOrEmpty(insertedCharLength))
            {
                MessageBox.Show("No length entered! Please try again.");
            }
            else
            {
                AlterTableWithChar(currentTable, currentColumn, sender.ToString(), insertedCharLength);
            }
        }

        private void IntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterTable(currentTable, currentColumn, sender.ToString());
        }

        private void DateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterTable(currentTable, currentColumn, sender.ToString());
        }
        #endregion
    }
}

