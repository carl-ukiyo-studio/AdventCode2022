using AdventCode2022;
using static AdventCode2022.InputHelper;

namespace AdventCode2022Tests;

public class Day1Test
{
    private readonly IDay _sut;

    public Day1Test()
    {
        _sut = new Day1();
    }

    [Fact]
    public void Ex1Test()
    {
        StreamReader input = ConvertStringToStream(@"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000");

        var answer = _sut.Ex1(input);
        Assert.Equal(24000, answer);
    }
    
    [Fact]
    public void Ex2Test()
    {
        StreamReader input = ConvertStringToStream(@"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000");

        var answer = _sut.Ex2(input);
        Assert.Equal(45000, answer);
    }

    [Fact]
    public void GetCalories_ShouldHandle_InvalidInput()
    {
        StreamReader input = ConvertStringToStream(@"");

        var answer = _sut.Ex1(input);
        
        Assert.Equal(-1, answer);
    }

    [Fact]
    public void GetCalories_ShouldHandle_StreamAlreadyRead()
    {
        StreamReader input = ConvertStringToStream(@"123");
        input.ReadToEnd();

        var answer = _sut.Ex2(input);
        
        Assert.Equal(-2, answer);
    }
}