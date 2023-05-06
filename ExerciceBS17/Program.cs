// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var estudiantes = new Dictionary<string, string>();

// Agregar algunos estudiantes a la colección
estudiantes.Add("1234", "Xiomara Amador");
estudiantes.Add("5678", "Yulissa Gonzlez");
estudiantes.Add("9012", "Evelin Gutierrez");

Console.WriteLine("Ingrese el numero de un estudiante para buscar su número de identificación:");
string idEstudiante = Console.ReadLine();

if (estudiantes.ContainsKey(idEstudiante))
{
    string nombreEstudiante = estudiantes[idEstudiante];
        Console.WriteLine($"El nombre del estudiante con el numero de identificacion {idEstudiante} es: {nombreEstudiante}");
    }
    else
    {
        Console.WriteLine($"No se encontró ningún estudiante con el numero {idEstudiante} en la colección.");
    }
    

