namespace Aula01;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Digite seu número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = number % 2;

        if (result == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}