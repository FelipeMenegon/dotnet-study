namespace Aula01;

public class Program
{
    public static void Main()
    {
        string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

        Console.WriteLine(fruits[0]);
        Console.WriteLine("----------------------------");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}