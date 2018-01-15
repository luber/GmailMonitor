using System;
using System.Threading;
using System.Windows.Forms;

namespace GMailMonitor
{
    static class Program
    {
        private static readonly Mutex AppInstanceMutex = new Mutex(true, "{83FEB764-6E96-4A16-A4FA-D64480799990}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (AppInstanceMutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.ThreadException += Application_ThreadException;

                Application.Run(new AppContext());
            }
            else
            {
                MessageBox.Show("Програма вже запущена!");
            }
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
