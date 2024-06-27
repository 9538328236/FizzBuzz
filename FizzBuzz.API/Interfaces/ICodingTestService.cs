using FizzBuzz.API.Model;


namespace FizzBuzz.API.Interfaces
{
    public interface ICodingTestService
    {
        Task<List<CodingTest>> DisplayResult(string[] inputItems );
    }
}
