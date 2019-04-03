//-----------------------------------------------------------------------
// <copyright file="Display.cs" company="Company name">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Computer
{
    /// <summary>
    /// The Class Display
    /// </summary>
    public class Display : Hardware
    {
        /// <summary>
        /// Principal attribute of the class
        /// </summary>
        private string resolution;

        /// <summary>
        /// resolution and dimension are attributes of the Display class
        /// </summary>
        private int dimension;

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Display"/> class.</para>
        /// </summary>
        /// <param name="brand"> the brand of the display</param>
        /// <param name="color">the color of the display</param>
        /// <param name="mac">the mac of the display</param>
        /// <param name="input">the value can be true or false</param>
        /// <param name="output">it can be true of false</param>
        /// <param name="resolution">the resolution of the Display</param>
        /// <param name="dimension">the dimension of the Display</param>
        public Display(string brand, string color, string mac, bool input, bool output, string resolution, int dimension) : base(brand, color, mac, input, output)
        {
            this.resolution = resolution;
            this.dimension = dimension;
        }

        /// <summary>
        /// This method projects the image
        /// </summary>
        /// <returns>returns an empty string</returns>
        public string Projectimage()
        {
            return string.Empty;
        }
    }
}
