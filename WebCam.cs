//-----------------------------------------------------------------------
// <copyright file="WebCam.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Computer
{
    public class WebCam : Hardware
    {
        private string resolution;
        private string lens;

        public WebCam(string marca, string color, string mac, bool input, bool output, string resolution, string lens) : base(marca, color, mac, input, output)
        {
            this.resolution = resolution;
            this.lens = lens;
        }

        public string CaptureImage(string stream)
        {
            return string.Empty;
        }
    }
}
