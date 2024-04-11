

namespace ConsoleApp1.Prototype;

public class Student : Prototype<Student>
{
    private string name { get; set; }
    private int age;
    private double psp;
    double averageBatchPsp;
    string batchName;

    public Student()
    { }

    public Student(Student student)
    {
        batchName = student.batchName;
        averageBatchPsp = student.averageBatchPsp;
        name = student.name;
        age = student.age;
        psp = student.psp;
    }

    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public int getAge()
    {
        return age;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public double getPsp()
    {
        return psp;
    }

    public double getAverageBatchPsp()
    {
        return averageBatchPsp;
    }

    public void setAverageBatchPsp(double averageBatchPsp)
    {
        this.averageBatchPsp = averageBatchPsp;
    }

    public string getBatchName()
    {
        return batchName;
    }

    public void setBatchName(string batchName)
    {
        this.batchName = batchName;
    }
    public Student clone()
    {
        return new Student(this);
    }
}