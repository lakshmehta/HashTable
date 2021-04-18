using System;

namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello World!WELCOME TO HASHTABLE");
            Console.WriteLine("Hash table demo"); //() []
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To be or not to be");
            hash.frequencyOfWords("0");
        }
    }
}
