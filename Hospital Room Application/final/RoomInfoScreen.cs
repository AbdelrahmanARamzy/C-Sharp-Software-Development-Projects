using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace final
{
    public partial class RoomInfoScreen : Form
    {
        private const string RoomInfoTableName = "Room_Information";
        private const string AdditionalItemsTableName = "Additional_items";
        private const string ArchitecturalDataTableName = "Architectural_Data";
        private const string CommunicationDataTableName = "Communications_Data";
        private const string CeilingTableName = "Ceiling_Finishes";
        private const string ClockTableName = "Clock_System";
        private const string AlarmTableName = "Alarm_Detection";

        /// <summary>
        /// the connectioin to the database
        /// </summary>
        SqlConnection myConnection;

        /// <summary>
        /// Holds the sql command that will be executed
        /// </summary>
        private SqlCommand command;

        /// <summary>
        /// Inserted room number
        /// </summary>
        private string roomNumber;

        /// <summary>
        /// Mapping each table name to its columns name and text boxes entries
        /// </summary>
        private Dictionary<string, Dictionary<string, string>> TablesDictionary;

        public RoomInfoScreen()
        {
            this.InitializeComponent();
            this.InitializeTablesInfo();
            this.myConnection = new SqlConnection(Program.ConnectionString);
            this.myConnection.Open();
        }

        /// <summary>
        /// Initializes screen's info and ui inputs
        /// </summary>
        private void InitializeTablesInfo()
        {
            this.TablesDictionary = new Dictionary<string, Dictionary<string, string>>()
            {
                {RoomInfoTableName,
                    new Dictionary<string, string>()
                    {
                        {"R_number", this.textBox2.Text },
                        {"Area", this.textBox3.Text },
                        {"Department", this.textBox4.Text },
                        {"R_Function", this.textBox5.Text },
                        {"use_time", this.textBox6.Text },
                        {"use_days", this.textBox7.Text },
                        {"normal_no_of_patients", this.textBox8.Text },
                        {"max_no_of_patients", this.textBox9.Text },
                        {"normal_no_of_occupants", this.textBox10.Text },
                        {"max_no_of_occupants", this.textBox11.Text },
                        {"normal_no_of_staff", this.textBox12.Text },
                        {"max_no_of_staff", this.textBox13.Text }
                    }
                },
                {AdditionalItemsTableName,
                    new Dictionary<string, string>()
                    {
                        {"R_number", this.textBox2.Text },
                        {"Equipment_item", this.textBox17.Text },
                        {"Equipment_number", this.textBox16.Text },
                        {"Furniture_items", this.textBox15.Text },
                        {"Furniture_number", this.textBox14.Text },
                        {"Millwork_items", this.textBox1.Text }
                    }
                },
                {ArchitecturalDataTableName,
                    new Dictionary<string, string>()
                    {
                        {"R_number", this.textBox2.Text },
                        {"Mirrors_width", this.textBox19.Text },
                        {"Mirrors_height", this.textBox18.Text }
                    }
                },
                {CommunicationDataTableName,
                    new Dictionary<string, string>()
                    {
                        {"R_number", this.textBox2.Text },
                        {"Computer_Printer", this.textBox22.Text },
                        {"Computer_Terminal", this.textBox21.Text },
                        {"Other", this.textBox20.Text }
                    }
                },
                {CeilingTableName,
                    new Dictionary<string, string>()
                    {
                        {"R_number", this.textBox2.Text },
                        {"Height", this.textBox23.Text },
                    }
                },
                {ClockTableName,
                    new Dictionary<string, string>()
                    {
                        {"R_number", this.textBox2.Text },
                    }
                },
                {AlarmTableName,
                    new Dictionary<string, string>()
                    {
                        {"R_number", this.textBox2.Text },
                    }
                },
            };
        }

        /// <summary>
        /// Excutes insert query on the given table name
        /// </summary>
        /// <param name="tableName">
        /// the table whose value will be inserted
        /// </param>
        private void ExecuteInsertSqlCommand(string tableName, Dictionary<string, string> tableEntries)
        {
            if (this.command == null)
            {
                this.command = this.myConnection.CreateCommand();
            }

            var columns = this.BuildQueryString(tableEntries.Keys.ToList());
            var values = this.BuildQueryString(tableEntries.Values.ToList(), true);

            this.command.CommandText = @" INSERT INTO " + tableName + " " + columns + " VALUES " + values;
            this.command.ExecuteNonQuery();
            this.command = null;
        }

        /// <summary>
        /// Saves current user input and proceeds to room specs screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.roomNumber = this.textBox2.Text;

            foreach(var table in this.TablesDictionary)
            {
                this.ExecuteInsertSqlCommand(table.Key, table.Value);
            }

            this.DisplayNextScreen();
        }

        /// <summary>
        /// Back to main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainScreen = new Form2();
            mainScreen.Show();
        }

        /// <summary>
        /// Displays next screen after the operations are done
        /// </summary>
        private void DisplayNextScreen()
        {
            this.Hide();
            RoomSpecificationsScreen roomSpecsScreen = new RoomSpecificationsScreen(this.roomNumber);
            roomSpecsScreen.Show();
        }

        /// <summary>
        /// Contructs a query string for the giiven columns or values string list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="isInsertedValue"></param>
        /// <returns></returns>
        private string BuildQueryString(List<string> list, bool isInsertedValue = false)
        {
            string temp = "(";

            for (int i = 0; i < list.Count; i++)
            {
                temp = isInsertedValue ? temp + "'" + list[i] + "'" : temp = temp + list[i] + ", ";
                temp = i < list.Count - 1 ? temp + ", " : temp;
            }

            temp = temp + ")";
            return temp;
        }
    }
}