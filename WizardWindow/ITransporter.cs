using System.Drawing;

namespace WizardWindow
{
    public interface ITransporter
    {
        void Send(Image currentImage);
    }
}