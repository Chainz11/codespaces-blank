class Student
{
    private string name;
    private int age;
    private double grade;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { 
            if (value < 18 ) {
                Console.WriteLine("newalidna wyzrast");
            } else {
                age = value; 
            }
        }
    }
    public double Grade
    {
        get { return grade; }
        set { 
            if ((value >= 2) && (value <= 6))
            {
                grade = value;
            }
            else 
            {
                Console.WriteLine("Невалидна оценка");
            }
        }
    }
    public void PrintDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Grade: " + grade);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "John";
        student.Age = 20;
        student.Grade = 3.7;
        student.PrintDetails();

        student.Age = 19;
        
        Console.WriteLine(student.Age);    

        student.Grade = 2;
        Console.WriteLine(student.Grade);
        student.age = 38;
    }
}
