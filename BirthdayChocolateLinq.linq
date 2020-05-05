<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int birthdayLinq(List<int> s, int d, int m) 
{
    int count = 0;
    for (int i = 0; i <= s.Count - m; i++)
    {
        if (s.Skip(i).Take(m).Sum() == d) count++;
    }

    return count;
}