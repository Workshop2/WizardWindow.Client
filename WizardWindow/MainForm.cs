using System;
using System.Windows.Forms;
using WizardWindow.Transport;

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
            TimeSpan timeToSend = TimeSpan.FromSeconds(0.1);

            var webcam = new WebCam(imgVideo);
            ITransporter transporter = new HttpTransport("http://localhost:60915/");

            var capture = new Capture(timeToSend, webcam, transporter);
            capture.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
