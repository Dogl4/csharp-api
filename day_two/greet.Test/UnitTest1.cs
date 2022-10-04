using Xunit;
using FluentAssertions;

namespace greet.Test;
public class UnitTest1
{
  [Theory(DisplayName = "Deve retornar \"Hello, World!\"")]
  [InlineData("Hello, World!")]
  public void Test1(string expected)
  {
    string result = Class1.Greet();

    result.Should().Be(expected);
  }
}