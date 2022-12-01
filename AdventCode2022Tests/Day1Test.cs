using AdventCode2022;

namespace AdventCode2022Tests;

public class Day1Test
{
    private readonly IDay _sut;

    public Day1Test()
    {
        _sut = new Day1();
    }

    [Fact]
    public void Test1()
    {
        string input = @"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";

        var answer = _sut.Calculate(input);
        Assert.Equal(24000, answer);
    }
}