using System;
using System.Threading;
using System.Threading.Tasks;
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

            // due to webcam bug, reboot every minute
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(TimeSpan.FromMinutes(1));
                Application.Restart();
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
