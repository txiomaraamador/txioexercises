// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        // Pedimos al usuario que ingrese el radio del circulo por consola
        Console.WriteLine("Ingrese el radio del circulo: "); 
        double radio = double.Parse(Console.ReadLine()); 
        // Llamamos a la funcion CalcularCircunferencia y le pasamos el radio como parametro
        double circunferencia = CalcularCircunferencia(radio); 
        
        Console.WriteLine("La circunferencia del circulo es: " + circunferencia); 
       
    }

    static double CalcularCircunferencia(double radio)
    {
        double pi = Math.PI; 
        double circunferencia = 2 * pi * radio; 
        return circunferencia; 
    }
}

