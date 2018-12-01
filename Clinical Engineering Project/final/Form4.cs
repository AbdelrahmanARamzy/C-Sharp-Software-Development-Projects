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
    public partial class Form4 : Form
    {
        private Form3 frm3;
        private Form10 frm10;
        string R_Num;
        public Form4(string R_num)
        {
            InitializeComponent();
            R_Num = R_num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987");
            myConnection.Open();
            ///////////////////////

            SqlCommand cmd1 = myConnection.CreateCommand();
            cmd1.CommandText = @" insert into Drainage (R_number) values ('" + R_Num + "')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = myConnection.CreateCommand();
            cmd2.CommandText = @" insert into Gas (R_number) values ('" + R_Num + "')";
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = myConnection.CreateCommand();
            cmd3.CommandText = @" insert into Communications_Data (R_number) values ('" + R_Num + "')";
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = myConnection.CreateCommand();
            cmd4.CommandText = @" insert into Floor_Finishes (R_number) values ('" + R_Num + "')";
            cmd4.ExecuteNonQuery();
            ////////////////////////////



            SqlCommand cmd5 = myConnection.CreateCommand();
            if (checkBox10.Checked == true)
            {
                cmd5.CommandText = @"UPDATE Drainage Set Sanitary = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd5.CommandText = @"UPDATE Drainage Set Sanitary = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd5.ExecuteNonQuery();

            SqlCommand cmd6 = myConnection.CreateCommand();
            if (checkBox9.Checked == true)
            {
                cmd6.CommandText = @"UPDATE Drainage Set Acid = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd6.CommandText = @"UPDATE Drainage Set Acid = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd6.ExecuteNonQuery();

            SqlCommand cmd7 = myConnection.CreateCommand();
            if (checkBox8.Checked == true)
            {
                cmd7.CommandText = @"UPDATE Drainage Set Radioisotopes = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd7.CommandText = @"UPDATE Drainage Set Radioisotopes = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd7.ExecuteNonQuery();

            SqlCommand cmd8 = myConnection.CreateCommand();
            if (checkBox7.Checked == true)
            {
                cmd8.CommandText = @"UPDATE Drainage Set Grease = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd8.CommandText = @"UPDATE Drainage Set Grease = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd8.ExecuteNonQuery();

            SqlCommand cmd9 = myConnection.CreateCommand();
            if (checkBox6.Checked == true)
            {
                cmd9.CommandText = @"UPDATE Drainage Set Oil = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd9.CommandText = @"UPDATE Drainage Set Oil = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd9.ExecuteNonQuery();

            SqlCommand cmd10 = myConnection.CreateCommand();
            if (checkBox11.Checked == true)
            {
                cmd10.CommandText = @"UPDATE Drainage Set Solvents = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd10.CommandText = @"UPDATE Drainage Set Solvents = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd10.ExecuteNonQuery();

            SqlCommand cmd11 = myConnection.CreateCommand();
            if (checkBox12.Checked == true)
            {
                cmd11.CommandText = @"UPDATE Drainage Set Plaster = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd11.CommandText = @"UPDATE Drainage Set Plaster = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd11.ExecuteNonQuery();

            SqlCommand cmd12 = myConnection.CreateCommand();
            if (checkBox13.Checked == true)
            {
                cmd12.CommandText = @"UPDATE Drainage Set Floor_Drain = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd12.CommandText = @"UPDATE Drainage Set Floor_Drain = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd12.ExecuteNonQuery();

            SqlCommand cmd13 = myConnection.CreateCommand();
            if (checkBox14.Checked == true)
            {
                cmd13.CommandText = @"UPDATE Drainage Set Housekeeping_Vacuum = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd13.CommandText = @"UPDATE Drainage Set Housekeeping_Vacuum = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd13.ExecuteNonQuery();

            /////////////////////////////////////



            SqlCommand cmd14 = myConnection.CreateCommand();
            if (checkBox42.Checked == true)
            {
                cmd14.CommandText = @"UPDATE Gas Set Medical_Vacuum = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd14.CommandText = @"UPDATE Gas Set Medical_Vacuum = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd14.ExecuteNonQuery();

            SqlCommand cmd15 = myConnection.CreateCommand();
            if (checkBox41.Checked == true)
            {
                cmd15.CommandText = @"UPDATE Gas Set Medical_Oxygen = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd15.CommandText = @"UPDATE Gas Set Medical_Oxygen = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd15.ExecuteNonQuery();

            SqlCommand cmd16 = myConnection.CreateCommand();
            if (checkBox40.Checked == true)
            {
                cmd16.CommandText = @"UPDATE Gas Set Laboratory_Vacuum = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd16.CommandText = @"UPDATE Gas Set Laboratory_Vacuum = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd16.ExecuteNonQuery();

            SqlCommand cmd17 = myConnection.CreateCommand();
            if (checkBox39.Checked == true)
            {
                cmd17.CommandText = @"UPDATE Gas Set Medical_Air = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd17.CommandText = @"UPDATE Gas Set Medical_Air = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd17.ExecuteNonQuery();

            SqlCommand cmd18 = myConnection.CreateCommand();
            if (checkBox38.Checked == true)
            {
                cmd18.CommandText = @"UPDATE Gas Set Medical_Nitrous_Oxide = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd18.CommandText = @"UPDATE Gas Set Medical_Nitrous_Oxide = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd18.ExecuteNonQuery();

            SqlCommand cmd19 = myConnection.CreateCommand();
            if (checkBox37.Checked == true)
            {
                cmd19.CommandText = @"UPDATE Gas Set Laboratory_Compressed_Air = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd19.CommandText = @"UPDATE Gas Set Laboratory_Compressed_Air = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd19.ExecuteNonQuery();

            SqlCommand cmd20 = myConnection.CreateCommand();
            if (checkBox36.Checked == true)
            {
                cmd20.CommandText = @"UPDATE Gas Set Medical_Nitrogen = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd20.CommandText = @"UPDATE Gas Set Medical_Nitrogen = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd20.ExecuteNonQuery();

            SqlCommand cmd21 = myConnection.CreateCommand();
            if (checkBox35.Checked == true)
            {
                cmd21.CommandText = @"UPDATE Gas Set Natural_Gas = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd21.CommandText = @"UPDATE Gas Set Natural_Gas = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd21.ExecuteNonQuery();

            SqlCommand cmd22 = myConnection.CreateCommand();
            if (checkBox34.Checked == true)
            {
                cmd22.CommandText = @"UPDATE Gas Set Shop_Compressed_Air = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd22.CommandText = @"UPDATE Gas Set Shop_Compressed_Air = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd22.ExecuteNonQuery();

            //////////////////////////////


            SqlCommand cmd23 = myConnection.CreateCommand();
            if (checkBox15.Checked == true)
            {
                cmd23.CommandText = @"UPDATE Communications_Data Set Bedhead_Consoles = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd23.CommandText = @"UPDATE Communications_Data Set Bedhead_Consoles = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd23.ExecuteNonQuery();

            SqlCommand cmd24 = myConnection.CreateCommand();
            if (checkBox17.Checked == true)
            {
                cmd24.CommandText = @"UPDATE Communications_Data Set Closed_Circuit_TV = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd24.CommandText = @"UPDATE Communications_Data Set Closed_Circuit_TV = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd24.ExecuteNonQuery();

            SqlCommand cmd25 = myConnection.CreateCommand();
            if (checkBox16.Checked == true)
            {
                cmd25.CommandText = @"UPDATE Communications_Data Set Computer_Terminal = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd25.CommandText = @"UPDATE Communications_Data Set Computer_Terminal = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd25.ExecuteNonQuery();

            SqlCommand cmd26 = myConnection.CreateCommand();
            if (checkBox18.Checked == true)
            {
                cmd26.CommandText = @"UPDATE Communications_Data Set Computer_Printer = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd26.CommandText = @"UPDATE Communications_Data Set Computer_Printer = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd26.ExecuteNonQuery();

            SqlCommand cmd27 = myConnection.CreateCommand();
            if (checkBox19.Checked == true)
            {
                cmd27.CommandText = @"UPDATE Communications_Data Set Call_System_Emergency = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd27.CommandText = @"UPDATE Communications_Data Set Call_System_Emergency = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd27.ExecuteNonQuery();

            SqlCommand cmd28 = myConnection.CreateCommand();
            if (checkBox20.Checked == true)
            {
                cmd28.CommandText = @"UPDATE Communications_Data Set Call_System_Audio = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd28.CommandText = @"UPDATE Communications_Data Set Call_System_Audio = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd28.ExecuteNonQuery();

            SqlCommand cmd29 = myConnection.CreateCommand();
            if (checkBox21.Checked == true)
            {
                cmd29.CommandText = @"UPDATE Communications_Data Set Call_System_Audio_Visual = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd29.CommandText = @"UPDATE Communications_Data Set Call_System_Audio_Visual = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd29.ExecuteNonQuery();

            SqlCommand cmd30 = myConnection.CreateCommand();
            if (checkBox22.Checked == true)
            {
                cmd30.CommandText = @"UPDATE Communications_Data Set Patient_Monitoring = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd30.CommandText = @"UPDATE Communications_Data Set Patient_Monitoring = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd30.ExecuteNonQuery();

            SqlCommand cmd31 = myConnection.CreateCommand();
            if (checkBox23.Checked == true)
            {
                cmd31.CommandText = @"UPDATE Communications_Data Set Code_Blue_Cardiac = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd31.CommandText = @"UPDATE Communications_Data Set Code_Blue_Cardiac = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd31.ExecuteNonQuery();

            SqlCommand cmd32 = myConnection.CreateCommand();
            if (checkBox24.Checked == true)
            {
                cmd32.CommandText = @"UPDATE Communications_Data Set Code_White_Panic = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd32.CommandText = @"UPDATE Communications_Data Set Code_White_Panic = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd32.ExecuteNonQuery();

            SqlCommand cmd33 = myConnection.CreateCommand();
            if (checkBox25.Checked == true)
            {
                cmd33.CommandText = @"UPDATE Communications_Data Set Telephone = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd33.CommandText = @"UPDATE Communications_Data Set Telephone = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd33.ExecuteNonQuery();

            SqlCommand cmd34 = myConnection.CreateCommand();
            if (checkBox26.Checked == true)
            {
                cmd34.CommandText = @"UPDATE Communications_Data Set Dictation = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd34.CommandText = @"UPDATE Communications_Data Set Dictation = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd34.ExecuteNonQuery();

            SqlCommand cmd35 = myConnection.CreateCommand();
            if (checkBox27.Checked == true)
            {
                cmd35.CommandText = @"UPDATE Communications_Data Set Intercom = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd35.CommandText = @"UPDATE Communications_Data Set Intercom = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd35.ExecuteNonQuery();

            SqlCommand cmd36 = myConnection.CreateCommand();
            if (checkBox28.Checked == true)
            {
                cmd36.CommandText = @"UPDATE Communications_Data Set Television = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd36.CommandText = @"UPDATE Communications_Data Set Television = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd36.ExecuteNonQuery();

            SqlCommand cmd37 = myConnection.CreateCommand();
            if (checkBox29.Checked == true)
            {
                cmd37.CommandText = @"UPDATE Communications_Data Set Data = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd37.CommandText = @"UPDATE Communications_Data Set Data = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd37.ExecuteNonQuery();

            SqlCommand cmd38 = myConnection.CreateCommand();
            if (checkBox30.Checked == true)
            {
                cmd38.CommandText = @"UPDATE Communications_Data Set Security_TV = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd38.CommandText = @"UPDATE Communications_Data Set Security_TV = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd38.ExecuteNonQuery();

            SqlCommand cmd39 = myConnection.CreateCommand();
            if (checkBox31.Checked == true)
            {
                cmd39.CommandText = @"UPDATE Communications_Data Set Access_Control = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd39.CommandText = @"UPDATE Communications_Data Set Access_Control = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd39.ExecuteNonQuery();

            SqlCommand cmd40 = myConnection.CreateCommand();
            if (checkBox32.Checked == true)
            {
                cmd40.CommandText = @"UPDATE Communications_Data Set Pocket_Paging = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd40.CommandText = @"UPDATE Communications_Data Set Pocket_Paging = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd40.ExecuteNonQuery();

            SqlCommand cmd41 = myConnection.CreateCommand();
            if (checkBox33.Checked == true)
            {
                cmd41.CommandText = @"UPDATE Communications_Data Set Public_Address = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd41.CommandText = @"UPDATE Communications_Data Set Public_Address = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd41.ExecuteNonQuery();

            /////////////////////////////////////////////////////



            SqlCommand cmd42 = myConnection.CreateCommand();
            if (checkBox1.Checked == true)
            {
                cmd42.CommandText = @"UPDATE Floor_Finishes Set Water_Impervious = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd42.CommandText = @"UPDATE Floor_Finishes Set Water_Impervious = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd42.ExecuteNonQuery();

            SqlCommand cmd43 = myConnection.CreateCommand();
            if (checkBox2.Checked == true)
            {
                cmd43.CommandText = @"UPDATE Floor_Finishes Set Resilient = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd43.CommandText = @"UPDATE Floor_Finishes Set Resilient = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd43.ExecuteNonQuery();

            SqlCommand cmd44 = myConnection.CreateCommand();
            if (checkBox3.Checked == true)
            {
                cmd44.CommandText = @"UPDATE Floor_Finishes Set Carpet = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd44.CommandText = @"UPDATE Floor_Finishes Set Carpet = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd44.ExecuteNonQuery();

            SqlCommand cmd45 = myConnection.CreateCommand();
            if (checkBox4.Checked == true)
            {
                cmd45.CommandText = @"UPDATE Floor_Finishes Set Chemical_Resistant = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd45.CommandText = @"UPDATE Floor_Finishes Set Chemical_Resistant = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd45.ExecuteNonQuery();

            SqlCommand cmd46 = myConnection.CreateCommand();
            if (checkBox5.Checked == true)
            {
                cmd46.CommandText = @"UPDATE Floor_Finishes Set Non_skid = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd46.CommandText = @"UPDATE Floor_Finishes Set Non_skid = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd46.ExecuteNonQuery();

            Form10 frm10 = new Form10(R_Num);
            this.Hide();
            frm10.Show();
            /////////////////////////////////
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3(R_Num);
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            checkBox1.BackColor = Color.Transparent;
            checkBox2.BackColor = Color.Transparent;
            checkBox3.BackColor = Color.Transparent;
            checkBox4.BackColor = Color.Transparent;
            checkBox5.BackColor = Color.Transparent;
            checkBox6.BackColor = Color.Transparent;
            checkBox7.BackColor = Color.Transparent;
            checkBox8.BackColor = Color.Transparent;
            checkBox9.BackColor = Color.Transparent;
            checkBox10.BackColor = Color.Transparent;
            checkBox11.BackColor = Color.Transparent;
            checkBox12.BackColor = Color.Transparent;
            checkBox13.BackColor = Color.Transparent;
            checkBox14.BackColor = Color.Transparent;
            checkBox15.BackColor = Color.Transparent;
            checkBox16.BackColor = Color.Transparent;
            checkBox17.BackColor = Color.Transparent;
            checkBox18.BackColor = Color.Transparent;
            checkBox19.BackColor = Color.Transparent;
            checkBox20.BackColor = Color.Transparent;
            checkBox21.BackColor = Color.Transparent;
            checkBox22.BackColor = Color.Transparent;
            checkBox23.BackColor = Color.Transparent;
            checkBox24.BackColor = Color.Transparent;
            checkBox25.BackColor = Color.Transparent;
            checkBox26.BackColor = Color.Transparent;
            checkBox27.BackColor = Color.Transparent;
            checkBox28.BackColor = Color.Transparent;
            checkBox29.BackColor = Color.Transparent;
            checkBox30.BackColor = Color.Transparent;
            checkBox31.BackColor = Color.Transparent;
            checkBox32.BackColor = Color.Transparent;
            checkBox33.BackColor = Color.Transparent;
            checkBox34.BackColor = Color.Transparent;
            checkBox35.BackColor = Color.Transparent;
            checkBox36.BackColor = Color.Transparent;
            checkBox37.BackColor = Color.Transparent;
            checkBox38.BackColor = Color.Transparent;
            checkBox39.BackColor = Color.Transparent;
            checkBox40.BackColor = Color.Transparent;
            checkBox41.BackColor = Color.Transparent;
            checkBox42.BackColor = Color.Transparent;
           
            WinAPI.AnimateWindow(this.Handle, 250, WinAPI.VER_POSITIVE);
        }
    }
}
