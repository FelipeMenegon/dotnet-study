namespace Aula01;

public class Program
{
    public static void Main()
    {
        int number = 1;

        switch (number)
        {
            case 1:
                Console.WriteLine("Number is 1");
                break;
            case 2:
                Console.WriteLine("Number is 2");
                break;
            default: // Caso não seja 1 ou 2 - Tipo else
                Console.WriteLine("Number is not 1 or 2");
                break;
        }
    }
}