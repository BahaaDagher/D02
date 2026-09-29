namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DS
            // Data Structure 
            // List  , Dictionary  , LinkedList  , Stack  , Queue

            

            List<int> numbers = new List<int>();

            // Set 
            numbers.Add(11); 
            numbers.Add(22); 
            numbers.Add(23);
            Console.WriteLine(numbers.Count);  //  3 
            Console.WriteLine(numbers.Capacity); // 4 

            numbers.Add(24);
            numbers.Add(25);

            Console.WriteLine(numbers.Count);  //   5
            Console.WriteLine(numbers.Capacity); //  8

            numbers.TrimExcess();


            Console.WriteLine(numbers.Count);  //   5
            Console.WriteLine(numbers.Capacity); //  5


            numbers.Add(25);

            Console.WriteLine(numbers.Count);  //  6
            Console.WriteLine(numbers.Capacity); //  10



            int[] arr = new int[32];

            arr[0] = 4; 
            arr[1] = 5;
            arr[2] = 6;
            arr[3] = 7;
            arr[4] = 7;
           
            
            // Count     = 5 
            // Capacity  = 8

        }
    }
}
