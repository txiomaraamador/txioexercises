// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una cadena: "); 
        string cadena = Console.ReadLine();

        int espacios = ContarEspacios(cadena); 
        Console.WriteLine("La cadena ingresada contiene " + espacios + " espacios."); 
        
    }
    static int ContarEspacios(string cadena)
    {
        int contador = 0; 
        foreach (char c in cadena) 
        {
            if (c == ' ') 
            {
                contador++;
            }
        }
        return contador; 
    }
}

