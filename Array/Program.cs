using System;
using System.Collections.Generic;


namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /* int N = 4;
             double[] B = new double[N];

             B[0] = 3.2; 
             B[1] = -0.3; 
             B[2] = 4E2; 
             B[3] = -2E-1;
             Console.WriteLine(B.Length);
             double Sum = 0;
             foreach(double a in B)
             {
                 Sum += a;
             }
             Console.WriteLine(Sum);

             for (int n= 0; n < N; n++)
             {
                 Console.WriteLine(B[n].ToString());

             }*/

            /*int N = 5;
            int[] A = new int[N];
            int[] B = new int[N];

            A[2] = 5;
            A.CopyTo(B, 0);
            B[2] = -1;
            Console.WriteLine(A[2]);
            Console.WriteLine(B[2]);*/

            // многомерный массив
            /* int N = 10; //размерность 1
             int M = 20; //размерность 2
             int[,] A; //обьявляем двумерный массив
             A = new int[N, M];

             for(int n = 0; n < N; n++)
             {
                 for(int m = 0; m < M; m++) //вложенный массив
                 {
                     A[n, m] = n + m;    // доступ к элементам массива 
                 }
             }*/


            // Списки (List)

            /* List<int> A = new List<int>();
             A.Add(4);
             A.Add(5);
             for(int n = 0; n < A.Count; n++)
             {
                 Console.WriteLine(A[n].ToString());
             }*/

            Random rnd = new Random();
            List<double> Q = new List<double>();
            while(Q.Count < 10)
            {
                Q.Add(rnd.NextDouble());
            }
            string s = "";
            foreach(double x in Q)
            {
                s += x.ToString() + " ";
            }
            Console.WriteLine(s);
        }
    }
}
