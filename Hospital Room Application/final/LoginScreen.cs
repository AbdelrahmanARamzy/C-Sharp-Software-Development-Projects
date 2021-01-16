using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final
{
    public partial class LoginScreen : Form
    {
        SqlConnection myConnection;

        public LoginScreen()
        {
            this.InitializeComponent();

            this.myConnection = new SqlConnection(Program.ConnectionString);
            this.myConnection.Open();
            this.textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var command = this.myConnection.CreateCommand();
            command.CommandText = @"SELECT [User_ID],[User_password]
                                FROM [dbo].[Users]
                                WHERE [User_ID]='" + this.textBox1.Text + "' and [User_Password]='" + this.textBox2.Text + "'";

            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                this.timer2.Start();
            }
            else
            {
                MessageBox.Show("Invalid username or password...");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.45;
                return;
            }

            this.timer1.Stop();
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.45;
                return;
            }

            this.Hide();
            Form2 mainScreen = new Form2();
            mainScreen.Show();
            this.timer2.Stop();
        }
    }
}
