using Xunit.Abstractions;

namespace testing_tests.Tests.DemoClass;
using Xunit;

public class DemoClass_NumberIsDivisibleBy_Tests
{

    public DemoClass_NumberIsDivisibleBy_Tests()
    {
        
    }
    
    private global::DemoClass _demoClass;
    private readonly ITestOutputHelper output;

    [Theory]
    [InlineData(2)]
    public void NumberIsDivisibleBy_EvenNumbers_ReturnTrue(int value)
    {
        foreach (int num in new List<int> {2, 4, 6, 20})
        {
            _demoClass = new(num);
            var result = _demoClass.NumberIsDivisibleBy(value);
            
            output.WriteLine(result.ToString());
            
            Assert.True(result);
        }
    }
}