using System.Threading.Channels;

namespace Shape
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(false,"red",1,2);
            //Rectangle rectangle = new();
            Console.WriteLine(rectangle);

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
        }	
	}
}
