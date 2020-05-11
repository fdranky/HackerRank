<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public static int pickingNumbers(List<int> a)
{
    a.Sort();
    int max = 0;
    int pivot = a[0];
    int count = 1;
    for (int i = 1; i < a.Count; i++) 
    {
        if (Math.Abs(pivot - a[i]) > 1) 
        {
            pivot = a[i];
            count = 1;
        } 
        else 
        {
            count++;
            if (count > max) 
            {
                max = count;
            }
        }
    }

    return max;
}