<Query Kind="Program" />

void Main()
{
	List<int> grades = new List<int>{4,73,67,38,33};
	GradingStudents(grades).Dump();
}

public static List<int> gradingStudents(List<int> grades)
{
    for (int i = 0; i < grades.Count; i++)
    {
        if ((grades[i] % 5 - 2) > 0)
        {
            int rounded = ((int)(grades[i] / 5) + 1) * 5;

            if (rounded < 40)
            {
                continue;
            } 

            grades[i] = rounded;
        }
    }

    return grades;
}
// Define other methods and classes here