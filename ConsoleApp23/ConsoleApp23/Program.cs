using System.Xml.Linq;

class Student // CLASS !!!
{
    private string lastName = "Stashko";
    private string Name = "Nikita";
    private string patronymic = "Sehrijovich";
    private int dateOfBirth = 28092010;
    private string homeAddress = "Sadovaja 3";
    private long phoneNumber = 380123456789;
    private int[] credits;
    private int[] coursework;
    private int[] exams;

    public Student(int creditsCount = 3, int courseworkCount = 3, int examsCount = 3)
    {
        credits = new int[creditsCount];
        coursework = new int[courseworkCount];
        exams = new int[examsCount];
    }
    public void SetCredits(int[] credits)
    {
        this.credits = credits;
    }
    public int[] GetCredits()
    {
        return credits;
    }

    public void SetCoursework(int[] coursework)
    {
        this.coursework = coursework;
    }
    public int[] GetCoursework()
    {
        return coursework;
    }

    public void SetExams(int[] exams)
    {
        this.exams = exams;
    }
    public int[] GetExams()
    {
        return exams;
    }

    public void SetName(string Name)
    {
        this.Name = Name;
    }
    public string GetName()
    {
        return Name;
    }

    public void SetLastName(string lastName)
    {
        this.lastName = lastName;
    }
    public string GetLastName()
    {
        return lastName;
    }

    public void SetPatronymic(string patronymic)
    {
        this.patronymic = patronymic;
    }
    public string GetPatronymic()
    {
        return patronymic;
    }

    public void SetDateOfBirth(int dateOfBirth)
    {
        this.dateOfBirth = dateOfBirth;
    }
    public int GetDateOfBirth()
    {
        return dateOfBirth;
    }

    public void SetHomeAddress(string homeAddress)
    {
        this.homeAddress = homeAddress;
    }
    public string GetHomeAddress()
    {
        return homeAddress;
    }

    public void SetPhoneNumber(long phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }
    public long GetPhoneNumber()
    {
        return phoneNumber;
    }
    public static void Print(in Student student)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(student.GetName());
        Console.WriteLine(student.GetLastName());
        Console.WriteLine(student.GetPatronymic());
        Console.WriteLine(student.GetDateOfBirth());
        Console.WriteLine(student.GetHomeAddress());
        Console.WriteLine(student.GetPhoneNumber());

        Console.WriteLine("\nЗаліки:");
        foreach (int mark in student.GetCredits())
            Console.Write(mark + " ");

        Console.WriteLine("\nКурсові:");
        foreach (int mark in student.GetCoursework())
            Console.Write(mark + " ");

        Console.WriteLine("\nЕкзамени:");
        foreach (int mark in student.GetExams())
            Console.Write(mark + " ");



    }

}
class Program
{
    static void Main()
    {
        Student s = new Student();
        s.SetCredits(new int[] { 90, 85, 100 });
        s.SetCoursework(new int[] { 80, 95, 70 });
        s.SetExams(new int[] { 88, 92, 75 });
        Student.Print(in s);
    }
}