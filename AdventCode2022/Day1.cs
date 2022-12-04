namespace AdventCode2022;

public class Day1 : Day
{
    public Day1()
    {
        Index = 1;
    }

    public override int Index { get; }

    public override int Ex1(StreamReader input)
    {
        var listOfCalories = GetCalories(input);
        if (listOfCalories.Count < 1)
        {
            return -1;
        }
        return listOfCalories.Max();
    }

    public override int Ex2(StreamReader input)
    {
        var listOfCalories = GetCalories(input);
        if (listOfCalories.Count < 1)
        {
            Console.WriteLine("Error! Input was empty!");
            return -2;
        }
        var listOfCaloriesOrderDesc = listOfCalories.OrderDescending();
        var topThree = listOfCaloriesOrderDesc.Take(3);
        var sumTopThree = topThree.Sum();
        return sumTopThree;
    }

    private List<int> GetCalories(StreamReader input)
    {
        try
        {
            string line;
            List<int> calories = new List<int>();
            int sum = 0;
            // Read and display lines from the file until the end of
            // the file is reached.
            while (input.Peek() >= 0)
            {
                line = input.ReadLine() ?? throw new InvalidOperationException();
                if (line == string.Empty)
                {
                    calories.Add(sum);
                    sum = 0;
                }
                else
                {
                    sum += int.Parse(line);
                    if (input.Peek() == -1)
                    {
                        calories.Add(sum);
                        sum = 0;
                    }
                }
            }

            return calories;
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("Invalid Input for Day1 Ex1!");
            Console.WriteLine(e.Message);
            return new List<int>();
        }
    }

}