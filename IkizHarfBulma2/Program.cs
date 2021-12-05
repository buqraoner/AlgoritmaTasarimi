using System;

namespace IkizHarfBulma2
{
    class Program
    {

         static int TekrarEden(string s)
        {

            int a = -1;
            int i = 0;

            for (int j = 0;  j<s.Length; j++)
            {

                for (j = i + 1; j < s.Length; j++)
                {

               
                    if (s[i] == s[j])
                {
                    a = j;
                    break;
                }

                }
                if (a != -1)          
                break;

            }
            return a;


            }

        static void Main(string[] args)
        {
            Console.WriteLine("Bir string ifade giriniz");
        string kelime = Console.ReadLine();
            int deneme = TekrarEden(kelime);
            if (deneme == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine(kelime[deneme]);
            
            
            // Fonkisyonu çağır


        }
    }
}