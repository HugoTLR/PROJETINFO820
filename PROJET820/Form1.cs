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
                    InitSelectPanel();
                    panelSELECT.Visible = true;
                    break;
                case 1:
                    panelCREATE.Visible = true;
                    break;
                case 2:
                    InitDeletePanel();
                    panelDELETE.Visible = true;
                    break;
                case 3:
                    InitInsertPanel();
                    panelINSERT.Visible = true;
                    break;
            }
        }

        private void InitInsertPanel()
        {
            for (int i = 0; i < dataInstance.TablesList.Count; i++)
            {
                cbINSERT.Items.Add(dataInstance.TablesList.ElementAt(i).Value.Name);
            }
        }
        
        private void InitDeletePanel()
        {
            for (int i = 0; i < dataInstance.TablesList.Count; i++)
            {
                lbTable2.Items.Add(dataInstance.TablesList.ElementAt(i).Value.Name);
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
            cbCOMMAND.SelectedIndex = 0;
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
            layoutReponse.Controls.Clear();
            layoutReponse.RowStyles.Clear();
            layoutReponse.ColumnStyles.Clear();;
            layoutReponse.RowCount = 1;
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
            try
            {
                while (dr.Read())
                {

                    layoutReponse.RowCount = layoutReponse.RowCount + 1;
                    //layoutReponse.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                    for (int i = 0; i < attr.Count; i++)
                    {
                        string type = dataInstance.TablesList[tname].AttrList.ElementAt(i).Type;
                        if (dr.IsDBNull(i))
                            layoutReponse.Controls.Add(new Label() { Text = "NULL" }, i, layoutReponse.RowCount - 1);
                        else if (type == "NUMBER")
                            layoutReponse.Controls.Add(new Label() { Text = dr.GetInt32(i).ToString() }, i, layoutReponse.RowCount - 1);
                        else if (type == "DATE")
                            layoutReponse.Controls.Add(new Label() { Text = dr.GetDateTime(i).ToString() }, i, layoutReponse.RowCount - 1);
                        else
                            layoutReponse.Controls.Add(new Label() { Text = dr.GetString(i) }, i, layoutReponse.RowCount - 1);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            MessageBox.Show("Select successful. See response page");
            

        }

        private void layoutReponse_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbNbAttr_TextChanged(object sender, EventArgs e)
        {
            panelCREATEattr.Controls.Clear();
            if (tbNbAttr.Text != "" && IsAllDigits(tbNbAttr.Text))
            {
                for(int i = 0; i < int.Parse(tbNbAttr.Text);i++)
                {
                    TextBox attrName = new TextBox();
                    attrName.SetBounds(0, 0 + i * 50, 75, 30);
                    attrName.Text = "aa";
                    ComboBox attrType = new ComboBox();
                    attrType.Items.Add("NUMBER");

                    attrType.Items.Add("DATE");
                    attrType.Items.Add("VARCHAR");
                    attrType.SetBounds(100, 0 + i * 50, 75, 30);
                    panelCREATEattr.Controls.Add(attrName);
                    panelCREATEattr.Controls.Add(attrType);

                }
            }
        }

        private bool IsAllDigits(string s)
        {
            foreach(char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FeedOracle();
        }

        //CREATE
        private void FeedOracle()
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "CREATE TABLE " + tbCreate.Text + "(";
            int nbArg = int.Parse(tbNbAttr.Text);
            bool isattr = false;
            int cpt = 1;
            string res = "";

            foreach (Control c in panelCREATEattr.Controls)
            {
                if (!isattr)
                    res += c.Text + " ";
                else
                {
                    if(c.Text == "VARCHAR")
                        res += (cpt/2 == nbArg) ? c.Text + "(30))" : c.Text + "(30),";
                    else
                        res += (cpt/2 == nbArg) ? c.Text + ")" : c.Text + ",";



                }
                cpt++;
                isattr = !isattr;
            }
            cmd.CommandText += res;
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            try
            {
                //Useless
                while (dr.Read())
                    Console.WriteLine(dr.GetValue(0));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            MessageBox.Show("Table Successfully Created");
        }

        private void lbTable2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDeleteWhere.Items.Clear();
            KeyValuePair<string, Table> t = dataInstance.TablesList.ElementAt(lbTable2.SelectedIndex);
            for (int i = 0; i < t.Value.AttrList.Count; i++)
            {
                cbDeleteWhere.Items.Add(t.Value.AttrList.ElementAt(i).Name);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CleanOracle();
        }

        private void CleanOracle()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            if(cbDeleteWhole.Checked)
                cmd.CommandText = "DELETE FROM " + lbTable2.Text;
            else
                cmd.CommandText = "DELETE FROM " + lbTable2.Text + " WHERE " + cbDeleteWhere.Text + " " + tbDeleteWhere.Text;
            
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            try
            {
                //Useless
                while (dr.Read())
                    Console.WriteLine(dr.GetValue(0));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            MessageBox.Show("Delete successful");
        }

        private void cbDeleteWhole_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDeleteWhole.Checked)
            {
                panelDeleteWhere.Hide();
            }
            else
            {
                panelDeleteWhere.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void cbINSERT_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelINSERTAttr.Controls.Clear();
            KeyValuePair<string, Table> t = dataInstance.TablesList.ElementAt(cbINSERT.SelectedIndex);
            for (int i = 0; i < t.Value.AttrList.Count; i++)
            {

                Label attrName = new Label();
                attrName.SetBounds(0, 0 + i * 50, 75, 30);
                attrName.Text = t.Value.AttrList[i].Name;
                TextBox attrType = new TextBox();
              
                attrType.SetBounds(100, 0 + i * 50, 75, 30);
                panelINSERTAttr.Controls.Add(attrName);
                panelINSERTAttr.Controls.Add(attrType);
            }
        }

        private void btnINSERT_Click(object sender, EventArgs e)
        {
            FeedTable();
        }

        private void FeedTable()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO " + cbINSERT.Text + " VALUES(";

            int cpt = 0;
            string type = "";
            foreach (Control c in panelINSERTAttr.Controls)
            {
                if (c is Label)
                    type = dataInstance.TablesList[cbINSERT.Text].AttrList[cpt].Type;
                else if (c is TextBox)
                {
                    if(type.Contains("VARCH"))
                        cmd.CommandText += (cpt != dataInstance.TablesList[cbINSERT.Text].AttrList.Count - 1) ? "'"+c.Text + "'," : "'"+c.Text + "')";
                    else
                        cmd.CommandText += (cpt != dataInstance.TablesList[cbINSERT.Text].AttrList.Count - 1) ? c.Text + "," : c.Text + ")";
                    cpt++;
                }
            }


            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            try
            {
                //Useless
                while (dr.Read())
                    Console.WriteLine(dr.GetValue(0));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            MessageBox.Show("Insert successful");
        }
    }
}
