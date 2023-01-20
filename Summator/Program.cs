namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is equal to "+Summator.Sum(new int[] { 1,2,3}));
            Console.WriteLine("The average of the array numbers is: "+ Summator.Average(new int[] { 5,5,6}));
            Console.WriteLine("The product of the array numbers is: " + Summator.Multiply(new int[] { 3, 4, 5 }));
        }
    }
}