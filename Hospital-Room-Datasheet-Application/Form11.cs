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
    public partial class Form11 : Form
    {
        private Form12 frm12;
        private Form2 frm2;
        public Form11()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Tnum1 = int.Parse(textBox6.Text);
            int Tnum2 = int.Parse(textBox7.Text);
            int Tnum3 = int.Parse(textBox8.Text);
            int Tnum4 = int.Parse(textBox9.Text);
            int Tnum5 = int.Parse(textBox10.Text);
            int Tnum6 = int.Parse(textBox11.Text);
            int Tnum7 = int.Parse(textBox12.Text);
            int Tnum8 = int.Parse(textBox13.Text);


            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_Datasheet;User ID=clinical;Password=321654987");
            myConnection.Open();

            if ((Tnum1 < 24 && Tnum1 > 1) && (Tnum2 < 7 && Tnum2 > 1) && (Tnum3 < 5 && Tnum3 > 1) && (Tnum4 < 10 && Tnum4 > 1) && (Tnum5 < 10 && Tnum5 > 1) && (Tnum6 < 20 && Tnum6 > 1) && (Tnum7 < 4 && Tnum7 > 1) && (Tnum8 < 7 && Tnum8 > 1))
            {
                SqlCommand cmd1 = myConnection.CreateCommand();
                cmd1.CommandText = @" insert into Room_Information (R_number,Area,Department,R_Function,use_time,use_days,normal_no_of_patients,max_no_of_patients,normal_no_of_occupants,max_no_of_occupants,normal_no_of_staff,max_no_of_staff)
                                values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "')";

                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = myConnection.CreateCommand();
                cmd2.CommandText = @" insert into Additional_items (R_number,Equipment_item,Equipment_number,Furniture_items,Furniture_number,Millwork_items)
                                 values ('" + textBox2.Text + "','" + textBox17.Text + "','" + textBox16.Text + "','" + textBox15.Text + "','" + textBox14.Text + "','" + textBox1.Text + "')";
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = myConnection.CreateCommand();
                cmd3.CommandText = @" insert into Architectural_Data (R_number,Mirrors_width,Mirrors_height)
                                 values ('" + textBox2.Text + "','" + textBox19.Text + "','" + textBox18.Text + "')";
                cmd3.ExecuteNonQuery();

                /*SqlCommand cmd4 = myConnection.CreateCommand();
                cmd4.CommandText = @" insert into Communications_Data (R_number,Computer_Printer,Computer_Terminal,Other)
                                 values ('" + textBox2.Text + "','" + textBox22.Text + "','" + textBox21.Text + "','" + textBox20.Text + "')";
                cmd4.ExecuteNonQuery();

                SqlCommand cmd5 = myConnection.CreateCommand();
                cmd5.CommandText = @" insert into Ceiling_Finishes (R_number,Height)
                                 values ('" + textBox2.Text + "','" + textBox23.Text + "')";
                cmd5.ExecuteNonQuery();*/

                SqlCommand cmd6 = myConnection.CreateCommand();
                cmd6.CommandText = @" insert into Clock_System (R_number)
                                 values ('" + textBox2.Text + "')";
                cmd6.ExecuteNonQuery();

                SqlCommand cmd7 = myConnection.CreateCommand();
                cmd7.CommandText = @" insert into Alarm_Detection (R_number)
                                 values ('" + textBox2.Text + "')";
                cmd7.ExecuteNonQuery();

                this.Hide();
                Form12 frm12 = new Form12(textBox2.Text);
                frm12.Show();

            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            WinAPI.AnimateWindow(this.Handle, 250, WinAPI.VER_POSITIVE);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
