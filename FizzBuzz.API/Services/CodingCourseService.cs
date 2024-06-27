
using FizzBuzz.API.Interfaces;
using FizzBuzz.API.Model;
using FizzBuzz.API.Utility;

namespace FizzBuzz.API.Services
{
    public class CodingCourseService : ICodingTestService
    {
        public async Task<List<CodingTest>> DisplayResult(string[] inputItems)
        {
            var results = new List<CodingTest>();
            foreach (var value in inputItems)
            {
                var finalResult = ProcessValue(value);
                results.Add(new CodingTest { UserInput = value, FinalResult = finalResult });
            }
            return results;

        }

        private List<string> ProcessValue(string value)
        {
            var finalRes = "";
            if (!IsValidItem(value))
            {
                return new List<string> { "Invalid Item" };
            }

            var result = new List<string>();

            if (IsDivisibleBy(value, Constants.Denominator1))
            {
                finalRes += Constants.DivisibleBy3Message;
            }

            if (IsDivisibleBy(value, Constants.Denominator2))
            {
                finalRes += (finalRes.Length > 0 ? "" : "") + Constants.DivisibleBy5Message;
            }

            if (result.Count == 0 && string.IsNullOrEmpty(finalRes))
            {
                result.Add(string.Format(Constants.DividedByNumber, value, Constants.Denominator1));
                result.Add(string.Format(Constants.DividedByNumber, value, Constants.Denominator2));
            }
            else
            {
                result.Add(finalRes);
            }

            return result;
        }

        bool IsDivisibleBy(string value, int denominator)
        {
            return Helper.DivideNumber(value, denominator) == 0;
        }

        bool IsValidItem(string value)
        {
            return Helper.DivideNumber(value, Constants.Denominator1) != -1 && Helper.DivideNumber(value, Constants.Denominator2) != -1;
        }

    }
    
}
