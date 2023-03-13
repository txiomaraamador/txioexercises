// See https://aka.ms/new-console-template for more information

namespace EjercicioCasa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un pequeño apartamento
            PequenoApartamento miApartamento = new PequenoApartamento();

            // Crear una persona
            Persona yo = new Persona("Xiomara", miApartamento);

            // Mostrar los datos de la persona
            yo.ShowData();
        }
    }

    // Definir la clase Casa
    class Casa
    {
        private double area;

        public Casa(double area)
        {
            this.area = area;
        }

        public double GetArea()
        {
            return area;
        }

        public void SetArea(double area)
        {
            this.area = area;
        }

        public void ShowData()
        {
            Console.WriteLine("Soy una casa, mi área es de " + area + " m2.");
        }

        public Puerta GetDoor()
        {
            return new Puerta("marrón");
        }
    }

    // Definir la clase Puerta
    class Puerta
    {
        private string color;

        public Puerta(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public void ShowData()
        {
            Console.WriteLine("Soy una puerta, mi color es " + color + ".");
        }
    }

    // Definir la clase PequenoApartamento como una subclase de Casa
    class PequenoApartamento : Casa
    {
        public PequenoApartamento() : base(50.0)
        {
        }
    }

    // Definir la clase Persona
    class Persona
    {
        private string nombre;
        private Casa casa;

        public Persona(string nombre, Casa casa)
        {
            this.nombre = nombre;
            this.casa = casa;
        }

        public void ShowData()
        {
            Console.WriteLine(nombre + " vive en una casa de " + casa.GetArea() + " m2.");
            casa.ShowData();
            casa.GetDoor().ShowData();
        }
    }
}
