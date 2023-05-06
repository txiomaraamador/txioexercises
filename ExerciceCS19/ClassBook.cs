
class ClassBook 
{
    public string titulo;
    public string autor;

    public static void Coleccionlibros() 
    {
        ClassBook[] libros = new ClassBook[2];

        Console.WriteLine("Inserta la información de dos libros:");

        for (int i = 0; i < libros.Length; i++) {
            Console.WriteLine("\nInformación del libro {0}:", i+1);

            Console.Write("Ingresa el nombre del libro: ");
            libros[i].titulo = Console.ReadLine();

            Console.Write("Ingresa el autor: ");
            libros[i].autor = Console.ReadLine();
        }
        Console.WriteLine("\nLibros:");
        for (int i = 0; i < libros.Length; i++) {
            Console.WriteLine("{0}: Título = {1}, Autor = {2}", i+1, libros[i].titulo, libros[i].autor);
        }
    }
}

