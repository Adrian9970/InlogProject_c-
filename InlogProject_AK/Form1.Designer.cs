namespace InlogProject_AK
{
    partial class Form1
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
            this.txtemail = new System.Windows.Forms.TextBox();
            this.wachtwoord = new System.Windows.Forms.TextBox();
            this.registerbutton = new System.Windows.Forms.Button();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblwachtwoord = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(275, 108);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(224, 22);
            this.txtemail.TabIndex = 0;
            // 
            // wachtwoord
            // 
            this.wachtwoord.Location = new System.Drawing.Point(275, 178);
            this.wachtwoord.Name = "wachtwoord";
            this.wachtwoord.PasswordChar = '*';
            this.wachtwoord.Size = new System.Drawing.Size(224, 22);
            this.wachtwoord.TabIndex = 1;
            // 
            // registerbutton
            // 
            this.registerbutton.Location = new System.Drawing.Point(275, 264);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(75, 29);
            this.registerbutton.TabIndex = 3;
            this.registerbutton.Text = "register";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(208, 114);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(40, 16);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "email";
            // 
            // lblwachtwoord
            // 
            this.lblwachtwoord.AutoSize = true;
            this.lblwachtwoord.Location = new System.Drawing.Point(191, 178);
            this.lblwachtwoord.Name = "lblwachtwoord";
            this.lblwachtwoord.Size = new System.Drawing.Size(78, 16);
            this.lblwachtwoord.TabIndex = 5;
            this.lblwachtwoord.Text = "wachtwoord";
            this.lblwachtwoord.Click += new System.EventHandler(this.lblwachtwoord_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(275, 216);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 29);
            this.login.TabIndex = 6;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lblwachtwoord);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.wachtwoord);
            this.Controls.Add(this.txtemail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox wachtwoord;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblwachtwoord;
        private System.Windows.Forms.Button login;
    }
}

