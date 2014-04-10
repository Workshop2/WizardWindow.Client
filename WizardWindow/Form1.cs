using System;
using System.Windows.Forms;

namespace WizardWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebCam _webcam;
        private void mainWinForm_Load(object sender, EventArgs e)
        {
            _webcam = new WebCam(imgVideo);
            _webcam.Start();
        }
    }
}
