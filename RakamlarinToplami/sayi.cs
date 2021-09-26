using System;
using System.Collections.Generic;
using System.Text;

namespace RakamlarinToplami
{
    class sayi
    {

        public static int RakamlariToplami(int n)
        {
            int toplam = 0;
            int  rakam = 0;
            while (n > 0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;
            }
            return toplam;
        }
    }
}
