namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            int studentGrade= 0;
            decimal averageGrade;
            Console.WriteLine("Enter 5 grades separated by new line: ");
            for(int i = 0;i < 5;i++)
            {
                int gradeContainer = Convert.ToInt32(Console.ReadLine());
                studentGrade += gradeContainer;
            }
            averageGrade = (decimal)studentGrade / 5;

            Console.WriteLine($"The average is {averageGrade} and round off to {Math.Round(averageGrade)}");
        }
    }
}