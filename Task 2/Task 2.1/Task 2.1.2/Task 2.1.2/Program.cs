using System;
using System.Collections.Generic;

namespace Task_2._1._2
{
    class Program
    {
        static List<Figure> figureList = new List<Figure>();
        static void Main(string[] args)
        {
            Menu();
        }

        static int InputValue(string s)
        {
            int valueS;
            do
            {
                Console.Write(s);
            } while (!Int32.TryParse(Console.ReadLine(), out valueS));
            return valueS;
        }

        static void Menu()
        {
            do
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1.  Добавить фигуру");
                Console.WriteLine("2.  Вывести фигуры");
                Console.WriteLine("3.  Очистить холст");
                Console.WriteLine("4.  Выход");
                string i = Console.ReadLine();
                switch (i)
                {
                    case "1":
                        ChoiceFigureType();
                        break;
                    case "2":
                        FiguresOutput();
                        break;
                    case "3":
                        Console.Clear();
                        figureList.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("выход");
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Ошибка");
                        break;
                }

            } while (true);
        }

        static void ChoiceFigureType()
        {
            Console.WriteLine("Выберите тип фигуры: ");
            Console.WriteLine("1.  Круг");
            Console.WriteLine("2.  Кольцо");
            Console.WriteLine("3.  Прямоугольник");
            Console.WriteLine("4.  Квадрат");
            Console.WriteLine("5.  Треугольник");
            Console.WriteLine("6.  Линия");
            string i = Console.ReadLine();
            switch (i)
            {
                case "1":
                    ChoiceDisc();
                    break;
                case "2":
                    ChoiceRing();
                    break;
                case "3":
                    ChoiceRectangle();
                    break;
                case "4":
                    ChoiceSquare();
                    break;
                case "5":
                    ChoiceTriangle();
                    break;
                case "6":
                    ChoiceLine();
                    break;
            }
        }

        static void ChoiceDisc()
        {
            Console.WriteLine("Введите параметры фигуры Круг");
            Console.WriteLine("Введите координаты центра");
            int x = InputValue("x = ");
            int y = InputValue("y = ");
            Console.WriteLine("Введите радиус");
            int radius = InputValue("radius = ");
            Console.WriteLine("Введите название фигуры");
            string name = Console.ReadLine();
            figureList.Add(new Disc(new Point { X = x, Y = y }, radius, name));
        }

        static void ChoiceRing()
        {
            Console.WriteLine("Введите параметры фигуры Кольцо");
            Console.WriteLine("Введите координаты центра");
            int x = InputValue("x = ");
            int y = InputValue("y = ");
            Console.WriteLine("Введите внешний радиус");
            int radius = InputValue("radius = ");
            Console.WriteLine("Введите ввнутренний радиус");
            int innerRadius = InputValue("inner radius = ");
            Console.WriteLine("Введите название фигуры");
            string name = Console.ReadLine();
            figureList.Add(new Ring(new Point { X = x, Y = y }, radius, innerRadius, name));
        }

        static void ChoiceRectangle()
        {
            Console.WriteLine("Введите параметры фигуры Прямоугольник");
            Console.WriteLine("Введите координаты первой точки");
            Point p1 = new Point { X = InputValue("x1 = "), Y = InputValue("y1 = ") };
            Console.WriteLine("Введите координаты второй точки");
            Point p2 = new Point { X = InputValue("x2 = "), Y = InputValue("y2 = ") };
            Console.WriteLine("Введите название фигуры");
            string name = Console.ReadLine();
            if (!(p1.X == p2.X || p1.Y == p2.Y))
                figureList.Add(new Rectangle(p1, p2, name));
            else
                Console.WriteLine("Это не прямоугольник!");
        }

        static void ChoiceSquare()
        {
            Console.WriteLine("Введите параметры фигуры Квадрат");
            Console.WriteLine("Введите координаты первой точки");
            Point p1 = new Point { X = InputValue("x1 = "), Y = InputValue("y1 = ") };
            Console.WriteLine("Введите координаты второй точки");
            Point p2 = new Point { X = InputValue("x2 = "), Y = InputValue("y2 = ") };
            Console.WriteLine("Введите название фигуры");
            string name = Console.ReadLine();
            if (!(p1.X == p2.X || p1.Y == p2.Y) &&
                (Math.Abs(p2.X - p1.X) == Math.Abs(p2.Y - p1.Y)))
                figureList.Add(new Square(p1, p2, name));
            else
                Console.WriteLine("Это не квадрат!");
        }

