//-----------------------------------------------------------------------
// <copyright file="Mouse.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Computer
{
    public class Mouse : Hardware
    {
        private int x;
        private int y;
        private string key;

        public Mouse(string marca, string color, string mac, bool input, bool output, int x, int y, string key) : base(marca, color, mac, input, output)
        {
            this.x = x;
            this.y = y;
            this.key = key;
        }

        public int X { get => this.x; set => this.x = value; }

        public int Y { get => this.y; set => this.y = value; }

        public string Move()
        {
            return string.Empty;
        }

        public string Press()
        {
            return string.Empty;
        }

        public string Roll()
        {
            return string.Empty;
        }
    }
}
