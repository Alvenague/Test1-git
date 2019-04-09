using Jalasoft.Bootcamp.Practice3.Generics;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Bootcamp.Practice3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var phone = new Smartphone();
            phone.IsLocked = true;
            phone.Carrier = "Entel";
            phone.ContactCount = 58;

            SaveFile<Smartphone>(phone);

            var book = new Product();
            book.Name = "Lord of the rings";
            book.Price = 25.5;

            SaveFile<Product>(book);
        }

        public static T LoadFromFile<T>(T o)
        {
                using (var reader = new StreamReader(@"C:\Users\Developer\source\repos\Jalasoft.Bootcamp.Practice3\Jalasoft.Bootcamp.Practice3\Generics\testfile.csv"))
                {
                     while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        
                    }
                }

            return o;
        }

        public static void SaveFile<T>(object o)
        {
            string strFilePath = @"C:\Users\Developer\source\repos\Jalasoft.Bootcamp.Practice3\Jalasoft.Bootcamp.Practice3\Generics\testfile.csv";
            string strSeperator = ",";
            StringBuilder sb_output = new StringBuilder();
            string newline_header = string.Empty;
            string newline = string.Empty;

            var phoneType = o.GetType();
            Console.WriteLine();
            var propertiesWithDisplayName = from prop in phoneType.GetProperties()
                                            where prop.GetCustomAttributes<DisplayAttribute>().Any()
                                            select prop;
            foreach (var property in propertiesWithDisplayName)
            {
                var attr = property.GetCustomAttribute<DisplayAttribute>();
                Console.WriteLine(attr.Name + ":" + property.GetValue(o));
                newline_header = newline_header + attr.Name + strSeperator;
                newline = newline + property.GetValue(o) + strSeperator;
            }

            newline_header = newline_header.Remove(newline_header.Length - 1);
            sb_output.AppendLine(newline_header);
            newline = newline.Remove(newline.Length - 1);
            sb_output.AppendLine(newline);
          
            File.WriteAllText(strFilePath, sb_output.ToString());
        }
    }
}
