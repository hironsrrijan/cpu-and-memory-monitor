using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Memory_Monitor
{
    public partial class Form1 : Form
    {

        private System.Timers.Timer _timer;

        //boolean for button start stop

        bool startflag = false;



        public Form1()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer();
            _timer.Interval = 3000;
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;
        }

        private void OntimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
          //  CheckForIllegalCrossThreadCalls = false;

            //we will monitor and get the values of cpu and memory
            int cpuvalue = GetCpuValue();
            int memvalue = GetMemValue();


            if (progressBarCPU.InvokeRequired)
            {
                progressBarCPU.Invoke(new Action(() => progressBarCPU.Value = cpuvalue));
            }
            else
            {
                progressBarCPU.Value = cpuvalue;
            }

            //cpu usage percentage

            if (labelCpuUsage.InvokeRequired)
            {
                labelCpuUsage.Invoke(new Action(() => labelCpuUsage.Text = cpuvalue.ToString() + "%" ));
            }
            else
            {
                labelCpuUsage.Text = cpuvalue.ToString() + "%";
            }




            if (progressBarMem.InvokeRequired)
            {
                progressBarMem.Invoke(new Action(() => progressBarMem.Value = memvalue));
            }
            else
            {
                progressBarMem.Value = memvalue;
            }

            //memory usage percentage

            if (labelMemUsage.InvokeRequired)
            {
                labelMemUsage.Invoke(new Action(() => labelMemUsage.Text = memvalue.ToString() + "%"));
            }
            else
            {
                labelMemUsage.Text = memvalue.ToString() + "%";
            }
        }

        private int GetCpuValue()
        {
            var CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            CpuCounter.NextValue();
            System.Threading.Thread.Sleep(3000);
            int returnvalue = (int)CpuCounter.NextValue();
            return returnvalue;

        }
        private int GetMemValue()
        {
            var MemCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");
            int returnvalue = (int)MemCounter.NextValue();
            return returnvalue;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (startflag == false)
            {
                startflag =true;
                _timer.Enabled = true;
                buttonStart.Text = "Stop Process";
            }
            else
            {
                startflag = false;
                _timer.Enabled = false;
                buttonStart.Text = "Start Process";
            }


           // _timer.Enabled = true;

        }
    }
}
