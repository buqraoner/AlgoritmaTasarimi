using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String İfadeler");
            Console.WriteLine("Kelime Bulucu ");
            string s1 = "This  string consist of a single short sentence.";
            int nWords = 0;

            s1 = s1.Trim();
            for(int ctr=0; ctr <s1.Length; ctr++){
                if(Char.IsPunctuation(s1[ctr]) | Char.IsWhiteSpace(s1[ctr]))
                nWords++;
            }

            Console.WriteLine("The sentence \n  {0}\nhas {1} words.",
            s1,nWords);
            


            
        }
    }
}
