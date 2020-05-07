<Query Kind="Program" />

void Main()
{
	Console.WriteLine(countingValleys("DUUDDU"));
}

// Define other methods and classes here
static int countingValleys(string s) 
{
    int count = 0;
	int level = 0;
    for (int i = 0; i < s.Length; i++) 
	{
		if (s[i] == 'D') level--;
		if (s[i] == 'U')
		{
			level++;
			if (level == 0) count++;
		}
	}
	
    return count;
}