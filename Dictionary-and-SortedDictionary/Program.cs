namespace Dictionary_and_SortedDictionary;

public class Program
{
    static void Main(string[] args)
    {
        // cookie
        Dictionary<string, string> cookies = new();

        cookies["user"] = "olivio";
        cookies["email"] = "olivio@gmail.com";
        cookies["phone"] = "123445677345";
        cookies["phone"] = "345655373565";

        Console.WriteLine(cookies["phone"]);
        Console.WriteLine(cookies["email"]);

        cookies.Remove("phone");

        foreach (KeyValuePair<string, string> item in cookies)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
