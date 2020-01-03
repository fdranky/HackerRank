<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static long arrayManipulation(int n, int[][] queries) {
    long[] arr = new long[n + 1];
    long max = 0;
    for (int i = 0; i < queries.Length; i++) 
    {
        int start = queries[i][0];
        int end = queries[i][1];
        int val = queries[i][2];

        arr[start] += val;
        if (end < n) arr[end + 1] -= val; 
    }

    long temp = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        temp += arr[j];
        if (temp > max) max = temp;
    }

    return max;
}