using Xunit;

using applib;
using Shouldly;
using System;
namespace tests;


public class UnitTest1
{
    // [Fact]
    // public void Test1()
    // {
    //     // given
    //     var c = new Class1();

    //     // when
    //     var result = c.Add(1, 2);

    //     // then
    //     // Assert.Equal(3, result); // 第一个参数是期望值，第二个是实际结果

    //     result.ShouldBe(3); // 导入shouldly包，代码更优雅

    // }

    // // 过程一样，多个测试数据
    // [Theory]
    // [InlineData(1, 2, 3)]
    // [InlineData(3, 2, 5)]
    // [InlineData(6, 7, 13)]
    // [InlineData(100, 200, 300)]

    // // [fact]
    // // 使用 dotnet watch test保存后会自动进行单元测试
    // // 单元测试并行 -parallel（一般不需要）

    // public void Test2(int a, int b, int e)
    // {
    //     // given
    //     var c = new Class1();

    //     // when
    //     var result = c.Add(a, b);

    //     // then
    //     // Assert.Equal(3, result); // 第一个参数是期望值，第二个是实际结果

    //     result.ShouldBe(e); // 导入shouldly包，代码更优雅

    // }


    [Theory]
    [InlineData(1, 2,"Result:3")]
    [InlineData(2, 2,"Result:4")]
    [InlineData(10, 20,"Result:30")]
    // 单元测试的原则：a测试不能影响b测试

    public void Test3(int a, int b, string c)
    {
        // given
        var c1 = new Class1Mock1Plus2();
        var c2 = new Class2(c1);

        // when
        var result = c2.XX(a, b);

        // then
        result.ShouldBe(c);

    }

    public class Class1Mock1Plus2 : IMath
    {
        public int Add(int a, int b)
        {
            if (a == 1 && b == 2)
                return 3;

            if (a == 2 && b == 2)
                return 4;

            if (a == 10 && b == 20)
                return 30;

            throw new Exception("unexpected");
        }

    }
}