namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Habibi, Please give two numbers:");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + (number1+number2));
        }
    }
}
