using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SerialLoopback
{
    public partial class Form1 : Form
    {
        #region Private Varriables
        //The lists of available settings, the first in the list will be the default
        List<int> baudList = new List<int>() { 115200, 57600, 19200, 9600, 4800, 2400, 1200, 600 };
        List<int> databitsList = new List<int>() { 8, 7, 6, 5 };
        List<Parity> parityList = new List<Parity>() { Parity.None, Parity.Even, Parity.Mark, Parity.Odd, Parity.Space };
        List<StopBits> stopbitsList = new List<StopBits>() { StopBits.One, StopBits.None, StopBits.OnePointFive, StopBits.Two };
        List<Handshake> handshakeList = new List<Handshake> { Handshake.None, Handshake.RequestToSend, Handshake.RequestToSendXOnXOff, Handshake.XOnXOff };

        static SerialPort serialPort1 = new SerialPort();
        static SerialPort serialPort2 = new SerialPort();

        Thread port1ReadThread = null;
        Thread port2ReadThread = null;

        static bool threadsLooping = false;
        static bool thread1Stopped = true;
        static bool thread2Stopped = true;

        #endregion
        #region Constructor / destructor
        public Form1()
        {                               
            InitializeComponent();

            string[] portStringNames = SerialPort.GetPortNames();
            List<string> portNameList = new List<string>(portStringNames);

            //Setup the dropdown lists with values
            initilizeComboBoxWithList(portNameList, ref port1Cbx);
            initilizeComboBoxWithList(portNameList, ref port2Cbx);
            initilizeComboBoxWithList(baudList, ref baudCbx);
            initilizeComboBoxWithList(parityList, ref parityCbx);
            initilizeComboBoxWithList(databitsList, ref databitsCbx);
            initilizeComboBoxWithList(stopbitsList, ref stopBitsCbx);
            initilizeComboBoxWithList(handshakeList, ref handShakeCbx);                             

            //Set the defaults for the port1 and port2 because they will not be the first in the list
            int index1 = portNameList.IndexOf("COM8");
            if (-1 != index1)
            {
                port1Cbx.SelectedIndex = index1;
            }

            int index2 = portNameList.IndexOf("COM3");
            if (-1 != index2)
            {
                port2Cbx.SelectedIndex = index2; 
            } 
        }

        

        ~Form1()
        {
            if (threadsLooping)
            {
                stop();
            }
            

            port1ReadThread.Join();
            port2ReadThread.Join();
        }

        #endregion
        #region Private Methods

        private void initilizeComboBoxWithList<T>(List<T> list, ref ComboBox cbx)
        {           
            for(int i = 0; i < list.Count; i++)
            {
                String nameToAdd = list[i].ToString();
                cbx.Items.Add(nameToAdd);
            }    
            
            cbx.SelectedIndex = 0;//Set it to the first in the list
        }

        //Both serial ports have to use the same settings besides the port names
        private void setupSerialPort(ref SerialPort serialPort)
        {
            serialPort.BaudRate = baudList[baudCbx.SelectedIndex];
            serialPort.Parity = parityList[parityCbx.SelectedIndex];
            serialPort.DataBits = databitsList[databitsCbx.SelectedIndex];
            serialPort.StopBits = stopbitsList[stopBitsCbx.SelectedIndex];
            serialPort.Handshake = handshakeList[handShakeCbx.SelectedIndex];
            serialPort.ReadTimeout = 3000;
        }

        private void startStopBtnClick(object sender, EventArgs e)
        {
            if (!threadsLooping)
            {
                start();
            }
            else
            {
                stop();
            }

        }

        private void start()
        {
            threadsLooping = true;

            serialPort1.PortName = (String)port1Cbx.SelectedItem;
            setupSerialPort(ref serialPort1);

            serialPort2.PortName = (String)port2Cbx.SelectedItem;
            setupSerialPort(ref serialPort2);

            serialPort1.Open();
            serialPort2.Open();
            port1ReadThread = new Thread(readPort1);
            port2ReadThread = new Thread(readPort2);
            port1ReadThread.Start();
            port2ReadThread.Start();
            
            startStopBtn.Text = "Disconnect";        
        }   

        private void stop()
        {
            startStopBtn.Text = "Closing";
            startStopBtn.Enabled = false;

            threadsLooping = false;
            
            //Stop the first
            while (!thread1Stopped || !thread2Stopped)
            {
                Thread.Sleep(1);//TODO Possibility of a infinite wait
            }            

            serialPort1.Close();
            serialPort2.Close();
                                    
            startStopBtn.Text = "Connect";
            startStopBtn.Enabled = true;
        }             

        private static void readPort1()
        {
            thread1Stopped = false;
            char[] buffer = new char[256];

                        
            while (threadsLooping)
            {
                try
                {
                    int count = serialPort1.Read(buffer, 0, 256);
                    serialPort2.Write(buffer, 0, count);
                    Console.Write(buffer, 0, count);                                    
                }
                catch (TimeoutException)
                {
                    //Intentionally left blank, may have forced exit from blocking read
                }
            }            

            thread1Stopped = true;
        }

        private static void readPort2()
        {
            thread2Stopped = false;
            char[] buffer = new char[256];
                 
            while (threadsLooping)
            {        
                try
                {            
                    int count = serialPort2.Read(buffer, 0, 256);
                    serialPort1.Write(buffer, 0, count);
                    Console.Write(buffer, 0, count);                                
                }
                catch (TimeoutException)
                {
                    //Intentionally left blank, may have forced exit from blocking read
                }
            }            

            thread2Stopped = true;
        }

        #endregion
    }
}
