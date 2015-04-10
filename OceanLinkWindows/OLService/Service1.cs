using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OLService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            notifyIcon1.ShowBalloonTip(5000, "Ocean Link Service", "The Ocean Link Service is now online.", System.Windows.Forms.ToolTipIcon.Info);
        }
        protected override void OnStop()
        {

        }
    }
}
