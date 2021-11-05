using System;
using System.Collections.Generic;
using System.Text;

namespace DZLR
{
    public class NewBaseType
    {
        public int[] Olustur(int limit)
        {
            int[] sayilar = new int[limit];
             Console.WriteLine("");
            for(int i =0; i<limit; i++)
            {
                sayilar[i]= new Random().Next(1,100);
               
                Console.Write("\n {0,5}\n",sayilar[i]);
                
                
            }
            return sayilar;
        }
    }

    
}
