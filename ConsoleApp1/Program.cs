using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mertebe
            //Task -3 İsdifadəçi Ədəd Daxil Edir. Daxil Edilən Ədədin Neçə Mərtəbəbli
            //Olduğunu Tapan Alqoritmi Qurun(Misal: 15613 - 5 Mərtəbəli, 656 - 3 Mərtəbəli)

            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //Mertebe(number);


            #endregion

            #region Quvvet
            //Task - 7 İsdifadəçi 2 Dənə Ədəd  Daxil Edir n və m ədədləri.
            //m Ədədinin n Qüvvətini Tapan Alqoritm Qurun.

            //Console.Write("Ededi daxil edin ");
            //int m;
            //int.TryParse(Console.ReadLine(), out m);
            //Console.Write("Quvveti daxil edin ");
            //int n;
            //int.TryParse(Console.ReadLine(), out n);

            //Quvvet(m, n);

            #endregion

            #region Faktorial
            //int n = 0;
            //int.TryParse(Console.ReadLine(), out n);

            //faktorial(n);
            #endregion

            #region Avarage

            //Console.WriteLine($"{Average(FieldArray())} -average budur");


            #endregion
        }

        #region Quvvet
        //static void Quvvet(int m, int n) 
        //{
        //    int result = 1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (n != 0)
        //        {
        //            result = result * m;

        //        }

        //    }
        //    Console.WriteLine(result);
        //}

        #endregion

        #region Mertebe
        //static void Mertebe(int n) // n=number
        //{
        //    int count = 0;

        //    int temp = n;
        //    while (n != 0)
        //    {
        //        n /= 10;
        //        count++;
        //    }
        //    Console.WriteLine($"{temp} ededi - {count} mertebelidir");
        //}
        #endregion

        #region faktorial
        //     static void faktorial (int n)
        //     {int fact = 1;
        //         for (int i = 1; i <= n; i++)
        //         {
        //             fact = fact * i;

        //         }
        //         Console.WriteLine(n + " ededinin faktoriali " + fact + " ededidir");

        //}
        //     }

        #endregion

        #region Array Avarage +Array fill by method

        //static int[] FieldArray()
        //{
        //    int size;
        //    Console.WriteLine("Arrayin uzunlugunu daxil edin");
        //    int.TryParse(Console.ReadLine(), out size);
        //    int[] arr = new int[size];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write($"Arrayin {i} elementini daxil edin - ");
        //        int.TryParse(Console.ReadLine(), out arr[i]);
        //    }
        //    foreach (int item in arr)
        //    {
        //        Console.Write(item+" ");
        //    }
        //    Console.WriteLine();
        //    return arr;
        //}
        //static double Average(int[] arr)
        //{
        //    double result = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        result = result + arr[i];
        //    }

        //    result = result / arr.Length;

        //    return result;
        //}



        #endregion

    }
}







    



