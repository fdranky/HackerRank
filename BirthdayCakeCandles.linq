<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int birthdayCakeCandles(int[] ar) 
{
    var dict = new Dictionary<int, int>();
    int max = 0;
    for (int i = 0; i < ar.Length; i++) 
    {
        if (max < ar[i]) max = ar[i];
        if (!dict.ContainsKey(ar[i]))
        {
            dict.Add(ar[i], 1);
        } 
        else 
        {
            dict[ar[i]]++;
        }
    }

    return dict[max];
}
