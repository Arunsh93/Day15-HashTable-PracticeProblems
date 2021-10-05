using System;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buildeing Hash Table Using Linked List ");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "Or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "be");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th Index Value: " + hash5);

            hash.Remove("2");

            string hash2 = hash.Get("2");
            Console.WriteLine("2nd Index Value: " + hash2);
        }
    }
}
