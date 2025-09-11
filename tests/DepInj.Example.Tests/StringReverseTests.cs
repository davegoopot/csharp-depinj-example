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

    [Fact]
    public void transform_handles_empty_string()
    {
        // Arrange
        var stringReverse = new StringReverse();
        var input = "";
        var expectedOutput = "";

        // Act
        var result = stringReverse.transform(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void transform_handles_single_character()
    {
        // Arrange
        var stringReverse = new StringReverse();
        var input = "a";
        var expectedOutput = "a";

        // Act
        var result = stringReverse.transform(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }
}