// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

        // Pedimos al usuario que ingrese una palabra por consola
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        // Creamos una lista de cadenas con la palabra ingresada como argumento
        List<string> listaCadenas = new List<string>() { palabra };

        // Llamamos a la función que cuenta las cadenas que contienen la letra x
        int contador = ContarCadenasConLetraX(listaCadenas);

        Console.WriteLine($"El número de cadenas que contienen la letra 'x' es: {contador}");

        static int ContarCadenasConLetraX(List<string> listaCadenas)
        {
          
            int contador = 0;
            // Iteramos por cada cadena en la lista
            foreach (string cadena in listaCadenas)
            {
                // Verificamos si la cadena contiene la letra 'x'
                if (cadena.Contains('x'))
                {
                    // Si contiene la letra 'x', incrementamos el contador
                    contador++;
                }
            }
            return contador;
        }



