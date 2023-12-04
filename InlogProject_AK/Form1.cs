using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace InlogProject_AK
{

   
    public partial class Form1 : Form
    {
        private UserSession currentUserSession;
        string connectionString = "Server=127.0.0.1;Port=3306;Database=inlogproject_ak;Uid=root;Pwd=;";
        MySqlConnection conn = null;


        // Your existing code...

        public Form1()
        {
            InitializeComponent();
            currentUserSession = new UserSession();
        }

      
        private MySqlConnection CreateDatabaseConnection()
{
    string connectionString = "Server=127.0.0.1;Port=3306;Database=inlogproject_ak;Uid=root;Pwd=;";
    MySqlConnection conn = new MySqlConnection(connectionString);
    return conn;
}
        public class UserSession
        {
            public string Email { get; set; }
            public string UserRole { get; set; }
        }
        private void lblwachtwoord_Click(object sender, EventArgs e)
        {
        }
    




        private void registerbutton_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
            form2.Show();
        }
        private bool Checklogingegevens(string email, string password)
        {
            try
            {
                using (conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string selectQuery = "SELECT wachtwoord FROM gebruiker WHERE email = @email";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, conn))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        string hashedPasswordFromDatabase = command.ExecuteScalar() as string;

                        if (!string.IsNullOrEmpty(hashedPasswordFromDatabase))
                        {
                            // Hash het ingevoerde wachtwoord
                            string hashedPassword = Hashwachtwoord(password);

                            // Vergelijk het gehashte wachtwoord met het gehashte wachtwoord in de database
                            if (hashedPasswordFromDatabase == hashedPassword)
                            {
                                return true;
                            }
                        }
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private string GetUserRoleByEmail(string email)
        {
            try
            {
                using (conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string selectQuery = "SELECT rol.naam FROM gebruiker AS usr " +
                                         "INNER JOIN rol ON usr.rolid = rol.ID " +
                                         "WHERE usr.email = @email";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, conn))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        object roleName = command.ExecuteScalar();

                        if (roleName != null)
                        {
                            return roleName.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        
         private void SetCurrentUserSession(string email)
        {
            currentUserSession.Email = email;
            currentUserSession.UserRole = GetUserRoleByEmail(email);
        }
        private void Showallegebruikergegevens(string email)
        {
            try
            {
                using (conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string selectQuery = "SELECT usr.email, usr.voornaam, usr.achternaam, usr.klas, rol.naam " +
                                         "FROM gebruiker AS usr " +
                                         "INNER JOIN rol ON usr.rolid = rol.ID " +
                                         "WHERE usr.email = @email";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, conn))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            StringBuilder userData = new StringBuilder();
                            while (reader.Read())
                            {
                                string userEmail = reader["email"].ToString();
                                string voornaam = reader["voornaam"].ToString();
                                string achternaam = reader["achternaam"].ToString();
                                string klas = reader["klas"].ToString();
                                string rolnaam = reader["naam"].ToString();

                                userData.AppendLine("email: " + userEmail);
                                userData.AppendLine("voornaam: " + voornaam);
                                userData.AppendLine("achternaam: " + achternaam);
                                userData.AppendLine("klas: " + klas);
                                userData.AppendLine("rol: " + rolnaam);
                                userData.AppendLine();
                            }

                            // Toon de gebruikersgegevens op het scherm, bijvoorbeeld in een MessageBox
                            MessageBox.Show(userData.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetFormBackgroundColor(string userRole)
        {
            if (userRole == "Admin")
            {
                this.BackColor = Color.LightGreen;
            }
            else if (userRole == "Gebruiker")
            {
                this.BackColor = Color.LightBlue;
            }
        }
        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtemail.Text;
                string password = wachtwoord.Text;

                bool loginSuccessful = Checklogingegevens(email, password);

                if (loginSuccessful)
                {
                    string userRole = GetUserRoleByEmail(email);

                    if (!string.IsNullOrEmpty(userRole))
                    {
                        SetCurrentUserSession(email); // Set the user session

                        MessageBox.Show("Inloggen gelukt! Rol: " + userRole);
                        Showallegebruikergegevens(email);
                        SetFormBackgroundColor(userRole);

                    }
                    else
                    {
                        MessageBox.Show("Ongeldige inloggegevens.");
                    }
                }
                else
                {
                    MessageBox.Show("Ongeldige inloggegevens.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string Hashwachtwoord(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        
    }
}
