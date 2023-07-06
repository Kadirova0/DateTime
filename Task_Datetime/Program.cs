using System;
using System.Globalization;

namespace Datetimee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime date = DateTime.ParseExact("05_08_2001", "dd_MM_yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

        }
    }
}