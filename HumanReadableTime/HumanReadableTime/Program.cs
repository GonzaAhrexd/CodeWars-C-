using Microsoft.VisualBasic;

namespace HumanReadableTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string formato = TimeFormat.GetReadableTime(5000);
            Console.WriteLine(formato);
        }
    }
}
