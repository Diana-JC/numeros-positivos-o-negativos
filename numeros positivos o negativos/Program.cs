// See https://aka.ms/new-console-template for more information

internal class Program
    {
        static void Main(string[] args)
        {
            //Determinar si un numero es negativo y positivo 

            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0) 
            {
                Console.WriteLine("el numero " + numero +" es neutro");
            }
            else if(numero > 0)
            {
                Console.WriteLine("el numero " + numero + " es positivo ");
            }
            else {
                Console.WriteLine("el numero " + numero + " es negativo ");
            }
            Console.ReadLine();
        }
    }