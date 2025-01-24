using Google.Protobuf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UserKezeles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace User_kezelés
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox4.Text;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Bejelentkezés sikeres!");
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }
        }

        public bool ValidateUser(string username, string password)
        {
            
            string connString = "Server=localhost;Database=user;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM `data` WHERE FirstName AND LastName AND Password";

                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {

                        MySqlCommand cmd = new MySqlCommand(query, conn);


                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {

                            string fname = reader["FirstName"].ToString();
                            string lname = reader["LastName"].ToString();
                            string password = int.Parse(reader["Password"].ToString());
                            string created = reader["CreatedTime"].ToString();
                            string updated = reader["UpdatedTime"].ToString();

                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt: {ex.Message}");
                    return false;
                }
                conn.Close();
            }
        }
    }
}