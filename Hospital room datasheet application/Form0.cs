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
    public partial class Form2 : Form
    {
        private Form14 frm14;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Form4 f4 = new Form4();
            f4.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Patient_Room_datasheet;User ID=clinical;Password=321654987");
            //myConnection.Open();
            /* SqlCommand cmd = myConnection.CreateCommand();
             cmd.CommandText = @" insert into Room_data (R_number,area,Using_Time,Using_Days,Norm_No_of_patients,Norm_No_of_staff,Norm_No_of_visitors,Max_No_of_patients,Max_No_of_staff,Max_No_of_visitors,Room_Function)
                                 values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "')";
             cmd.ExecuteNonQuery();
             MessageBox.Show("Data added sucessfully");8*/
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f11 = new Form11();
            f11.Show();  
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.25;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14(textBox1.Text, comboBox1.Text);
            this.Hide();
            frm14.Show();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /*string type = comboBox1.Text;
            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987");
            myConnection.Open();
            SqlCommand cmd = myConnection.CreateCommand();

            cmd.CommandText = @" insert into Door_width (R_number,type)
                                values ('" + textBox2.Text + "','" + type +  "')";
            cmd.ExecuteNonQuery();*/

            /*using (SqlConnection con = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987"))
            {
                try
                {
                    using (var cmd = new SqlCommand("INSERT INTO registor (R_number, type) VALUES (@R_number,@type)"))
                    {
                        cmd.Connection = con;
                        cmd.Parameters.Add("@R_number", textBox2.Text);
                        cmd.Parameters.Add("@type", comboBox1.GetItemText(comboBox1.SelectedItem));
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Record inserted");
                        }
                        else
                        {
                            MessageBox.Show("Record failed");
                        }

                    }
                }

                catch (Exception b)
                {
                    MessageBox.Show("Error during insert: " + b.Message);
                }

                /*SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandText = @" insert into clinical (R_number,area,Using_Time,Using_Days,Norm_No_of_patients,Norm_No_of_staff,Norm_No_of_visitors,Max_No_of_patients,Max_No_of_staff,Max_No_of_visitors,Room_Function)
                                    values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added sucessfully");8
            }*/
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
           
           /* SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987");
            myConnection.Open();
            SqlCommand cmd = myConnection.CreateCommand();

            cmd.CommandText = @" insert into Room_Information (R_number,Area,Department,R_Function,use_time,use_days,normal_no_of_patients,max_no_of_patients,normal_no_of_occupants,max_no_of_occupants,normal_no_of_staff,max_no_of_staff)
                                values ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "')";
            
            cmd.ExecuteNonQuery();
           

            MessageBox.Show("Data added sucessfully");*/
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987;MultipleActiveResultSets = True;");
            SqlCommand cmd;
            SqlDataReader dr;
            SqlDataReader dr2;
            myConnection.Open();

            if (comboBox2.Text == "Equipment")
            {
                cmd = new SqlCommand("select * From Additional_items ", myConnection);
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    string rnum = dr["R_number"].ToString();
                    cmd = new SqlCommand("select Equipment_number From Additional_items where Equipment_item = '"+ textBox2.Text + "' AND R_number = '"+ rnum +"'", myConnection);
                    dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        string number = dr["Equipment_number"].ToString();
                        count += int.Parse(number);
                    }
                    dr2.Close();
                }
                dr.Close();
                count_result.Text = count.ToString();
            }

            if (comboBox2.Text == "Furniture")
            {
                cmd = new SqlCommand("select * From Additional_items ", myConnection);
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    string rnum = dr["R_number"].ToString();
                    cmd = new SqlCommand("select Furniture_number From Additional_items where Furniture_items = '" + textBox2.Text + "' AND R_number = '" + rnum + "'", myConnection);
                    dr2 = cmd.ExecuteReader();
                    while (dr2.Read())
                    {
                        string number = dr["Furniture_number"].ToString();
                        count += int.Parse(number);
                    }
                    dr2.Close();
                }
                dr.Close();
                count_result.Text = count.ToString();
            }
        }
    }
}
               

          
    

                     

                
                
              
        
    

