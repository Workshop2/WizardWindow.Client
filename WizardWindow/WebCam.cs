using System.Windows.Forms;
using WebCam_Capture;

namespace WizardWindow
{
    public class WebCam
    {
        private readonly WebCamCapture _webcam;
        private readonly PictureBox _frameImage;
        private const int FrameNumber = 30;


        public WebCam(PictureBox imageControl)
        {
            _webcam = new WebCamCapture
            {
                FrameNumber = 0ul, 
                TimeToCapture_milliseconds = FrameNumber,
            };

            _webcam.ImageCaptured += webcam_ImageCaptured;
            _frameImage = imageControl;
        }

        private void webcam_ImageCaptured(object source, WebcamEventArgs e)
        {
            _frameImage.Image = e.WebCamImage;
        }

        public void Start()
        {
            _webcam.TimeToCapture_milliseconds = FrameNumber;
            _webcam.Start(0);
        }

        public void Stop()
        {
            _webcam.Stop();
        }

        public void Continue()
        {
            // change the capture time frame
            _webcam.TimeToCapture_milliseconds = FrameNumber;

            // resume the video capture from the stop
            _webcam.Start(_webcam.FrameNumber);
        }

        public void ResolutionSetting()
        {
            _webcam.Config();
        }

        public void AdvanceSetting()
        {
            _webcam.Config2();
        }
    }
}
