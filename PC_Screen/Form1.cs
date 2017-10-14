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

namespace PC_Screen
{
    
   public partial class PC_screenForm : Form
    {
        const int DEL_Key = 127;  
        private static String RxString;
        private static UInt32 ByteCounter = 0;
        byte[] ByteOfData = new byte[1];
        #region inilization
        public PC_screenForm()
        {
            InitializeComponent();
            GetAvaliablePorts();
            EndBtn.Enabled = false;
            StartBtn.Enabled = false;
        }
        #endregion
        #region Done.
        private void GetAvaliablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            PortLists.Items.AddRange(ports);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InitBtn_Click(object sender, EventArgs e)
        {

            /*Try to not open used ports*/
            try
            {
                /*Selecting the port*/
                serialPortRead.PortName = PortLists.Text;
                /*You should setup what's COM will use in setup*/
                if (!serialPortRead.IsOpen)
                {
                    /*Open the ports*/
                    serialPortRead.Open();

                    /*Write the status of the ports*/
                    labelstatus.Text = serialPortRead.PortName + " Ready!\n";

                    /*Disable the init button as it's inilized */
                    StartBtn.Enabled = false;
                    EndBtn.Enabled = true;
                    PortLists.Enabled = false;
                    ByteCounter = 0;
                }
                else
                {
                    labelstatus.Text = "The port is not opened";
                }

            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            catch (SystemException)
            {
                MessageBox.Show("USB Device For Communication Is Not Connected");
            }


        }

        private void PortLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartBtn.Enabled = true;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            PortLists.Items.Clear();
            GetAvaliablePorts();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            serialPortRead.Close();
            ReadTextBox.Text = "";
            EndBtn.Enabled = false;
            StartBtn.Enabled = true;
            PortLists.Enabled = true;
            ReadTextBox.Text = "";
            ByteCounter = 0;
            labelstatus.Text = "Stopped !";
        }
        #endregion

        private void serialPortRead_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
             /*This is an event which will be called in case of reciveing data*/
            try
            {
               RxString = serialPortRead.ReadExisting();
               ByteOfData = Encoding.ASCII.GetBytes(RxString);
               this.Invoke(new EventHandler(DisplayText));
            }

            catch (System.TimeoutException) { }

        }

        private void DisplayText(object s, EventArgs e)
        {
            
           if (ByteOfData[0] != DEL_Key)
            {
                ReadTextBox.AppendText(RxString.ToString());
                ByteCounter = ByteCounter + Convert.ToUInt32(RxString.Length);
                labelstatus.Text = "Recived " + ByteCounter + " bytes";
            }
           else
            {
                ReadTextBox.Text = "";
                ByteCounter = 0;
                labelstatus.Text = "Cleared !";
            }
        }

        private void PC_screenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPortRead.Close();
        }

        private void ReadTextBox_TextChanged(object sender, EventArgs e)
        {
            ReadTextBox.SelectionStart = ReadTextBox.Text.Length; //Set the current caret position at the end
            ReadTextBox.ScrollToCaret(); //Now scroll it automatically
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ReadTextBox.Text = "";
            ByteCounter = 0;
            labelstatus.Text = "Cleared !";
        }

        private void Settingbtn_Click(object sender, EventArgs e)
        {
            SettingForm uartSetting = new SettingForm();
            uartSetting.ShowDialog();

        }
        
    }
}
