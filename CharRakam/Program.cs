using System;

namespace CharRakam
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 65; i<=90; i++){
                Console.Write("{0,5}",
                (char)i);

                if(i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
