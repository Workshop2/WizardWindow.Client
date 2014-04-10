using System;
using System.Drawing;
using System.Timers;

namespace WizardWindow
{
    public class Capture
    {
        private readonly WebCam _camera;
        private readonly Transporter _transporter;

        public Capture(TimeSpan timeToCapture, WebCam camera, Transporter transporter)
        {
            _camera = camera;
            _transporter = transporter;
            var timer = new Timer { Interval = timeToCapture.TotalMilliseconds };
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Image currentImage = _camera.GetPhoto();
            _transporter.Send(currentImage);
        }
    }
}