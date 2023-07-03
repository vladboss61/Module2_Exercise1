
namespace MyDLL;

internal class Program
{
    public static void Main(string[] args)
    {
        string text = "My text to file.";

        File.Create("log.txt");

        File.AppendAllText("log.txt", text);
        File.AppendAllText("log.txt", text);

        Console.WriteLine("Hello, World!");
    }
}
