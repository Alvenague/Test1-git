//-----------------------------------------------------------------------
// <copyright file="User.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace Computer
{
    using System;
    public class User
    {
        private string userName;
        private string password;
        private string profile;

        public User(string userName, string password, string profile)
        {
            this.userName = userName;
            this.password = password;
            this.profile = profile;
        }

        public static void Main()
        {
            Console.WriteLine("Starting all:");
            CPU cpu = new CPU("Dell", "negro", "12:E3:4D:5C:11:AA", true, true, "Windows10", "Sata_500GB", "i5", 16);
            KeyBoard kb = new KeyBoard("Genius", "negro", "12:E3:4D:5C:11:AB", false, true, string.Empty, "ES", true);
            Display dis = new Display("Samsung", "negro", "12:E3:4D:5C:11:AC", true, false, "1920x1080", 15);
            Mouse mouse = new Mouse("Genius", "negro", "12:E3:4D:5C:11:AD", false, true, 0, 0, string.Empty);
            WebCam wc = new WebCam("Genius", "negro", "12:E3:4D:5C:11:AE", false, true, "1k", string.Empty);
            User user = new User("admin", "12345", "admin");

            Console.WriteLine("on all: ");

            cpu.OnOff();
            kb.OnOff();
            dis.OnOff();
            mouse.OnOff();
            wc.OnOff();
            Console.WriteLine("typed text: ");

            mouse.X = 1;
            mouse.Y = 1;
            mouse.X = 2;
            mouse.Y = 1;
            mouse.X = 3;
            mouse.Y = 1;
            mouse.X = 4;
            mouse.Y = 1;
            mouse.X = 5;
            mouse.Y = 1;
            mouse.X = 6;
            mouse.Y = 2;
            mouse.X = 6;
            mouse.Y = 3;
            mouse.X = 6;
            mouse.Y = 4;
            mouse.X = 6;
            mouse.Y = 5;
            mouse.X = 6;
            mouse.Y = 6;
            mouse.X = 6;
            mouse.Y = 7;
            mouse.Press();
            Console.WriteLine();
        }

       public bool TurnOn()
        {
            return false;
        }

        public bool TurnOff()
        {
            return false;
        }

        public bool UsePC()
        {
            return false;
        }
    }
}
