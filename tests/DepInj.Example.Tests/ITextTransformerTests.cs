using DepInj.Example.Core;

namespace DepInj.Example.Tests;

public class ITextTransformerTests
{
    [Fact]
    public void string_reverse_implements_itexttransformer_interface()
    {
        // Arrange
        ITextTransformer transformer = new StringReverse();
        var input = "hello";
        var expectedOutput = "olleh";

        // Act
        var result = transformer.transform(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }
}