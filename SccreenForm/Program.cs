using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenForm
{
    //static class Program
    public class Program : ApplicationContext
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
        }

        //public ControlForm controlForm = new ControlForm();
        public Brightness screenForm = new Brightness();

        private Program()
        {
            //controlForm.program = screenForm.program = this;
            //controlForm.Show();
            screenForm.Show();
        }
    }
}