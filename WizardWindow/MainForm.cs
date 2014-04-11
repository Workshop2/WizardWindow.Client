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

        private void mainWinForm_Load(object sender, EventArgs e)
        {
            TimeSpan timeToSend = TimeSpan.FromSeconds(1);

            var webcam = new WebCam(imgVideo);
            ITransporter transporter = new TestTransporter();

            var capture = new Capture(timeToSend, webcam, transporter);
            capture.Start();
        }
    }
}
