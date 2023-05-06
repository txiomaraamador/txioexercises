
struct Punto2D {
    public short x;
    public short y;
    public byte r;
    public byte g;
    public byte b;
}
class ClassCord{
    public static void Coordenadas(){
        Punto2D punto1, punto2;

        Console.WriteLine("Ingrese los datos del primer punto:");
        Console.Write("Coordenada x: ");
        punto1.x = Convert.ToInt16(Console.ReadLine());
        Console.Write("Coordenada y: ");
        punto1.y = Convert.ToInt16(Console.ReadLine());
        Console.Write("Valor de r : ");
        punto1.r = Convert.ToByte(Console.ReadLine());
        Console.Write("Valor de g : ");
        punto1.g = Convert.ToByte(Console.ReadLine());
        Console.Write("Valor de b : ");
        punto1.b = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("\nIngrese los datos del segundo punto:");
        Console.Write("Coordenada x: ");
        punto2.x = Convert.ToInt16(Console.ReadLine());
        Console.Write("Coordenada y: ");
        punto2.y = Convert.ToInt16(Console.ReadLine());
        Console.Write("Valor de r : ");
        punto2.r = Convert.ToByte(Console.ReadLine());
        Console.Write("Valor de g : ");
        punto2.g = Convert.ToByte(Console.ReadLine());
        Console.Write("Valor de b : ");
        punto2.b = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("\nContenido del primer punto:");
        Console.WriteLine("Coordenada x: {0}", punto1.x);
        Console.WriteLine("Coordenada y: {0}", punto1.y);
        Console.WriteLine("Valor de r: {0}", punto1.r);
        Console.WriteLine("Valor de g: {0}", punto1.g);
        Console.WriteLine("Valor de b: {0}", punto1.b);

        Console.WriteLine("\nContenido del segundo punto:");
        Console.WriteLine("Coordenada x: {0}", punto2.x);
        Console.WriteLine("Coordenada y: {0}", punto2.y);
        Console.WriteLine("Valor de r: {0}", punto2.r);
        Console.WriteLine("Valor de g: {0}", punto2.g);
        Console.WriteLine("Valor de b: {0}", punto2.b);
    }
}
