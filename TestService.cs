namespace FunctionApp1
{
    public class TestService : ITestService
    {
        public string GetName()
        {
            return "krishna";
        }
    }

    public interface ITestService
    {
        string GetName();
    }
}
