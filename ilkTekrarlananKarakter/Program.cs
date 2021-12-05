//
   // /C# program to find the first
// repeated character in a string
using System;
using System.Collections.Generic;
 
class GFG
{
    // This function prints the first
    // repeated character in str[]
    public static char firstRepeating(char[] str)
    {
        // Creates an empty hashset
        HashSet<char> h = new HashSet<char>();

        // Traverse the input array
        // from left to right
        for (int i = 0; i <= str.Length - 1; i++)
        {
            char c = str[i];

            // If element is already in hash set,
            // update x and then break
            if (h.Contains(c))
            {
                return c;
            }

            else // Else add element to hash set
            {
                h.Add(c);
            }
        }

        return '\0';
    }

    // Driver Code
    public static void Main(string[] args)
    {
        string str = "BugriSamaa";
        char[] arr = str.ToCharArray();
        Console.WriteLine(firstRepeating(arr));
    }
}
