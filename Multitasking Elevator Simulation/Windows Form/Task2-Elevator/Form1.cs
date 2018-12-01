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
        private SerialPort myPort;

        //Floor Number defination
        private int currentFloor;
        private int defaultFloor = 1;
        private int mFloor;

        private string recievedData;
        //private string buttonState;

        private bool goingUp = false;
        private bool goingDown = false;
        public Form1()
        {
            InitializeComponent();
            //init(); // connect to arduino
            currentFloor = defaultFloor;
            label8.Text = currentFloor.ToString();
            //label4.Text = recievedData;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
                MessageBox.Show("Error Connecting Arduino");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveElevator(1);
        }

        private void MoveElevator(int headFloor)
        {
            //get the floor difference
            int floorDiff = Math.Abs(currentFloor - headFloor);
            //decide which direction to go
            if (currentFloor < headFloor)
            {
                goingUp = true;
                label6.Text = "Going Up";
            }
            else if (currentFloor > headFloor)
            {
                goingDown = true;
                label6.Text = "Going Down";
            }
            else
            {
                MessageBox.Show("Already Here");
            }

            for (int i=0; i<floorDiff; i++)
            {

                if (goingUp)
                {
                    //increase of decrease floor num
                    currentFloor++;
                    //get the current floor
                    label8.Text = currentFloor.ToString();
                }
                else if (goingDown)
                {
                    //decrease of decrease floor num
                    currentFloor--;
                    //get the current floor
                    label8.Text = currentFloor.ToString();
                }
                //delay 2 sec
                timeDelay();
            }
            goingDown = false;
            goingUp = false;
            label6.Text = "Stopped";
            ButtonControlCheck();
        }

        public void timeDelay()
        {
            Application.DoEvents();
            if (goingUp)
            {
                label6.Text = "Going Up";
            }
            else if (goingDown)
            {
                label6.Text = "Going Down";
            }
            //delay
            Thread.Sleep(2000);
        }

        private void ButtonControlCheck()
        {
            if (currentFloor == 5)
            {
                upBtn.Enabled = false;
            }
            else
            {
                upBtn.Enabled = true;
            }

            if (currentFloor == 1)
            {
                downBtn.Enabled = false;
            }
            else
            {
                downBtn.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveElevator(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveElevator(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MoveElevator(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoveElevator(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //up btn
            try
            {
                //mFloor = int.Parse(textBox1.Text);
                mFloor = int.Parse(recievedData);

                if (mFloor <= 5 && mFloor >= 1)
                {
                    if (currentFloor < mFloor)
                    {
                        CallElevator(mFloor);
                    }
                    else
                    {
                        MessageBox.Show("Can't do this");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the right number");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the number of your floor");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //down btn
            try
            {
                //mFloor = int.Parse(textBox1.Text);
                mFloor = int.Parse(recievedData);

                if (mFloor <= 5 && mFloor >= 1)
                {
                    if(currentFloor > mFloor)
                    {
                        CallElevator(mFloor);
                    }
                    else
                    {
                        MessageBox.Show("Can't do this");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the right number");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the number of your floor");
            }
        }

        private void CallElevator(int mFloor)
        {
            //get the floor difference
            int floorDiff = Math.Abs(currentFloor - mFloor);
            //decide which direction to go
            if (currentFloor < mFloor)
            {
                goingUp = true;
                label6.Text = "Going Up";
            }
            else if (currentFloor > mFloor)
            {
                goingDown = true;
                label6.Text = "Going Down";
            }
            else
            {
                MessageBox.Show("Already Here");
            }

            for (int i = 0; i < floorDiff; i++)
            {

                if (goingUp)
                {
                    //increase of decrease floor num
                    currentFloor++;
                    //get the current floor
                    label8.Text = currentFloor.ToString();
                }
                else if (goingDown)
                {
                    //decrease of decrease floor num
                    currentFloor--;
                    //get the current floor
                    label8.Text = currentFloor.ToString();
                }
                //delay 2 sec
                timeDelay();
            }
            goingDown = false;
            goingUp = false;
            CheckStatus();
            ButtonControlCheck();
            label6.Text = "Stopped";
        }
        private void CheckStatus()
        {
            //Maintain Up Btn Status
            if (currentFloor > mFloor)
            {
                upBtn.Enabled = false;
            }
            else
            {
                upBtn.Enabled = true;
            }

            //Maintain Down Btn Status
            if (currentFloor < mFloor)
            {
                downBtn.Enabled = false;
            }
            else
            {
                downBtn.Enabled = true;
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
                //label4.Text = recievedData;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Connecting Arduino");
            }
        }

        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            recievedData = myPort.ReadLine();
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
                MessageBox.Show("Error Disconnecting Arduino");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
