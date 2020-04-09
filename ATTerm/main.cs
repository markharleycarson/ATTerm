using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace ATTerm
{
    public partial class Form1 : Form
    {
        char rxd;
        string[] ports;
        SerialPort serialPort1;
        // delegate is used to write to a UI control from a non-UI thread  
        private delegate void SetTextDeleg(string text);
        public Form1()
        {

            InitializeComponent();

            ports = SerialPort.GetPortNames();     // ports list
            cmbBaud.Items.Add(9600);               // baud rates
            cmbBaud.Items.Add(19200);
            cmbBaud.Items.Add(38400);
            cmbBaud.Items.Add(57600);
            cmbBaud.Items.Add(115200);

            for( int i = 0; i < ports.Length; i++)
            {
                cmbPort.Items.Add(ports[i]);
            }

            cmbPort.SelectedItem = 0;   // 'COM no 1
            cmbBaud.SelectedItem = 0;

            //openFileDialog1
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.Filter = "TXT files|*.txt";
            openFileDialog1.InitialDirectory = Application.ExecutablePath; //@"C:\";
            

            btnDisconnect.Enabled = true;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("          AT GSM Application        " + Environment.NewLine +
               "             version: 1.0.0.10         " + Environment.NewLine +
               "          MH Carson       " + Environment.NewLine +
               "" + Environment.NewLine +
               " Donations and Assistance: https://ko-fi.com/markcarson" + Environment.NewLine +
               " https://github.com/markharleycarson/ATTerm " + Environment.NewLine +
               "  (based on original idea https://github.com/oakkar7 and ATCommand?) "
               );
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
            Close();
        
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnDisconnect.Text == "Connect")
                {
                    serialPort1 = new SerialPort(cmbPort.Text, Convert.ToInt32(cmbBaud.Text));

                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort2_DataReceived);
                    //Other Serial Port Property
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataBits = 8;                   //Open serial port
                    serialPort1.ReadTimeout = 2000;
                    serialPort1.WriteTimeout = 2000;

                    serialPort1.Open();

                    btnDisconnect.Text = "Disconnect";
                }
                else
                {
                    serialPort1.Close();
                    btnDisconnect.Text = "Connect";
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                serialPort1.Close();
                btnDisconnect.Text = "Connect";
            }
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string strres = serialPort1.ReadExisting();
            //The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.  
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { strres });

        }
        private void si_DataReceived(string data)
        {
            txtResults.AppendText(data + Environment.NewLine);
            //
            txtResultsHex.AppendText(StrToHex(data) + Environment.NewLine);
        }
        private string StrToHex(string data)
        {
            byte[] ba = Encoding.Default.GetBytes(data);
            var hexString = BitConverter.ToString(ba);
            //hexString = hexString.Replace("-", "");

            return hexString;
        }

        private void btnAT_Click(object sender, EventArgs e)
        {
            Button button;
            if (serialPort1 == null)
            {
                return;
            }
            string strRes = sender.GetType().Name;
            if ((sender is Button) && (serialPort1.IsOpen == true))
            {
                button = sender as Button;
            } else
            {
                return;
            }
            //
            switch (button.Name) 
            {
                case "btnAddCmd":
                    {
                        serialPort1.Write(txtSendCmd.Text);
                        if (chkAddCR.Checked == true)
                        {
                            serialPort1.Write("\r");
                        }
                        if (chkAddLF.Checked == true)
                        {
                            serialPort1.Write("\n");
                        }
                        break;
                    }
                case "btnAT":
                {
                    serialPort1.Write(txtAT.Text + "\r");
                    break;
                }
                case "btnSignal":
                    {
                        serialPort1.Write(txtSignal.Text + "\r");
                        break;
                    }
                case "btnNetwork":
                    {
                        serialPort1.Write(txtNetwork.Text + "\r");
                        break;
                    }
                //
                case "btnVersions":
                    {
                        if (chkInfo.Checked == true)
                        {
                            serialPort1.Write(txtInfo.Text + "\r");
                            Thread.Sleep(1000);
                        }
                        if (chkHW.Checked == true)
                        {
                            serialPort1.Write(txtHW.Text + "\r");
                            Thread.Sleep(1000);
                        }
                        if (chkFW.Checked == true)
                        {
                            serialPort1.Write(txtFW.Text + "\r");
                            Thread.Sleep(1000);
                        }
                        break;
                    }
                case "btnReset":
                    {
                        serialPort1.Write(txtReset.Text + "\r");
                        break;
                    }
                case "btnSave":
                    {
                        serialPort1.Write(txtSave.Text + "\r");
                        break;
                    }
                case "btnPower":
                    {
                        serialPort1.Write(txtPower.Text + "\r");
                        break;
                    }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open script file openFileDialog1
            Stream myStream = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName.ToString());
                txtScript.Text = "";
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    { 
                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                        {
                            String line = sr.ReadToEnd();
                            txtScript.Text = line;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intCurLine = 0;
            string strCurrentLine = "";
            // parse script and run
            try
            {
                while (txtScript.Lines.Length > intCurLine)
                {
                    strCurrentLine = txtScript.Lines[intCurLine];
                    strCurrentLine = strCurrentLine.Trim();
                    // test empty line skip
                    if (strCurrentLine == "")
                    {
                        intCurLine++;
                        continue;
                    }
                    // test comments skip line
                    if (strCurrentLine.Substring(0,2) == "//")
                    {
                        intCurLine++;
                        continue;
                    }
                    serialPort1.Write(strCurrentLine + "\r");
                    intCurLine++;
                    if (chkSleepScript.Checked)
                    {
                        Application.DoEvents();
                        Thread.Sleep(500);
                        Application.DoEvents();
                    }
                }
            }

            catch
            {

            }
        }
    }
}
