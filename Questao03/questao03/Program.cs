using System;
using System.Collections.Generic;

namespace questao03
{
    public class Program
    {
        public static void Main()
        {
            subString(Console.ReadLine());
        }

        static void subString(String word)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i; j < word.Length; j++)
                {
                    char[] letter = word.Substring(i, j + 1 - i).ToCharArray();
                    Array.Sort(letter);
                    string aux = new string(letter);
                    if (map.ContainsKey(aux))
                        map[aux] = map[aux] + 1;
                    else
                        map.Add(aux, 1);
                }
            }
            int anagramPairCount = 0;
            foreach (string key in map.Keys)
            {
                int n = map[key];
                anagramPairCount += (n * (n - 1)) / 2;
            }
            Console.Write(anagramPairCount);
        }
    }
}