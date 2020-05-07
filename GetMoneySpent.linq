<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int getMoneySpent(int[] keyboards, int[] drives, int b) 
{
    int max = -1;
    for (int i = 0; i < keyboards.Length; i++) 
    {
        for (int j = 0; j < drives.Length; j++)
        {
            int sum = keyboards[i] + drives[j];
            if (sum > max && sum <= b) 
            {
                max = sum;
            }
        }
    }

    return max;
}