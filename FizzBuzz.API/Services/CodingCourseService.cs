
using FizzBuzz.API.Interfaces;
using FizzBuzz.API.Model;

namespace FizzBuzz.API.Services
{
    public class CodingCourseService : ICodingTestService
    {
        public async Task<List<CodingTest>> DisplayResult(string[] inputItems)
        {
           
            var results = new List<CodingTest>();

            foreach (var value in inputItems)
            {
                if (int.TryParse(value, out int number))
                {
                    var finalResult = "";

                    if (number % 3 == 0)
                    {
                        finalResult += "Fizz";
                    }
                    if (number % 5 == 0)
                    {
                        finalResult += (finalResult.Length > 0 ? "" : "") + "Buzz";
                    }

                    if(number % 3 != 0 && number % 5 != 0 && finalResult.Length == 0)
                    {
                        results.Add(new CodingTest { UserInput = value, FinalResult = "", DivisionPerfomed = new List<string> { "Divided"+Convert.ToString(number)+"By 3", "Divided" + Convert.ToString(number) + "By 5" } });
                    }

                    else
                    {
                        results.Add(new CodingTest { UserInput = value, FinalResult = finalResult, DivisionPerfomed = new List<string>() });
                    }
                   
                }
                else
                {
                    results.Add(new CodingTest { UserInput = value, FinalResult = "Invalid item" });
                }
            }

            return results;
        }
       
    }
    
}
