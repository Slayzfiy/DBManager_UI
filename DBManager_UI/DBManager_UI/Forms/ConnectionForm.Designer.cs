namespace DBManager_UI
{
    partial class Connection_form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection_form));
            this.tb_server = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tb_id = new MetroFramework.Controls.MetroTextBox();
            this.tb_password = new MetroFramework.Controls.MetroTextBox();
            this.cB_true = new MetroFramework.Controls.MetroCheckBox();
            this.cB_notActivated = new MetroFramework.Controls.MetroCheckBox();
            this.btn_connect = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(112, 112);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(233, 23);
            this.tb_server.TabIndex = 15;
            this.tb_server.Tag = "hide";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Tag = "hide";
            this.metroLabel1.Text = "Server";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 144);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Tag = "hide";
            this.metroLabel2.Text = "Username";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 175);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Tag = "hide";
            this.metroLabel3.Text = "Password";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 209);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Tag = "hide";
            this.metroLabel4.Text = "SSPI";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(112, 144);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(233, 23);
            this.tb_id.TabIndex = 20;
            this.tb_id.Tag = "hide";
            // 
            // tb_password
            // 
            this.tb_password.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tb_password.Location = new System.Drawing.Point(112, 175);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(233, 23);
            this.tb_password.TabIndex = 21;
            this.tb_password.Tag = "hide";
            this.tb_password.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_password.UseStyleColors = true;
            // 
            // cB_true
            // 
            this.cB_true.AutoSize = true;
            this.cB_true.Location = new System.Drawing.Point(112, 209);
            this.cB_true.Name = "cB_true";
            this.cB_true.Size = new System.Drawing.Size(54, 15);
            this.cB_true.TabIndex = 22;
            this.cB_true.Tag = "hide";
            this.cB_true.Text = "active";
            this.cB_true.UseVisualStyleBackColor = true;
            // 
            // cB_notActivated
            // 
            this.cB_notActivated.AutoSize = true;
            this.cB_notActivated.Location = new System.Drawing.Point(270, 209);
            this.cB_notActivated.Name = "cB_notActivated";
            this.cB_notActivated.Size = new System.Drawing.Size(75, 15);
            this.cB_notActivated.TabIndex = 23;
            this.cB_notActivated.Tag = "hide";
            this.cB_notActivated.Text = "not active";
            this.cB_notActivated.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(112, 254);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(233, 23);
            this.btn_connect.Style = MetroFramework.MetroColorStyle.Black;
            this.btn_connect.TabIndex = 24;
            this.btn_connect.Tag = "hide";
            this.btn_connect.Text = "Connect to Databases";
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(23, 49);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(148, 25);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Tag = "hide";
            this.metroLabel5.Text = "Connect to Server";
            // 
            // Connection_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(376, 321);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.cB_notActivated);
            this.Controls.Add(this.cB_true);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tb_server);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Connection_form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.ConnectionForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tb_server;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tb_id;
        private MetroFramework.Controls.MetroTextBox tb_password;
        private MetroFramework.Controls.MetroCheckBox cB_true;
        private MetroFramework.Controls.MetroCheckBox cB_notActivated;
        private MetroFramework.Controls.MetroButton btn_connect;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

