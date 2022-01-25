using System;

namespace Matrisler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] dizi = new int[2, 2];
            //dizi[0, 0] = 1;
            //dizi[0, 1] = 5;
            //dizi[1, 0] = 7;
            //dizi[1, 1] = 9;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //        Console.Write("{0}", dizi[i, j]);
            //    Console.WriteLine();

            //}
            //Console.Read();

            //-----------------------------------------------------------------------

            //int[,] dizi = new int[2, 3];
            //dizi[0, 0] = 2;
            //dizi[0, 1] = 5;
            //dizi[0, 2] = 10;
            //dizi[1, 0] = 6;
            //dizi[1, 1] = 8;
            //dizi[1, 2] = 9;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //        Console.Write(" {0} ", dizi[i, j]);
            //    Console.WriteLine();
            //}
            //Console.Read();

            //----------------------------------------------------------------------------

            //int[,] dizi = new int[3, 2];
            //dizi[0, 0] = 10;
            //dizi[1, 0] = 30;
            //dizi[2, 0] = 50;
            //dizi[0, 1] = 20;
            //dizi[1, 1] = 40;
            //dizi[2, 1] = 60;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //        Console.Write(" {0} ", dizi[i, j]);
            //    Console.WriteLine();
            //}
            //Console.Read();

            //-----------------matrislerde toplama--------------------------

            //int[,] matris1 = { { 10, 12, 14, 18 }, { 20, 14, 16, 13 }, { 25, 14, 41, 21 }, { 32, 36, 41, 57 } };
            //int[,] matris2 = { { 40, 30, 20, 10 }, { 7, 9, 8, 6 }, { 21, 22, 23, 24 }, { 34, 35, 36, 37 } };

            //int[,] toplam = new int[4, 4];
            //for (int i = 0; i < 4; i++)
            //{
            //    for(int j = 0;j<4;j++)
            //    {
            //        toplam[i, j] = matris1[i, j] + matris2[i, j];
            //    }
            //}
            //for (int k = 0; k < 4; k++)
            //{
            //    Console
            //        .WriteLine();
            //    for (int m = 0; m < 4; m++)
            //    {
            //        Console.Write(toplam[k, m] + " ");
            //    }
            //}
            //Console.Read();

            //------------------------satır ve sütun sayısı klavyeden girilen matrisi hesaplama------------------------------

            //int satir, sutun;
            //Console.WriteLine("Satır Sayısını Giriniz...");
            //satir = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sütun Sayısını Giriniz...");
            //sutun = Convert.ToInt32(Console.ReadLine());

            //int[,] matris = new int[satir, sutun];
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write("Matrisin {0} x {1} Değeri:", i + 1, j + 1);
            //        matris[i, j] = Convert.ToInt32(Console.ReadLine());

            //    }
            //}
            //Console.WriteLine();
            //for (int k = 0; k < satir; k++)
            //{
            //    for (int m = 0; m < sutun; m++)
            //    {
            //        Console.Write(matris[k, m]+" ");
                    
            //    }
            //    Console.WriteLine();
            //}

            ////-----------matrisin transpozunu alma----------------
            //Console.WriteLine();
            //for (int x = 0; x < satir; x++)
            //{
            //    for (int y = 0; y < sutun; y++)
            //    {
            //        Console.Write(matris[y, x] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////------------------matrisi bir katsayı ile çarpma---------------
            //Console.WriteLine();
            //for (int s = 0; s < satir; s++)
            //{
            //    for (int t = 0; t < sutun; t++)
            //    {
            //        Console.Write(matris[s,t]*5+" ");
            //    }
            //    Console.WriteLine();
            //}

            


        }
    }
}
