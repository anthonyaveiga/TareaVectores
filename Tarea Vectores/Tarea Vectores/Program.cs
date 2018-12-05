using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_vectores
{
	class Program
	{
		public static void TareaVectores()
		{
			int[] vec = new int[5];
			int mayor = vec[0], menor = vec[0];

			for (int i = 0; i < vec.Length; i++)
			{
				while (vec[i] < 1 || vec[i] > 1000)
				{
					Console.WriteLine("Ingrese valor {0} del vector", i + 1);
					vec[i] = Int32.Parse(Console.ReadLine());
				}

			}
			for (int i = 0; i < vec.Length; i++)
			{
				if (vec[i] > mayor)
				{
					mayor = vec[i];
				}
			}
			menor = mayor;
			for (int i = 0; i < vec.Length; i++)
			{
				if (vec[i] < menor)
				{
					menor = vec[i];
				}
			}


			Console.WriteLine("El numero mayor es: " + mayor);
			Console.WriteLine("El numero menor es: " + menor);
		}

		static void Main(string[] args)
		{
			TareaVectores();
			Console.ReadKey();
		}
	}
}
