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

        public OracleConnection conn { get; protected set; }
        public bool connexion { get; protected set; }
        private Instance dataInstance;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            string log = tbLogin.Text;
            string pw = tbPassword.Text;
            string host = tbIP.Text;
            string oradb = "Data Source=(DESCRIPTION="
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=" + host + ")(PORT=1521)))"
                + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
                + "User Id=" + log + ";Password=" + pw + ";";

            conn = new OracleConnection(oradb);
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
            cmd.CommandText = "select table_name,column_id,column_name,data_type FROM user_tab_columns";
            cmd.CommandType = CommandType.Text;

            
            OracleDataReader dr = cmd.ExecuteReader();

            string t = "";
            while (dr.Read())
            {
                if(t != dr.GetString(0))
                {
                    dataInstance.TablesList.Add(dr.GetString(0),new Table(dr.GetString(0)));
                    t = dr.GetString(0);
                }
                Attribute a = (dr.GetInt16(1) == 1) ? new Attribute(dr.GetString(2), dr.GetString(3), true) : new Attribute(dr.GetString(2), dr.GetString(3));

                dataInstance.TablesList[t].AddAttribute(a);
            }

            /*
            for(int i = 0; i < dataInstance.TablesList.Count; i++)
            {
                string name = dataInstance.TablesList.ElementAt(i).Name;
                cmd.CommandText = "SHOW COLUMNS FROM " + name + ";";

                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    dataInstance.TablesList.ElementAt(i).AddAttribute(new Attribute("eeeee", "eeeee"));
                    ///// recuperation des attributs de chaque table ici
                }

            }*/
        }

        private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Check Credentials Here  

            if (!connexion && tabControl.SelectedTab != tabLogin)
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
            for(int i = 0; i < dataInstance.TablesList.Count;i++)
            {
                lbTable.Items.Add(dataInstance.TablesList.ElementAt(i).Value.Name);
            }
        }

        private void tabForm_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataInstance = new Instance();
            cbCOMMAND.SelectedIndex = 1;
        }

        private void lbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbAttribute.Items.Clear();
            KeyValuePair<string,Table> t= dataInstance.TablesList.ElementAt(lbTable.SelectedIndex);
            for (int i = 0; i < t.Value.AttrList.Count; i++)
            {
                clbAttribute.Items.Add(t.Value.AttrList.ElementAt(i).Name);
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            AskOracle();
        }

        private void AskOracle()
        {
            string tname = lbTable.SelectedItem.ToString();
            List<string> attr = new List<string>();
            for(int i = 0; i < clbAttribute.Items.Count; i++)
            {
                if(clbAttribute.GetItemChecked(i))
                    attr.Add(clbAttribute.GetItemText(clbAttribute.Items[i]));
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ";
            for(int i = 0; i <  attr.Count; i++)
            {
                cmd.CommandText += (i == attr.Count-1) ? attr.ElementAt(i) : attr.ElementAt(i) + ",";
            }
            cmd.CommandText += " FROM " + tname;
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();


            layoutReponse.ColumnCount = attr.Count;
            for(int i = 0; i < attr.Count; i++)
            {
                layoutReponse.Controls.Add(new Label() { Text = attr.ElementAt(i) }, i, 0);
            }

            int cpt = layoutReponse.RowCount;            
            while (dr.Read())
            {

                layoutReponse.RowCount = layoutReponse.RowCount + 1;
                layoutReponse.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                for (int i = 0; i < attr.Count; i++)
                {
                    if(dataInstance.TablesList[tname].AttrList.ElementAt(i).Type == "NUMBER")
                        layoutReponse.Controls.Add(new Label() { Text = dr.GetInt16(i).ToString() }, i, layoutReponse.RowCount - 1);
                    else

                        layoutReponse.Controls.Add(new Label() { Text = dr.GetString(i) }, i, layoutReponse.RowCount - 1);
                }
            }
        }

        private void layoutReponse_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
