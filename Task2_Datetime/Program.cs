using System.Globalization;

namespace datetime2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime time1 = new DateTime(05 / 08 / 2001);
            time1 = time1.AddDays(30);
            time1 = time1.AddHours(6);
            time1 = time1.AddMinutes(17);
            Console.WriteLine(time1);
        }
    }
}