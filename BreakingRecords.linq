<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static int[] breakingRecords(int[] scores) {
    var exceeding = new int[] { 0, 0 };
    int max = scores[0];
    int min = scores[0];
    foreach (int score in scores)
    {
        if (score > max) 
        {
            max = score;
            exceeding[0]++;
        }

        if (score < min) 
        {
            min = score;
            exceeding[1]++;
        }
    }

    return exceeding;
}