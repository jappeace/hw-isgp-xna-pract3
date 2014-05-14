using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transform;

namespace ConsoleApplication1 {
	class Program {
		static void Main(string[] args) {
			Matrix x = new Matrix(new double[,]{
				{1,2,3,4},
				{5,6,7,8},
				{9,10,11,12},
				{13,14,15,16}
			});
			Console.WriteLine(x.ToString());
			Console.WriteLine("");
			Matrix y = new Matrix(new double[,]{
				{1,2,3,4},
				{5,6,7,8},
				{9,10,11,12},
				{13,14,15,16}
			});
			Console.WriteLine("add and subtrackt");
			Matrix z = x + y;
			Console.WriteLine(z);
			z = x - y;
			Console.WriteLine(z);
			Console.WriteLine("Multiplication");
			z = x * 2;
			Console.WriteLine(z);
			z =  2 * y;
			Console.WriteLine(z);

			z = x * y;
			Console.WriteLine(z);

			Console.WriteLine("Vectors");
			Console.WriteLine("add and subtrackt");
			Vector v = new Vector(1,2,3,1);
			Console.WriteLine(v+v);
			Console.WriteLine(v-v);
			Console.WriteLine(v*v);
			Console.WriteLine("matrix times vector");
			Console.WriteLine(x*v);
			Console.ReadKey();
		}
	}
}
