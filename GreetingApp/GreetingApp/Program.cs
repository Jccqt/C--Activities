namespace GreetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter the total number of your enrolled courses: ");
            int courseNum;
            courseNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the price of your favorite book: ");
            double bookPrice;
            bookPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Total enrolled courses: {courseNum}");
            Console.WriteLine($"Price of my favorite book: {bookPrice}");
        }
    }
}