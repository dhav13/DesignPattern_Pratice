

using ConsoleApp1.Builder;

namespace ConsoleApp1.Prototype;

public class StudentRegistry
{
    Dictionary<string, Student> map = new Dictionary<string, Student>();

    public Student Get(string key)
    {
        return map.GetValueOrDefault(key);
    }

    public void register(string key, Student st)
    {
        map.Add(key, st);
    }
}
