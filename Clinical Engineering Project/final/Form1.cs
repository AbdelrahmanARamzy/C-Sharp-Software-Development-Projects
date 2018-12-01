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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987");
            myConnection.Open();
            SqlCommand cmd = myConnection.CreateCommand();
            cmd.CommandText = @"SELECT [User_ID],[User_password]
                                FROM [dbo].[Users]
            WHERE [User_ID]='" + textBox1.Text + "' and [User_Password]='" + textBox2.Text + "'";

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                // MessageBox.Show("Welcome");
                //Form2 objForm2 = new Form2();
                //objForm2.Show();

                timer2.Start();

            }
            else
                MessageBox.Show("Invalid username or password");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            WinAPI.AnimateWindow(this.Handle, 150, WinAPI.BLEND);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Environment.Exit(1);
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
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
