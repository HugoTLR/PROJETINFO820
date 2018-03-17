namespace PROJET820
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.labPassword = new System.Windows.Forms.Label();
            this.labLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tabForm = new System.Windows.Forms.TabPage();
            this.panelSELECT = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panelCREATE = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelDELETE = new System.Windows.Forms.Panel();
            this.panelINSERT = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDeleteWhere = new System.Windows.Forms.Panel();
            this.cbDeleteWhere = new System.Windows.Forms.ComboBox();
            this.tbDeleteWhere = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbDeleteWhole = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTable2 = new System.Windows.Forms.ListBox();
            this.panelCREATEattr = new System.Windows.Forms.Panel();
            this.tbNbAttr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCreate = new System.Windows.Forms.TextBox();
            this.la = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTable = new System.Windows.Forms.ListBox();
            this.clbAttribute = new System.Windows.Forms.CheckedListBox();
            this.cbCOMMAND = new System.Windows.Forms.ComboBox();
            this.tabReponse = new System.Windows.Forms.TabPage();
            this.layoutReponse = new System.Windows.Forms.TableLayoutPanel();
            this.cbINSERT = new System.Windows.Forms.ComboBox();
            this.btnINSERT = new System.Windows.Forms.Button();
            this.panelINSERTAttr = new System.Windows.Forms.Panel();
            this.cbSELECT = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.panelSELECT.SuspendLayout();
            this.panelCREATE.SuspendLayout();
            this.panelDELETE.SuspendLayout();
            this.panelINSERT.SuspendLayout();
            this.panelDeleteWhere.SuspendLayout();
            this.tabReponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabForm);
            this.tabControl.Controls.Add(this.tabReponse);
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(872, 448);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.label5);
            this.tabLogin.Controls.Add(this.tbIP);
            this.tabLogin.Controls.Add(this.btnConnection);
            this.tabLogin.Controls.Add(this.labPassword);
            this.tabLogin.Controls.Add(this.labLogin);
            this.tabLogin.Controls.Add(this.tbPassword);
            this.tabLogin.Controls.Add(this.tbLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(864, 422);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "IP SERVER :";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(89, 97);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 5;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(38, 153);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.Text = "Connexion";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(7, 65);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(58, 13);
            this.labPassword.TabIndex = 3;
            this.labPassword.Text = "password :";
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Location = new System.Drawing.Point(7, 27);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(35, 13);
            this.labLogin.TabIndex = 2;
            this.labLogin.Text = "login :";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(89, 62);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "root";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(89, 24);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.Text = "hr";
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.panelINSERT);
            this.tabForm.Controls.Add(this.panelCREATE);
            this.tabForm.Controls.Add(this.panelDELETE);
            this.tabForm.Controls.Add(this.panelSELECT);
            this.tabForm.Controls.Add(this.cbCOMMAND);
            this.tabForm.Location = new System.Drawing.Point(4, 22);
            this.tabForm.Name = "tabForm";
            this.tabForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabForm.Size = new System.Drawing.Size(864, 422);
            this.tabForm.TabIndex = 1;
            this.tabForm.Text = "Formulaire";
            this.tabForm.UseVisualStyleBackColor = true;
            this.tabForm.Click += new System.EventHandler(this.tabForm_Click);
            // 
            // panelSELECT
            // 
            this.panelSELECT.Controls.Add(this.cbSELECT);
            this.panelSELECT.Controls.Add(this.btnSelect);
            this.panelSELECT.Controls.Add(this.label2);
            this.panelSELECT.Controls.Add(this.label1);
            this.panelSELECT.Controls.Add(this.lbTable);
            this.panelSELECT.Controls.Add(this.clbAttribute);
            this.panelSELECT.Location = new System.Drawing.Point(0, 40);
            this.panelSELECT.Name = "panelSELECT";
            this.panelSELECT.Size = new System.Drawing.Size(218, 375);
            this.panelSELECT.TabIndex = 2;
            this.panelSELECT.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(67, 316);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panelCREATE
            // 
            this.panelCREATE.Controls.Add(this.btnCreate);
            this.panelCREATE.Controls.Add(this.panelCREATEattr);
            this.panelCREATE.Controls.Add(this.tbNbAttr);
            this.panelCREATE.Controls.Add(this.label7);
            this.panelCREATE.Controls.Add(this.label6);
            this.panelCREATE.Controls.Add(this.tbCreate);
            this.panelCREATE.Controls.Add(this.la);
            this.panelCREATE.Location = new System.Drawing.Point(218, 40);
            this.panelCREATE.Name = "panelCREATE";
            this.panelCREATE.Size = new System.Drawing.Size(218, 375);
            this.panelCREATE.TabIndex = 4;
            this.panelCREATE.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(64, 316);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panelDELETE
            // 
            this.panelDELETE.Controls.Add(this.panelDeleteWhere);
            this.panelDELETE.Controls.Add(this.btnDelete);
            this.panelDELETE.Controls.Add(this.cbDeleteWhole);
            this.panelDELETE.Controls.Add(this.label3);
            this.panelDELETE.Controls.Add(this.lbTable2);
            this.panelDELETE.Location = new System.Drawing.Point(436, 40);
            this.panelDELETE.Name = "panelDELETE";
            this.panelDELETE.Size = new System.Drawing.Size(218, 375);
            this.panelDELETE.TabIndex = 3;
            this.panelDELETE.Visible = false;
            // 
            // panelINSERT
            // 
            this.panelINSERT.Controls.Add(this.panelINSERTAttr);
            this.panelINSERT.Controls.Add(this.btnINSERT);
            this.panelINSERT.Controls.Add(this.cbINSERT);
            this.panelINSERT.Controls.Add(this.label4);
            this.panelINSERT.Location = new System.Drawing.Point(654, 40);
            this.panelINSERT.Name = "panelINSERT";
            this.panelINSERT.Size = new System.Drawing.Size(218, 375);
            this.panelINSERT.TabIndex = 5;
            this.panelINSERT.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "INSERT";
            // 
            // panelDeleteWhere
            // 
            this.panelDeleteWhere.Controls.Add(this.cbDeleteWhere);
            this.panelDeleteWhere.Controls.Add(this.tbDeleteWhere);
            this.panelDeleteWhere.Location = new System.Drawing.Point(6, 140);
            this.panelDeleteWhere.Name = "panelDeleteWhere";
            this.panelDeleteWhere.Size = new System.Drawing.Size(212, 154);
            this.panelDeleteWhere.TabIndex = 7;
            // 
            // cbDeleteWhere
            // 
            this.cbDeleteWhere.FormattingEnabled = true;
            this.cbDeleteWhere.Location = new System.Drawing.Point(0, 0);
            this.cbDeleteWhere.Name = "cbDeleteWhere";
            this.cbDeleteWhere.Size = new System.Drawing.Size(100, 21);
            this.cbDeleteWhere.TabIndex = 6;
            // 
            // tbDeleteWhere
            // 
            this.tbDeleteWhere.Location = new System.Drawing.Point(112, 0);
            this.tbDeleteWhere.Name = "tbDeleteWhere";
            this.tbDeleteWhere.Size = new System.Drawing.Size(100, 20);
            this.tbDeleteWhere.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(74, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbDeleteWhole
            // 
            this.cbDeleteWhole.AutoSize = true;
            this.cbDeleteWhole.Location = new System.Drawing.Point(86, 117);
            this.cbDeleteWhole.Name = "cbDeleteWhole";
            this.cbDeleteWhole.Size = new System.Drawing.Size(114, 17);
            this.cbDeleteWhole.TabIndex = 4;
            this.cbDeleteWhole.Text = "Delete whole table";
            this.cbDeleteWhole.UseVisualStyleBackColor = true;
            this.cbDeleteWhole.CheckedChanged += new System.EventHandler(this.cbDeleteWhole_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TABLE";
            // 
            // lbTable2
            // 
            this.lbTable2.FormattingEnabled = true;
            this.lbTable2.Location = new System.Drawing.Point(86, 15);
            this.lbTable2.Name = "lbTable2";
            this.lbTable2.Size = new System.Drawing.Size(120, 95);
            this.lbTable2.TabIndex = 2;
            this.lbTable2.SelectedIndexChanged += new System.EventHandler(this.lbTable2_SelectedIndexChanged);
            // 
            // panelCREATEattr
            // 
            this.panelCREATEattr.AutoScroll = true;
            this.panelCREATEattr.Location = new System.Drawing.Point(3, 137);
            this.panelCREATEattr.Name = "panelCREATEattr";
            this.panelCREATEattr.Size = new System.Drawing.Size(212, 157);
            this.panelCREATEattr.TabIndex = 5;
            // 
            // tbNbAttr
            // 
            this.tbNbAttr.Location = new System.Drawing.Point(92, 90);
            this.tbNbAttr.Name = "tbNbAttr";
            this.tbNbAttr.Size = new System.Drawing.Size(100, 20);
            this.tbNbAttr.TabIndex = 4;
            this.tbNbAttr.TextChanged += new System.EventHandler(this.tbNbAttr_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "NB ATTR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "TABLE NAME";
            // 
            // tbCreate
            // 
            this.tbCreate.Location = new System.Drawing.Point(92, 50);
            this.tbCreate.Name = "tbCreate";
            this.tbCreate.Size = new System.Drawing.Size(100, 20);
            this.tbCreate.TabIndex = 1;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(11, 15);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(50, 13);
            this.la.TabIndex = 0;
            this.la.Text = "CREATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ATTRIBUTES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TABLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTable
            // 
            this.lbTable.FormattingEnabled = true;
            this.lbTable.Location = new System.Drawing.Point(44, 36);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(120, 95);
            this.lbTable.TabIndex = 1;
            this.lbTable.SelectedIndexChanged += new System.EventHandler(this.lbTable_SelectedIndexChanged);
            // 
            // clbAttribute
            // 
            this.clbAttribute.FormattingEnabled = true;
            this.clbAttribute.Location = new System.Drawing.Point(44, 181);
            this.clbAttribute.Name = "clbAttribute";
            this.clbAttribute.Size = new System.Drawing.Size(120, 94);
            this.clbAttribute.TabIndex = 0;
            // 
            // cbCOMMAND
            // 
            this.cbCOMMAND.FormattingEnabled = true;
            this.cbCOMMAND.Items.AddRange(new object[] {
            "SELECT",
            "CREATE",
            "DELETE",
            "INSERT"});
            this.cbCOMMAND.Location = new System.Drawing.Point(373, 13);
            this.cbCOMMAND.Name = "cbCOMMAND";
            this.cbCOMMAND.Size = new System.Drawing.Size(121, 21);
            this.cbCOMMAND.TabIndex = 1;
            this.cbCOMMAND.SelectedIndexChanged += new System.EventHandler(this.cbCOMMAND_SelectedIndexChanged);
            // 
            // tabReponse
            // 
            this.tabReponse.Controls.Add(this.layoutReponse);
            this.tabReponse.Location = new System.Drawing.Point(4, 22);
            this.tabReponse.Name = "tabReponse";
            this.tabReponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabReponse.Size = new System.Drawing.Size(864, 422);
            this.tabReponse.TabIndex = 2;
            this.tabReponse.Text = "Reponse";
            this.tabReponse.UseVisualStyleBackColor = true;
            // 
            // layoutReponse
            // 
            this.layoutReponse.AutoScroll = true;
            this.layoutReponse.ColumnCount = 2;
            this.layoutReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutReponse.Location = new System.Drawing.Point(7, 6);
            this.layoutReponse.MaximumSize = new System.Drawing.Size(864, 350);
            this.layoutReponse.Name = "layoutReponse";
            this.layoutReponse.RowCount = 1;
            this.layoutReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutReponse.Size = new System.Drawing.Size(760, 350);
            this.layoutReponse.TabIndex = 0;
            this.layoutReponse.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutReponse_Paint);
            // 
            // cbINSERT
            // 
            this.cbINSERT.FormattingEnabled = true;
            this.cbINSERT.Location = new System.Drawing.Point(82, 33);
            this.cbINSERT.Name = "cbINSERT";
            this.cbINSERT.Size = new System.Drawing.Size(100, 21);
            this.cbINSERT.TabIndex = 7;
            this.cbINSERT.SelectedIndexChanged += new System.EventHandler(this.cbINSERT_SelectedIndexChanged);
            // 
            // btnINSERT
            // 
            this.btnINSERT.Location = new System.Drawing.Point(82, 316);
            this.btnINSERT.Name = "btnINSERT";
            this.btnINSERT.Size = new System.Drawing.Size(75, 23);
            this.btnINSERT.TabIndex = 8;
            this.btnINSERT.Text = "INSERT";
            this.btnINSERT.UseVisualStyleBackColor = true;
            this.btnINSERT.Click += new System.EventHandler(this.btnINSERT_Click);
            // 
            // panelINSERTAttr
            // 
            this.panelINSERTAttr.AutoScroll = true;
            this.panelINSERTAttr.Location = new System.Drawing.Point(2, 137);
            this.panelINSERTAttr.Name = "panelINSERTAttr";
            this.panelINSERTAttr.Size = new System.Drawing.Size(212, 157);
            this.panelINSERTAttr.TabIndex = 9;
            // 
            // cbSELECT
            // 
            this.cbSELECT.AutoSize = true;
            this.cbSELECT.Location = new System.Drawing.Point(44, 281);
            this.cbSELECT.Name = "cbSELECT";
            this.cbSELECT.Size = new System.Drawing.Size(113, 17);
            this.cbSELECT.TabIndex = 5;
            this.cbSELECT.Text = "Select whole table";
            this.cbSELECT.UseVisualStyleBackColor = true;
            this.cbSELECT.CheckedChanged += new System.EventHandler(this.cbSELECT_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 451);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabForm.ResumeLayout(false);
            this.panelSELECT.ResumeLayout(false);
            this.panelSELECT.PerformLayout();
            this.panelCREATE.ResumeLayout(false);
            this.panelCREATE.PerformLayout();
            this.panelDELETE.ResumeLayout(false);
            this.panelDELETE.PerformLayout();
            this.panelINSERT.ResumeLayout(false);
            this.panelINSERT.PerformLayout();
            this.panelDeleteWhere.ResumeLayout(false);
            this.panelDeleteWhere.PerformLayout();
            this.tabReponse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TabPage tabForm;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.ComboBox cbCOMMAND;
        private System.Windows.Forms.Panel panelSELECT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbTable;
        private System.Windows.Forms.CheckedListBox clbAttribute;
        private System.Windows.Forms.Panel panelDELETE;
        private System.Windows.Forms.CheckBox cbDeleteWhole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTable2;
        private System.Windows.Forms.Panel panelINSERT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelCREATE;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TabPage tabReponse;
        private System.Windows.Forms.TableLayoutPanel layoutReponse;
        private System.Windows.Forms.TextBox tbNbAttr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCreate;
        private System.Windows.Forms.Panel panelCREATEattr;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbDeleteWhere;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbDeleteWhere;
        private System.Windows.Forms.Panel panelDeleteWhere;
        private System.Windows.Forms.Button btnINSERT;
        private System.Windows.Forms.ComboBox cbINSERT;
        private System.Windows.Forms.Panel panelINSERTAttr;
        private System.Windows.Forms.CheckBox cbSELECT;
    }
}

