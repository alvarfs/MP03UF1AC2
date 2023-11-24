using System.ComponentModel.Design;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        // Escribe un programa que introduciendo tres notas de un alumno por consola, calcule la
        // media e indique si está suspendido o aprobado (nota media mayor o igual a 5)

        int nota1, nota2, nota3;

        System.Console.Write("primera nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("tercera nota: ");
        nota3 = Convert.ToInt32(Console.ReadLine());
        
        int avg = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"total media examenes: {avg}");
        

        if (avg < 5)
        {
            System.Console.WriteLine("SUSPENDIDO!!");
        }else
        {
            System.Console.WriteLine("APROBADO!!");
        }

        // Codifica un programa que pida números al usuario y finalice la ejecución con el número 0.
        // Cuando acabe, deberá mostrar por consola cuantos fueron pares y cuantos impares.
        
        int userNum;
        int pares = 0;
        int impares = 0;

        System.Console.WriteLine("para finalizar envia '0'");
        do
        {
            System.Console.Write("escribe un numero: ");
            userNum = Convert.ToInt32(Console.ReadLine());
            
            if (userNum % 2 == 0)
            {
                pares += 1;
            }else
            {
                impares += 1;
            }
        } while (userNum != 0);

        Console.WriteLine($"total impares: {impares}");
        Console.WriteLine($"total pares: {pares}");
        
        // Imprime en pantalla un tablero de ajedrez con B para las blancas y N para las negras de 8X8

        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                Console.Write("B");
                Console.Write("N");
            }
            Console.WriteLine();
        }
    }
}