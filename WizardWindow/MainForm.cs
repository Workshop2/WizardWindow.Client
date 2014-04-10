using System;
using System.Windows.Forms;

namespace WizardWindow
{
    public partial class MainForm : Form
    {
        public MainForm()
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
