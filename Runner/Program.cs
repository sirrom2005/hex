using System;
using rmCrypt; 

namespace Runner
{
    class Program
    {
        private static Crypt c = new Crypt("aaasada");

        static void Main(string[] args)
        {
            string text = "The brown jox jump over the tree";
            var en = c.EnCode(text);
            var dn = c.DeCode(en);


            Console.WriteLine($"Input >>{text}");
            Console.WriteLine($"Encoded String>>>\n{en}");
            Console.WriteLine($"Decoded String>>> {dn}");
            Console.Read();
        }
    }
}
