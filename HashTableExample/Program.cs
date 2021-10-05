using System;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buildeing Hash Table Using Linked List ");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = paragraph.Split(" ");

            MyMapNode<int, string> hashTable = new MyMapNode<int, string>(words.Length);
            int key = 0;

            foreach(string word in words)
            {
                hashTable.Add(key, word);
                key++;
            }

            /*Frequency frequency = new Frequency();
            frequency.WordFrequency(hashTable);*/

            Operations operation = new Operations();
            operation.WordFrequency(hashTable);
            Console.WriteLine();
            operation.Remove(hashTable, "avoidable");


            /*hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "Or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "be");*/

            /*string hash5 = hash.Get("5");
            Console.WriteLine("5th Index Value: " + hash5);

            hash.Remove("2");

            string hash2 = hash.Get("2");
            Console.WriteLine("2nd Index Value: " + hash2);*/
        }
    }
}
