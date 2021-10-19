using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_lab1
{
    class CifruN
    {
            public static string Encipher(string input, int key)
            {
                string output = "";
                foreach (char character in input) output = output + cipher(character, key);
                return output;
            }
            public static string Decipher(string input, int key)
            {
                return Encipher(input, 26 - key);
            }
            public static char cipher(char character, int key)
            {
                if (!char.IsLetter(character))
                {
                    return character;
                }           
                char d = char.IsUpper(character) ? 'A' : 'a';
                return (char)((((character + key) - d) % 26) + d);
            }       
    }
}
