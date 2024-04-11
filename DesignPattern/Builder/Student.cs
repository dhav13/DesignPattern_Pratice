namespace ConsoleApp1.Builder;
public class Student : IStudent
{
    private string name;
    private int age;
    private string gender;
    private double marks;

    public string Name => name;
    public int Age => age;
    public string Gender => gender;
    public double Marks { get { return marks; } }


    public class Builder
    {
        private readonly Student student;

        public Builder()
        {
            student = new Student();
        }

        public Builder WithName(string name)
        {
            student.name = name;
            return this;
        }

        public Builder WithAge(int age)
        {
            student.age = age;
            return this;
        }


        public Builder WithGender(string gender)
        {
            student.gender = gender;
            return this;
        }

        public Builder WithMarks(double marks)
        {
            if (marks < 36)
            {
                throw new ArgumentException("Fail hogaya, kya Object banane ka!");
            }
            student.marks = marks;
            return this;
        }

        public Student Build()
        {
            return student;
        }
    }
}
