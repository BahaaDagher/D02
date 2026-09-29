using System.Xml;

namespace solveChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            // set 
            numbers[0] = 11;
            numbers[1] = 22;
            numbers[2] = 33;

            Console.WriteLine(numbers[0]); // 11
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            numbers[0] = 111;

            Console.WriteLine("========================");

            Console.WriteLine(numbers[0]); // 111
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);



            string[] names = new string[5];

            names[0] = "Ahmed"; 
            names[1] = "Ali"; 
            names[2] = "Mai";



            //int x = 9;
            //x = 8; 
            //Console.WriteLine(x); // 8

            //x = 14;
            //Console.WriteLine(x); // 14



            //int[] arr = { 1 , 2 , 3  }; 
            int[] arr = [ 1 , 2 , 3  ];  // collection Expression

        }
    }
}
