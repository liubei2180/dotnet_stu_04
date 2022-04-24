using Xunit;

using applib;
using Shouldly;
using System;
using Moq;
namespace tests;


public class UnitTest1
{
    [Fact]
    public void Test3()
    {

        // given 
        var mock = new Mock<IMath>();
        mock.Setup(x => x.Add(1, 2)).Returns(3);

        var c2 = new Class2(mock.Object);

        // when
        var result = c2.XX(1, 2);

        // then
        result.ShouldBe("Result:3");

        // 验证是否调用了一次
        mock.Verify(x => x.Add(1, 2), Times.Once);
    }

    [Fact]
    public void Test4()
    {

        // given 
        var mock = new Mock<IMath>();
        mock.Setup(x => x.Add(3, 5)).Returns(8);

        var c2 = new Class2(mock.Object);

        // when
        var result = c2.XX(3, 5);

        // then
        result.ShouldBe("Result:8");

        // 验证是否调用了一次（两个单元测试之间互不影响）
        mock.Verify(x => x.Add(3, 5), Times.Once);
    }
}