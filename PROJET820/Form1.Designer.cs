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
            this.panelINSERT = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCREATE = new System.Windows.Forms.Panel();
            this.la = new System.Windows.Forms.Label();
            this.panelDELETE = new System.Windows.Forms.Panel();
            this.cbDeleteWhole = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTable2 = new System.Windows.Forms.ListBox();
            this.panelSELECT = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTable = new System.Windows.Forms.ListBox();
            this.clbAttribute = new System.Windows.Forms.CheckedListBox();
            this.cbCOMMAND = new System.Windows.Forms.ComboBox();
            this.tabReponse = new System.Windows.Forms.TabPage();
            this.layoutReponse = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.panelINSERT.SuspendLayout();
            this.panelCREATE.SuspendLayout();
            this.panelDELETE.SuspendLayout();
            this.panelSELECT.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(784, 448);
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
            this.tabLogin.Size = new System.Drawing.Size(776, 422);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "IP SERVER :";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(288, 59);
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
            this.labPassword.Location = new System.Drawing.Point(7, 104);
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
            this.tbPassword.Location = new System.Drawing.Point(89, 101);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(89, 24);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 0;
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
            this.tabForm.Size = new System.Drawing.Size(776, 422);
            this.tabForm.TabIndex = 1;
            this.tabForm.Text = "Formulaire";
            this.tabForm.UseVisualStyleBackColor = true;
            this.tabForm.Click += new System.EventHandler(this.tabForm_Click);
            // 
            // panelINSERT
            // 
            this.panelINSERT.Controls.Add(this.label4);
            this.panelINSERT.Location = new System.Drawing.Point(429, 346);
            this.panelINSERT.Name = "panelINSERT";
            this.panelINSERT.Size = new System.Drawing.Size(235, 322);
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
            // panelCREATE
            // 
            this.panelCREATE.Controls.Add(this.la);
            this.panelCREATE.Location = new System.Drawing.Point(485, 6);
            this.panelCREATE.Name = "panelCREATE";
            this.panelCREATE.Size = new System.Drawing.Size(235, 322);
            this.panelCREATE.TabIndex = 4;
            this.panelCREATE.Visible = false;
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(29, 36);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(50, 13);
            this.la.TabIndex = 0;
            this.la.Text = "CREATE";
            // 
            // panelDELETE
            // 
            this.panelDELETE.Controls.Add(this.cbDeleteWhole);
            this.panelDELETE.Controls.Add(this.label3);
            this.panelDELETE.Controls.Add(this.lbTable2);
            this.panelDELETE.Location = new System.Drawing.Point(173, 42);
            this.panelDELETE.Name = "panelDELETE";
            this.panelDELETE.Size = new System.Drawing.Size(306, 286);
            this.panelDELETE.TabIndex = 3;
            this.panelDELETE.Visible = false;
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
            // 
            // panelSELECT
            // 
            this.panelSELECT.Controls.Add(this.btnSelect);
            this.panelSELECT.Controls.Add(this.label2);
            this.panelSELECT.Controls.Add(this.label1);
            this.panelSELECT.Controls.Add(this.lbTable);
            this.panelSELECT.Controls.Add(this.clbAttribute);
            this.panelSELECT.Location = new System.Drawing.Point(6, 42);
            this.panelSELECT.Name = "panelSELECT";
            this.panelSELECT.Size = new System.Drawing.Size(348, 318);
            this.panelSELECT.TabIndex = 2;
            this.panelSELECT.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(32, 252);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ATTRIBUTES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TABLE";
            // 
            // lbTable
            // 
            this.lbTable.FormattingEnabled = true;
            this.lbTable.Location = new System.Drawing.Point(93, 15);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(120, 95);
            this.lbTable.TabIndex = 1;
            this.lbTable.SelectedIndexChanged += new System.EventHandler(this.lbTable_SelectedIndexChanged);
            // 
            // clbAttribute
            // 
            this.clbAttribute.FormattingEnabled = true;
            this.clbAttribute.Location = new System.Drawing.Point(92, 116);
            this.clbAttribute.Name = "clbAttribute";
            this.clbAttribute.Size = new System.Drawing.Size(120, 94);
            this.clbAttribute.TabIndex = 0;
            // 
            // cbCOMMAND
            // 
            this.cbCOMMAND.FormattingEnabled = true;
            this.cbCOMMAND.Items.AddRange(new object[] {
            "CREATE",
            "DELETE",
            "INSERT",
            "SELECT"});
            this.cbCOMMAND.Location = new System.Drawing.Point(98, 6);
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
            this.tabReponse.Size = new System.Drawing.Size(776, 422);
            this.tabReponse.TabIndex = 2;
            this.tabReponse.Text = "Reponse";
            this.tabReponse.UseVisualStyleBackColor = true;
            // 
            // layoutReponse
            // 
            this.layoutReponse.ColumnCount = 2;
            this.layoutReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutReponse.Location = new System.Drawing.Point(7, 6);
            this.layoutReponse.Name = "layoutReponse";
            this.layoutReponse.RowCount = 1;
            this.layoutReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutReponse.Size = new System.Drawing.Size(474, 248);
            this.layoutReponse.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 451);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabForm.ResumeLayout(false);
            this.panelINSERT.ResumeLayout(false);
            this.panelINSERT.PerformLayout();
            this.panelCREATE.ResumeLayout(false);
            this.panelCREATE.PerformLayout();
            this.panelDELETE.ResumeLayout(false);
            this.panelDELETE.PerformLayout();
            this.panelSELECT.ResumeLayout(false);
            this.panelSELECT.PerformLayout();
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
    }
}

