
struct Punto2D {
    public short x;
    public short y;
    public byte r;
    public byte g;
    public byte b;
}

class ClassCoordenadas{
    public static void Coordenadas(){
        Punto2D[] puntos = new Punto2D[10];

        for (int i = 0; i < puntos.Length; i++) {
            Console.WriteLine("Ingrese los datos del punto {0}:", i + 1);
            Console.Write("Coordenada x: ");
            puntos[i].x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Coordenada y: ");
            puntos[i].y = Convert.ToInt16(Console.ReadLine());
            Console.Write("Valor de r : ");
            puntos[i].r = Convert.ToByte(Console.ReadLine());
            Console.Write("Valor de g : ");
            puntos[i].g = Convert.ToByte(Console.ReadLine());
            Console.Write("Valor de b : ");
            puntos[i].b = Convert.ToByte(Console.ReadLine());
        }

        for (int i = 0; i < puntos.Length; i++) {
            Console.WriteLine("\nContenido del punto {0}:", i + 1);
            Console.WriteLine("Coordenada x: {0}", puntos[i].x);
            Console.WriteLine("Coordenada y: {0}", puntos[i].y);
            Console.WriteLine("Valor de r: {0}", puntos[i].r);
            Console.WriteLine("Valor de g: {0}", puntos[i].g);
            Console.WriteLine("Valor de b: {0}", puntos[i].b);
        }
    }
}
