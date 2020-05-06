<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static void bonAppetit(List<int> bill, int k, int b) 
{
    int sum = bill.Sum();
    int splitAmount = (sum - bill[k]) / 2;
    Console.WriteLine(splitAmount == b ? "Bon Appetit" : $"{Math.Abs(splitAmount - b)}");    
}