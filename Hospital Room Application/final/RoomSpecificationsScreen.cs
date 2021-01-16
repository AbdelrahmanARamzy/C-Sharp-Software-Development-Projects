using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace final
{
    public partial class RoomSpecificationsScreen : Form
    {
        private const string DrianageTableName = "Drainage";
        private const string GasTableName = "Gas";
        private const string CommunicationTableName = "Communications_Data";
        private const string FloorTableName = "Floor_Finishes";

        /// <summary>
        /// Maps each table name to its column/checkbox mapping
        /// </summary>
        private Dictionary<string, List<CheckBox>> TablesDictionary = new Dictionary<string, List<CheckBox>>();

        /// <summary>
        /// Maps each column name to its check box
        /// </summary>
        private Dictionary<CheckBox, string> ColumnsByCheckBoxes;

        /// <summary>
        /// the connectioin to the database
        /// </summary>
        private SqlConnection myConnection;

        /// <summary>
        /// Holds the sql command that will be executed
        /// </summary>
        private SqlCommand command;

        /// <summary>
        /// Inserted room number
        /// </summary>
        private string roomNumber;

        public RoomSpecificationsScreen(string roomNumber)
        {
            this.InitializeComponent();

            this.InitializeScreen();
            this.myConnection = new SqlConnection(Program.ConnectionString);
            this.myConnection.Open();
            this.roomNumber = roomNumber;
        }

        /// <summary>
        /// Initializes current form's data structures
        /// </summary>
        private void InitializeScreen()
        {
            this.InitializeCheckBoxesdictionary();
            this.InitializeDrainageCheckBoxesList();
            this.InitializeFloorsCheckBoxesList();
            this.InitializeGasCheckBoxesList();
            this.InitializeCommunicationCheckBoxesList();
        }

        /// <summary>
        /// Initializes drainage table to handle user's UI input
        /// </summary>
        private void InitializeDrainageCheckBoxesList()
        {
            var drainageTableCheckBoxes = new List<CheckBox>()
            {
                this.checkBox6,
                this.checkBox7,
                this.checkBox8,
                this.checkBox9,
                this.checkBox10,
                this.checkBox11,
                this.checkBox12,
                this.checkBox13,
                this.checkBox14
            };

            this.TablesDictionary.Add(DrianageTableName, drainageTableCheckBoxes);
        }

        /// <summary>
        /// Initializes gas table to handle user's UI input
        /// </summary>
        private void InitializeGasCheckBoxesList()
        {
            var gasTableCheckBoxes = new List<CheckBox>()
            {
                this.checkBox34,
                this.checkBox35,
                this.checkBox36,
                this.checkBox37,
                this.checkBox38,
                this.checkBox39,
                this.checkBox40,
                this.checkBox41,
                this.checkBox42
            };

            this.TablesDictionary.Add(GasTableName, gasTableCheckBoxes);
        }

        /// <summary>
        /// Initializes communication table to handle user's UI input
        /// </summary>
        private void InitializeCommunicationCheckBoxesList()
        {
            var communicationTableCheckBoxes = new List<CheckBox>()
            {
                this.checkBox15,
                this.checkBox16,
                this.checkBox17,
                this.checkBox18,
                this.checkBox19,
                this.checkBox20,
                this.checkBox21,
                this.checkBox22,
                this.checkBox23,
                this.checkBox24,
                this.checkBox25,
                this.checkBox26,
                this.checkBox27,
                this.checkBox28,
                this.checkBox29,
                this.checkBox30,
                this.checkBox31,
                this.checkBox32,
                this.checkBox33
            };

            this.TablesDictionary.Add(CommunicationTableName, communicationTableCheckBoxes);
        }

        /// <summary>
        /// Initializes floor table to handle user's UI input
        /// </summary>
        private void InitializeFloorsCheckBoxesList()
        {
            var floorTableCheckBoxes = new List<CheckBox>()
            {
                this.checkBox1,
                this.checkBox2,
                this.checkBox3,
                this.checkBox4,
                this.checkBox5
            };

            this.TablesDictionary.Add(FloorTableName, floorTableCheckBoxes);
        }

        /// <summary>
        /// Mapping each column name to its corresponding check box
        /// </summary>
        private void InitializeCheckBoxesdictionary()
        {
            this.ColumnsByCheckBoxes = new Dictionary<CheckBox, string>()
            {
                {this.checkBox10, "Sanitary" },
                {this.checkBox9, "Acid" },
                {this.checkBox8, "Radioisotopes" },
                {this.checkBox7, "Grease" },
                {this.checkBox6, "Oil" },
                {this.checkBox11, "Solvents" },
                {this.checkBox12, "Plaster" },
                {this.checkBox13, "Floor_Drain" },
                {this.checkBox14, "Housekeeping_Vacuum" },

                {this.checkBox42, "Medical_Vacuum" },
                {this.checkBox41, "Medical_Oxygen" },
                {this.checkBox40, "Laboratory_Vacuum" },
                {this.checkBox39, "Medical_Air" },
                {this.checkBox38, "Medical_Nitrous_Oxide" },
                {this.checkBox37, "Laboratory_Compressed_Air" },
                {this.checkBox36, "Medical_Nitrogen" },
                {this.checkBox35, "Natural_Gas" },
                {this.checkBox34, "Shop_Compressed_Air" },

                {this.checkBox15, "Bedhead_Consoles" },
                {this.checkBox17, "Closed_Circuit_TV" },
                {this.checkBox16, "Computer_Terminal" },
                {this.checkBox18, "Computer_Printer" },
                {this.checkBox19, "Call_System_Emergency" },
                {this.checkBox20, "Call_System_Audio" },
                {this.checkBox21, "Call_System_Audio_Visual" },
                {this.checkBox22, "Patient_Monitoring" },
                {this.checkBox23, "Code_Blue_Cardiac" },
                {this.checkBox24, "Code_White_Panic" },
                {this.checkBox25, "Telephone" },
                {this.checkBox26, "Dictation" },
                {this.checkBox27, "Intercom" },
                {this.checkBox28, "Television" },
                {this.checkBox29, "Data" },
                {this.checkBox30, "Security_TV" },
                {this.checkBox31, "Access_Control" },
                {this.checkBox32, "Pocket_Paging" },
                {this.checkBox33, "Public_Address" },

                {this.checkBox1, "Water_Impervious" },
                {this.checkBox2, "Resilient" },
                {this.checkBox3, "Carpet" },
                {this.checkBox4, "Chemical_Resistant" },
                {this.checkBox5, "Non_skid" },
            };
        }

        /// <summary>
        /// Excutes insert query on the given table name
        /// </summary>
        /// <param name="tableName">
        /// the table whose value will be inserted
        /// </param>
        private void ExecuteInsertSqlCommand(string tableName)
        {
            if(this.command == null)
            {
                this.command = this.myConnection.CreateCommand();
            }

            this.command.CommandText = @" INSERT INTO " + tableName + " (R_number) VALUES ('" + this.roomNumber + "')";
            this.command.ExecuteNonQuery();
            this.command = null;
        }

        /// <summary>
        /// Excutes update query on the given table name
        /// </summary>
        /// <param name="tableName">
        /// the table whose value will be updated
        /// </param>
        private void ExecuteUpdateSqlCommand(CheckBox checkBox, string tableName)
        {
            if (this.command == null)
            {
                this.command = this.myConnection.CreateCommand();
            }

            var columnName = this.ColumnsByCheckBoxes[checkBox];

            this.command.CommandText = checkBox.Checked? @"UPDATE " + tableName + " SET " + columnName + " = 1 WHERE R_number = '" + this.roomNumber + "'":
                @"UPDATE " + tableName + " SET " + columnName + " = 0 WHERE R_number = '" + this.roomNumber + "'";

            this.command.ExecuteNonQuery();
            this.command = null;
        }

        /// <summary>
        /// Inserts data into a table based on the UI inputs
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="checkBoxes"></param>
        private void InsertTableData(string tableName, List<CheckBox> checkBoxes)
        {
            foreach (var checkBox in checkBoxes)
            {
                this.ExecuteUpdateSqlCommand(checkBox, tableName);
            }
        }

        /// <summary>
        /// Saves room specs and returns to the main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var tableName in this.TablesDictionary.Keys.ToList())
            {
                this.ExecuteInsertSqlCommand(tableName);
            }

            foreach (var table in this.TablesDictionary)
            {
                this.InsertTableData(table.Key, table.Value);
            }

            this.BackToMainScreen();
            MessageBox.Show("Room information has been added successfully");
        }

        /// <summary>
        /// Returns to home screen
        /// </summary>
        private void BackToMainScreen()
        {
            this.Hide();
            var mainScreen = new Form2();
            mainScreen.Show();
        }

        /// <summary>
        /// Back to room info screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomInfoScreen roomInfoScreen = new RoomInfoScreen();
            roomInfoScreen.Show();
        }
    }
}
