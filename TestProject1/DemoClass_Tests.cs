namespace TestProject1;

public class DemoClass_Tests
{
    private DemoClass _demoClass;

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    [InlineData(20)]
    public void DemoClass_NumberIsDivisibleBy_ReturnTrue(int value)
    {
        _demoClass = new(value);

        var result = _demoClass.NumberIsDivisibleBy(2);
        
        Assert.True(result);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(4)]
    [InlineData(7)]
    [InlineData(14)]
    public void DemoClass_NumberIsDivisibleBy_ReturnFalse(int value)
    {
        _demoClass = new(value);

        var result = _demoClass.NumberIsDivisibleBy(3);
        
        Assert.False(result);
    }
    
    
    [Theory]
    [InlineData(1, @"D:\Code\dotnet-test-test\dotnet-test-test\Program.cs")]
    [InlineData(2, @"D:\Code\sp24-gpr250\Final - JoshuAnne\Final\CollisionEvent.cpp")]
    [InlineData(3, @"C:\Users\akoni\Downloads\Forbidden.png")]
    [InlineData(4, @"D:\curseforge\minecraft\Install\launcher_custom_skins.json")]
    public void DemoClass_FileName_ReturnTrue(int testNumber, string path)
    {
        _demoClass = new(path);

        var fileNameResult = _demoClass.FileName;
        
        string GetExpectedResult (int testNumber) 
        {
            switch (testNumber)
            {
                case 1:
                    return "Program.cs";
                case 2:
                    return "CollisionEvent.cpp";
                case 3:
                    return "Forbidden.png";
                case 4:
                    return "launcher_custom_skins.json";
                default:
                    return "ERROR!";
            }
            
        }
        
        Assert.Equal(GetExpectedResult(testNumber), fileNameResult);
    }
}