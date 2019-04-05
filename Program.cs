using System;
using System.Collections.Generic;

namespace Mravis
{
    class Program
    {
      
        static void Main(string[] args)
        {
           // int l;
            int[,] mat = new int[100,100];
            int[] vec=new int[100];
            string firstLine;
            int mi = 0;
            int n = 0;
            int i=0;
            bool n_rango=false;

            if ((firstLine = Console.ReadLine()) != null)
            {

                n = Int32.Parse(firstLine.ToString());
                while (i < n && n >= 1 && n <= 1000)
                {
                    n_rango = true;
                    i++;
                    string line;
                    if ((line = Console.ReadLine()) != null && i < n)
                    {
                        string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        if (Int32.Parse(split[0]) >= 1)
                        {
                            mat[mi, 0] = Int32.Parse(split[0]);
                        }
                        else n_rango = false;
                        if (Int32.Parse(split[1]) <= n)
                        {
                            mat[mi, 1] = Int32.Parse(split[1]);
                        }
                        else n_rango = false;
                        if (Int32.Parse(split[2]) >= 1 || Int32.Parse(split[2]) <= 100)
                        {
                            mat[mi, 2] = Int32.Parse(split[2]);

                        }
                        else n_rango = false;

                        if (Int32.Parse(split[3]) >= 0 || Int32.Parse(split[3]) <= 1)
                        {
                            mat[mi, 3] = Int32.Parse(split[3]);
                        }
                        else n_rango = false;

                        //mat[mi, 0] = Int32.Parse(split[0]);
                        //mat[mi, 1] = Int32.Parse(split[1]);
                        //mat[mi, 2] = Int32.Parse(split[2]);
                        //mat[mi, 3] = Int32.Parse(split[3]);
                        mi++;
                    }
                    if (i == n)
                    {
                        string[] ki = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        int j = 0;
                        while (j < ki.Length)
                        {
                            if (Int32.Parse(ki[j]) == -1 || (Int32.Parse(ki[j]) >=1 && Int32.Parse(ki[j]) <= 10))
                            {
                                vec[j] = Int32.Parse(ki[j]);
                            }
                            else n_rango = false;
                            //Console.WriteLine("K-: " + k[j].ToString());

                            j++;

                        }

                    }
                }

                if (n_rango)
                {
                   
                    int r1 = FindMax(mat,n);

                    int r2 = 0;
                    int sw = 0;
                    int el1 = 0;
                    for (i = 0; i < n - 1; i++)
                    {
                        if (mat[i, 0] == r1)
                        {
                            if (vec[mat[i, 1] - 1] > 0 && sw == 0)
                            {
                                r2 = vec[mat[i, 1] - 1];
                                sw = 1;
                                el1 = mat[i, 1] - 1;
                            }

                            if (r2 > vec[mat[i, 1] - 1] && vec[mat[i, 1] - 1] > 0)
                            {
                                r2 = vec[mat[i, 1] - 1];
                                el1 = mat[i, 1] - 1;

                            }

                        }
                    }

                    int l1 = n - 1;
                    int el2 = el1 + 1;
                    double data1 = vec[el1];
                    while (l1 > 1)
                    {
                        for (i = 0; i < n - 1; i++)
                        {
                            if (mat[i, 1] == el2)
                            {
                                if (mat[i, 3] == 1)
                                {
                                    data1 = Math.Sqrt(data1);
                                }
                                data1 = (data1 * 100) / mat[i, 2];
                                el2 = mat[i, 0];
                                l1 = el2;
                            }

                        }

                    }

                    if(data1<=2000000000)
                    Console.WriteLine(data1);

                }
               

        }
    }

        private static int FindMax(int [,]m,int n)
        { int r1=0;
            for (int i = 0; i < n - 1; i++)
            {
                if (m[i, 0] > r1)
                {
                    r1 = m[i, 0];
                }

            }
            return r1;
        }
    }
}