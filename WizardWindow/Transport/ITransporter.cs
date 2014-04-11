using System.Drawing;

namespace WizardWindow.Transport
{
    public interface ITransporter
    {
        void Send(Image currentImage);
    }
}