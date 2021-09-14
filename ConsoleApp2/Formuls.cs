using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Формулы
{
	class Формулы
	{
		static void Main(string[] args)
		{
			/* №1
			double r, x;
			x = 9;
			r = (2*Math.Sqrt(x))/(1/(Math.Sqrt(x)-2)+1/(Math.Sqrt(x)+2));
			Console.WriteLine(r);
			Console.ReadKey();
			*/

			/* №2
			double r, x, y;
			x = 9;
			y = 6;
			r = (1-Math.Sqrt(1+Math.Abs(Math.Pow(x,2)-(Math.Pow(y,2)))))/(2-Math.Abs(Math.Pow(x,2)-Math.Pow(y,2)));
			Console.WriteLine(r);
			Console.ReadKey();
			*/

			/* №3
			double r, a, b, c, d;
			a = 5;
			b = 7;
			c = 3;
		    d = 8;
			r = (a+b-1.7)/(c+(d/Math.Sqrt(c+d)+0.5));
			Console.WriteLine(r);
			Console.ReadKey();

			/* №4
			double r, a;
			a = 90;
			r = (Math.Sin(a))/(1+(Math.Cos(a)+1)/(Math.Pow(Math.Tan(a),2)));
			Console.WriteLine(r);
			Console.ReadKey();
			*/

			/* №5
			double r, a;
			a = 90;
			r = (1)/(Math.Sqrt(1+Math.Sin(((1)/Math.Sqrt(2+Math.Cos(((1)/Math.Sqrt(2+Math.Pow(Math.Sin(a),2)))))))));
			Console.WriteLine(r);
			Console.ReadKey();
			*/

			/* №6
			double r, x;
			x = 6;
			r = (1)/(Math.Sqrt(1+Math.Cos((1-x)/(1+x))));
			Console.WriteLine(r);
			Console.ReadKey();
			*/

		}
	}
}
