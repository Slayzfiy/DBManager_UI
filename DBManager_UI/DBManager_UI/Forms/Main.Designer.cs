namespace DBManager_UI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dg_data = new System.Windows.Forms.DataGridView();
            this.btn_addrow = new System.Windows.Forms.Button();
            this.btn_addcolumn = new System.Windows.Forms.Button();
            this.lB_databases = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lB_tables = new System.Windows.Forms.ListBox();
            this.btn_createDB = new MetroFramework.Controls.MetroButton();
            this.btn_dropDB = new MetroFramework.Controls.MetroButton();
            this.btn_addTable = new MetroFramework.Controls.MetroButton();
            this.btn_deleteTable = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.charToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varcharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColumnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_data
            // 
            this.dg_data.ColumnHeadersHeight = 34;
            this.dg_data.Location = new System.Drawing.Point(659, 63);
            this.dg_data.Name = "dg_data";
            this.dg_data.RowHeadersWidth = 62;
            this.dg_data.Size = new System.Drawing.Size(861, 550);
            this.dg_data.TabIndex = 19;
            this.dg_data.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_data_ColumnHeaderMouseClick);
            // 
            // btn_addrow
            // 
            this.btn_addrow.Location = new System.Drawing.Point(1212, 793);
            this.btn_addrow.Name = "btn_addrow";
            this.btn_addrow.Size = new System.Drawing.Size(75, 23);
            this.btn_addrow.TabIndex = 1;
            this.btn_addrow.Text = "Add Row";
            this.btn_addrow.UseVisualStyleBackColor = true;
            this.btn_addrow.Click += new System.EventHandler(this.btn_addrow_Click);
            // 
            // btn_addcolumn
            // 
            this.btn_addcolumn.Location = new System.Drawing.Point(1307, 793);
            this.btn_addcolumn.Name = "btn_addcolumn";
            this.btn_addcolumn.Size = new System.Drawing.Size(75, 23);
            this.btn_addcolumn.TabIndex = 2;
            this.btn_addcolumn.Text = "Add Column";
            this.btn_addcolumn.UseVisualStyleBackColor = true;
            this.btn_addcolumn.Click += new System.EventHandler(this.btn_addcolumn_Click);
            // 
            // lB_databases
            // 
            this.lB_databases.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB_databases.FormattingEnabled = true;
            this.lB_databases.HorizontalScrollbar = true;
            this.lB_databases.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lB_databases.ItemHeight = 21;
            this.lB_databases.Location = new System.Drawing.Point(43, 63);
            this.lB_databases.Name = "lB_databases";
            this.lB_databases.Size = new System.Drawing.Size(271, 550);
            this.lB_databases.TabIndex = 7;
            this.lB_databases.SelectedIndexChanged += new System.EventHandler(this.lB_databases_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(43, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Databases";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(349, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 25);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Tables";
            // 
            // lB_tables
            // 
            this.lB_tables.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB_tables.FormattingEnabled = true;
            this.lB_tables.HorizontalScrollbar = true;
            this.lB_tables.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lB_tables.ItemHeight = 21;
            this.lB_tables.Location = new System.Drawing.Point(352, 63);
            this.lB_tables.Name = "lB_tables";
            this.lB_tables.Size = new System.Drawing.Size(271, 550);
            this.lB_tables.TabIndex = 9;
            this.lB_tables.SelectedIndexChanged += new System.EventHandler(this.lB_tables_SelectedIndexChanged);
            // 
            // btn_createDB
            // 
            this.btn_createDB.Location = new System.Drawing.Point(43, 792);
            this.btn_createDB.Name = "btn_createDB";
            this.btn_createDB.Size = new System.Drawing.Size(108, 24);
            this.btn_createDB.TabIndex = 15;
            this.btn_createDB.Text = "Create Database";
            this.btn_createDB.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btn_dropDB
            // 
            this.btn_dropDB.Location = new System.Drawing.Point(206, 793);
            this.btn_dropDB.Name = "btn_dropDB";
            this.btn_dropDB.Size = new System.Drawing.Size(108, 24);
            this.btn_dropDB.TabIndex = 16;
            this.btn_dropDB.Text = "Drop Database";
            this.btn_dropDB.Click += new System.EventHandler(this.btn_dropDB_Click);
            // 
            // btn_addTable
            // 
            this.btn_addTable.Location = new System.Drawing.Point(349, 793);
            this.btn_addTable.Name = "btn_addTable";
            this.btn_addTable.Size = new System.Drawing.Size(108, 24);
            this.btn_addTable.TabIndex = 17;
            this.btn_addTable.Text = "Add Table";
            this.btn_addTable.Click += new System.EventHandler(this.btn_addTable_Click);
            // 
            // btn_deleteTable
            // 
            this.btn_deleteTable.Location = new System.Drawing.Point(512, 793);
            this.btn_deleteTable.Name = "btn_deleteTable";
            this.btn_deleteTable.Size = new System.Drawing.Size(108, 24);
            this.btn_deleteTable.TabIndex = 18;
            this.btn_deleteTable.Text = "Delete Table";
            this.btn_deleteTable.Click += new System.EventHandler(this.btn_deleteTable_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeTypeToolStripMenuItem1,
            this.deleteColumnToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            // 
            // changeTypeToolStripMenuItem1
            // 
            this.changeTypeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charToolStripMenuItem,
            this.varcharToolStripMenuItem,
            this.intToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.changeTypeToolStripMenuItem1.Name = "changeTypeToolStripMenuItem1";
            this.changeTypeToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.changeTypeToolStripMenuItem1.Text = "Change Type";
            // 
            // charToolStripMenuItem
            // 
            this.charToolStripMenuItem.Name = "charToolStripMenuItem";
            this.charToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.charToolStripMenuItem.Text = "char";
            this.charToolStripMenuItem.Click += new System.EventHandler(this.CharToolStripMenuItem_Click);
            // 
            // varcharToolStripMenuItem
            // 
            this.varcharToolStripMenuItem.Name = "varcharToolStripMenuItem";
            this.varcharToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.varcharToolStripMenuItem.Text = "varchar";
            this.varcharToolStripMenuItem.Click += new System.EventHandler(this.VarcharToolStripMenuItem_Click);
            // 
            // intToolStripMenuItem
            // 
            this.intToolStripMenuItem.Name = "intToolStripMenuItem";
            this.intToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.intToolStripMenuItem.Text = "int";
            this.intToolStripMenuItem.Click += new System.EventHandler(this.IntToolStripMenuItem_Click);
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dateToolStripMenuItem.Text = "date";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.DateToolStripMenuItem_Click);
            // 
            // deleteColumnToolStripMenuItem1
            // 
            this.deleteColumnToolStripMenuItem1.Name = "deleteColumnToolStripMenuItem1";
            this.deleteColumnToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.deleteColumnToolStripMenuItem1.Text = "Delete Column";
            this.deleteColumnToolStripMenuItem1.Click += new System.EventHandler(this.deleteColumnToolStripMenuItem1_Click);
            // 
            // changeTypeToolStripMenuItem
            // 
            this.changeTypeToolStripMenuItem.Name = "changeTypeToolStripMenuItem";
            this.changeTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeTypeToolStripMenuItem.Text = "Change Type";
            // 
            // deleteColumnToolStripMenuItem
            // 
            this.deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            this.deleteColumnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteColumnToolStripMenuItem.Text = "Delete Column";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "please click on a table if it doesnt update";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 880);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_deleteTable);
            this.Controls.Add(this.btn_addTable);
            this.Controls.Add(this.btn_dropDB);
            this.Controls.Add(this.btn_createDB);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lB_tables);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lB_databases);
            this.Controls.Add(this.btn_addcolumn);
            this.Controls.Add(this.btn_addrow);
            this.Controls.Add(this.dg_data);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_data;
        private System.Windows.Forms.Button btn_addrow;
        private System.Windows.Forms.Button btn_addcolumn;
        private System.Windows.Forms.ListBox lB_databases;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListBox lB_tables;
        private MetroFramework.Controls.MetroButton btn_createDB;
        private MetroFramework.Controls.MetroButton btn_dropDB;
        private MetroFramework.Controls.MetroButton btn_addTable;
        private MetroFramework.Controls.MetroButton btn_deleteTable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem charToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varcharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}