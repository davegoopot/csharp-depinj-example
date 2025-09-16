namespace DepInj.Example.Core;

public class StringReverse : ITextTransformer
{
    public string? transform(string? input)
    {
        if (input == null)
            return null;
        
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}