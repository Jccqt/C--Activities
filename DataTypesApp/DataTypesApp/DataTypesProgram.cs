namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int appleCount = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter total price of {appleCount} apple(s): ");
            double applePrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The total price of {appleCount} apple(s) is {applePrice}");
            Console.WriteLine($"The value of original price is {applePrice}");

            int applePriceInt = (int)applePrice; // will convert double to int
            Console.WriteLine($"The value of converted price is {applePriceInt}");
        }
    }
}