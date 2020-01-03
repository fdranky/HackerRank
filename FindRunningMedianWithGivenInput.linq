<Query Kind="Program" />

void Main()
{
	int[] inputs = new int[]{12,4,5,3,8,7};
	List<int> medianList = new List<int>{};
	for (int i = 0; i < inputs.Length; i++)
	{
		medianList.Add(inputs[i]);
		medianList.Sort();
		Console.WriteLine(FindRunningMedian(medianList));
	}
}

double FindRunningMedian(List<int> inputs)
{
	if(inputs.Count == 1) return inputs[0];
	int half = inputs.Count / 2;
	return (inputs.Count & 1) == 0 ? (double)(inputs[half] + inputs[half - 1]) / 2 : inputs[half];
}
// Define other methods and classes here
