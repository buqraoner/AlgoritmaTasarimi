using System;

namespace BirdenN_eKadarOlanSayilarinToplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Birden {0}'e kadar olan sayilarin toplamı = {1,5}",
                n,sayi.NeKadarOlanSayilarinToplami(n));
            Console.WriteLine("Birden {0}'e kadar olan sayilarin toplamı = {1,5}",
               n, sayi.NeKadarOlanSayilarinFormulleToplami(n));
        }
    }
}
