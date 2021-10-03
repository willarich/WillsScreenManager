using System;
using System.Drawing;
using System.Windows.Forms;

namespace TestDiodeUI
{
    public partial class ControlForm : Form
    {
        public Program program;

        public ControlForm()
        {
            InitializeComponent();
        }

        private void UpdateBrightness()
        {
            float f = trackBarBrightness.Value * 0.01f;

            program.screenForm.Opacity = 1 - f;
            program.screenForm.BackColor = Color.Black;
        }

        private void brightnessBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateBrightness();
        }

        private void ControlForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            program.ExitThread();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            UpdateBrightness();
        }
    }
}