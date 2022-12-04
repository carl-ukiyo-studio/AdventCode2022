using AdventCode2022;

namespace AdventCode2022Tests;

public class Day4Test
{
    private readonly IDay _sut;

    public Day4Test()
    {
        _sut = new Day4();
    }

    [Fact]
    public void Ex1Test()
    {
        StreamReader input = InputHelper.ConvertStringToStream(@"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8
17-34,18-34");

        var answer = _sut.Ex1(input);
        Assert.Equal(3, answer);
    }
    
    [Fact]
    public void Ex2Test()
    {
        StreamReader input = InputHelper.ConvertStringToStream(@"2-4,6-8
2-3,4-5
5-7,7-9
2-8,3-7
6-6,4-6
2-6,4-8");

        var answer = _sut.Ex2(input);
        Assert.Equal(4, answer);
    }
}