        static void ChoiceTriangle()
        {
            Console.WriteLine("Введите параметры фигуры Треугольник");
            Console.WriteLine("Введите координаты первой точки");
            Point p1 = new Point { X = InputValue("x1 = "), Y = InputValue("y1 = ") };
            Console.WriteLine("Введите координаты второй точки");
            Point p2 = new Point { X = InputValue("x2 = "), Y = InputValue("y2 = ") };
            Console.WriteLine("Введите координаты третьей точки");
            Point p3 = new Point { X = InputValue("x3 = "), Y = InputValue("y3 = ") };
            Console.WriteLine("Введите название фигуры");
            string name = Console.ReadLine();
            if (!(p1.X == p2.X && p1.X == p3.X) &&
                !(p1.Y == p2.Y && p1.Y == p3.X))
                figureList.Add(new Triangle(p1, p2, p3, name));
            else
                Console.WriteLine("Это не треугольник!");
        }

        static void ChoiceLine()
        {
            Console.WriteLine("Введите параметры фигуры Линия");
            Console.WriteLine("Введите координаты первой точки");
            Point p1 = new Point { X = InputValue("x1 = "), Y = InputValue("y1 = ") };
            Console.WriteLine("Введите координаты второй точки");
            Point p2 = new Point { X = InputValue("x2 = "), Y = InputValue("y2 = ") };
            Console.WriteLine("Введите название фигуры");
            string name = Console.ReadLine();
            figureList.Add(new Line(p1, p2, name));
        }

        static void FiguresOutput()
        {
            for (int i = 0; i < figureList.Count; i++)
            {
                if (figureList[i] is Disc)
                {
                    Disc disc = figureList[i] as Disc;
                    Console.WriteLine($"Фигура Круг: {disc.Name}");
                    Console.WriteLine($"Длина описанной окружности: {disc.Circumference()}");
                    Console.WriteLine($"Площадь круга: {disc.CircleArea()}");
                    Console.WriteLine();
                }
                if (figureList[i] is Ring)
                {
                    Ring ring = figureList[i] as Ring;
                    Console.WriteLine($"Фигура Кольцо: {ring.Name}");
                    Console.WriteLine($"Площадь кольца: {ring.RingArea()}");
                    Console.WriteLine($"Суммарная длина внешней и внутренней окружностей: {ring.SumCircumference()}");
                    Console.WriteLine();
                }
                if (figureList[i] is Rectangle)
                {
                    Rectangle rect = figureList[i] as Rectangle;
                    Console.WriteLine($"Фигура Прямоугольник: {rect.Name}");
                    Console.WriteLine($"Площадь прямоугольника: {rect.RectArea()}");
                    Console.WriteLine($"Периметр прямоугольника: {rect.RectPerimeter()}");
                    Console.WriteLine();
                }
                if (figureList[i] is Square)
                {
                    Square square = figureList[i] as Square;
                    Console.WriteLine($"Фигура Квадрат: {square.Name}");
                    Console.WriteLine($"Площадь квадрата: {square.SquareArea()}");
                    Console.WriteLine($"Периметр квадрата: {square.SquarePerimeter()}");
                }
                if (figureList[i] is Triangle)
                {
                    Triangle triangle = figureList[i] as Triangle;
                    Console.WriteLine($"Фигура Треугольник: {triangle.Name}");
                    Console.WriteLine($"Периметр треугольника: {triangle.TriangleP()}");
                    Console.WriteLine($"Площадь треугольника: {triangle.TriangleArea()}");
                }
                if(figureList[i] is Line)
                {
                    Line line = figureList[i] as Line;
                    Console.WriteLine($"Фигура Линия: {line.Name}");
                    Console.WriteLine($"Длина линии: {line.LengthLine()}");
                }
            }
        }
    }
}
