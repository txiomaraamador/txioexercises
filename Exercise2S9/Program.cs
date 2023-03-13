// See https://aka.ms/new-console-template for more information

namespace TextDisplay
{
    class ScreenText
    {
        private int x;
        private int y;
        private string text;

        public ScreenText(int x, int y, string text)
        {
            this.x = x;
            this.y = y;
            this.text = text;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void Display()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
    }

    class CenteredText : ScreenText
    {
        public CenteredText(int y, string text) : base(0, y, text)
        {
            SetX((Console.WindowWidth - text.Length) / 2);
        }
    }

    class FramedText : CenteredText
    {
        private int startY;

        public FramedText(int startY, string text) : base(startY + 1, text)
        {
            this.startY = startY;
        }

        public override void Display()
        {
            int length = GetLength();
            int x = (Console.WindowWidth - length) / 2;
            int y = startY;
            Console.SetCursorPosition(x, y);
            Console.Write("┌" + new string('─', length - 2) + "┐");
            for (int i = 0; i < GetHeight(); i++)
            {
                y++;
                Console.SetCursorPosition(x, y);
                Console.Write("│" + new string(' ', length - 2) + "│");
            }
            y++;
            Console.SetCursorPosition(x, y);
            Console.Write("└" + new string('─', length - 2) + "┘");
            base.Display();
        }

        private int GetLength()
        {
            return GetText().Length + 2;
        }

        private int GetHeight()
        {
            return 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ScreenText screenText = new ScreenText(10, 10, "Hello, world!");
            screenText.Display();

            CenteredText centeredText = new CenteredText(15, "Este texto está centrado horizontalmente.");
            centeredText.Display();

            FramedText framedText = new FramedText(20, "Este texto está centrado y enmarcado.");
            framedText.Display();

            Console.ReadKey();
        }
    }
}
