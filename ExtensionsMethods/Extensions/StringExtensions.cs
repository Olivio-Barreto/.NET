namespace ExtensionsMethods.Extensions;

public static class StringExtensions
{
    public static string Cut(this string obj, int number)
    {
        if (number > 10) return "nao pode ser maior que 10";

        char[] letras = new char[number];

        for (int i = 0; i < number; i++)
        {
            letras[i] = obj[i];
        }

        return new string(letras);
    }
}
