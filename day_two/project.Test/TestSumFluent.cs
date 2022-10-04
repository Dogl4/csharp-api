using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace project.Test
{
  public class TestSumFluent
  {
    var result;

    [Fact]
    public void Test1()
    {
      result = Sum(77, 33);
      result.Should().Be(110);
    }

    [Theory(DisplayName = "Deve somar corretamente as entradas.")]
    [InlineData(3, 3, 6)]
    [InlineData(-10, 3, -7)]
    [InlineData(77, 33, 110)]
    public void Test2(int entry1, int entry2, int expected)
    {
      result = Sum(entry1, entry2);
      result.Should().Be(expected);
    }
  }
}