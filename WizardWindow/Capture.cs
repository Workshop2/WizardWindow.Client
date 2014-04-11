using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using WizardWindow.Transport;

namespace WizardWindow
{
    public class Capture
    {
        private readonly TimeSpan _timeToCapture;
        private readonly WebCam _camera;
        private readonly ITransporter _transporter;

        public Capture(TimeSpan timeToCapture, WebCam camera, ITransporter transporter)
        {
            _timeToCapture = timeToCapture;
            _camera = camera;
            _transporter = transporter;
        }

        public void Start()
        {
            _camera.Start();
            Reset();
        }

        private void Reset()
        {
            Task.Factory.StartNew(Tick)
                .ContinueWith(task =>
                {
                    Thread.Sleep(_timeToCapture);
                    Reset();
                });
        }

        private void Tick()
        {
            Image currentImage = _camera.GetPhoto();

            if (currentImage != null)
            {
                _transporter.Send(currentImage);
            }
        }
    }
}