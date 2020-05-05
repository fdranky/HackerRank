<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int divisibleSumPairs(int n, int k, int[] ar) 
{
    var arr = new int[k];
    for (int i = 0; i < n; i++)
    {
        arr[ar[i] % k]++;
    }

    int count = 0;
    count += (arr[0] * (arr[0] - 1)) / 2;
    for (int j = 1; j <= k / 2 && j != k - j; j++)
    {
        count += arr[j] * arr[k - j];
    }

    if ((k & 1) == 0)
    {
        count += (arr[k/2] * (arr[k/2] - 1)) / 2;
    }

    return count;
}