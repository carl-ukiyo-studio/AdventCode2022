namespace AdventCode2022;
using static InputHelper;


public class AdventCalendar
{
    public async Task Day1()
    {
        Console.WriteLine("====== Day 1 ======");
        IDay day1 = new Day1();
        Console.WriteLine("Day 1 - Exercise 1");
        StreamReader input = await GetInput(day1.Index);
        var day1Ex1Answer = day1.Ex1(input);
        Console.WriteLine(day1Ex1Answer.ToString());
        Console.WriteLine("Day 1 - Exercise 2");
        input = await GetInput(day1.Index);
        var day1Ex2Answer = day1.Ex2(input);
        Console.WriteLine(day1Ex2Answer.ToString());
    }

    public async Task Day2()
    {
        Console.WriteLine("====== Day 2 ======");
        IDay day2 = new Day2();
        Console.WriteLine("Day 2 - Exercise 1");
        StreamReader input = await GetInput(day2.Index);
        var day2Ex1Answer = day2.Ex1(input);
        Console.WriteLine(day2Ex1Answer.ToString());
        Console.WriteLine("Day 2 - Exercise 2");
        input = await GetInput(day2.Index);
        var day2Ex2Answer = day2.Ex2(input);
        Console.WriteLine(day2Ex2Answer.ToString());
    }

    public async Task Day3()
    {
        Console.WriteLine("====== Day 3 ======");
        IDay day3 = new Day3();
        Console.WriteLine("Day 3 - Exercise 1");
        StreamReader input = await GetInput(day3.Index);
        var day2Ex1Answer = day3.Ex1(input);
        Console.WriteLine(day2Ex1Answer.ToString());
        // Console.WriteLine("Day 3 - Exercise 2");
        // input = await GetInput(day3.Index);
        // var day2Ex2Answer = day3.Ex2(input);
        // Console.WriteLine(day2Ex2Answer.ToString());
    }
}