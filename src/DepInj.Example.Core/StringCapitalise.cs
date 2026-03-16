namespace DepInj.Example.Core;

public class StringCapitalise : ITextTransformer
{
    public string? transform(string? input)
    {
        return input?.ToUpper();
    }
}
