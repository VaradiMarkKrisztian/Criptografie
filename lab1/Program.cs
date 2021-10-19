using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_lab1
{
    class Program
    { 
        static void Main(string[] args)
        {
            //cifrun();
            //SubsMonoAlfabetica();
            Console.ReadKey();
        }
        static void SubsMonoAlfabetica()
        {
            string cheie = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";          
            string CheieDecriptare = Substitutie_monoalfabetica.shuffle(cheie);
            Console.WriteLine($"Alfabetul ordonat {cheie}");
            Console.WriteLine($"Alfabetul Random  { Substitutie_monoalfabetica.shuffle(cheie)}");
            Console.WriteLine("Introduceti un text ");           
            string plaintext = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Textul cifrat este {Substitutie_monoalfabetica.Encipher(plaintext, cheie,CheieDecriptare)}");
            Console.WriteLine("Introduceti un text cifrat ");
            string ciphertext = Console.ReadLine();
            Console.WriteLine($"Textul descifrat este {Substitutie_monoalfabetica.Decipher(ciphertext, CheieDecriptare,cheie)}");
        }
        static void cifrun()
        {
            Console.WriteLine("Introduceti un text pentru criptare cu 3");
            string plaintext = Console.ReadLine();
            Console.WriteLine(CifruN.Encipher(plaintext, 3));
            Console.WriteLine();

            Console.WriteLine("Introduceti un text pentru criptare");
            string plaintext2 = Console.ReadLine();
            Console.WriteLine("Introduceti o cheie 1->25 pentru criptare");
            int cheie = int.Parse(Console.ReadLine());
            Console.WriteLine($"Textul obtinut este {CifruN.Encipher(plaintext2, cheie)}");
            Console.WriteLine("Introduceti un text cifrat pentru decriptare cu criptanaliza");
            string ciphertext = Console.ReadLine();
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine($"cheie {i}: { CifruN.Decipher(ciphertext, i)}");
            }           
        }    
    }
}
