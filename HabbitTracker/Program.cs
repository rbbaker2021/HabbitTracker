using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabbitTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HabbitTrackerForm habbitTracker = new HabbitTrackerForm();
            Application.Run(habbitTracker);
            habbitTracker.StoreSessionInfo();
        }
    }
}