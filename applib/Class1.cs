namespace applib;
// 需要一个月才能实现
// public class Class1: IMath


// {
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }

// }

public interface IMath 
{
    int Add(int a, int b);

}

public class Class2
{
    private readonly IMath _math;
    public Class2(IMath math) {
        _math = math;
    }

    public string XX(int a, int b)
    {
        return "Result:" + _math.Add(a, b);
    }

     public HHH YY()
    {
        // 很复杂的逻辑
        return new HHH { 
            Name = "mz",
            Id = 12345,
            IsOk = false,
        };
    }
}

public class HHH
{
    public string Name { get; set; }

    public int Id { get; set; }

    public bool IsOk { get; set; }
}
