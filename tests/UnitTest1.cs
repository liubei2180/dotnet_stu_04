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
        mock.Verify(x=> x.Add(1,2), Times.Once);
    }
}