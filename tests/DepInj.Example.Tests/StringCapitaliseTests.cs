using DepInj.Example.Core;

namespace DepInj.Example.Tests;

public class StringCapitaliseTests
{
    [Fact]
    public void transform_capitalises_string_correctly()
    {
        // Arrange
        var stringCapitalise = new StringCapitalise();
        var input = "hello world";
        var expectedOutput = "HELLO WORLD";

        // Act
        var result = stringCapitalise.transform(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void transform_handles_null_input_correctly()
    {
        // Arrange
        var stringCapitalise = new StringCapitalise();
        string? input = null;
        string? expectedOutput = null;

        // Act
        var result = stringCapitalise.transform(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }
}