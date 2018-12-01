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
    public partial class Form10 : Form
    {
        private Form3 frm3;
        string R_num_;
        public Form10(string R_num)
        {
            InitializeComponent();
            R_num_ = R_num;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            WinAPI.AnimateWindow(this.Handle, 250, WinAPI.VER_POSITIVE);
        }

        private void Door_width_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(R_num_);
            this.Hide();
            frm4.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string type = Door_width.Text;
            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987");
            myConnection.Open();

            SqlCommand cmd2 = myConnection.CreateCommand();

            cmd2.CommandText = @"insert into Architectural_Data (R_number,Door_width) values('" + R_num_ + "', '" + type + "')";
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = myConnection.CreateCommand();

            cmd3.CommandText = @"UPDATE Architectural_Data Set Racks = '" + Racks.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = myConnection.CreateCommand();

            cmd4.CommandText = @"UPDATE Architectural_Data Set Hooks = '" + Hooks.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = myConnection.CreateCommand();

            cmd5.CommandText = @"UPDATE Architectural_Data Set Boards = '" + Boards.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd5.ExecuteNonQuery();

            SqlCommand cmd6 = myConnection.CreateCommand();

            cmd6.CommandText = @"UPDATE Architectural_Data Set Tracks = '" + Tracks.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd6.ExecuteNonQuery();

            SqlCommand cmd7 = myConnection.CreateCommand();

            cmd7.CommandText = @"UPDATE Architectural_Data Set Rails = '" + Rails.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd7.ExecuteNonQuery();

            SqlCommand cmd8 = myConnection.CreateCommand();

            cmd8.CommandText = @"Insert into Mechanical_Data (R_number,Temperature) values('" + R_num_ + "', '" + Temperature.Text + "')";
            cmd8.ExecuteNonQuery();

            SqlCommand cmd9 = myConnection.CreateCommand();

            cmd9.CommandText = @"UPDATE Mechanical_Data Set Humidity = '" + Humidity.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd9.ExecuteNonQuery();

            SqlCommand cmd10 = myConnection.CreateCommand();

            cmd10.CommandText = @"UPDATE Mechanical_Data Set Pressure = '" + Pressure.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd10.ExecuteNonQuery();

            SqlCommand cmd11 = myConnection.CreateCommand();

            cmd11.CommandText = @"Insert into Fixture (R_number,Fixture_Fittings) values('" + R_num_ + "', '" + Fixture_Fittings.Text + "')";
            cmd11.ExecuteNonQuery();

            SqlCommand cmd12 = myConnection.CreateCommand();

            cmd12.CommandText = @"UPDATE Mechanical_Data Set Ventillation = '" + Ventilation.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd12.ExecuteNonQuery();

            SqlCommand cmd13 = myConnection.CreateCommand();

            cmd13.CommandText = @"UPDATE Mechanical_Data Set Air_returend = '" + Air_returend.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd13.ExecuteNonQuery();

            SqlCommand cmd14 = myConnection.CreateCommand();

            cmd14.CommandText = @"UPDATE Architectural_Data Set Door_lock = '" + Door_lock.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd14.ExecuteNonQuery();

            SqlCommand cmd15 = myConnection.CreateCommand();

            cmd15.CommandText = @"UPDATE Architectural_Data Set Door_Material = '" + Door_Material.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd15.ExecuteNonQuery();

            SqlCommand cmd16 = myConnection.CreateCommand();

            cmd16.CommandText = @"UPDATE Fixture Set Accessories = '" + Accessories.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd16.ExecuteNonQuery();

            SqlCommand cmd17 = myConnection.CreateCommand();

            cmd17.CommandText = @"UPDATE Architectural_Data Set Ceiling = '" + Ceiling.Text + "' WHERE R_number = '" + R_num_ + "'";
            cmd17.ExecuteNonQuery();

            MessageBox.Show("Data added sucessfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
