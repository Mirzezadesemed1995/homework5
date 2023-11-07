internal class Program
{
    private static void Main(string[] args)
    {
        Student st = new Student();
        st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine(string.Join(", ", st.Grades)); // Вывод: 2, 4, 6, 8

    }
}

public class Student
{
    private int[] grades;

    public int[] Grades
    {
        get { return grades; }
        set { grades = FilterEvenGrades(value); }
    }

    public Student()
    {
        grades = new int[0];
    }

    public Student(int[] initialGrades)
    {
        grades = FilterEvenGrades(initialGrades);
    }

    private int[] FilterEvenGrades(int[] grades)
    {
        return grades.Where(grade => grade % 2 == 0).ToArray();
    }
}
