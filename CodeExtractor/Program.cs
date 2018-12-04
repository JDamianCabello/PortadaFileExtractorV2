using System;

namespace CodeExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalPatch, destinationPatch;
            Console.WriteLine("Original patch:");
            originalPatch = Console.ReadLine();
            Console.WriteLine("Destination patch:");
            destinationPatch = Console.ReadLine();

            Copy.ExpecificFiles(originalPatch, destinationPatch, true,true,true,true,false);

            Console.WriteLine("All done, press one key to leave.");
            Console.ReadKey();
        }
    }
}
