<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int migratoryBirds(List<int> arr) 
{
    var types = new int[5];
    int minIndex = 0;
    int maxValue = 0;
    for (int i = 0; i < arr.Count; i++)
    {
        int type = arr[i] - 1;
        types[type]++;

        if (maxValue < types[type]) 
        {
            maxValue = types[type];
            minIndex = arr[i];
        }

        if (maxValue == types[type] && minIndex > arr[i]) 
        {
            minIndex = arr[i];
        }
    }

    return minIndex;
}