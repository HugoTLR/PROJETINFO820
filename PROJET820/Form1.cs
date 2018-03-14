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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            string log = tbLogin.Text;
            string pw = tbPassword.Text;



            //FAIRE LA CO ICI

            // si successs
                connexion = true;
            //CHARGER LE MODELE DE LA BDD
            //else

            MessageBox.Show("Incorrect Login or password");

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
                    panelSELECT.Visible = true;
                    break;
            }
        }

        private void tabForm_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCOMMAND.SelectedIndex = 3;
        }
    }
}
