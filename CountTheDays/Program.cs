namespace CountTheDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Day day = new Day();

            Console.WriteLine(day.countDays(new DateTime(2016, 12, 2)));
            Console.WriteLine(day.countDays(DateTime.Now));
            Console.WriteLine(day.countDays(new DateTime(2025, 12, 2)));

        }
    }
}
