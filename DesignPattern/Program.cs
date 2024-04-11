
using ConsoleApp1;
using ConsoleApp1.Prototype;

#region Builder
//Student student = null;
//try
//{
//    student = new Student.Builder()
//         .WithName("George")
//         .WithGender("Male")
//         .WithAge(42)
//         .WithMarks(35)
//         .Build();
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.ToString());
//}

//if (student != null)
//{
//    Console.WriteLine(student);
//}
#endregion

#region Prototype

StudentRegistry registry = new StudentRegistry();
fillRegistry(registry);

Student saketh = registry.Get("july22").clone();
saketh.setName("saketh");
saketh.setAge(30);

Student suyash = registry.Get("july22").clone();
suyash.setName("suyash");
suyash.setAge(30);

Student swraj = registry.Get("aug22").clone();
swraj.setName("swraj");
//swraj.setPsp(90);
swraj.setAge(30);

Student sneha = registry.Get("sept22").clone();
sneha.setName("sneha");
sneha.setAge(30);

Console.WriteLine("Debug");

static void fillRegistry(StudentRegistry registry)
{
    Student julyBatch = new Student();
    julyBatch.setBatchName("july22");
    julyBatch.setAverageBatchPsp(90);
    registry.register("july22", julyBatch);

    Student augBatch = new Student();
    augBatch.setBatchName("aug22");
    augBatch.setAverageBatchPsp(98);
    registry.register("aug22", augBatch);

    IntelligentStudent septBatch = new IntelligentStudent();
    septBatch.setBatchName("sept22");
    septBatch.IQ = 100;
    registry.register("sept22", septBatch);

}
#endregion