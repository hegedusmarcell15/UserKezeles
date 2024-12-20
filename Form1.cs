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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connString = "Server=localhost;Database=user;Uid=root;Pwd=;";

  
            string query = "SELECT * FROM `data`";


            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();


                    MySqlCommand cmd = new MySqlCommand(query, conn);


                    MySqlDataReader reader = cmd.ExecuteReader();


                    listBox1.Items.Clear();


                    while (reader.Read())
                    {

                        string fname = reader["FirstName"].ToString();
                        string lname = reader["LastName"].ToString();
                        int password = int.Parse(reader["Password"].ToString());
                        string created = reader["CreatedTime"].ToString();
                        string updated = reader["UpdatedTime"].ToString();



                        string displayText = $"Vezetéknév: {fname}, Keresztnév: {lname}, Jelszava: {password}, Adatbázisba felvéve: {created}, Módosítva: {updated}";


                        listBox1.Items.Add(displayText);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt: " + ex.Message);
                }
                conn.Close();
            }
        }
    }
}
   
