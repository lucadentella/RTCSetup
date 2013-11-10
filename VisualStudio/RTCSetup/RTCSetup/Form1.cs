using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.IO.Ports;

namespace RTCSetup
{
    public partial class Form1 : Form
    {

        PrivateFontCollection pfc = new PrivateFontCollection();
        private SerialManager serialManager = new SerialManager();
        private bool connected = false;
        private string sketchVersion = "1.0";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("RTCSetup.Resources.digital-7.ttf");
            byte[] fontdata = new byte[fontStream.Length];
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            fontStream.Close();
            unsafe
            {
                fixed (byte* pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                }
            }
            lbSystemTime.Font = new Font(pfc.Families.First(), 30, FontStyle.Regular);
            lbRTCTime.Font = new Font(pfc.Families.First(), 30, FontStyle.Regular);

            dtpCustom.Value = DateTime.Now;
            lbRTCTime.Text = "unknown";

            addAvailableComPorts();
            updateUI();
        }

        private void addAvailableComPorts()
        {
            foreach (string comPort in serialManager.getAvailablePorts())
                cbSerialPorts.Items.Add(comPort);

            if (cbSerialPorts.Items.Count > 0) cbSerialPorts.SelectedIndex = 0;
        }

        private void updateUI()
        {
            if (connected)
            {
                btConnect.Text = "DISCONNECT";
                toolStripStatusLabel1.Text = "Connected with sketch v" + sketchVersion;
                btGet.Enabled = true;
                btSetSystem.Enabled = true;
                btSetCustom.Enabled = true;
                dtpCustom.Enabled = true;
                cbSerialPorts.Enabled = false;
            }
            else
            {
                btConnect.Text = "CONNECT";
                toolStripStatusLabel1.Text = "Disconnected";
                btGet.Enabled = false;
                btSetSystem.Enabled = false;
                btSetCustom.Enabled = false;
                dtpCustom.Enabled = false;
                cbSerialPorts.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbSystemTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                string serialPortName = (string)cbSerialPorts.SelectedItem;
                bool result = serialManager.connect(serialPortName);

                if (result) 
                {
                    result = serialManager.handshake();
                } 
                else return;

                if(result) 
                {
                    connected = true;
                    updateUI();
                }
                else serialManager.disconnect();
            }

            else
            {
                serialManager.disconnect();
                connected = false;
                updateUI();
            }
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            lbRTCTime.Text = serialManager.getRTCTime();
        }

        private void btSetSystem_Click(object sender, EventArgs e)
        {
            serialManager.setRTCTime(DateTime.Parse(lbSystemTime.Text));
        }

        private void btSetCustom_Click(object sender, EventArgs e)
        {
            serialManager.setRTCTime(dtpCustom.Value);
        }
    }
}
