using System.Drawing;
using System.Threading.Tasks;
using RestSharp;

namespace WizardWindow.Transport
{
    public class HttpTransport : ITransporter
    {
        private readonly RestClient _client;

        public HttpTransport(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public void Send(Image currentImage)
        {
            Task.Factory.StartNew(() =>
            {
                byte[] imgArray;
                lock (currentImage)
                {
                    var converter = new ImageConverter();
                    imgArray = (byte[])converter.ConvertTo(currentImage, typeof(byte[]));
                }

                var request = new RestRequest("Home", Method.POST);
                request.RequestFormat = RestSharp.DataFormat.Json;
                request.AddParameter("field_name", "field_done");
                request.AddFile("file", imgArray, "webCam.jpg");

                _client.Execute(request);
            });
        }
    }
}