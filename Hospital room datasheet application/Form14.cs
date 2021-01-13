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
    public partial class Form14 : Form
    {
        string choice_;
        string R_num_;
        public Form14(string R_num,string choice)
        {
            InitializeComponent();
            choice_ = choice;
            R_num_ = R_num;
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;

            SqlConnection myConnection = new SqlConnection("Data Source=roomdb.cqqrtfvavnxp.us-east-2.rds.amazonaws.com,1433;Initial Catalog=Room_datasheet;User ID=clinical;Password=321654987");
            SqlCommand cmd;
            SqlDataReader dr;
            myConnection.Open();

            if (choice_ == "Additional items")
            {
                cmd = new SqlCommand("select * From Additional_items where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Equipment Item: " + dr["Equipment_item"].ToString() );
                    listBox1.Items.Add("Equipment Number: " + dr["Equipment_number"].ToString());
                    listBox1.Items.Add("Furniture Items: " + dr["Furniture_items"].ToString());
                    listBox1.Items.Add("Furniture Number: " + dr["Furniture_number"].ToString());
                    listBox1.Items.Add("Millwork Items: " + dr["Millwork_items"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Alarm Detection")
            {
                cmd = new SqlCommand("select * From Alarm_Detection where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Fire Alarm System: " + dr["Fire_Alarm_System"].ToString());
                    listBox1.Items.Add("Intrusion Detector: " + dr["Intrusion_Detector"].ToString());
                    listBox1.Items.Add("Heat Detector: " + dr["Heat_Detector"].ToString());
                    listBox1.Items.Add("Smoke Detector: " + dr["Smoke_Detector"].ToString());
                    listBox1.Items.Add("Gas Detector: " + dr["Gas_Detector"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Alarm fire")
            {
                cmd = new SqlCommand("select * From Alarm_fire where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Type of detector: " + dr["Type_of_detector"].ToString());
                }
                dr.Close();
               
            }

            if (choice_ == "Architectural DATA")
            {
                cmd = new SqlCommand("select * From Architectural_Data where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Door width: " + dr["Door_width"].ToString());
                    listBox1.Items.Add("Door lock: " + dr["Door_lock"].ToString());
                    listBox1.Items.Add("Door Material: " + dr["Door_Material"].ToString());
                    listBox1.Items.Add("Ceiling: " + dr["Ceiling"].ToString());
                    listBox1.Items.Add("Racks: " + dr["Racks"].ToString());
                    listBox1.Items.Add("Hooks: " + dr["Hooks"].ToString());
                    listBox1.Items.Add("Boards: " + dr["Boards"].ToString());
                    listBox1.Items.Add("Tracks: " + dr["Tracks"].ToString());
                    listBox1.Items.Add("Rails: " + dr["Rails"].ToString());
                    listBox1.Items.Add("Mirrors width: " + dr["Mirrors_width"].ToString());
                    listBox1.Items.Add("Mirrors height: " + dr["Mirrors_height"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Ceiling finishes")
            {
                cmd = new SqlCommand("select * From Ceiling_Finishes where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Acoustic: " + dr["Acoustic"].ToString());
                    listBox1.Items.Add("Washable: " + dr["Washable"].ToString());
                    listBox1.Items.Add("Special: " + dr["Special"].ToString());
                    listBox1.Items.Add("Height: " + dr["Height"].ToString());
                    listBox1.Items.Add("Other: " + dr["Other"].ToString());
                }
                dr.Close();

            }

            if (choice_ == "Clock system")
            {
                cmd = new SqlCommand("select * From Clock_System where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Synchronized: " + dr["Synchronized"].ToString());
                    listBox1.Items.Add("Stand_Alone: " + dr["Stand_Alone"].ToString());
                    listBox1.Items.Add("Clock 24 Hour: " + dr["Clk_24_Hour"].ToString());
                    listBox1.Items.Add("Clock 12 Hour: " + dr["Clk_12_Hour"].ToString());
                    listBox1.Items.Add("Elapsed Time: " + dr["Elapsed_Time"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Communications DATA")
            {
                cmd = new SqlCommand("select * From Communications_Data where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Bedhead Consoles: " + dr["Bedhead_Consoles"].ToString());
                    listBox1.Items.Add("Closed Circuit TV: " + dr["Closed_Circuit_TV"].ToString());
                    listBox1.Items.Add("Computer Terminal: " + dr["Computer_Terminal"].ToString());
                    listBox1.Items.Add("Computer Printer: " + dr["Computer_Printer"].ToString());
                    listBox1.Items.Add("Call System Emergency: " + dr["Call_System_Emergency"].ToString());
                    listBox1.Items.Add("Call System Audio: " + dr["Call_System_Audio"].ToString());
                    listBox1.Items.Add("Call System Audio Visual: " + dr["Call_System_Audio_Visual"].ToString());
                    listBox1.Items.Add("Patient Monitoring: " + dr["Patient_Monitoring"].ToString());
                    listBox1.Items.Add("Code Blue Cardiac: " + dr["Code_Blue_Cardiac"].ToString());
                    listBox1.Items.Add("Code White Panic: " + dr["Code_White_Panic"].ToString());
                    listBox1.Items.Add("Telephone: " + dr["Telephone"].ToString());
                    listBox1.Items.Add("Dictation: " + dr["Dictation"].ToString());
                    listBox1.Items.Add("Intercom: " + dr["Intercom"].ToString());
                    listBox1.Items.Add("Television: " + dr["Television"].ToString());
                    listBox1.Items.Add("Data: " + dr["Data"].ToString());
                    listBox1.Items.Add("Security TV: " + dr["Security_TV"].ToString());
                    listBox1.Items.Add("Access Control: " + dr["Access_Control"].ToString());
                    listBox1.Items.Add("Pocket Paging: " + dr["Pocket_Paging"].ToString());
                    listBox1.Items.Add("Public Address: " + dr["Public_Address"].ToString());
                    listBox1.Items.Add("Other: " + dr["Other"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Drainage")
            {
                cmd = new SqlCommand("select * From Drainage where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Sanitary: " + dr["Sanitary"].ToString());
                    listBox1.Items.Add("Acid: " + dr["Acid"].ToString());
                    listBox1.Items.Add("Radioisotopes: " + dr["Radioisotopes"].ToString());
                    listBox1.Items.Add("Grease: " + dr["Grease"].ToString());
                    listBox1.Items.Add("Oil: " + dr["Oil"].ToString());
                    listBox1.Items.Add("Solvents: " + dr["Solvents"].ToString());
                    listBox1.Items.Add("Plaster: " + dr["Plaster"].ToString());
                    listBox1.Items.Add("Floor Drain: " + dr["Floor_Drain"].ToString());
                    listBox1.Items.Add("Housekeeping Vacuum: " + dr["Housekeeping_Vacuum"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Electrical door")
            {
                cmd = new SqlCommand("select * From Electrical_Door where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Magnetic Door Position Switch: " + dr["Magnetic_Door_Position_Switch"].ToString());
                    listBox1.Items.Add("Electronic Door Locking Hardware: " + dr["Electronic_Door_Locking_Hardware"].ToString());
                    listBox1.Items.Add("Automatic Door Opener: " + dr["Automatic_Door_Opener"].ToString());
                    listBox1.Items.Add("Request to exit for Door shunt: " + dr["Request_to_exit_for_Door_shunt"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Fixture")
            {
                cmd = new SqlCommand("select * From Fixture where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Fixture Fittings:" + dr["Fixture_Fittings"].ToString());
                    listBox1.Items.Add("Single Bowl Sink length: " + dr["Single_Bowl_Sink_length"].ToString());
                    listBox1.Items.Add("Single Bowl Sink width: " + dr["Single_Bowl_Sink_width"].ToString());
                    listBox1.Items.Add("Single Bowl Sink height: " + dr["Single_Bowl_Sink_height"].ToString());
                    listBox1.Items.Add("Double Bowl Sink height: " + dr["Double_Bowl_Sink_height"].ToString());
                    listBox1.Items.Add("Double Bowl Sink Width: " + dr["Double_Bowl_Sink_Width"].ToString());
                    listBox1.Items.Add("Double Bowl Sink length: " + dr["Double_Bowl_Sink_length"].ToString());
                    listBox1.Items.Add("Accessories: " + dr["Accessories"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Floor finishes")
            {
                cmd = new SqlCommand("select * From Floor_Finishes where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Water Impervious: " + dr["Water_Impervious"].ToString());
                    listBox1.Items.Add("Resilient: " + dr["Resilient"].ToString());
                    listBox1.Items.Add("Carpet: " + dr["Carpet"].ToString());
                    listBox1.Items.Add("Chemical Resistant: " + dr["Chemical_Resistant"].ToString());
                    listBox1.Items.Add("Non skid: " + dr["Non_skid"].ToString());
                }
                dr.Close();


            }

            if (choice_ == "Gas")
            {
                cmd = new SqlCommand("select * From Gas where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Medical Vacuum: " + dr["Medical_Vacuum"].ToString());
                    listBox1.Items.Add("Medical Oxygen: " + dr["Medical_Oxygen"].ToString());
                    listBox1.Items.Add("Laboratory Vacuum: " + dr["Laboratory_Vacuum"].ToString());
                    listBox1.Items.Add("Medical Air: " + dr["Medical_Air"].ToString());
                    listBox1.Items.Add("Medical Nitrous Oxide: " + dr["Medical_Nitrous_Oxide"].ToString());
                    listBox1.Items.Add("Laboratory Compressed Air: " + dr["Laboratory_Compressed_Air"].ToString());
                    listBox1.Items.Add("Medical Nitrogen: " + dr["Medical_Nitrogen"].ToString());
                    listBox1.Items.Add("Natural Gas: " + dr["Natural_Gas"].ToString());
                    listBox1.Items.Add("Shop Compressed Air: " + dr["Shop_Compressed_Air"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Lighting")
            {
                cmd = new SqlCommand("select * From Lighting where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Ambient: " + dr["Ambient"].ToString());
                    listBox1.Items.Add("Task: " + dr["Task"].ToString());
                    listBox1.Items.Add("Examining: " + dr["Examining"].ToString());
                    listBox1.Items.Add("Colour Corrected: " + dr["Colour_Corrected"].ToString());
                    listBox1.Items.Add("Lighting Control: " + dr["Lighting_Control"].ToString());
                    listBox1.Items.Add("Imaging: " + dr["Imaging"].ToString());
                    listBox1.Items.Add("Other: " + dr["Other"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Mechanical DATA")
            {
                cmd = new SqlCommand("select * From Mechanical_Data where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Temperature: " + dr["Temperature"].ToString());
                    listBox1.Items.Add("Humidity: " + dr["Humidity"].ToString());
                    listBox1.Items.Add("Pressure: " + dr["Pressure"].ToString());
                    listBox1.Items.Add("Ventillation: " + dr["Ventillation"].ToString());
                    listBox1.Items.Add("Air returend: " + dr["Air_returend"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Room information")
            {
                cmd = new SqlCommand("select * From Room_Information where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Area: " + dr["Area"].ToString());
                    listBox1.Items.Add("Department: " + dr["Department"].ToString());
                    listBox1.Items.Add("Room Function: " + dr["R_Function"].ToString());
                    listBox1.Items.Add("use time: " + dr["use_time"].ToString());
                    listBox1.Items.Add("use days: " + dr["use_days"].ToString());
                    listBox1.Items.Add("normal number of patients: " + dr["normal_no_of_patients"].ToString());
                    listBox1.Items.Add("max number of patients: " + dr["max_no_of_patients"].ToString());
                    listBox1.Items.Add("normal number of occupants: " + dr["normal_no_of_occupants"].ToString());
                    listBox1.Items.Add("max number of occupants: " + dr["max_no_of_occupants"].ToString());
                    listBox1.Items.Add("normal number of staff: " + dr["normal_no_of_staff"].ToString());
                    listBox1.Items.Add("max number of staff: " + dr["max_no_of_staff"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Special Considerations")
            {
                cmd = new SqlCommand("select * From Special_Considerations where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Noise insulate walls: " + dr["Noise_insulate_walls"].ToString());
                    listBox1.Items.Add("Vibration: " + dr["Vibration"].ToString());
                    listBox1.Items.Add("Radiation Shielding: " + dr["Radiation_Shielding"].ToString());
                    listBox1.Items.Add("Magnetic Field: " + dr["Magnetic_Field"].ToString());
                    listBox1.Items.Add("Noxious Gas Vapour: " + dr["Noxious_Gas_Vapour"].ToString());
                    listBox1.Items.Add("Corrosion: " + dr["Corrosion"].ToString());
                    listBox1.Items.Add("Static Electricity: " + dr["Static_Electricity"].ToString());
                    listBox1.Items.Add("Natural Light View_Out: " + dr["Natural_Light_View_Out"].ToString());
                    listBox1.Items.Add("Special Floor Conditions: " + dr["Special_Floor_Conditions"].ToString());
                    listBox1.Items.Add("Special Ceiling Conditions: " + dr["Special_Ceiling_Conditions"].ToString());
                    listBox1.Items.Add("Local Scavenging System: " + dr["Local_Scavenging_System"].ToString());
                    listBox1.Items.Add("Speech Privacy Isolation: " + dr["Speech_Privacy_Isolation"].ToString());
                    listBox1.Items.Add("Glazed Partitions Doors: " + dr["Glazed_Partitions_Doors"].ToString());
                    listBox1.Items.Add("Laminar Flow Cabinet: " + dr["Laminar_Flow_Cabinet"].ToString());
                    listBox1.Items.Add("Fume Cabinet for Chemical: " + dr["Fume_Cabinet_for_Chemical"].ToString());
                    listBox1.Items.Add("Fume Cabinet for Radioactive: " + dr["Fume_Cabinet_for_Radioactive"].ToString());
                    listBox1.Items.Add("Fume Cabinet for Biohazard: " + dr["Fume_Cabinet_for_Biohazard"].ToString());
                    listBox1.Items.Add("Exhaust Canopy: " + dr["Exhaust_Canopy"].ToString());
                    listBox1.Items.Add("Exceptional Loading Floor: " + dr["Exceptional_Loading_Floor"].ToString());
                    listBox1.Items.Add("Exceptional Loading Wall: " + dr["Exceptional_Loading_Wall"].ToString());
                    listBox1.Items.Add("Exceptional Loading Ceilling: " + dr["Exceptional_Loading_Ceilling"].ToString());
                    listBox1.Items.Add("other: " + dr["other"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Special storage requirements")
            {
                cmd = new SqlCommand("select * From Special_Storage_Requirements where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Equipment: " + dr["Equipment"].ToString());
                    listBox1.Items.Add("Refrigerated: " + dr["Refrigerated"].ToString());
                    listBox1.Items.Add("Wheelchairs Stretchers: " + dr["Wheelchairs_Stretchers"].ToString());
                    listBox1.Items.Add("Medications: " + dr["Medications"].ToString());
                    listBox1.Items.Add("Narcotics: " + dr["Narcotics"].ToString());
                    listBox1.Items.Add("Photo Equipment: " + dr["Photo_Equipment"].ToString());
                    listBox1.Items.Add("Radiology Cassettes: " + dr["Radiology_Cassettes"].ToString());
                    listBox1.Items.Add("Solutions: " + dr["Solutions"].ToString());
                    listBox1.Items.Add("Supplies: " + dr["Supplies"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Storage component")
            {
                cmd = new SqlCommand("select * From Storage_Component where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Depth 300mm 12: " + dr["Depth_300mm_12"].ToString());
                    listBox1.Items.Add("Depth 450mm 18: " + dr["Depth_450mm_18"].ToString());
                    listBox1.Items.Add("Depth 600mm 24: " + dr["Depth_600mm_24"].ToString());
                    listBox1.Items.Add("Depth other: " + dr["Depth_other"].ToString());
                    listBox1.Items.Add("Cupboards Under: " + dr["Cupboards_Under"].ToString());
                    listBox1.Items.Add("Cupboards Above: " + dr["Cupboards_Above"].ToString());
                    listBox1.Items.Add("Cupboards Drawers: " + dr["Cupboards_Drawers"].ToString());
                    listBox1.Items.Add("Cupboards Full Height: " + dr["Cupboards_Full_Height"].ToString());
                    listBox1.Items.Add("Equipment Over: " + dr["Equipment_Over"].ToString());
                    listBox1.Items.Add("Equipment Under: " + dr["Equipment_Under"].ToString());
                    listBox1.Items.Add("Open Shelving Over Counter: " + dr["Open_Shelving_Over_Counter"].ToString());
                    listBox1.Items.Add("Open Shelving Under Counter: " + dr["Open_Shelving_Under_Counter"].ToString());
                    listBox1.Items.Add("Open Shelving Full height: " + dr["Open_Shelving_Full_height"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Wall finishes")
            {
                cmd = new SqlCommand("select * From Wall_Finishes where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Standard: " + dr["Standard"].ToString());
                    listBox1.Items.Add("Washable: " + dr["Washable"].ToString());
                    listBox1.Items.Add("Water Impervious: " + dr["Water_Impervious"].ToString());
                    listBox1.Items.Add("Special Protection: " + dr["Special_Protection"].ToString());
                    listBox1.Items.Add("other: " + dr["other"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Water")
            {
                cmd = new SqlCommand("select * From Water where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Domestic Hot Water 82c: " + dr["Domestic_Hot_Water_82c"].ToString());
                    listBox1.Items.Add("Domestic Hot Water 43c: " + dr["Domestic_Hot_Water_43c"].ToString());
                    listBox1.Items.Add("Domestic Hot Water 60c: " + dr["Domestic_Hot_Water_60c"].ToString());
                    listBox1.Items.Add("Domestic Cold Water: " + dr["Domestic_Cold_Water"].ToString());
                    listBox1.Items.Add("Distilled Water Localized: " + dr["Distilled_Water_Localized"].ToString());
                    listBox1.Items.Add("Softened Water: " + dr["Softened_Water"].ToString());
                    listBox1.Items.Add("De Ionized Water Localized: " + dr["De_Ionized_Water_Localized"].ToString());
                    listBox1.Items.Add("Dialysate Water Localized: " + dr["Dialysate_Water_Localized"].ToString());
                    listBox1.Items.Add("Particulate Filtered Water: " + dr["Particulate_Filtered_Water"].ToString());
                    listBox1.Items.Add("Fire Suppression Sprinkler: " + dr["Fire_Suppression_Sprinkler"].ToString());
                    listBox1.Items.Add("Other: " + dr["Other"].ToString());
                    listBox1.Items.Add("Max Micron Size: " + dr["Max__Micron_Size"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Window")
            {
                cmd = new SqlCommand("select * From Window where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Exterior: " + dr["Exterior"].ToString());
                    listBox1.Items.Add("Interior: " + dr["Interior"].ToString());
                    listBox1.Items.Add("Operable: " + dr["Operable"].ToString());
                }
                dr.Close();
            }

            if (choice_ == "Work surface")
            {
                cmd = new SqlCommand("select * From Work_Surface where R_number =  '" + R_num_ + "' ", myConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add("Moveable: " + dr["Moveable"].ToString());
                    listBox1.Items.Add("Fixed: " + dr["Fixed"].ToString());
                    listBox1.Items.Add("Standing Height 900 36: " + dr["Standing_Height_900_36"].ToString());
                    listBox1.Items.Add("Sitting Height 750 30: " + dr["Sitting_Height_750_30"].ToString());
                    listBox1.Items.Add("Depth 600mm 24: " + dr["Depth_600mm_24"].ToString());
                    listBox1.Items.Add("Depth 900mm 36: " + dr["Depth_900mm_36"].ToString());
                    listBox1.Items.Add("Depth other: " + dr["Depth_other"].ToString());
                    listBox1.Items.Add("Stainless Steel: " + dr["Stainless_Steel"].ToString());
                    listBox1.Items.Add("Wood: " + dr["Wood"].ToString());
                    listBox1.Items.Add("Acid Resistant: " + dr["Acid_Resistant"].ToString());
                    listBox1.Items.Add("other special surface: " + dr["other_special_surface"].ToString());
                }
                dr.Close();
            }

            WinAPI.AnimateWindow(this.Handle, 250, WinAPI.BLEND);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
