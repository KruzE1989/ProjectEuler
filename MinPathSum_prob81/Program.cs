using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MinPathSum_prob81
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0,x = 79,y = 79,j = 0;
            int[] iInput = new int[80];
            int[][] myMatrix = new int[80][];
            int[][] Temp;
            int sum = 0;
            StreamReader objRdr = new StreamReader(@"C:\Documents and Settings\neerav_patel\Desktop\Matrix.txt");
            List<string> objRow = File.ReadAllLines(@"C:\Documents and Settings\neerav_patel\Desktop\Matrix.txt").ToList<string>();
            while (!(objRdr.EndOfStream))
            {
                iInput = objRdr.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray();
                myMatrix[i] = iInput;
                i++;
            }
            Temp = myMatrix;
            for (j = 77; j > 0; j--)
            {
                Temp[79][j] += Temp[79][j+1];
                Temp[j][79] += Temp[j + 1][79];
            }
            //for (int k = 0; k < 79; k++)
            //{
            //    for (int l = 0; l < 79; l++)
            //    {
            //        Console.Write(Temp[k][l] + " ");
            //    }
            //    Console.WriteLine("");
            //}
            for (i = 77; i >= 0; i--)
            {
                for (j = 77; j >= 0; j--)
                {
                    Temp[i][j] += Math.Min(Temp[i + 1][j], Temp[i][j + 1]);
                }
            }
            Console.WriteLine(Temp[0][0]);
            //sum = myMatrix[79][79];
            //while (x > 0 && y > 0)
            //{
            //    if (myMatrix[x - 1][y] < myMatrix[x][y - 1])
            //    {
            //        sum += myMatrix[x - 1][y];
            //        --x;
            //    }
            //    else
            //    {
            //        sum += myMatrix[x][y - 1];
            //        --y;
            //    }
            //}
            //for (int z = 0; z < 15; z++)
            //{
            //    sum += myMatrix[z][0];
            //}
            //Console.WriteLine(x);
            //Console.WriteLine(y);
        }
    }
}
