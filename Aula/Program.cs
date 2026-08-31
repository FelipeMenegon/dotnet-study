using Aula13;

namespace Aula01;

public class Program
{
    public static void Main()
    {
        // Instancia da classe Cake
        Cake strawberryCake = new Cake();

        // Setar atributos
        strawberryCake.id = 470;
        strawberryCake.name = "Strawberry Cake";
        strawberryCake.description = "A delicious strawberry cake with fresh cream.";
        strawberryCake.Value = 23;
        strawberryCake.isFilling = true;

        // Mostrar console
        Console.WriteLine($"Cake Nmae {strawberryCake.name}");
    }
}