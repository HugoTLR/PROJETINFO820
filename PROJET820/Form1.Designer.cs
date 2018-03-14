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
            this.tabForm = new System.Windows.Forms.TabPage();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labLogin = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.cbCOMMAND = new System.Windows.Forms.ComboBox();
            this.layoutCreate = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.layoutCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabForm);
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 448);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabLogin
            // 
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
            // tabForm
            // 
            this.tabForm.Controls.Add(this.layoutCreate);
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
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(395, 101);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(338, 201);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // labLogin
            // 
            this.labLogin.AutoSize = true;
            this.labLogin.Location = new System.Drawing.Point(273, 101);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(35, 13);
            this.labLogin.TabIndex = 2;
            this.labLogin.Text = "login :";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(216, 204);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(58, 13);
            this.labPassword.TabIndex = 3;
            this.labPassword.Text = "password :";
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(448, 316);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.Text = "Connexion";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
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
            this.cbCOMMAND.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // layoutCreate
            // 
            this.layoutCreate.Controls.Add(this.textBox1);
            this.layoutCreate.Location = new System.Drawing.Point(19, 55);
            this.layoutCreate.Name = "layoutCreate";
            this.layoutCreate.Size = new System.Drawing.Size(751, 343);
            this.layoutCreate.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
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
            this.layoutCreate.ResumeLayout(false);
            this.layoutCreate.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel layoutCreate;
        private System.Windows.Forms.TextBox textBox1;
    }
}

