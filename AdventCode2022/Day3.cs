namespace AdventCode2022;

public class Day3 : Day
{
    // make a dictionary of letter to value
    // make a function that can find the duplicate in two lists
    // make a function that can split a string in the middle and place each part in a list

    private Dictionary<string, int> itemValues = new();

    public Day3()
    {
        Index = 3;
        PrepareData();
    }

    public override int Ex1(StreamReader input)
    {
        string line;
        int totalValue = 0;
        // Read and display lines from the file until the end of
        // the file is reached.
        while (input.Peek() >= 0)
        {
            line = input.ReadLine();
            var compartments = SplitInTwo(line);
            var duplicateType = FindDuplicateType(compartments[0].ToCharArray(), compartments[1].ToCharArray());
            var itemValue = itemValues.GetValueOrDefault(duplicateType.ToString());
            totalValue += itemValue;
        }

        return totalValue;
    }

    public override int Ex2(StreamReader input)
    {
        string line;
        int totalValue = 0;
        int count = 0;
        List<string> group = new();
        // Read and display lines from the file until the end of
        // the file is reached.
        while (input.Peek() >= 0)
        {
            line = input.ReadLine();
            count++;
            if (count < 3)
            {
                group.Add(line);
            }
            else
            {
                group.Add(line);
                count = 0;
                var list1 = group[0].ToCharArray();
                var list2 = group[1].ToCharArray();
                var list3 = group[2].ToCharArray();
                var groupType = FindCommonTypeInGroup(list1, list2, list3);
                var itemValue = itemValues.GetValueOrDefault(groupType.ToString());
                totalValue += itemValue;
                group.Clear();
            }
        }

        return totalValue;
    }

    public override int Index { get; }

    private List<string> SplitInTwo(string items)
    {
        var length = items.Length;
        var midIndex = length / 2;
        var firstHalf = items.Substring(0, midIndex);
        var secondHalf = items.Substring(midIndex);

        return new List<string>()
        {
            firstHalf,
            secondHalf
        };
    }

    private char FindDuplicateType(char[] list1, char[] list2)
    {
        var duplicates = list1.Intersect(list2).ToList();

        return duplicates.FirstOrDefault();
    }

    private char FindCommonTypeInGroup(char[] list1, char[] list2, char[] list3)
    {
        var firstIntersect = list1.Intersect(list2);
        var duplicatesInGroup = firstIntersect.Intersect(list3);
        return duplicatesInGroup.FirstOrDefault();
    }

    private void PrepareData()
    {
        itemValues.Add("a", 1);
        itemValues.Add("b", 2);
        itemValues.Add("c", 3);
        itemValues.Add("d", 4);
        itemValues.Add("e", 5);
        itemValues.Add("f", 6);
        itemValues.Add("g", 7);
        itemValues.Add("h", 8);
        itemValues.Add("i", 9);
        itemValues.Add("j", 10);
        itemValues.Add("k", 11);
        itemValues.Add("l", 12);
        itemValues.Add("m", 13);
        itemValues.Add("n", 14);
        itemValues.Add("o", 15);
        itemValues.Add("p", 16);
        itemValues.Add("q", 17);
        itemValues.Add("r", 18);
        itemValues.Add("s", 19);
        itemValues.Add("t", 20);
        itemValues.Add("u", 21);
        itemValues.Add("v", 22);
        itemValues.Add("w", 23);
        itemValues.Add("x", 24);
        itemValues.Add("y", 25);
        itemValues.Add("z", 26);

        itemValues.Add("A", 27);
        itemValues.Add("B", 28);
        itemValues.Add("C", 29);
        itemValues.Add("D", 30);
        itemValues.Add("E", 31);
        itemValues.Add("F", 32);
        itemValues.Add("G", 33);
        itemValues.Add("H", 34);
        itemValues.Add("I", 35);
        itemValues.Add("J", 36);
        itemValues.Add("K", 37);
        itemValues.Add("L", 38);
        itemValues.Add("M", 39);
        itemValues.Add("N", 40);
        itemValues.Add("O", 41);
        itemValues.Add("P", 42);
        itemValues.Add("Q", 43);
        itemValues.Add("R", 44);
        itemValues.Add("S", 45);
        itemValues.Add("T", 46);
        itemValues.Add("U", 47);
        itemValues.Add("V", 48);
        itemValues.Add("W", 49);
        itemValues.Add("X", 50);
        itemValues.Add("Y", 51);
        itemValues.Add("Z", 52);
    }
}