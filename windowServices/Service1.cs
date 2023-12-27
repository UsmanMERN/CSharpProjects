﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace windowServices
{
    public partial class Service1 : ServiceBase
    {
        Timer timer= new Timer();
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("Service is started at" + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
        }

        protected override void OnStop()
        {
            WriteToFile("Service is stopped at" + DateTime.Now);
        }
        private void OnElapsedTime(object sender, ElapsedEventArgs e)
        {
            WriteToFile("Service is recall at" + DateTime.Now);
        }
        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\serviceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/','_')+".txt";
            if (!File.Exists(filePath)) { 
            using (StreamWriter sw= File.CreateText(filePath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(Message);
                }
            }
        }
        }
    }
}
