// See https://aka.ms/new-console-template for more information


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello!!");
    }
}

public class DemoClass
{
    public DemoClass()
    {
        
    }
    public DemoClass(int number)
    {
        _number = number;
    }
    public DemoClass(string path)
    {
        _path = path;
    }
    public DemoClass(int number, string path)
    {
        _number = number;
        _path = path;
    }

    private int _number;
    public int Number
    {
        get => _number;
        set => _number = value;
    }

    public bool NumberIsDivisibleBy(int divisor) => _number % divisor == 0;

    private string _path;

    public string Path
    {
        get => _path;
        set => _path = value;
    }

    public string FileName
    {
        get
        {
            string tempPath = _path.Replace(@"\", "/");
            string name;
            var pathTokens = tempPath.Split('/');
            // If the path is to a directory (ends with /)
            if (tempPath.EndsWith('/'))
                name = $"{pathTokens.ElementAt(pathTokens.Length - 2)}/";
            else
                name = pathTokens.Last();
            return name;
        }
    }
}
