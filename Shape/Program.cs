using System.Security.Cryptography;
using System.Threading.Channels;

namespace Shape
{
	internal class Program
	{
		static void KeruletVsTeruletLyukasztas(Shape s1) 
		{
			if (s1.Area() > s1.Perimeter())
			{
				s1.MakeHoley();
			}
		}

		static void RectangleLetrehozas(int a, int b)
		{
			if (a == b)
			{
				new Square(false, "red", a, b);
			}
			else 
			{
				new Rectangle(false, "red", a, b);
			}
		}

		static Shape MaxTerulet(Shape[] shapes)
		{
			Shape max = shapes[0];
			for (int i = 1; i < shapes.Length; i++)
			{
				if (max.Area() < shapes[i].Area())
				{
					max = shapes[i];
				}
			}
			return max;

		}

		static void Feladat()
		{
			Shape[] shapes =
				{
				new Square(false, "red", 6,6),
				new Circle("white",5),
				new Rectangle(true,"grey",1,2),
				new Square(true, "purple", 4,2),
				new Circle("orange",2),
				};

		}

		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(false,"red",1,2);
            //Rectangle rectangle = new();
            //Console.WriteLine(rectangle);

			Shape shape = rectangle;

			Shape[] shapes =
			{
				rectangle,
				new Square(true,"blue",1,1),
				new Circle("black",5)
			};

			Square square = new Square(false, "red", 5, 5);

			Rectangle rectangle1 = square;
			Shape shape3 = square;

			Feladat();
        }	
	}
}
