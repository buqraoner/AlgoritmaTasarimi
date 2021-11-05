using System;

namespace Dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N Değerini giriniz : ");

            int limit =Convert.ToInt32(Console.ReadLine());

                int[] sayilar = new Dizi().Olustur(limit);



            


        }
    }
}
