namespace Solvechallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite number (1 - 100):");
            int number = Convert.ToInt32( Console.ReadLine() );
            //Console.WriteLine($"No really!! {number} is my favorite number too! ");
            Console.WriteLine("No really!! " + number + " is my favorite number too! ");
        }
    }
}
