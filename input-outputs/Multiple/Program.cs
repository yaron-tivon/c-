namespace Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter two numbers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
           
            Console.WriteLine($"{num1}*{num2}={num1*num2}");
        }
    }
}