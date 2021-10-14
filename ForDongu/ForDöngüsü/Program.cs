using System;

namespace ForDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int tekToplam = 0, ciftToplam = 0;
            int limit = 10;
            Console.WriteLine("Tek sayilar");
            for (int i =1; i<100; i += 2)
            {
                Console.Write("{0,5}", i);
                tekToplam += i; // tekToplam=Tektoplam +i
               

            }
          

            Console.WriteLine("\nÇift sayilar");
            for (int i = 1; i < 100; i += 2)
            {
                Console.Write("{0,5}", i);
                ciftToplam += i; // ciftToplam=cifttoplam +i

            }
            

            Console.WriteLine(" \nTek Toplam : {0,5} \nCift toplam:{1,5}",
                tekToplam, ciftToplam);



            Console.WriteLine("\n\n{0} kadar olan çift sayilar ",limit);
            for (int i = 0; i < limit; i += 2)
            {
                if(i != 0)
                {

                
                Console.Write("{0,5}", i);
                ciftToplam += i; // ciftToplam=cifttoplam +i
                }

            }

            Console.WriteLine("\n{0} kadar olan tek sayilar ", limit);
            for(int i = 1; i<limit; i += 2)
            {
                Console.Write("{0,5}", i);
                tekToplam += i;
                
            }



        }
    }
}
