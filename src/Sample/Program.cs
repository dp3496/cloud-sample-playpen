namespace Sample;

public class Program
{
    public static void Main(string[] args)
    {
        var sampleService = new SampleService();
        
        Console.WriteLine(sampleService.GetSomething());
    }
}