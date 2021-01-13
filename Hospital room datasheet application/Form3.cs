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
    public partial class Form3 : Form
    {
        private Form4 frm4;

        private Form12 frm12;

        string R_Num;

        public Form3(string R_num)
        {
            InitializeComponent();
            R_Num = R_num;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
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
            checkBox43.BackColor = Color.Transparent;
            checkBox44.BackColor = Color.Transparent;
            checkBox45.BackColor = Color.Transparent;
            checkBox46.BackColor = Color.Transparent;
            checkBox47.BackColor = Color.Transparent;
            checkBox48.BackColor = Color.Transparent;
            checkBox49.BackColor = Color.Transparent;
            checkBox50.BackColor = Color.Transparent;
            checkBox51.BackColor = Color.Transparent;
            checkBox52.BackColor = Color.Transparent;
            checkBox53.BackColor = Color.Transparent;
            checkBox54.BackColor = Color.Transparent;
            checkBox55.BackColor = Color.Transparent;
            checkBox56.BackColor = Color.Transparent;
            checkBox57.BackColor = Color.Transparent;
            checkBox58.BackColor = Color.Transparent;
            checkBox59.BackColor = Color.Transparent;
            checkBox60.BackColor = Color.Transparent;
            checkBox61.BackColor = Color.Transparent;
            checkBox62.BackColor = Color.Transparent;
            checkBox63.BackColor = Color.Transparent;
            checkBox64.BackColor = Color.Transparent;
            checkBox65.BackColor = Color.Transparent;
            checkBox66.BackColor = Color.Transparent;
            checkBox67.BackColor = Color.Transparent;
            checkBox68.BackColor = Color.Transparent;
            checkBox69.BackColor = Color.Transparent;
            checkBox70.BackColor = Color.Transparent;
            checkBox71.BackColor = Color.Transparent;
            checkBox72.BackColor = Color.Transparent;
            checkBox73.BackColor = Color.Transparent;
            checkBox74.BackColor = Color.Transparent;
            checkBox75.BackColor = Color.Transparent;
            checkBox76.BackColor = Color.Transparent;
            checkBox77.BackColor = Color.Transparent;
            checkBox78.BackColor = Color.Transparent;
            checkBox79.BackColor = Color.Transparent;
            checkBox80.BackColor = Color.Transparent;
            checkBox81.BackColor = Color.Transparent;
            checkBox82.BackColor = Color.Transparent;
            checkBox83.BackColor = Color.Transparent;
            checkBox84.BackColor = Color.Transparent;
            checkBox85.BackColor = Color.Transparent;
            checkBox86.BackColor = Color.Transparent;
            checkBox87.BackColor = Color.Transparent;
            WinAPI.AnimateWindow(this.Handle, 250, WinAPI.VER_POSITIVE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987");
            myConnection.Open();

            SqlCommand cmd1 = myConnection.CreateCommand();
            cmd1.CommandText = @" insert into Wall_Finishes (R_number) values ('" + R_Num + "')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = myConnection.CreateCommand();
            cmd2.CommandText = @" insert into Window (R_number) values ('" + R_Num + "')";
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = myConnection.CreateCommand();
            cmd3.CommandText = @" insert into Work_Surface (R_number) values ('" + R_Num + "')";
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = myConnection.CreateCommand();
            cmd4.CommandText = @" insert into Special_Considerations (R_number) values ('" + R_Num + "')";
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = myConnection.CreateCommand();
            cmd5.CommandText = @" insert into Special_Storage_Requirements (R_number) values ('" + R_Num + "')";
            cmd5.ExecuteNonQuery();

            SqlCommand cmd6 = myConnection.CreateCommand();
            cmd6.CommandText = @" insert into Storage_Component (R_number) values ('" + R_Num + "')";
            cmd6.ExecuteNonQuery();

            SqlCommand cmd7 = myConnection.CreateCommand();
            cmd7.CommandText = @" insert into Gas (R_number) values ('" + R_Num + "')";
            cmd7.ExecuteNonQuery();

            SqlCommand cmd8 = myConnection.CreateCommand();
            cmd8.CommandText = @" insert into Water (R_number) values ('" + R_Num + "')";
            cmd8.ExecuteNonQuery();

            SqlCommand cmd9 = myConnection.CreateCommand();
            cmd9.CommandText = @" insert into Lighting (R_number) values ('" + R_Num + "')";
            cmd9.ExecuteNonQuery();

            SqlCommand cmd10 = myConnection.CreateCommand();
            cmd10.CommandText = @" insert into Alarm_Detection (R_number) values ('" + R_Num + "')";
            cmd10.ExecuteNonQuery();

            SqlCommand cmd11 = myConnection.CreateCommand();
            cmd11.CommandText = @" insert into Clock_System (R_number) values ('" + R_Num + "')";
            cmd11.ExecuteNonQuery();

            SqlCommand cmd12 = myConnection.CreateCommand();
            cmd12.CommandText = @" insert into Electrical_Door (R_number) values ('" + R_Num + "')";
            cmd12.ExecuteNonQuery();

            SqlCommand cmd13 = myConnection.CreateCommand();
            cmd13.CommandText = @" insert into Floor_Finishes (R_number) values ('" + R_Num + "')";
            cmd13.ExecuteNonQuery();

            SqlCommand cmd14 = myConnection.CreateCommand();
            cmd14.CommandText = @" insert into Communications_Data (R_number) values ('" + R_Num + "')";
            cmd14.ExecuteNonQuery();

            SqlCommand cmd15 = myConnection.CreateCommand();
            cmd15.CommandText = @" insert into Drainage (R_number) values ('" + R_Num + "')";
            cmd15.ExecuteNonQuery();

            SqlCommand cmd16 = myConnection.CreateCommand();
            if (checkBox1.Checked == true)
            {
                cmd16.CommandText = @"UPDATE Wall_Finishes Set Standard = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd16.CommandText = @"UPDATE Wall_Finishes Set Standard = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd16.ExecuteNonQuery();

            SqlCommand cmd17 = myConnection.CreateCommand();
            if (checkBox2.Checked == true)
            {
                cmd17.CommandText = @"UPDATE Wall_Finishes Set Washable = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd17.CommandText = @"UPDATE Wall_Finishes Set Washable = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd17.ExecuteNonQuery();

            SqlCommand cmd18 = myConnection.CreateCommand();
            if (checkBox3.Checked == true)
            {
                cmd18.CommandText = @"UPDATE Wall_Finishes Set Water_Impervious = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd18.CommandText = @"UPDATE Wall_Finishes Set Water_Impervious = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd18.ExecuteNonQuery();

            SqlCommand cmd19 = myConnection.CreateCommand();
            if (checkBox4.Checked == true)
            {
                cmd19.CommandText = @"UPDATE Wall_Finishes Set Special_Protection = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd19.CommandText = @"UPDATE Wall_Finishes Set Special_Protection = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd19.ExecuteNonQuery();

            SqlCommand cmd20 = myConnection.CreateCommand();
            if (checkBox9.Checked == true)
            {
                cmd20.CommandText = @"UPDATE Work_Surface Set Moveable = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd20.CommandText = @"UPDATE Work_Surface Set Moveable = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd20.ExecuteNonQuery();

            SqlCommand cmd21 = myConnection.CreateCommand();
            if (checkBox8.Checked == true)
            {
                cmd21.CommandText = @"UPDATE Work_Surface Set Fixed = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd21.CommandText = @"UPDATE Work_Surface Set Fixed = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd21.ExecuteNonQuery();

            SqlCommand cmd22 = myConnection.CreateCommand();
            if (checkBox10.Checked == true)
            {
                cmd22.CommandText = @"UPDATE Work_Surface Set Standing_Height_900_36 = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd22.CommandText = @"UPDATE Work_Surface Set Standing_Height_900_36 = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd22.ExecuteNonQuery();

            SqlCommand cmd23 = myConnection.CreateCommand();
            if (checkBox11.Checked == true)
            {
                cmd23.CommandText = @"UPDATE Work_Surface Set Sitting_Height_750_30 = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd23.CommandText = @"UPDATE Work_Surface Set Sitting_Height_750_30 = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd23.ExecuteNonQuery();

            SqlCommand cmd24 = myConnection.CreateCommand();
            if (checkBox12.Checked == true)
            {
                cmd24.CommandText = @"UPDATE Work_Surface Set Depth_600mm_24 = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd24.CommandText = @"UPDATE Work_Surface Set Depth_600mm_24 = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd24.ExecuteNonQuery();

            SqlCommand cmd25 = myConnection.CreateCommand();
            if (checkBox13.Checked == true)
            {
                cmd25.CommandText = @"UPDATE Work_Surface Set Depth_900mm_36 = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd25.CommandText = @"UPDATE Work_Surface Set Depth_900mm_36 = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd21.ExecuteNonQuery();

            SqlCommand cmd26 = myConnection.CreateCommand();
            if (checkBox14.Checked == true)
            {
                cmd26.CommandText = @"UPDATE Work_Surface Set Stainless_Steel = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd26.CommandText = @"UPDATE Work_Surface Set Stainless_Steel = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd26.ExecuteNonQuery();

            SqlCommand cmd27 = myConnection.CreateCommand();
            if (checkBox15.Checked == true)
            {
                cmd27.CommandText = @"UPDATE Work_Surface Set Wood = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd27.CommandText = @"UPDATE Work_Surface Set Wood = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd27.ExecuteNonQuery();

            SqlCommand cmd28 = myConnection.CreateCommand();
            if (checkBox16.Checked == true)
            {
                cmd28.CommandText = @"UPDATE Work_Surface Set Acid_Resistant = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd28.CommandText = @"UPDATE Work_Surface Set Acid_Resistant = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd28.ExecuteNonQuery();

            SqlCommand cmd29 = myConnection.CreateCommand();
            if (checkBox17.Checked == true)
            {
                cmd29.CommandText = @"UPDATE Work_Surface Set other_special_surface = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd29.CommandText = @"UPDATE Work_Surface Set other_special_surface = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd29.ExecuteNonQuery();

            SqlCommand cmd30 = myConnection.CreateCommand();
            if (checkBox5.Checked == true)
            {
                cmd30.CommandText = @"UPDATE Window Set Exterior = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd30.CommandText = @"UPDATE Window Set Exterior = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd30.ExecuteNonQuery();

            SqlCommand cmd31 = myConnection.CreateCommand();
            if (checkBox6.Checked == true)
            {
                cmd31.CommandText = @"UPDATE Window Set Interior = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd31.CommandText = @"UPDATE Window Set Interior = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd31.ExecuteNonQuery();

            SqlCommand cmd32 = myConnection.CreateCommand();
            if (checkBox7.Checked == true)
            {
                cmd32.CommandText = @"UPDATE Window Set Operable = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd32.CommandText = @"UPDATE Window Set Operable = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd32.ExecuteNonQuery();

            SqlCommand cmd33 = myConnection.CreateCommand();
            if (checkBox39.Checked == true)
            {
                cmd33.CommandText = @"UPDATE Storage_Component Set Depth_300mm_12 = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd33.CommandText = @"UPDATE Storage_Component Set Depth_300mm_12 = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd33.ExecuteNonQuery();

            SqlCommand cmd34 = myConnection.CreateCommand();
            if (checkBox40.Checked == true)
            {
                cmd34.CommandText = @"UPDATE Storage_Component Set Depth_450mm_18 = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd34.CommandText = @"UPDATE Storage_Component Set Depth_450mm_18 = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd34.ExecuteNonQuery();

            SqlCommand cmd35 = myConnection.CreateCommand();
            if (checkBox41.Checked == true)
            {
                cmd35.CommandText = @"UPDATE Storage_Component Set Depth_600mm_24 = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd35.CommandText = @"UPDATE Storage_Component Set Depth_600mm_24 = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd35.ExecuteNonQuery();

            SqlCommand cmd36 = myConnection.CreateCommand();
            if (checkBox44.Checked == true)
            {
                cmd36.CommandText = @"UPDATE Storage_Component Set Cupboards_Under = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd36.CommandText = @"UPDATE Storage_Component Set Cupboards_Under = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd36.ExecuteNonQuery();

            SqlCommand cmd37 = myConnection.CreateCommand();
            if (checkBox43.Checked == true)
            {
                cmd37.CommandText = @"UPDATE Storage_Component Set Cupboards_Above = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd37.CommandText = @"UPDATE Storage_Component Set Cupboards_Above = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd37.ExecuteNonQuery();

            SqlCommand cmd38 = myConnection.CreateCommand();
            if (checkBox42.Checked == true)
            {
                cmd38.CommandText = @"UPDATE Storage_Component Set Cupboards_Drawers = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd38.CommandText = @"UPDATE Storage_Component Set Cupboards_Drawers = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd38.ExecuteNonQuery();

            SqlCommand cmd39 = myConnection.CreateCommand();
            if (checkBox47.Checked == true)
            {
                cmd39.CommandText = @"UPDATE Storage_Component Set Cupboards_Full_Height = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd39.CommandText = @"UPDATE Storage_Component Set Cupboards_Full_Height = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd39.ExecuteNonQuery();

            SqlCommand cmd40 = myConnection.CreateCommand();
            if (checkBox46.Checked == true)
            {
                cmd40.CommandText = @"UPDATE Storage_Component Set Equipment_Over = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd40.CommandText = @"UPDATE Storage_Component Set Equipment_Over = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd40.ExecuteNonQuery();

            SqlCommand cmd41 = myConnection.CreateCommand();
            if (checkBox45.Checked == true)
            {
                cmd41.CommandText = @"UPDATE Storage_Component Set Equipment_Under = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd41.CommandText = @"UPDATE Storage_Component Set Equipment_Under = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd41.ExecuteNonQuery();

            SqlCommand cmd42 = myConnection.CreateCommand();
            if (checkBox50.Checked == true)
            {
                cmd42.CommandText = @"UPDATE Storage_Component Set Open_Shelving_Over_Counter = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd42.CommandText = @"UPDATE Storage_Component Set Open_Shelving_Over_Counter = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd42.ExecuteNonQuery();

            SqlCommand cmd43 = myConnection.CreateCommand();
            if (checkBox49.Checked == true)
            {
                cmd43.CommandText = @"UPDATE Storage_Component Set Open_Shelving_Under_Counter = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd43.CommandText = @"UPDATE Storage_Component Set Open_Shelving_Under_Counter = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd43.ExecuteNonQuery();

            SqlCommand cmd44 = myConnection.CreateCommand();
            if (checkBox48.Checked == true)
            {
                cmd44.CommandText = @"UPDATE Storage_Component Set Open_Shelving_Full_height = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd44.CommandText = @"UPDATE Storage_Component Set Open_Shelving_Full_height = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd44.ExecuteNonQuery();

            SqlCommand cmd45 = myConnection.CreateCommand();
            if (checkBox18.Checked == true)
            {
                cmd45.CommandText = @"UPDATE Special_Considerations Set Noise_insulate_walls = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd45.CommandText = @"UPDATE Special_Considerations Set Noise_insulate_walls = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd45.ExecuteNonQuery();

            SqlCommand cmd46 = myConnection.CreateCommand();
            if (checkBox19.Checked == true)
            {
                cmd46.CommandText = @"UPDATE Special_Considerations Set Vibration = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd46.CommandText = @"UPDATE Special_Considerations Set Vibration = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd46.ExecuteNonQuery();

            SqlCommand cmd47 = myConnection.CreateCommand();
            if (checkBox20.Checked == true)
            {
                cmd47.CommandText = @"UPDATE Special_Considerations Set Radiation_Shielding = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd47.CommandText = @"UPDATE Special_Considerations Set Radiation_Shielding = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd47.ExecuteNonQuery();

            SqlCommand cmd48 = myConnection.CreateCommand();
            if (checkBox21.Checked == true)
            {
                cmd48.CommandText = @"UPDATE Special_Considerations Set Magnetic_Field = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd48.CommandText = @"UPDATE Special_Considerations Set Magnetic_Field = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd48.ExecuteNonQuery();

            SqlCommand cmd49 = myConnection.CreateCommand();
            if (checkBox22.Checked == true)
            {
                cmd49.CommandText = @"UPDATE Special_Considerations Set Noxious_Gas_Vapour = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd49.CommandText = @"UPDATE Special_Considerations Set Noxious_Gas_Vapour = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd49.ExecuteNonQuery();

            SqlCommand cmd50 = myConnection.CreateCommand();
            if (checkBox23.Checked == true)
            {
                cmd50.CommandText = @"UPDATE Special_Considerations Set Corrosion = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd50.CommandText = @"UPDATE Special_Considerations Set Corrosion = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd50.ExecuteNonQuery();

            SqlCommand cmd51 = myConnection.CreateCommand();
            if (checkBox24.Checked == true)
            {
                cmd51.CommandText = @"UPDATE Special_Considerations Set Static_Electricity = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd51.CommandText = @"UPDATE Special_Considerations Set Static_Electricity = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd51.ExecuteNonQuery();

            SqlCommand cmd52 = myConnection.CreateCommand();
            if (checkBox25.Checked == true)
            {
                cmd52.CommandText = @"UPDATE Special_Considerations Set Natural_Light_View_Out = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd52.CommandText = @"UPDATE Special_Considerations Set Natural_Light_View_Out = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd52.ExecuteNonQuery();

            SqlCommand cmd53 = myConnection.CreateCommand();
            if (checkBox26.Checked == true)
            {
                cmd53.CommandText = @"UPDATE Special_Considerations Set Special_Floor_Conditions = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd53.CommandText = @"UPDATE Special_Considerations Set Special_Floor_Conditions = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd53.ExecuteNonQuery();

            SqlCommand cmd54 = myConnection.CreateCommand();
            if (checkBox27.Checked == true)
            {
                cmd54.CommandText = @"UPDATE Special_Considerations Set Special_Ceiling_Conditions = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd54.CommandText = @"UPDATE Special_Considerations Set Special_Ceiling_Conditions = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd54.ExecuteNonQuery();

            SqlCommand cmd55 = myConnection.CreateCommand();
            if (checkBox37.Checked == true)
            {
                cmd55.CommandText = @"UPDATE Special_Considerations Set Local_Scavenging_System = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd55.CommandText = @"UPDATE Special_Considerations Set Local_Scavenging_System = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd55.ExecuteNonQuery();

            SqlCommand cmd56 = myConnection.CreateCommand();
            if (checkBox36.Checked == true)
            {
                cmd56.CommandText = @"UPDATE Special_Considerations Set Speech_Privacy_Isolation = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd56.CommandText = @"UPDATE Special_Considerations Set Speech_Privacy_Isolation = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd56.ExecuteNonQuery();

            SqlCommand cmd57 = myConnection.CreateCommand();
            if (checkBox35.Checked == true)
            {
                cmd57.CommandText = @"UPDATE Special_Considerations Set Glazed_Partitions_Doors = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd57.CommandText = @"UPDATE Special_Considerations Set Glazed_Partitions_Doors = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd57.ExecuteNonQuery();

            SqlCommand cmd58 = myConnection.CreateCommand();
            if (checkBox34.Checked == true)
            {
                cmd58.CommandText = @"UPDATE Special_Considerations Set Laminar_Flow_Cabinet = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd58.CommandText = @"UPDATE Special_Considerations Set Laminar_Flow_Cabinet = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd58.ExecuteNonQuery();

            SqlCommand cmd59 = myConnection.CreateCommand();
            if (checkBox33.Checked == true)
            {
                cmd59.CommandText = @"UPDATE Special_Considerations Set Fume_Cabinet_for_Chemical = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd59.CommandText = @"UPDATE Special_Considerations Set Fume_Cabinet_for_Chemical = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd59.ExecuteNonQuery();

            SqlCommand cmd60 = myConnection.CreateCommand();
            if (checkBox32.Checked == true)
            {
                cmd60.CommandText = @"UPDATE Special_Considerations Set Fume_Cabinet_for_Radioactive = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd60.CommandText = @"UPDATE Special_Considerations Set Fume_Cabinet_for_Radioactive = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd60.ExecuteNonQuery();

            SqlCommand cmd61 = myConnection.CreateCommand();
            if (checkBox31.Checked == true)
            {
                cmd61.CommandText = @"UPDATE Special_Considerations Set Fume_Cabinet_for_Biohazard = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd61.CommandText = @"UPDATE Special_Considerations Set Fume_Cabinet_for_Biohazard = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd61.ExecuteNonQuery();

            SqlCommand cmd62 = myConnection.CreateCommand();
            if (checkBox30.Checked == true)
            {
                cmd62.CommandText = @"UPDATE Special_Considerations Set Exhaust_Canopy = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd62.CommandText = @"UPDATE Special_Considerations Set Exhaust_Canopy = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd62.ExecuteNonQuery();

            SqlCommand cmd63 = myConnection.CreateCommand();
            if (checkBox29.Checked == true)
            {
                cmd63.CommandText = @"UPDATE Special_Considerations Set Exceptional_Loading_Floor = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd63.CommandText = @"UPDATE Special_Considerations Set Exceptional_Loading_Floor = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd63.ExecuteNonQuery();

            SqlCommand cmd64 = myConnection.CreateCommand();
            if (checkBox28.Checked == true)
            {
                cmd64.CommandText = @"UPDATE Special_Considerations Set Exceptional_Loading_Wall = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd64.CommandText = @"UPDATE Special_Considerations Set Exceptional_Loading_Wall = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd64.ExecuteNonQuery();

            SqlCommand cmd65 = myConnection.CreateCommand();
            if (checkBox38.Checked == true)
            {
                cmd65.CommandText = @"UPDATE Special_Considerations Set Exceptional_Loading_Ceilling = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd65.CommandText = @"UPDATE Special_Considerations Set Exceptional_Loading_Ceilling = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd65.ExecuteNonQuery();

            SqlCommand cmd66 = myConnection.CreateCommand();
            if (checkBox51.Checked == true)
            {
                cmd66.CommandText = @"UPDATE Special_Storage_Requirements Set Equipment = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd66.CommandText = @"UPDATE Special_Storage_Requirements Set Equipment = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd66.ExecuteNonQuery();

            SqlCommand cmd67 = myConnection.CreateCommand();
            if (checkBox52.Checked == true)
            {
                cmd67.CommandText = @"UPDATE Special_Storage_Requirements Set Refrigerated = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd67.CommandText = @"UPDATE Special_Storage_Requirements Set Refrigerated = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd67.ExecuteNonQuery();

            SqlCommand cmd68 = myConnection.CreateCommand();
            if (checkBox53.Checked == true)
            {
                cmd68.CommandText = @"UPDATE Special_Storage_Requirements Set Wheelchairs_Stretchers = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd68.CommandText = @"UPDATE Special_Storage_Requirements Set Wheelchairs_Stretchers = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd68.ExecuteNonQuery();

            SqlCommand cmd69 = myConnection.CreateCommand();
            if (checkBox54.Checked == true)
            {
                cmd69.CommandText = @"UPDATE Special_Storage_Requirements Set Medications = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd69.CommandText = @"UPDATE Special_Storage_Requirements Set Medications = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd69.ExecuteNonQuery();

            SqlCommand cmd70 = myConnection.CreateCommand();
            if (checkBox55.Checked == true)
            {
                cmd70.CommandText = @"UPDATE Special_Storage_Requirements Set Narcotics = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd70.CommandText = @"UPDATE Special_Storage_Requirements Set Narcotics = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd70.ExecuteNonQuery();

            SqlCommand cmd71 = myConnection.CreateCommand();
            if (checkBox56.Checked == true)
            {
                cmd71.CommandText = @"UPDATE Special_Storage_Requirements Set Photo_Equipment = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd71.CommandText = @"UPDATE Special_Storage_Requirements Set Photo_Equipment = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd71.ExecuteNonQuery();

            SqlCommand cmd72 = myConnection.CreateCommand();
            if (checkBox57.Checked == true)
            {
                cmd72.CommandText = @"UPDATE Special_Storage_Requirements Set Radiology_Cassettes = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd72.CommandText = @"UPDATE Special_Storage_Requirements Set Radiology_Cassettes = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd72.ExecuteNonQuery();

            SqlCommand cmd73 = myConnection.CreateCommand();
            if (checkBox58.Checked == true)
            {
                cmd73.CommandText = @"UPDATE Special_Storage_Requirements Set Solutions = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd73.CommandText = @"UPDATE Special_Storage_Requirements Set Solutions = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd73.ExecuteNonQuery();

            SqlCommand cmd74 = myConnection.CreateCommand();
            if (checkBox59.Checked == true)
            {
                cmd74.CommandText = @"UPDATE Special_Storage_Requirements Set Supplies = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd74.CommandText = @"UPDATE Special_Storage_Requirements Set Supplies = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd74.ExecuteNonQuery();

            SqlCommand cmd75 = myConnection.CreateCommand();
            if (checkBox60.Checked == true)
            {
                cmd75.CommandText = @"UPDATE Water Set Domestic_Hot_Water_82c = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd75.CommandText = @"UPDATE Water Set Domestic_Hot_Water_82c = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd75.ExecuteNonQuery();

            SqlCommand cmd76 = myConnection.CreateCommand();
            if (checkBox61.Checked == true)
            {
                cmd76.CommandText = @"UPDATE Water Set Domestic_Hot_Water_43c = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd76.CommandText = @"UPDATE Water Set Domestic_Hot_Water_43c = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd76.ExecuteNonQuery();

            SqlCommand cmd77 = myConnection.CreateCommand();
            if (checkBox62.Checked == true)
            {
                cmd77.CommandText = @"UPDATE Water Set Domestic_Hot_Water_60c = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd77.CommandText = @"UPDATE Water Set Domestic_Hot_Water_60c = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd77.ExecuteNonQuery();

            SqlCommand cmd78 = myConnection.CreateCommand();
            if (checkBox63.Checked == true)
            {
                cmd78.CommandText = @"UPDATE Water Set Domestic_Cold_Water = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd78.CommandText = @"UPDATE Water Set Domestic_Cold_Water = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd78.ExecuteNonQuery();

            SqlCommand cmd79 = myConnection.CreateCommand();
            if (checkBox64.Checked == true)
            {
                cmd79.CommandText = @"UPDATE Water Set Distilled_Water_Localized = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd79.CommandText = @"UPDATE Water Set Distilled_Water_Localized = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd79.ExecuteNonQuery();

            SqlCommand cmd80 = myConnection.CreateCommand();
            if (checkBox65.Checked == true)
            {
                cmd80.CommandText = @"UPDATE Water Set Softened_Water = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd80.CommandText = @"UPDATE Water Set Softened_Water = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd80.ExecuteNonQuery();

            SqlCommand cmd81 = myConnection.CreateCommand();
            if (checkBox66.Checked == true)
            {
                cmd81.CommandText = @"UPDATE Water Set De_Ionized_Water_Localized = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd81.CommandText = @"UPDATE Water Set De_Ionized_Water_Localized = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd81.ExecuteNonQuery();

            SqlCommand cmd82 = myConnection.CreateCommand();
            if (checkBox67.Checked == true)
            {
                cmd82.CommandText = @"UPDATE Water Set Dialysate_Water_Localized = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd82.CommandText = @"UPDATE Water Set Dialysate_Water_Localized = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd82.ExecuteNonQuery();

            SqlCommand cmd83 = myConnection.CreateCommand();
            if (checkBox68.Checked == true)
            {
                cmd83.CommandText = @"UPDATE Water Set Particulate_Filtered_Water = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd83.CommandText = @"UPDATE Water Set Particulate_Filtered_Water = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd83.ExecuteNonQuery();

            SqlCommand cmd84 = myConnection.CreateCommand();
            if (checkBox69.Checked == true)
            {
                cmd84.CommandText = @"UPDATE Water Set Fire_Suppression_Sprinkler = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd84.CommandText = @"UPDATE Water Set Fire_Suppression_Sprinkler = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd84.ExecuteNonQuery();

            SqlCommand cmd85 = myConnection.CreateCommand();
            if (checkBox70.Checked == true)
            {
                cmd85.CommandText = @"UPDATE Alarm_Detection Set Fire_Alarm_System = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd85.CommandText = @"UPDATE Alarm_Detection Set Fire_Alarm_System = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd85.ExecuteNonQuery();

            SqlCommand cmd86 = myConnection.CreateCommand();
            if (checkBox71.Checked == true)
            {
                cmd86.CommandText = @"UPDATE Alarm_Detection Set Intrusion_Detector = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd86.CommandText = @"UPDATE Alarm_Detection Set Intrusion_Detector = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd86.ExecuteNonQuery();

            SqlCommand cmd87 = myConnection.CreateCommand();
            if (checkBox72.Checked == true)
            {
                cmd87.CommandText = @"UPDATE Alarm_Detection Set Heat_Detector = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd87.CommandText = @"UPDATE Alarm_Detection Set Heat_Detector = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd87.ExecuteNonQuery();

            SqlCommand cmd88 = myConnection.CreateCommand();
            if (checkBox73.Checked == true)
            {
                cmd88.CommandText = @"UPDATE Alarm_Detection Set Smoke_Detector = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd88.CommandText = @"UPDATE Alarm_Detection Set Smoke_Detector = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd88.ExecuteNonQuery();

            SqlCommand cmd89 = myConnection.CreateCommand();
            if (checkBox74.Checked == true)
            {
                cmd89.CommandText = @"UPDATE Alarm_Detection Set Gas_Detector = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd89.CommandText = @"UPDATE Alarm_Detection Set Gas_Detector = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd89.ExecuteNonQuery();

            SqlCommand cmd90 = myConnection.CreateCommand();
            if (checkBox83.Checked == true)
            {
                cmd90.CommandText = @"UPDATE Clock_System Set Synchronized = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd90.CommandText = @"UPDATE Clock_System Set Synchronized = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd90.ExecuteNonQuery();

            SqlCommand cmd91 = myConnection.CreateCommand();
            if (checkBox82.Checked == true)
            {
                cmd91.CommandText = @"UPDATE Clock_System Set Stand_Alone = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd91.CommandText = @"UPDATE Clock_System Set Stand_Alone = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd91.ExecuteNonQuery();

            SqlCommand cmd92 = myConnection.CreateCommand();
            if (checkBox81.Checked == true)
            {
                cmd92.CommandText = @"UPDATE Clock_System Set Clk_24_Hour = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd92.CommandText = @"UPDATE Clock_System Set Clk_24_Hour = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd92.ExecuteNonQuery();

            SqlCommand cmd93 = myConnection.CreateCommand();
            if (checkBox80.Checked == true)
            {
                cmd93.CommandText = @"UPDATE Clock_System Set Clk_12_Hour = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd93.CommandText = @"UPDATE Clock_System Set Clk_12_Hour = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd93.ExecuteNonQuery();

            SqlCommand cmd94 = myConnection.CreateCommand();
            if (checkBox79.Checked == true)
            {
                cmd94.CommandText = @"UPDATE Clock_System Set Elapsed_Time = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd94.CommandText = @"UPDATE Clock_System Set Elapsed_Time = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd94.ExecuteNonQuery();

            SqlCommand cmd95 = myConnection.CreateCommand();
            if (checkBox84.Checked == true)
            {
                cmd95.CommandText = @"UPDATE Electrical_Door Set Magnetic_Door_Position_Switch = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd95.CommandText = @"UPDATE Electrical_Door Set Magnetic_Door_Position_Switch = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd95.ExecuteNonQuery();

            SqlCommand cmd96 = myConnection.CreateCommand();
            if (checkBox85.Checked == true)
            {
                cmd96.CommandText = @"UPDATE Electrical_Door Set Electronic_Door_Locking_Hardware = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd96.CommandText = @"UPDATE Electrical_Door Set Electronic_Door_Locking_Hardware = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd96.ExecuteNonQuery();

            SqlCommand cmd97 = myConnection.CreateCommand();
            if (checkBox86.Checked == true)
            {
                cmd97.CommandText = @"UPDATE Electrical_Door Set Automatic_Door_Opener = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd97.CommandText = @"UPDATE Electrical_Door Set Automatic_Door_Opener = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd97.ExecuteNonQuery();

            SqlCommand cmd98 = myConnection.CreateCommand();
            if (checkBox87.Checked == true)
            {
                cmd98.CommandText = @"UPDATE Electrical_Door Set Request_to_exit_for_Door_shunt = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd98.CommandText = @"UPDATE Electrical_Door Set Request_to_exit_for_Door_shunt = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd98.ExecuteNonQuery();

            SqlCommand cmd99 = myConnection.CreateCommand();
            if (checkBox75.Checked == true)
            {
                cmd99.CommandText = @"UPDATE Lighting Set Ambient = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd99.CommandText = @"UPDATE Lighting Set Ambient = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd99.ExecuteNonQuery();

            SqlCommand cmd100 = myConnection.CreateCommand();
            if (checkBox76.Checked == true)
            {
                cmd100.CommandText = @"UPDATE Lighting Set Task = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd100.CommandText = @"UPDATE Lighting Set Task = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd100.ExecuteNonQuery();

            SqlCommand cmd101 = myConnection.CreateCommand();
            if (checkBox77.Checked == true)
            {
                cmd101.CommandText = @"UPDATE Lighting Set Examining = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd101.CommandText = @"UPDATE Lighting Set Examining = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd101.ExecuteNonQuery();

            SqlCommand cmd102 = myConnection.CreateCommand();
            if (checkBox78.Checked == true)
            {
                cmd102.CommandText = @"UPDATE Lighting Set Colour_Corrected = 1 WHERE R_number = '" + R_Num + "'";
            }
            else
            {
                cmd102.CommandText = @"UPDATE Lighting Set Colour_Corrected = 0 WHERE R_number = '" + R_Num + "'";
            }
            cmd102.ExecuteNonQuery();

            Form4 frm4 = new Form4(R_Num);
            this.Hide();
            frm4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 frm12 = new Form12(R_Num);
            frm12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
    }

