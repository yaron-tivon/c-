namespace ReadNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            Console.WriteLine("Enter two numbers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine($"The sum is {sum}");
        }
    }
}