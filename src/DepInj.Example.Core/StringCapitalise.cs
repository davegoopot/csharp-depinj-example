namespace DepInj.Example.Core;

public class StringCapitalise : ITextTransformer
{
    public string? transform(string? input)
    {
        if (input == null)
            return null;
        
        return input.ToUpper();
    }
}