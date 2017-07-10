using System.Security.Cryptography;

using static System.Console;
using static System.Convert;

namespace SymmetricKeyGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
            tripleDESCryptoServiceProvider.GenerateKey();
            WriteLine(ToBase64String(tripleDESCryptoServiceProvider.Key));
            WriteLine("Done!");
            ReadLine();
        }
    }
}
