using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_lab1
{
    class Substitutie_monoalfabetica
    {
       // string AlfabetOrdonat = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string shuffle(string alphabet)
        {
            string key = alphabet;
            char[] keyChars = key.ToCharArray();
            int j;
            Random rnd = new Random();
            char aux;
            for (int i = keyChars.Length-1; i >=1; i--)
            {
                j = rnd.Next(i + 1);
                aux = keyChars[i];
                keyChars[i] = keyChars[j];
                keyChars[j] = aux;
            }
            return key = new string(keyChars);
        }
       public static string Encipher(string plaintext, string cheie, string cheieDecriptare)
        { 
            string text =plaintext.ToUpper();
            char[] AlfabetOrdonat = cheie.ToCharArray();
            char[] ShuffledAlfabet = cheieDecriptare.ToCharArray();
            string rezultat = "";
            int pos = 0;

            //facem arr pt cheie si cheieDecriptare
            //daca gasim pozitia elem din text in cheie salvam acea pozitie si cautam  ce elem e pe acea pozitie in cheieDecriptare
            //cand il gasim punem elementul intr-un string rezultat
            //afisam string-ul rezultat la final
            foreach (char character in text)
            {
                if (!char.IsLetter(character))
                    rezultat = rezultat + " ";
                else
                {
                    for (int i = 0; i < AlfabetOrdonat.Length; i++)
                        if ((char)character == AlfabetOrdonat[i])
                            pos = i;
                    for (int j = 0; j < ShuffledAlfabet.Length; j++)
                        if (pos == j) rezultat = rezultat + ShuffledAlfabet[j];
                }
            }
            return rezultat;
       }
        public static string Decipher(string ciphertext, string cheieDecriptare, string cheie)
        {
            //pentru decriptare facem criptarea in ordine inversa
            //gasim pozitia characterului in alfabetul Random
            //si cautam acea pozitie in alfabetul ordonat pentru a il putea schimba la loc pentru a obtine un text lizibil
            string text = ciphertext.ToUpper();
            char[] ShuffledAlfabet = cheie.ToCharArray();
            char[] AlfabetOrdonat = cheieDecriptare.ToCharArray();
            string rezultat = "";
            int pos = 0;
            foreach (char character in text)
            {
                if (!char.IsLetter(character))
                    rezultat = rezultat + " ";
                else
                {
                    for (int i = 0; i < AlfabetOrdonat.Length; i++)
                        if ((char)character == AlfabetOrdonat[i])
                            pos = i;
                    for (int j = 0; j < ShuffledAlfabet.Length; j++)
                        if (pos == j) rezultat = rezultat + ShuffledAlfabet[j];
                }
            }
            return rezultat;
        }
    }
}
