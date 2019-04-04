using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasfot.Kattis
{
    class Mravi
    {
        public static void Main(string[] args)
        {

            string firstLine;
            int i = 0;
            int n = 0;
            int[] k = new int[100];
            int[,] m = new int[100, 100];
            int j = 0;
            int mi = 0;
            //int mj = 0;
            if ((firstLine = Console.ReadLine()) != null)
            {
                n = Int32.Parse(firstLine.ToString());
                while (i < n && n >= 1 && n <= 1000)
                {
                    i++;
                    string line;
                    if ((line = Console.ReadLine()) != null && i < n)
                    {
                        string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        m[mi, 0] = Int32.Parse(split[0]);
                        m[mi, 1] = Int32.Parse(split[1]);
                        m[mi, 2] = Int32.Parse(split[2]);
                        m[mi, 3] = Int32.Parse(split[3]);
                        mi++;
                    }
                    if (i == n )
                    {
                        string[] ki = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        j = 0;
                        while (j < ki.Length)
                        {

                            k[j] = Int32.Parse(ki[j]);
                            //Console.WriteLine("K-: " + k[j].ToString());

                            j++;

                        }

                    }
                }
                int kj = 0;
                double sum = 0;
                double max_value = 0;
                double one_percent = 0;

                while (kj < j)
                {
                    if (k[kj] >= 1 && k[kj] <= 10)
                    {
                       // bool find = true;
                        for (int g = 0; g < n ; g++)
                        {
                            if (m[g, 1] == kj + 1)
                            {
                                
                                if (m[g, 3]==1)
                                {
                                    one_percent = (Math.Sqrt(k[kj])) / m[g, 2];
                                    max_value = Math.Max(max_value, one_percent);

                                }
                                else
                                {
                                     one_percent = k[kj]/ m[g, 2];
                                     max_value = Math.Max(max_value, one_percent);
                                }
                            }
                          

                        }
                    }
                    kj++;
                    
                }
                kj = 0;
                while (kj < j)
                {
                    if (k[kj] >= 1 && k[kj] <= 10)
                    {
                        for (int g = 0; g < n; g++)
                        {
                            if (m[g, 1] == kj + 1)
                            {
                                sum += max_value * m[g, 2];
                            }


                        }
                    }
                    kj++;

                }
                Console.WriteLine(sum);

            }
        }
    }

}

