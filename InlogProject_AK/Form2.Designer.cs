using System;

namespace InlogProject_AK
{
    partial class Form2
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
            this.emailreg = new System.Windows.Forms.TextBox();
            this.wachtwoordreg = new System.Windows.Forms.TextBox();
            this.naamreg = new System.Windows.Forms.TextBox();
            this.achternaamreg = new System.Windows.Forms.TextBox();
            this.klasreg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailreg
            // 
            this.emailreg.Location = new System.Drawing.Point(198, 92);
            this.emailreg.Name = "emailreg";
            this.emailreg.Size = new System.Drawing.Size(117, 22);
            this.emailreg.TabIndex = 0;
            this.emailreg.TextChanged += new System.EventHandler(this.emailreg_TextChanged);
            // 
            // wachtwoordreg
            // 
            this.wachtwoordreg.Location = new System.Drawing.Point(198, 120);
            this.wachtwoordreg.Name = "wachtwoordreg";
            this.wachtwoordreg.Size = new System.Drawing.Size(117, 22);
            this.wachtwoordreg.TabIndex = 1;
            this.wachtwoordreg.TextChanged += new System.EventHandler(this.wachtwoordreg_TextChanged);
            // 
            // naamreg
            // 
            this.naamreg.Location = new System.Drawing.Point(198, 148);
            this.naamreg.Name = "naamreg";
            this.naamreg.Size = new System.Drawing.Size(117, 22);
            this.naamreg.TabIndex = 2;
            this.naamreg.TextChanged += new System.EventHandler(this.naamreg_TextChanged);
            // 
            // achternaamreg
            // 
            this.achternaamreg.Location = new System.Drawing.Point(198, 176);
            this.achternaamreg.Name = "achternaamreg";
            this.achternaamreg.Size = new System.Drawing.Size(117, 22);
            this.achternaamreg.TabIndex = 3;
            this.achternaamreg.TextChanged += new System.EventHandler(this.achternaamreg_TextChanged);
            // 
            // klasreg
            // 
            this.klasreg.Location = new System.Drawing.Point(198, 207);
            this.klasreg.Name = "klasreg";
            this.klasreg.Size = new System.Drawing.Size(117, 22);
            this.klasreg.TabIndex = 4;
            this.klasreg.TextChanged += new System.EventHandler(this.klasreg_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wachtwoord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Achternaam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "klas";
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(198, 265);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 10;
            this.btnreg.Text = "register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(198, 331);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klasreg);
            this.Controls.Add(this.achternaamreg);
            this.Controls.Add(this.naamreg);
            this.Controls.Add(this.wachtwoordreg);
            this.Controls.Add(this.emailreg);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.TextBox emailreg;
        private System.Windows.Forms.TextBox wachtwoordreg;
        private System.Windows.Forms.TextBox naamreg;
        private System.Windows.Forms.TextBox achternaamreg;
        private System.Windows.Forms.TextBox klasreg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnLogin;
    }
}