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

static int getMoneySpentFaster(int[] ks, int[] ds, int b) 
{
    var keyboards = ks.ToList();
    var drives = ds.ToList();
    keyboards.Sort();
    drives.Sort();

    var bigger = keyboards.Last() >= drives.Last() ? keyboards : drives;
    var smaller = keyboards.Last() >= drives.Last() ? drives : keyboards;
    int max = -1;
    for (int i = bigger.Count - 1; i >= 0; i--) 
    {
        for (int j = 0; j < smaller.Count; j++)
        {
            int sum = bigger[i] + smaller[j];
            if (sum > b) break;
            if (sum <= b && sum > max) max = sum;
        }
    }

    return max;
}