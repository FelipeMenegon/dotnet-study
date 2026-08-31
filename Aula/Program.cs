namespace Aula01;

public class Program
{
    public static void Main()
    {
        int number = 10; // Declaração e inicialização da variável 'number' com o valor 10

        number = 20; // Atribuição de um novo valor à variável 'number'

        Console.WriteLine("O valor da variável 'number' é: " + number);

        const int constantNumber = 1000;
        Console.WriteLine("O valor da variável 'constantNumber' é: " + constantNumber);

        var variable = "Hello, World!"; // Declaração de uma variável usando 'var' - Tipo String
        variable = 10; // Atribuição com erro de tipo - Não é permitido atribuir um valor inteiro a uma variável que foi inferida como string
    
        dynamic variables = "Hello, World!"; // Declaração de uma variável usando 'dynamic' - Tipo String   

        dynamic variables = 10; // Atribuição de um valor inteiro à variável 'variables' - Permitido com 'dynamic'
    }
    
}