using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace WizardWindow.Transport
{
    public class TestTransporter : ITransporter
    {
        public void Send(Image currentImage)
        {
            string path = Path.GetTempFileName() + ".jpg";
            currentImage.Save(path, ImageFormat.Jpeg);
        }
    }
}