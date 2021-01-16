using System;
using System.Windows.Forms;

namespace final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RoomInfoScreen roomInfoScreen = new RoomInfoScreen();
            roomInfoScreen.Show();     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.25;
                return;
            }

            this.timer1.Stop();
            Application.Exit();
        }
    }
}   