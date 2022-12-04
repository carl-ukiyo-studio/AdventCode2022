namespace AdventCode2022;

public class Day4: Day
{
    
    // convert assignment to list (2-4) -> 2,3,4
    // compare two lists and find if one is a subset of the other
    // ^^ can make to HashSets and use isSubset function
    // ^^ need to make sure smaller set is used for the check

    public Day4()
    {
        Index = 4;
    }
    public override int Ex1(StreamReader input)
    {
        string line;
        int totalSubsets = 0;
        // Read and display lines from the file until the end of
        // the file is reached.
        while (input.Peek() >= 0)
        {
            line = input.ReadLine();
            var pair = line.Split(",");
            var set1 = ConvertToList(pair[0]);
            var set2 = ConvertToList(pair[1]);
            var isSubset = CheckIfSubset(set1, set2);
            if (isSubset)
            {
                totalSubsets++;
            }
        }

        return totalSubsets;
    }
    
    public override int Ex2(StreamReader input)
    {
        string line;
        int totalOverlap = 0;
        // Read and display lines from the file until the end of
        // the file is reached.
        while (input.Peek() >= 0)
        {
            line = input.ReadLine();
            var pair = line.Split(",");
            var set1 = ConvertToList(pair[0]);
            var set2 = ConvertToList(pair[1]);
            var overlap = CheckIfOverlap(set1, set2);
            if (overlap)
            {
                totalOverlap++;
            }
        }

        return totalOverlap;
    }

    private bool CheckIfSubset(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.Count >= set2.Count ? set2.IsSubsetOf(set1) : set1.IsSubsetOf(set2);
    }

    public override int Index { get; }

    private HashSet<int> ConvertToList(string assignment)
    {
        var range = assignment.Split("-");
        var start = int.Parse(range[0]);
        var end = int.Parse(range[1]);
        var count = (end - start) + 1;
        return start == end ? new HashSet<int>(){start} : Enumerable.Range(start, count).ToHashSet();
    }

    private bool CheckIfOverlap(HashSet<int> set1, HashSet<int> set2)
    {
        var intersect = set1.Intersect(set2).ToList();
        return intersect.Count > 0;
    }
}