using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
	internal abstract class Shape
	{
		bool isHoley;
		string color;

		protected Shape(string color, bool isHoley = false )
		{
			this.isHoley = isHoley;
			this.color = color;
		}


		public override string ToString()
		{
			return $"{color} - {isHoley} - K: {Perimeter()} - T: {Area()}";
		}

		public void MakeHoley() 
		{
			isHoley = true;
		}

		public abstract double Perimeter();
		public abstract double Area();

		

		public string Color { get => color; set => color = value; }
	}
}
