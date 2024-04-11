

namespace ConsoleApp1.Prototype;
public class IntelligentStudent : Student
{
    public int IQ;

    public IntelligentStudent()
    {
    }

    IntelligentStudent(IntelligentStudent student) : base(student)
    {
        this.IQ = student.IQ;
    }

    //Override
    public IntelligentStudent clone()
    {
        return new IntelligentStudent(this);
    }
}

