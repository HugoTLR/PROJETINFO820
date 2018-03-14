using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET820
{
    public partial class Form1 : Form
    {

        public bool connexion { get; protected set; }
        private string host;

        public List<string> tableName { get; protected set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            string log = tbLogin.Text;
            string pw = tbPassword.Text;

            string oradb = "Data Source=(DESCRIPTION="
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + host + ")(PORT=1521)))"
                + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
                + "User Id=" + log + ";Password=" + pw + ";";

            OracleConnection conn = new OracleConnection(oradb);
            try
            {
                conn.Open();

                connexion = true;
            }
            catch(Exception ex)// Intercepte toutes les exceptions
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            if (connexion)
            {
                MessageBox.Show("Connexion Successfull");
                LoadDBStruct(conn);

                //Charger le modele ici
            }
        }

        private void LoadDBStruct(OracleConnection conn)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select table_name FROM user_tables";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tableName.Add(dr.GetString(0));// changer de structure plus tard
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Check Credentials Here  

            if (!connexion)
            {
                MessageBox.Show("Unable to load tab. You have insufficient access privileges.");
                tabControl.SelectedTab = tabLogin;
            }
        }

        private void cbCOMMAND_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in tabForm.Controls)
            {
                if (c is Panel)
                    c.Visible = false;
            }
            switch (cbCOMMAND.SelectedIndex)
            {
                case 0:
                    panelCREATE.Visible = true;
                    break;
                case 1:
                    panelDELETE.Visible = true;
                    break;
                case 2:
                    panelINSERT.Visible = true;
                    break;
                case 3:
                    InitSelectPanel();
                    panelSELECT.Visible = true;
                    break;
            }
        }

        private void InitSelectPanel()
        {
            foreach(string s in tableName)
            {
                lbTable.Items.Add(s);
            }
        }

        private void tabForm_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            host = "XX.XXX.XXX.XXX";
            tableName = new List<string>();
            cbCOMMAND.SelectedIndex = 1;
        }
    }
}
