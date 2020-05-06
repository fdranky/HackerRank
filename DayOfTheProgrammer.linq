<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
static string dayOfProgrammer(int year) 
{
    if (year == 1918) return "26.09.1918"; 
    bool isJulianLeapYear = 1700 <= year && year <= 1917 && year % 4 == 0;
    bool isGregorianLeapYear = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
    return (isJulianLeapYear || isGregorianLeapYear ? "12.09." : "13.09.") + year.ToString();
}