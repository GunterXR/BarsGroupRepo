using System;

public class Program
{
    static void Main(string[] args)
    {
        Reader reader = new Reader();
        reader.OnKeyPressed += Print;
        reader.Run();
    }
    static void Print(Object sender, char a)
    {
        Console.WriteLine("\nСобытие: символ " + a + "\n");
    }
}
public class Reader
{
    public event EventHandler<char> OnKeyPressed;
    public void Run()
    {
        char a;
        do 
        {
            Console.Write("Введите любой символ: ");
            a = Console.ReadKey().KeyChar;
            OnKeyPressed?.Invoke(this, a);
        }
        while (a != 'c' && a != 'с'); //Выход из цикла происходит независимо от раскладки.
    }
}