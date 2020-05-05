<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int birthday(List<int> s, int d, int m) 
{
    int count = 0;
    for (int i = 0; i <= s.Count - m; i++)
    {
        int sum = 0;
        for (int j = 0; j < m; j++)
        {
            sum += s[i + j];
        }
        if (sum == d) count++;
    }

    return count;
}
