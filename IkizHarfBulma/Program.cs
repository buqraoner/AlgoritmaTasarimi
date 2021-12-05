using System;

namespace IkizHarfBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //string veri tipine değer atama
            string kelime = " Helo Worldd ";
            
            //Başı ve sonundaki boşlukları sil 
            kelime = kelime.Trim();

            //For döngüsü ile her harfi döndürme
            //i tam sayı değerini  kelime stringin  harf uzunluğu kadar döndür
            // her seferinde i'yi 1 arttır karakter bittiğinde döngüden çık
            for(int i = 0; i<kelime.Length; i++)
            {   

                if(kelime[i]    == kelime[i+1]){

                    Console.WriteLine(kelime[i]);
                    break;

                }

               


                }

            }






        }
    }

