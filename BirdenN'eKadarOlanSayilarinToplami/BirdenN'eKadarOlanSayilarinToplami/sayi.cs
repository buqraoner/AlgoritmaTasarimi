using System;
using System.Collections.Generic;
using System.Text;

namespace BirdenN_eKadarOlanSayilarinToplami
{
    class sayi
    {


        public static int NeKadarOlanSayilarinToplami(int n)
        {
            int t = 0;
            for (int i = 0; i <= n; i++)

                t += i;
            return t;

        }

        public static int NeKadarOlanSayilarinFormulleToplami(int n)
        {
            return n * (n + 1) / 2;

        }

       
			


    }
}
