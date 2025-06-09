namespace HandsOnWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //working with arrays
            int[] numbers = new int[5]; // Declare an array of integers with a size of 5
            //assing values to the array
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
           // numbers[5]= 60; // This will cause an IndexOutOfRangeException because the array size is 5 (0-4)
           //access value from array
           Console.WriteLine("The first number is: " + numbers[0]); // Output: The first number is: 10
              Console.WriteLine("The second number is: " + numbers[1]); // Output: The second number is: 20
            // Loop through the array and print each number
            Console.WriteLine("All numbers in the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]); // Output: 10, 20, 30, 40, 50
            }
            // Example of using a foreach loop to iterate through the array
            Console.WriteLine("Using foreach loop to print all numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number); // Output: 10, 20, 30, 40, 50
            }
            // Example of using an array initializer to create and assign values to an array
            int[] moreNumbers = { 60, 70, 80, 90, 100 };
            Console.WriteLine("More numbers in the array:");
            foreach (int number in moreNumbers)
            {
                Console.WriteLine(number); // Output: 60, 70, 80, 90, 100
            }
           
        }
    }
}
