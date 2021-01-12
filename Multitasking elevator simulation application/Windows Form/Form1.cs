using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Task2_Elevator
{
    public partial class Form1 : Form
    {
        private const int FirstFloorIndex = 1;
        private const int SecondFloorIndex = 2;
        private const int ThirdFloorIndex = 3;
        private const int ForthFloorIndex = 4;
        private const int FifthFloorIndex = 5;

        /// <summary>
        /// Determines elevator's different states
        /// </summary>
        private enum ElevatorState
        {
            Idle,
            Up,
            Down
        }

        /// <summary>
        /// Port that will be used in arduino connection
        /// </summary>
        private SerialPort myPort;

        /// <summary>
        /// Current elevator floor
        /// </summary>
        private int currentFloor;

        /// <summary>
        /// Recieved floor index
        /// </summary>
        private int recievedFloorIndex;

        /// <summary>
        /// Recieved data from arduino
        /// </summary>
        private string recievedData;

        /// <summary>
        /// Determines elevator's current state
        /// </summary>
        private ElevatorState elevatorState = ElevatorState.Idle;

        public Form1()
        {
            this.InitializeComponent();
            this.init();
            this.currentFloor = FirstFloorIndex;
            this.elevatorState = ElevatorState.Idle;
            this.label8.Text = currentFloor.ToString();
            this.label4.Text = recievedData;
        }

        /// <summary>
        /// Connects to arduino
        /// </summary>
        private void init()
        {
            try
            {
                myPort = new SerialPort();
                myPort.BaudRate = 9600;
                myPort.PortName = "COM7";
                myPort.Open();

                while (true)
                {
                    recievedData = myPort.ReadLine();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting Arduino!");
            } 
        }

        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.recievedData = myPort.ReadLine();
        }

        /// <summary>
        /// Controls elevator's movement logic
        /// </summary>
        /// <param name="headFloor"></param>
        private void MoveElevator(int headFloor)
        {
            int floorDiff = Math.Abs(this.currentFloor - headFloor);

            this.DecideElevatorState();

            for (int i=0; i < floorDiff; i++)
            {
                if (this.elevatorState == ElevatorState.Up)
                {
                    this.currentFloor++;
                    label8.Text = this.currentFloor.ToString();
                }
                else if (this.elevatorState == ElevatorState.Down)
                {
                    this.currentFloor--;
                    label8.Text = this.currentFloor.ToString();
                }

                this.TimeDelay();
            }

            this.label6.Text = "Stopped";
            this.ChangeButtonsState();
        }

        /// <summary>
        /// Decides current elecator state based on the current floor
        /// </summary>
        private void DecideElevatorState()
        {
            if (this.currentFloor < headFloor)
            {
                this.elevatorState = ElevatorState.Up;
                this.label6.Text = "Going Up";
            }
            else if (this.currentFloor > headFloor)
            {
                this.elevatorState = ElevatorState.Down;
                this.label6.Text = "Going Down";
            }
            else
            {
                this.elevatorState = ElevatorState.Idle;
                MessageBox.Show("Destination reached!");
            }
        }

        /// <summary>
        /// Added a specific time delay after finishing an operation
        /// </summary>
        public void TimeDelay()
        {
            Application.DoEvents();

            if (this.elevatorState == ElevatorState.Up)
            {
                label6.Text = "Going Up";
            }
            else if (this.elevatorState == ElevatorState.Down)
            {
                label6.Text = "Going Down";
            }

            Thread.Sleep(2000);
        }

        /// <summary>
        /// Change buttons state based on the current floor
        /// </summary>
        private void ChangeButtonsState()
        {
            this.upBtn.Enabled = !(this.currentFloor == 5);
            this.downBtn.Enabled = !(this.currentFloor == 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MoveElevator(FirstFloorIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MoveElevator(SecondFloorIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.MoveElevator(ThirdFloorIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.MoveElevator(ForthFloorIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.MoveElevator(FifthFloorIndex);
        }

        /// <summary>
        /// Up button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.recievedFloorIndex = int.Parse(this.recievedData);

                if (this.recievedFloorIndex <= 5 && this.recievedFloorIndex >= 1)
                {
                    if (this.currentFloor > this.recievedFloorIndex)
                    {
                        this.MessageBox.Show("Can't do this");
                        return;
                    }

                    this.MoveElevator(this.recievedFloorIndex);
                }
                else
                {
                    MessageBox.Show("Please Enter the right number...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the number of your floor...");
            }
        }

        /// <summary>
        /// Down button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.recievedFloorIndex = int.Parse(this.recievedData);

                if (this.recievedFloorIndex <= 5 && recievedFloorIndex >= 1)
                {
                    if(this.currentFloor < this.recievedFloorIndex)
                    {
                        MessageBox.Show("Can't do this");
                        return;
                    }

                    this.MoveElevator(this.recievedFloorIndex);
                }
                else
                {
                    MessageBox.Show("Please Enter the right number...");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the number of your floor...");
                return;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            myPort = new SerialPort();
            myPort.BaudRate = 9600;
            myPort.PortName = "COM6";
            myPort.DataReceived += myPort_DataReceived;

            try
            {
                myPort.Open();
                label3.Text = "Status: Connected";
            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting Arduino!");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                myPort.Close();
                label3.Text = "Status: Disconnected";
            }
            catch (Exception)
            {
                MessageBox.Show("Error Disconnecting Arduino!");
            }
        }
    }
}
