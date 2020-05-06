<Query Kind="Program" />

void Main()
{
	var socks = new int[] {10, 20, 20, 10, 10, 30, 50, 10, 20};
	Console.WriteLine(sockMerchant(socks));
}

// Define other methods and classes here
static int sockMerchant(int[] ar) 
{
    var dicc = new Dictionary<int, int>();
    int pairs = 0;
    foreach(int i in ar) 
    {
        if (dicc.ContainsKey(i))
        {
            dicc[i]++;
            if ((dicc[i] & 1) == 0) pairs++;
        }
        else
        {
            dicc.Add(i, 1);
        }
    }
	dicc.Dump();
    return pairs;
}