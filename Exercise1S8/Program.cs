// See https://aka.ms/new-console-template for more information

            double ancho, altura;

            Console.WriteLine("Ingrese el ancho del rectángulo:");
            ancho = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del rectángulo:");
            altura = double.Parse(Console.ReadLine());

            double perimetro = 2 * (ancho + altura);
            double area = ancho * altura;
            double diagonal = Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(altura, 2));

            Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
            Console.WriteLine("El área del rectángulo es: " + area);
            Console.WriteLine("La diagonal del rectángulo es: " + diagonal);
   
