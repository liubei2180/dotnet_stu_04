using Xunit;

using applib;
using Shouldly;
namespace tests;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // given
        var c = new Class1();

        // when
        var result = c.add(1, 2);

        // then
        // Assert.Equal(3, result); // 第一个参数是期望值，第二个是实际结果

        result.ShouldBe(3); // 导入shouldly包，代码更优雅

    }

    // 过程一样，多个测试数据
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 2, 5)]
    [InlineData(100, 200, 300)]

    // [fact]

    public void Test2(int a, int b, int e)
    {
        // given
        var c = new Class1();

        // when
        var result = c.add(a, b);

        // then
        // Assert.Equal(3, result); // 第一个参数是期望值，第二个是实际结果

        result.ShouldBe(e); // 导入shouldly包，代码更优雅

    }
}