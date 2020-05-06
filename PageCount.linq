<Query Kind="Program" />

void Main()
{
	Console.WriteLine(simplerPageCount(6, 5));
}

// Define other methods and classes here
static int pageCount(int n, int p) 
{
    int half = n / 2;
    if (p > half)
    {
        int diff = ((n & 1) == 0 ? n + 1 : n) - p;
        return diff / 2;
    } 
    else
    {
        int diff = (p + n) - n;
        return (diff) / 2;
    }
}

static int simplerPageCount(int n, int p) 
{
    int half = n / 2;
    int left = p / 2;
    int right = half - left;
    return (left < right) ? left : right;
}