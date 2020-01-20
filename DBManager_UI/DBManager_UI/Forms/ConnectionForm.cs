using Datenbanken___Tabelle_erstellen__Daten;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManager_UI
{
    public partial class Connection_form : MetroFramework.Forms.MetroForm
    {
        public static MetroProgressSpinner spinner;
        public static Main secondForm;

        public Connection_form()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load_1(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';
            tb_server.Text = "localdb";
            tb_password.Text = "1234";
            tb_id.Text = "fabio";
            cB_true.Checked = true;

            spinner = new MetroFramework.Controls.MetroProgressSpinner()
            {
                Location = new System.Drawing.Point(135, 110),
                Maximum = 100,
                Name = "spinner",
                Size = new System.Drawing.Size(100, 100),
                TabIndex = 25,
                Visible = true,
            };
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            SQLManager mng = new SQLManager();
            mng.ServerName = tb_server.Text;
            mng.Username = tb_id.Text;
            mng.Password = tb_password.Text;
            if (cB_notActivated.Checked)
            {
                mng.Security = "false";
            }
            else
            {
                mng.Security = "true";
            }


            SQLManager.createConnection(mng.ServerName, mng.Security, false);

            #region redundant

            foreach (var item in this.Controls
                    .OfType<MetroButton>()
                    .Where(x => (string)x.Tag.ToString() == ("hide"))
                    .ToList())
            {
                item.Hide();
            }

            foreach (var item in this.Controls
                   .OfType<MetroLabel>()
                   .Where(x => (string)x.Tag.ToString() == ("hide"))
                   .ToList())
            {
                item.Hide();
            }
            foreach (var item in this.Controls
                   .OfType<MetroCheckBox>()
                   .Where(x => (string)x.Tag.ToString() == ("hide"))
                   .ToList())
            {
                item.Hide();
            }
            foreach (var item in this.Controls
                   .OfType<MetroTextBox>()
                   .Where(x => (string)x.Tag.ToString() == ("hide"))
                   .ToList())
            {
                item.Hide();
            }
            #endregion

            Controls.Add(spinner);
            spinner.Visible = true;


            Main i = new Main();




            Connection_form infoTraeger = new Connection_form();
            Main abonnent = new Main();
            infoTraeger.Registrierung(abonnent);
            infoTraeger.setInformation();
            this.Hide();
        }

 
        private event EreignisDelegat ereignisBehandler;
        public void Registrierung(Main abo)
        {
            ereignisBehandler += abo.InfoEmpfang;
        }
        public void setInformation()
        {            
            EreignisArgumente ea = new EreignisArgumente(true);
            ereignisBehandler(ea);
        }
    }
    public delegate void EreignisDelegat(EreignisArgumente e);
}
