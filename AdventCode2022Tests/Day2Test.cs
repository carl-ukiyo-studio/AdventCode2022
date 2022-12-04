using AdventCode2022;

namespace AdventCode2022Tests;

public class Day2Test
{
    private readonly IDay _sut;

    public Day2Test()
    {
        _sut = new Day2();
    }

    [Theory]                        // opponent vs player
    [InlineData("A", "X", "draw")]  // Rock vs Rock = draw
    [InlineData("A", "Y", "win")]   // Rock vs Paper = win
    [InlineData("A", "Z", "lose")]  // Rock vs Scissors = lose
    [InlineData("B", "X", "lose")]  // Paper vs Rock = lose
    [InlineData("B", "Y", "draw")]  // Paper vs Paper = draw
    [InlineData("B", "Z", "win")]   // Paper vs Scissors = win
    [InlineData("C", "X", "win")]   // Scissors vs Rock = win
    [InlineData("C", "Y", "lose")]  // Scissors vs Paper = lose
    [InlineData("C", "Z", "draw")]  // Scissors vs Scissors = draw
    public void DeterminePlayerOutcome_ShouldReturnCorrectOutcome(string opponent, string player, string expectedOutcome)
    {
        var outcome = _sut.Test(opponent, player);
        
        Assert.Equal(expectedOutcome, outcome);
    }

    [Fact]
    public void Ex1Test()
    {
        StreamReader input = InputHelper.ConvertStringToStream(@"A Y
B X
C Z");
        var totalScore = _sut.Ex1(input);
        
        Assert.Equal(15, totalScore);
    }
    
    [Fact]
    public void Ex2Test()
    {
        StreamReader input = InputHelper.ConvertStringToStream(@"A Y
B X
C Z");
        var totalScore = _sut.Ex2(input);
        
        Assert.Equal(12, totalScore);
    }

}