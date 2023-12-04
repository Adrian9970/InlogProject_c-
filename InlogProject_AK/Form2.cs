using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InlogProject_AK
{
    public partial class Form2 : Form
    {
        string connectionString = "Server=127.0.0.1;Port=3306;Database=inlogproject_ak;Uid=root;Pwd=;";
        MySqlConnection conn = null;


       
        string insertQuery = "INSERT INTO gebruiker (email, wachtwoord, voornaam, achternaam, klas, rolid) VALUES (@value1, @value2, @value3, @value4, @value5, 2)";

        public Form2()
        {
            InitializeComponent();
            {
                try
                {
                    conn = new MySqlConnection(connectionString);
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void klasreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void achternaamreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void naamreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void wachtwoordreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailreg_TextChanged(object sender, EventArgs e)
        {

        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));

                return builder.ToString();
            }
        }
        private void btnreg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailreg.Text) || string.IsNullOrWhiteSpace(wachtwoordreg.Text) ||
               string.IsNullOrWhiteSpace(naamreg.Text) || string.IsNullOrWhiteSpace(achternaamreg.Text) ||
               string.IsNullOrWhiteSpace(klasreg.Text)
            ){
                MessageBox.Show("Vul alle vereiste velden in voordat je registreert.");
            }
            else
            {
                try
                {
                    using (conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                        {
                            // Hash van wachtwoord
                            string hashedPassword = HashPassword(wachtwoordreg.Text);

                            command.Parameters.AddWithValue("@value1", emailreg.Text);
                            command.Parameters.AddWithValue("@value2", hashedPassword); // Voeg het gehashte wachtwoord 
                            command.Parameters.AddWithValue("@value3", naamreg.Text);
                            command.Parameters.AddWithValue("@value4", achternaamreg.Text);
                            command.Parameters.AddWithValue("@value5", klasreg.Text);



                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registratie gelukt.Klik OK om terug te gaan naar inlogscherm");
                                this.Close();
                                Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                                if (form1 != null)
                                {
                                    form1.Show();
                                    form1.BringToFront();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Registratie niet.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout tijdens registratie van uw account:" + ex.Message);
                }
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Show();
                form1.BringToFront();
            }
        }
    }

     }
    

