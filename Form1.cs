using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace user_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Connect conn = new Connect();

        private void button1_Click(object sender, EventArgs e)
        {
            string[] darabol = textBox1.Text.Split(' ');
            if (beleptet(darabol[1], darabol[0], textBox2.Text) == true)
            {
                MessageBox.Show("Regisztrált tag");
            }
            else
            {
                
            }
        }

        private bool beleptet(string firstName,string lastName, string pass)
        {
            conn.Connection.Open();
            string sql = $"SELECT `Id` FROM `data` WHERE FirstName = '{firstName}' AND LastName = '{lastName}' AND Password = '{pass}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);
            MySqlDataReader dr = cmd.ExecuteReader();
            bool van = dr.Read();
            conn.Connection.Close();
            return van;
        }

        private string regisztral(string firstName, string lastName, string pass)
        {
            conn.Connection.Open() ;
            string sql =$"INSERT INTO `data`(`FirstName`, `LastName`, `Password`, `CreatedTime`, `UpdatedTime`) VALUES ('{firstName}','{lastName}','{pass}','{DateTime.Now.ToString("yyyy-MM-dd")}','{DateTime.Now.ToString("yyyy-MM-dd")}')";
            MySqlCommand cmd = new MySqlCommand( sql, conn.Connection );

            var result = cmd.ExecuteNonQuery();

            
            conn.Connection.Close();
            return result > 0 ? "Sikeres regisztráció" : "Sikertelen Regisztráció";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regisztral(textBox3.Text, textBox4.Text, textBox5.Text);
            MessageBox.Show("Sikeres regisztráció");

        }
    }   

}
