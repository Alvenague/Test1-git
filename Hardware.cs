//-----------------------------------------------------------------------
// <copyright file="Hardware.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Computer
{
    /// <summary>
    ///  It is the class Hardware
    /// </summary>
    public class Hardware
    {
        /// <summary>
        /// it gets or sets brand
        /// </summary>
        private string brand;

        /// <summary>
        /// it gets or sets color
        /// </summary>
        private string color;

        /// <summary>
        /// it gets or sets mac
        /// </summary>
        private string mac;

        /// <summary>
        /// it gets or sets input
        /// </summary>
        private bool input;

        /// <summary>
        /// it gets or sets output
        /// </summary>
        private bool output;

        /// <summary>
        /// it gets or sets on
        /// </summary>
        private bool on;

        /// <summary>
        /// Initializes a new instance of  the <see cref="Hardware"/> class.
        /// </summary>
         public Hardware()
        {
            this.on = false;
        }

        /// <summary>
        /// Initializes a new instance of  the <see cref="Hardware"/> class.
        /// </summary>
        /// <param name="brand">brand of the Hardware</param>
        /// <param name="color">color of the Hardware</param>
        /// <param name="mac">mac of the Hardware</param>
        /// <param name="input"> defining if input is true or false</param>
        /// <param name="output">defining if output is true or false</param>
        public Hardware(string brand, string color, string mac, bool input, bool output)
        {
            this.brand = brand;
            this.color = color;
            this.mac = mac;
            this.input = input;
            this.output = output;
        }

        /// <summary>
        /// Turns on or it turns off a device
        /// </summary>
        public void OnOff()
        {
            this.on = !this.on;
        }

        /// <summary>
        /// It plug in or plugs out a device
        /// </summary>
        /// <returns>it returns the value of true or false </returns>
        protected bool Plug()
        {
            return false;
        }

        /// <summary>
        /// the device changes to a StandBy state
        /// </summary>
        /// <returns>it returns the value of true or false</returns>
        protected bool StandBy()
        {
            return false;
        }
    }
}
