using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String İfadeler");
            Console.WriteLine("Kelime Bulucu ");
            string s1 = "This string consist of a single short sentence.";
            int nWords = 0;

            s1 = s1.Trim();
            // Başında veya solunda boşluk varsa trimle

            for(int ctr=0; ctr <s1.Length; ctr++){
                if(Char.IsPunctuation(s1[ctr]) | Char.IsWhiteSpace(s1[ctr]))
                nWords++;
            }

            // 0'dan başla s1'in uzunluğu kadar dön ve karakter sayısını arttır
            //for döngüsü T'ye H'ye bakarak tek tek ilerleyecek.
            // char.IsPunctuation , 
            // Unicode karakterinin bir noktalama işareti olarak kategorilere ayrılmadığını gösterir.

            //||(veya) operatörü iki değerden birisi doğru ise doğru, ikisi de yanlış ise yanlış değerini döndürür ayrıca önceliği en az olan mantıksal operatördür.

            //Char.IsWhiteSpace Boşluk var mı yok mu 
            Console.WriteLine("The sentence \n  {0}\nhas {1} words.",
            s1,nWords);

            //IsNullOrWhiteSpace bir dizenin  null,eşit String.Empty
            //veya yalnızca boşluk karakterlerinden oluşan bir değer olup olmadığını gösterir
            
            


            
        }
    }
}
