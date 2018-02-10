using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ACM.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ////For UI Thread exception.
            //Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler);

            ////Force all Windows Forms errors to go through our handler.
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            ////For non-UI thread exceptions
            //AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                //Application.Run(new PedometerWin());
                Application.Run(new OrderWin());
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem with this application. Please call support.");
                System.Windows.Forms.Application.Exit();
                //throw;
            }
            
            
        }

        //Exceptions handler
        static void GlobalExceptionHandler(object sender, EventArgs e)
        {
            //Log the issue
            MessageBox.Show("There was a problem with this application. Please call support.");
            System.Windows.Forms.Application.Exit();
        }
    }
}
