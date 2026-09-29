namespace ArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int student1 = 450; 
            int student2 = 480; 
            int student3 = 400;

            // array 
            int[] students = new int[5];

            // acceccing
            //index 0 ........ n-1  -> n = arr.length() ;
            // Set
            students[0] = 450; // 1
            students[1] = 500; // 2
            students[2] = 200; // 3

            // Get 
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);
            Console.WriteLine(students[4]);

            
        }
    }
}
