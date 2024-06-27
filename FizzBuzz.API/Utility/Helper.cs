using FizzBuzz.API.Model;

namespace FizzBuzz.API.Utility
{
    public static class Helper
    {
        public static CodingTest BuildResponse(string value)
        {
           
            if (int.TryParse(value, out int number))
            {
                var finalResult = "";

                if (number % 3 == 0)
                {
                    finalResult += Constants.DivisibleBy3Message;
                }
                if (number % 5 == 0)
                {
                    finalResult += (finalResult.Length > 0 ? "" : "") + Constants.DivisibleBy5Message;
                }

                if (number % 3 != 0 && number % 5 != 0 && finalResult.Length == 0)
                {
                        return new CodingTest { UserInput = value, FinalResult = new List<string> { string.Format(Constants.DividedByNumber, number, 3), string.Format(Constants.DividedByNumber, number, 5) } };
                }

                else
                {
                    return new CodingTest { UserInput = value, FinalResult = new List<string> { finalResult } };
                }

            }
            else
            {
                return new CodingTest { UserInput = value, FinalResult = new List<string> { "Invalid Item" } };
            }
           
        }
    }
}
