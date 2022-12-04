namespace AdventCode2022;

public interface IDay
{
    int Ex1(StreamReader input);
    int Ex2(StreamReader input);

    string Test(string i, string j);
    int Index { get; }
}