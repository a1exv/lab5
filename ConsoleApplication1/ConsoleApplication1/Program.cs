using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication44
{
    public enum Color { red, blue, green };
    public abstract class Figure
    {

        protected char s;
        protected Color color;
        public Figure()
        {
            s = '*';
            color = Color.red;
        }
        public Figure(char _s, Color c)
        {
            s = _s;
            color = c;
        }
        public abstract void ShowFigure();
        public virtual void ShowInfo()
        {
            Console.WriteLine("symbol is " + s + "  color is " + color.ToString());
        }
    }
    public class Square : Figure
    {

        int size;
        public Square()
            : base()
        {
            size = 4;
        }
        public Square(int _size, char _s, Color _color)
            : base(_s, _color)
        {
            size = _size;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Figure is " + this.GetType());
            base.ShowInfo();
        }
        public override void ShowFigure()
        {
            switch (base.color)
            {
                case Color.red: Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.blue: Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.green: Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default: Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(s);
                }
                Console.Write('\n');
            }
            Console.ResetColor();
        }
    }
    public class Triangle : Figure
    {

        int baseSize;
        public Triangle()
            : base()
        {
            baseSize = 4;
        }
        public Triangle(int _baseSize, char _s, Color _color)
            : base(_s, _color)
        {
            baseSize = _baseSize;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Figure is " + this.GetType());
            base.ShowInfo();
        }
        public override void ShowFigure()
        {
            switch (base.color)
            {
                case Color.red: Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.blue: Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.green: Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default: Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            int k = baseSize / 2;
            for (int i = 0; i < baseSize; i++)
            {
                Char[] white = new Char[k + 1];
                for (int j = 0; j < k; j++)
                {
                    white[j] = ' ';
                }
                char[] symbol = new char[i + 1];
                for (int j = 0; j < i + 1; j++)
                {
                    symbol[j] = s;
                }
                Console.Write(white);
                Console.WriteLine(symbol);
                k--;
            }
            Console.ResetColor();
        }
    }
    public class Rectangle : Figure
    {

        int lenght;
        int width;
        public Rectangle()
            : base()
        {
            lenght = 4;
            width = 3;
        }
        public Rectangle(int _lenght, int _width, char _s, Color _color)
            : base(_s, _color)
        {
            lenght = _lenght;
            width = _width;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Figure is " + this.GetType());
            base.ShowInfo();
        }
        public override void ShowFigure()
        {
            switch (base.color)
            {
                case Color.red: Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.blue: Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.green: Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default: Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    Console.Write(s);
                }
                Console.Write('\n');
            }
            Console.ResetColor();
        }
    }
    public class CommonFigure
    {
        public Figure[] figures = new Figure[2];
        static int amount = 0;
        public void CreateFigure()
        {
            Console.WriteLine(" what is the color? 1-red, 2-blue, 3-green");
            Color c = (Color)(Convert.ToInt32(Console.ReadLine()) - 1);
            Console.WriteLine("what is the symbol? ");
            char s = Console.ReadLine()[0];
            Console.WriteLine("what is the figure? 1-square, 2-triangle, 3 -rectangle");
            int fig = Convert.ToInt32(Console.ReadLine());
            switch (fig)
            {
                case 1:
                    Figure f1 = new Square(5, s, c);
                    figures[amount] = f1;
                    amount++;
                    break;
                case 2: figures[amount] = new Triangle(4, s, c);
                    amount++;
                    break;
                case 3: figures[amount] = (new Rectangle(4, 5, s, c));
                    amount++;
                    break;
                default: figures[amount] = (new Square(5, s, c));
                    amount++;
                    break;

            }
        }
        public void ShowAll()
        {
            foreach (Figure f in figures)
            {
                if (f != null)
                {
                    f.ShowFigure();
                    Console.WriteLine();
                    Console.ResetColor();
                }
                else break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CommonFigure figs = new CommonFigure();
            figs.CreateFigure();
            figs.CreateFigure();
            figs.ShowAll();
        }
    }
}
