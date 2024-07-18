using FluentAssertions;

namespace Lis.UnitTests;

public class LisGeneratorTest
{
    [Theory]
    [InlineData("6 1 5 9 2", "1 5 9")]
    public void TestCase1(string input, string expectedOutput)
    {
        // action
        var output = LisGenerator.Generate(input);

        // assert
        output.Should().Be(expectedOutput);
    }
}