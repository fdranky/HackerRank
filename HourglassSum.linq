<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int hourglassSum(int[][] arr) 
{
    int max = -63;
    int x = arr.Length - 1;
    int y = arr[0].Length - 1;
    for (int i = 1; i < x; i++)
    {
        for (int j = 1; j < y; j++)
        {
            int upRow = arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1];
            int lowRow = arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];

            int sum = upRow + arr[i][j] + lowRow;
            if (sum > max) max = sum;
        }
    }    
    return max;
}