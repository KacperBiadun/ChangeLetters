using System;
using System.Collections;
using System.Collections.Generic;

namespace ChangeLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var ht = new Hashtable();
            ht.Add('A', "2");
            ht.Add('B', "22");
            ht.Add('C', "222");
            ht.Add('D', "3");
            ht.Add('E', "33");
            ht.Add('F', "333");
            ht.Add('G', "4");
            ht.Add('H', "44");
            ht.Add('I', "444");
            ht.Add('J', "5");
            ht.Add('K', "55");
            ht.Add('L', "555");
            ht.Add('M', "6");
            ht.Add('N', "66");
            ht.Add('O', "666");
            ht.Add('P', "7");
            ht.Add('Q', "77");
            ht.Add('R', "777");
            ht.Add('S', "7777");
            ht.Add('T', "8");
            ht.Add('U', "88");
            ht.Add('V', "888");
            ht.Add('W', "9");
            ht.Add('X', "99");
            ht.Add('Y', "999");
            ht.Add('Z', "9999");


            foreach (var letter in input)
            {
                if (ht.ContainsKey(letter))
                {
                    var hashVal = ht[letter];
                    Console.Write(hashVal);
                }
            }


        }
    }
}