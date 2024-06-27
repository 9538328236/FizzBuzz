
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
                results.Add(Helper.BuildResponse(value));
            }

            return results;
        }
       
    }
    
}
