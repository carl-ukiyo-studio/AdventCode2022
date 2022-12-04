using AdventCode2022;
using static AdventCode2022.InputHelper;

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

Console.WriteLine("====== Day 2 ======");
IDay day2 = new Day2();
Console.WriteLine("Day 2 - Exercise 1");
input = await GetInput(day2.Index);
var day2Ex1Answer = day2.Ex1(input);
Console.WriteLine(day2Ex1Answer.ToString());
Console.WriteLine("Day 2 - Exercise 2");
input = await GetInput(day2.Index);
var day2Ex2Answer = day2.Ex2(input);
Console.WriteLine(day2Ex2Answer.ToString());