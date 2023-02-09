namespace Sample.Tests;

public class SampleServiceTests
{
    [Fact]
    public void MustFetchSomething()
    {
        var sampleService = new SampleService();

        var something = sampleService.GetSomething();
        
        Assert.NotNull(something);
    }
}