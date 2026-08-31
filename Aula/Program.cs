namespace Aula01;

public class Program
{
    public static void Main()
    {
        List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Cherry",
            "Date",
            "Elderberry"
        };

        Console.WriteLine(fruits[0]); // Output: Apple
        fruits.Add("Fig");
        Console.WriteLine(fruits[5]); // Output: Fig
        fruits.Remove(fruits[1]); // Removes "Banana"
    }
}