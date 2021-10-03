using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenForm
{
    public partial class Brightness : Form
    {
        public Brightness()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0084) // WM_NCHITTEST
                m.Result = (IntPtr)(-1); // HTTRANSPARENT
            else
                base.WndProc(ref m);
        }
    }
}