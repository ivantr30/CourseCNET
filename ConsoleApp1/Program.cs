namespace Test;

internal class Program
{
    static void Main()
    {
        foreach (var i in Directory.EnumerateFiles(@"C:\Users\Ivan\Downloads\Telegram Desktop\SECRET FILE\Новая папка", "*", SearchOption.AllDirectories))
        {
            Console.WriteLine(i);
        }
    }
}
