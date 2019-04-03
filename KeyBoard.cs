//-----------------------------------------------------------------------
// <copyright file="Keyboard.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Computer
{
    public class KeyBoard : Hardware
    {
        private string key;
        private string language;

        public KeyBoard()
        {
        }

        public KeyBoard(string marca, string color, string mac, bool input, bool output, string key, string language, bool numPad) : base(marca, color, mac, input, output)
        {
            this.key = key;
            this.language = language;
        }
    }
}
