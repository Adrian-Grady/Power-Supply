using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NIV = NationalInstruments.Visa;
using IVI = Ivi.Visa;
using NationalInstruments.Visa;
using System.Threading;
using NationalInstruments.Visa.Internal;

namespace PowerSupplyReader
{
    //by Adrian Grady
    public partial class Form1 : Form
    {
        BackgroundWorker worker;
        public Form1()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
        }//constructor, initializes form and creates backgroundworker
        int selectOutput = 1;
        NIV.MessageBasedSession currSession = null;
        NIV.ResourceManager rManager = null;
        bool runWorker = true;
        private void btnWriteVolt_Click(object sender, EventArgs e)
        {
            string newVolts = tbWriteVolt.Text;
            if (newVolts.Length == 0)
            {
                tbStatus.Text = "Please enter a voltage";
            }
            else if (Convert.ToDouble(newVolts) > 60 || Convert.ToDouble(newVolts) < 0)
            {
                tbStatus.Text = "Please enter a voltage between 0V and 60V";
            }
            else
            {
                currSession.RawIO.Write("V" + selectOutput + " " + newVolts + "\n");
                tbStatus.Text = "Voltage set";
            }
        }//sets voltage between 0 and 60
        private void btnSetCurr_Click(object sender, EventArgs e)
        {
            string newCurr = tbWriteCurrent.Text;
            if (newCurr.Length == 0)
            {
                tbStatus.Text = "Please enter a voltage";
            }
            else if (Convert.ToDouble(newCurr) > 20 || Convert.ToDouble(newCurr) < 0)
            {
                tbStatus.Text = "Please enter a current limit between 0A and 20A";
            }
            else
            {
                currSession.RawIO.Write("I" + selectOutput + " " + newCurr + "\n");
                tbStatus.Text = "Current limits set";
            }
        }//sets current between 0 and 20
        private void btnOpenConn_Click(object sender, EventArgs e)
        {
            runWorker = true;
            tbStatus.Text = "Opening connection";
            string resource = tbResourceName.Text;
            using (rManager = new ResourceManager())
            {
                try
                {
                    currSession = (MessageBasedSession)rManager.Open(resource);
                    tbStatus.Text = "Connection complete";
                    btnSetCurr.Enabled = true;
                    btnWriteVolt.Enabled = true;
                    //btnOutOff.Enabled = true;
                   // btnOutOn.Enabled = true;
                    worker.DoWork += worker_DoWork;
                    worker.RunWorkerAsync();
                    btnOpenConn.Enabled = false;
                    lblResources.Visible = false;
                    lbResources.Visible = false;
                    currSession.RawIO.Write("OP1?\n");
                    string output1Status = currSession.RawIO.ReadString();
                    if (output1Status[0] == '0')
                    {
                        btnOutOn.Enabled = true;
                    }
                    else if (output1Status[0] == '1')
                    {
                        btnOutOff.Enabled = true;
                    }
                }
                catch (InvalidCastException)
                {
                    tbStatus.Text = "Invalid resource ID";
                }
                catch (Exception ex)
                {
                    tbStatus.Text = ex.Message;
                }

            }
        }//opens the connection using the already-selected VISA resource, enables the other buttons, and starts the measurement

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int iterator = 0;
            while (true)
            {
                iterator++;
                if (runWorker == false)
                {
                    return;
                }
                lblVolts.Invoke(new Action(() =>
                {

                    currSession.RawIO.Write("V1O?\n");
                    lblVolts.Text = "Voltage 1:" + currSession.RawIO.ReadString();
                }));
                lblVolt2.Invoke(new Action(() =>
                {

                    currSession.RawIO.Write("V2O?\n");
                    lblVolt2.Text = "Voltage 2:" + currSession.RawIO.ReadString();

                }));
                lblCurr.Invoke(new Action(() =>
                {

                    currSession.RawIO.Write("I1O?\n");
                    lblCurr.Text = "Current 1:" + currSession.RawIO.ReadString();
                }));
                lblCurr2.Invoke(new Action(() =>
                {

                    currSession.RawIO.Write("I2O?\n");
                    lblCurr2.Text = "Current 2:" + currSession.RawIO.ReadString();
                }));
                if (iterator == 100)
                {
                    //currSession.Dispose();
                    //currSession.Clear();
                    //MessageBasedSession currSession = (MessageBasedSession)rManager.Open(tbResourceName.Text);
                    iterator = 0;
                }
            }
        }//continually updates the voltages and currents of both outputs via a BackgroundWorker

        private void lbResources_DoubleClick(object sender, EventArgs e)
        {
                if (lbResources.SelectedItem != null)
                    tbResourceName.Text = lbResources.SelectedItem.ToString();

        }//adds the double-clicked resource to tbResourceName

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var rm = new ResourceManager())
            {
                var resources = rm.Find("(ASRL|GPIB|TCPIP|USB)?*");
                foreach (string resource in resources)
                {
                    lbResources.Items.Add(resource);
                }
            }
        }//populate the list box with all available VISA resources

        /* private void btnCloseConnection_Click(object sender, EventArgs e)
         {
             runWorker = false;
             worker.CancelAsync();
             Thread.Sleep(2000);
             worker.DisposeIfNotNull();
             worker.Dispose();
             tbResourceName.Clear();
             rManager.Dispose();
             currSession.Dispose();
             btnOpenConn.Enabled = true;
             btnSetCurr.Enabled = false;
             btnWriteVolt.Enabled = false;
         }
        */
        private void btnOutOff_Click(object sender, EventArgs e)
        {
            currSession.RawIO.Write("OP" + selectOutput + " 0\n");
            btnOutOff.Enabled = false;
            btnOutOn.Enabled = true;

        }//turns output off
        private void btnOutOn_Click(object sender, EventArgs e)
        {
            currSession.RawIO.Write("OP" + selectOutput + " 1\n");
            btnOutOn.Enabled = false;
            btnOutOff.Enabled = true;
        }//turns output on

        private void rbOut2_MouseClick(object sender, MouseEventArgs e)
        {

            selectOutput = 2;
            currSession.RawIO.Write("OP2?\n");
            if (currSession.RawIO.ReadString()[0] == '0')
            {
                btnOutOn.Enabled = true;
                btnOutOff.Enabled = false;
            }
            else
            {
                btnOutOff.Enabled = true;
                btnOutOn.Enabled = false;
            }
        }//selects output 2 and enables/disables buttons as needed

        private void rbOut1_MouseClick(object sender, MouseEventArgs e)
        {

            selectOutput = 1;
            currSession.RawIO.Write("OP1?\n");
            if (currSession.RawIO.ReadString()[0] == '0')
            {
                btnOutOn.Enabled = true;
                btnOutOff.Enabled = false;
            }
            else
            {
                btnOutOff.Enabled = true;
                btnOutOn.Enabled = false;
            }
        }//selects output 1 and enables/disables buttons as needed
    }
}
