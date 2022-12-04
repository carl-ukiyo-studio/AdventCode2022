namespace AdventCode2022;

public class Day2 : Day
{
    // A = 1, B = 2, C = 3
    // X = 1, Y = 2, Z = 3
    // A,X = Rock
    // B,Y = Paper
    // C,Z = Scissors
    // lose = 0, draw = 3, win = 6

    private Dictionary<string, int> hands = new();
    private Dictionary<string, int> outcomeValues = new();

    public Day2()
    {
        Index = 2;
        PrepareData();
    }

    public override int Ex1(StreamReader input)
    {
        string line;
        int totalScore = 0;
        // Read and display lines from the file until the end of
        // the file is reached.
        while (input.Peek() >= 0)
        {
            line = input.ReadLine();
            var opponent = line[0].ToString();
            var player = line[2].ToString();
            var outcome = DeterminePlayerOutcome(opponent, player);
            var score = hands.GetValueOrDefault(ConvertToHand(player)) + outcomeValues.GetValueOrDefault(outcome);
            totalScore += score;
        }

        return totalScore;
    }

    // now X = Lose, Y = draw, Z = win instead
    // need to work out what hand to play to get desired outcome
    
    public override int Ex2(StreamReader input)
    {
        string line;
        int totalScore = 0;
        // Read and display lines from the file until the end of
        // the file is reached.
        while (input.Peek() >= 0)
        {
            line = input.ReadLine();
            var opponent = line[0].ToString();
            var desiredOutcome = line[2].ToString();
            var playerHand = DetermineHandToGetDesiredOutcome(opponent, desiredOutcome);
            var score = hands.GetValueOrDefault(playerHand) + outcomeValues.GetValueOrDefault(ConvertToOutcome(desiredOutcome));
            totalScore += score;
        }

        return totalScore;
    }

    public override string Test(string i, string j)
    {
        return DeterminePlayerOutcome(i, j);
    }

    public override int Index { get; }

    private void PrepareData()
    {
        hands.Add("rock", 1);
        hands.Add("paper", 2);
        hands.Add("scissors", 3);
        outcomeValues.Add("lose", 0);
        outcomeValues.Add("draw", 3);
        outcomeValues.Add("win", 6);
    }

    private string DeterminePlayerOutcome(string opponent, string player)
    {
        switch (opponent)
        {
            case "A":
                switch (player)
                {
                    case "X": return "draw"; // Rock vs Rock
                    case "Y": return "win"; // Rock vs Paper
                    case "Z": return "lose"; // Rock vs Scissors
                }

                break;
            case "B":
                switch (player)
                {
                    case "X": return "lose"; // Paper vs Rock
                    case "Y": return "draw"; // Paper vs Paper
                    case "Z": return "win"; // Paper vs Scissors
                }

                break;
            case "C":
                switch (player)
                {
                    case "X": return "win"; // Scissors vs Rock
                    case "Y": return "lose"; // Scissors vs Paper
                    case "Z": return "draw"; // Scissors vs Scissors
                }

                break;
            default: return "error";
        }

        return "error";
    }

    private string DetermineHandToGetDesiredOutcome(string opponent, string outcome)
    {
        switch (opponent)
        {
            case "A":
                switch (outcome)
                {
                    case "X": return "scissors"; // Rock, Lose => Scissors
                    case "Y": return "rock"; // Rock, Draw => Rock
                    case "Z": return "paper"; // Rock, Win => Paper
                }

                break;
            case "B":
                switch (outcome)
                {
                    case "X": return "rock"; // Paper, Lose => Rock
                    case "Y": return "paper"; // Paper, Draw => Paper
                    case "Z": return "scissors"; // Paper, Win => Scissors
                }

                break;
            case "C":
                switch (outcome)
                {
                    case "X": return "paper"; // Scissors, Lose => Paper
                    case "Y": return "scissors"; // Scissors, Draw => Scissors
                    case "Z": return "rock"; // Scissors, Win => Rock
                }

                break;
            default: return "error";
        }

        return "error";
    }

    private string ConvertToHand(string symbol)
    {
        return symbol switch
        {
            "A" => "rock",
            "B" => "paper",
            "C" => "scissors",
            "X" => "rock",
            "Y" => "paper",
            "Z" => "scissors",
            _ => ""
        };
    }

    private string ConvertToOutcome(string symbol)
    {
        return symbol switch
        {
            "X" => "lose",
            "Y" => "draw",
            "Z" => "win",
            _ => ""
        };
    }
}