namespace FizzBuzz.API.Model
{
    public class CodingTest
    {
        public int Id { get; set; }
        public string UserInput { get; set; } = string.Empty;
        public List<string> FinalResult { get; set; } = new List<string>();

    }
}
