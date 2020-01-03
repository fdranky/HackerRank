<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static string timeConversion(string s) 
{
    string format = s.Substring(s.Length - 2, 2);
    s = s.Remove(s.Length - 2, 2);
    
    string hours = s.Substring(0, 2);
    if (format == "PM" && hours != "12") 
    {
        hours = (Int32.Parse(hours) + 12).ToString();
    } 
    else if (format == "AM")
    {
        if (hours == "12")
        {
            hours = "00";
        }
    }
    s = s.Remove(0, 2).Insert(0, hours.ToString());

    return s;
}