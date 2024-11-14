using System.Numerics;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our lundry");
            Console.WriteLine();
            Console.Write("please enter the number of small rugs :  ");
            int smallRugs = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("please enter the number of large rugs :  ");
            int largeRugs = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Price for Small rug is : 25$");
            Console.WriteLine("Price for Large rug is : 35$");
            Console.WriteLine(" ----------------------------------");
            int smallRugsCost = 25 * smallRugs;
            int largeRugsCost = 35 * largeRugs;
            Console.WriteLine($" estimated price for Small rugs is = {smallRugsCost} $");
            Console.WriteLine($" estimated price for Large rugs is = {largeRugsCost} $");
            int cost = smallRugsCost + largeRugsCost;
            Console.WriteLine( $"total price with out tax is  {cost}  ");
            double tax = 0.06 * cost;
            double totalPrice =  cost+tax;
            Console.WriteLine($"Total estimated price : {totalPrice}");
            Console.WriteLine();
            Console.WriteLine("this estimate is valid for 30 days");

        }











        

        

    }
}
