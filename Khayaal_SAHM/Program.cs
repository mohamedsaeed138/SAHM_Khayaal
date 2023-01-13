using Khayaal_SAHM.Main_Form_and_Children_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Raw_Materials_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms.Relations_Form_and_Mdi_Forms;
using Khayaal_SAHM.Main_Form_and_Children_Forms_AR;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Khayaal_SAHM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string Mac_Address = NetworkInterface
.GetAllNetworkInterfaces()
.Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
.Select(nic => nic.GetPhysicalAddress().ToString())
.FirstOrDefault();
            //if ("" == Mac_Address&&DateTime.Now < new DateTime(2023, 1, 5))
            //{

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
            //}
            //else
            //{
            //    MessageBox.Show("For  Activation \nCall +201228552872 ");
            //}
            //
            //

        }

    }
}
