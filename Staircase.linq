<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static void staircase(int n) 
{
    for (int i = 0; i < n; i++)
    {
        string line = "";
        for (int j = 0; j < n; j++) 
        {
            if (j < n - (i + 1))
            {
                line += ' ';
            } 
            else if (n - (i + 1) <= j)
            {
                line += '#';
            }
        }
        Console.WriteLine(line);
    }
}