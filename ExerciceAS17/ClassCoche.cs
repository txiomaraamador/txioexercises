
public class ClassCoche
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }
    public string Tipo { get; set; }
    public int Kilometros { get; set; }

    public static List<ClassCoche> ColeccionDeCoches()
    {
        var coches = new List<ClassCoche>();

        Console.WriteLine("Ingrese la cantidad de coches que desea ingresar en la colección:");
        int cantidadCoches = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < cantidadCoches; i++)
        {
            Console.WriteLine($"Ingrese los datos del coche {i + 1}:");
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Año: ");
            int anio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tipo (estándar o manual): ");
            string tipo = Console.ReadLine();
            Console.Write("Kilómetros: ");
            int kilometros = Convert.ToInt32(Console.ReadLine());

            coches.Add(new ClassCoche() { Marca = marca, Modelo = modelo, Anio = anio, Tipo = tipo, Kilometros = kilometros });
        }
        return coches;
    }
}



   


    




