using AdventCode2022;

namespace AdventCode2022Tests;

public class Day3Test
{
    private readonly IDay _sut;

    public Day3Test()
    {
        _sut = new Day3();
    }

    [Fact]
    public void Ex1Test()
    {
        StreamReader input = InputHelper.ConvertStringToStream(@"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw");

        var answer = _sut.Ex1(input);
        Assert.Equal(157, answer);
    }
}