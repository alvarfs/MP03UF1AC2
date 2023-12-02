using System.ComponentModel.Design;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        // Escribe un programa que introduciendo tres notas de un alumno por consola, calcule la
        // media e indique si está suspendido o aprobado (nota media mayor o igual a 5)
        
        int totalNotas = 3;
        int avg = 0;

        for (int i = 0; i < totalNotas; i++)
        {
            System.Console.Write("nota examen: ");
            int nota = Convert.ToInt32(Console.ReadLine());
            avg += nota;
        }

        avg /= totalNotas;
        Console.WriteLine($"media total: {avg}");

        if (avg < 5)
        {
            System.Console.WriteLine("SUSPENDIDO!!");
        }else
        {
            System.Console.WriteLine("APROBADO!!");
        }

        System.Console.WriteLine("-----");

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

        System.Console.WriteLine("-----");
        
        // Codifica un programa “Calculadora”, con las 4 operacions básicas, sumar restar,
        // multiplicar y dividir siguiendo estos pasos:

        // Pide al usuario que introduzca dos números

        // Pregunta la operación con los siguiente códigos numéricos (1-suma, 2-resta,
        // 3-multiplicación, 4-división)

        // Pregunta si finaliza o añade más números
        
        int num1, num2, op;
        int result = 0;
        bool addMore = true;

        System.Console.Write("Introduce un numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Introduce operador (1-suma, 2-resta, 3-multi, 4-div): ");
        op = Convert.ToInt32(Console.ReadLine());

        result += num1;

        do
        {
            System.Console.Write("Introduce otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    result += num2;
                    break;
                case 2:
                    result -= num2;
                    break;
                case 3:
                    result *= num2;
                    break;
                case 4:
                    result /= num2;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Resultado: {result}");

            System.Console.Write("Añadir mas numeros (SI = S / NO = N): ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "n")
            {
                addMore = false;
            }
        } while (addMore);

        System.Console.WriteLine("-----");

        // Letra del DNI. 

        // La letra del DNI se calcula dividiendo el número de documento entre 23. A partir del
        // resto, se obtiene la letra a partir de los caracteres del siguiente cuadro

        // Codificar un programa que pida números al usuario hasta que encuentre uno
        // compatible con la letra a.
        
        do
        {
            Console.Write("Introduce numero dni: ");
            userNum = Convert.ToInt32(Console.ReadLine());
        } while (userNum % 23 != 3);
        
        System.Console.WriteLine("-----");

        // Imprime en pantalla un triangulo de 15 asteriscos de altura x 15 de base.

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {   
                if (i >= j)
                {
                    System.Console.Write("*");
                }
            }
            System.Console.WriteLine("");
        }

        System.Console.WriteLine("-----");

        // Imprime en pantalla un tablero de ajedrez con B para las blancas y N para las negras de 8X8.

        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= 8; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Console.Write("B");
                }else
                {
                    Console.Write("N");
                }
            }
            Console.WriteLine();
        }
    }
}