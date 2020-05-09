<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static string catAndMouse(int x, int y, int z) 
{
    int catAmouse = Math.Abs(x - z);
    int catBmouse = Math.Abs(y - z);
    if (catAmouse == catBmouse) return "Mouse C";
    return "Cat " + ((catAmouse > catBmouse) ? "B" : "A");
}