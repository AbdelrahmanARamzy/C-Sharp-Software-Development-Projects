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
using System.Data.SqlTypes;

namespace final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            WinAPI.AnimateWindow(this.Handle, 150, WinAPI.BLEND);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987");
            myConnection.Open();
            SqlCommand cmd = myConnection.CreateCommand();
            cmd.CommandText = @"SELECT [User_ID],[User_password]
                                FROM [dbo].[Users]
            WHERE [User_ID]='" + textBox1.Text + "' and [User_Password]='" + textBox2.Text + "'";

            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("Invalid username or password!");
                return;
            }

            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.45;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.45;
            }
            else
            {
                this.Hide();
                Form2 objForm2 = new Form2();
                objForm2.Show();
                timer2.Stop();
            }
        }
    }
}
