// See https://aka.ms/new-console-template for more information

var coches = ClassCoche.ColeccionDeCoches();

foreach (var coche in coches)
{
    Console.WriteLine($"Marca: {coche.Marca}, Modelo: {coche.Modelo}, Año: {coche.Anio}, Tipo: {coche.Tipo}, Kilómetros: {coche.Kilometros}");
}