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
    public partial class Form12 : Form
    {
        private Form11 frm11;
        private Form3 frm3;
        string R_num_;

        public Form12(string R_num)
        {
            InitializeComponent();
            R_num_ = R_num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_Datasheet;User ID=clinical;Password=321654987");
            myConnection.Open();
            SqlCommand cmd1 = myConnection.CreateCommand();
            cmd1.CommandText = @" insert into Drainage (R_number)
                                values ('" + R_num_ + "')";

            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = myConnection.CreateCommand();
            cmd2.CommandText = @" insert into Electrical_Door (R_number)
                                values ('" + R_num_ + "')";

            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = myConnection.CreateCommand();
            cmd3.CommandText = @" insert into Fixture (R_number,Single_Bowl_Sink_length,Single_Bowl_Sink_width,Single_Bowl_Sink_height,Double_Bowl_Sink_length,Double_Bowl_Sink_Width,Double_Bowl_Sink_height)
                                 values ('" + R_num_ + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = myConnection.CreateCommand();
            cmd4.CommandText = @" insert into Floor_Finishes (R_number)
                                 values ('" + R_num_ + "')";
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = myConnection.CreateCommand();
            cmd5.CommandText = @" insert into Gas (R_number)
                                 values ('" + R_num_ + "')";
            cmd5.ExecuteNonQuery();

            SqlCommand cmd7 = myConnection.CreateCommand();
            cmd7.CommandText = @" insert into Mechanical_Data (R_number)
                                 values ('" + R_num_ + "')";
            cmd7.ExecuteNonQuery();

            this.Hide();
            Form3 frm3 = new Form3(R_num_);
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 frm11 = new Form11();
            frm11.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            WinAPI.AnimateWindow(this.Handle, 250, WinAPI.VER_POSITIVE);
        }
    }
}
