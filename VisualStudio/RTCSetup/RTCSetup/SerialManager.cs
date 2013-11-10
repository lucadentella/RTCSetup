using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace RTCSetup
{
    class SerialManager
    {
        private SerialPort serialPort;

        public string[] getAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        public bool connect(string serialPortName)
        {
            serialPort = new SerialPort(serialPortName, 57600);
            serialPort.NewLine = "\r\n";
            serialPort.ReadTimeout = 500;

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open serial port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // First handshake with the device:
        // when it received ## it must answer with !!
        public bool handshake()
        {
            serialPort.WriteLine("##");

            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if(response.Equals("!!")) return true;
            MessageBox.Show("Unknown device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Get the version of the running sketch
        // command: ?V
        // response: <version> (for example "1.0")
        public string getSketchVersion()
        {
            serialPort.WriteLine("?V");

            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return response;
        }

        // Get the actual RTC date and time 
        // command: ?T
        // response: date and time in the form dd/MM/yyyy hh:mm:ss
        public string getRTCTime()
        {
            serialPort.WriteLine("?T");

            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "UNKNOWN";
            }
            return response;
        }

        // Set the RTC date and time
        // command: !TddMMyyyyhhmmss
        // response: OK
        public bool setRTCTime(DateTime time)
        {
            // Wait until we're 200ms before the next second
            while (DateTime.Now.Millisecond != 850)
                Thread.Sleep(1);

            string command = "!T" + time.AddSeconds(1).ToString("ddMMyyyyHHmmss");
            serialPort.WriteLine(command);

            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Equals("OK"))
            {
                MessageBox.Show("RTC set!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Wrong response from RTC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void disconnect()
        {
            serialPort.Close();
        }
    }
}
