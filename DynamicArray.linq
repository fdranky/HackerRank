<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public static List<int> dynamicArray(int n, List<List<int>> queries)
{
    int lastAnswer = 0;
    var sequences = new List<int>[n];
    List<int> results = new List<int>();
    for (int i = 0; i < queries.Count; i++) 
    {
        int x = queries[i][1];
        int y = queries[i][2];
        if (sequences[(x ^ lastAnswer) % n] == null) 
        {
            sequences[(x ^ lastAnswer) % n] = new List<int>();
        }
        var sequence = sequences[(x ^ lastAnswer) % n];

        if (queries[i][0] == 1)
        {
            sequence.Add(y);
        } 
        else
        {
            lastAnswer = sequence[y % sequence.Count];
            results.Add(lastAnswer);
        }
    }
    return results;
}