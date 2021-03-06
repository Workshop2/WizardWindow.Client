﻿using System.Drawing;
using System.Windows.Forms;
using WebCam_Capture;

namespace WizardWindow
{
    public class WebCam
    {
        private readonly WebCamCapture _webcam;
        private readonly PictureBox _frameImage;
        private Image _image = new Bitmap(1, 1);
        private const int FrameNumber = 60;
        
        public WebCam(PictureBox imageControl)
        {
            _webcam = new WebCamCapture
            {
                FrameNumber = 0ul, 
                TimeToCapture_milliseconds = FrameNumber,
                Width = 640,
                Height = 480,
                ClientSize = new Size(640, 480),
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                AutoSize = true,
                Size = new Size(640, 480),
                MinimumSize = new Size(640, 480),
                AutoScrollMinSize = new Size(640, 480),
                CaptureHeight = 480,
                CaptureWidth = 640
            };

            _webcam.ImageCaptured += webcam_ImageCaptured;
            _frameImage = imageControl;
        }

        private void webcam_ImageCaptured(object source, WebcamEventArgs e)
        {
            lock (_image)
            {
                _image = e.WebCamImage;
                _frameImage.Image = _image.Clone() as Image;
            }
        }

        public void Start()
        {
            _webcam.TimeToCapture_milliseconds = FrameNumber;
            _webcam.Start(0);
            _webcam.Start(0);
        }

        public Image GetPhoto()
        {
           // _webcam.CaptureHeight

            lock (_image)
            {
                return _image;
            }
        }
    }
}
