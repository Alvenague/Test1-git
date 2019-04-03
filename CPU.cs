//-----------------------------------------------------------------------
// <copyright file="CPU.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Computer
{
    public class CPU : Hardware
    {
        private string software;
        private string hardDisk;
        private string processor;
        private int ram;

        public CPU(string marca, string color, string mac, bool input, bool output, string software, string hardDisk, string processor, int ram) : base(marca, color, mac, input, output)
        {
            this.software = software;
            this.hardDisk = hardDisk;
            this.processor = processor;
            this.ram  = ram;
        }
        
        /// <summary>
        /// Processes data that were send to the CPU
        /// </summary>
        /// <param name="stream">It is the data   that were send</param>
        /// <returns>String of the data</returns>
        public string DataProcessing(string stream)
        {
            return string.Empty;
        }

        /// <summary>
        /// It transmits the data 
        /// </summary>
        /// <param name="stream"> it is data</param>
        /// <returns>it send data</returns>
        public string Transmition(string stream)
        {
            return string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public string Reception(string stream)
        {
            return string.Empty;
        }
    }
}
