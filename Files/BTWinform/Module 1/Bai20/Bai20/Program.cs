using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai20
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false);


            frmFlashForm f = new frmFlashForm();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)

            {

                Application.Run(new frmMain());

            }

        }
    }
}
