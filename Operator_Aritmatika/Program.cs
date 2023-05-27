using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Aritmatika
	/*
	1. Penjumlahan = +
	2. Pengurangan = -
	3. Perkalian = *
	4. Pembagian = /
	5. Modulus / sisa = %
*/
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int A = 5;
			int B = 10;
			Console.WriteLine("Masukan Angka 1 : ");
			A = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Masukan Angka 2 : ");
			B = Convert.ToInt32(Console.ReadLine());


			double aDb1 = Convert.ToDouble(A); //Untuk membagi nilai hasil Koma
			double bDb1 = Convert.ToDouble(B);

			Console.WriteLine("Hasil A+B " + Convert.ToInt16( A + B ));
			Console.WriteLine("Hasil A-B " + Convert.ToInt16(A - B));
			Console.WriteLine("Hasil A*B " + Convert.ToInt16(A * B));
			Console.WriteLine("Hasil A/B " + Convert.ToDouble(aDb1 / bDb1));
			Console.WriteLine("Hasil A%B " + Convert.ToInt16(A % B));
		}
	}
}
