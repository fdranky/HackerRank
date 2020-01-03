<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int[] matchingStrings(string[] strings, string[] queries) {
    var dict = new Dictionary<string, int>();
    for (int i = 0; i < queries.Length; i++) 
    {
        if (!dict.ContainsKey(queries[i]))
        {
            dict.Add(queries[i], 0);
        }
    }

    for (int j = 0; j < strings.Length; j++)
    {
        if (dict.ContainsKey(strings[j]))
        {
            dict[strings[j]]++;
        }
    }

    int[] matches = new int[queries.Length];
    for (int k = 0; k < queries.Length; k++)
    {
        if (dict.ContainsKey(queries[k]))
        {
            matches[k] = dict[queries[k]];
        }
    }

    return matches;
}