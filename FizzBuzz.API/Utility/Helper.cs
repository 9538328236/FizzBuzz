
namespace FizzBuzz.API.Utility
{
    public static class Helper
    {
        public static int DivideNumber(string value, int denominator)
        {
            if (int.TryParse(value, out int number))
            {
                return number % denominator;
            }
            else
            {
                return -1;
            }
           
        }

    }
}
