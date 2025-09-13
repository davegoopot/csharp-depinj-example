using DepInj.Example.Core;

namespace DepInj.Example.Tests;

public class StringReverseTests
{
    [Fact]
    public void transform_reverses_string_correctly()
    {
        // Arrange
        var stringReverse = new StringReverse();
        var input = "hello";
        var expectedOutput = "olleh";

        // Act
        var result = stringReverse.transform(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }
}