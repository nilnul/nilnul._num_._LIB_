using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.nint
{

	static public partial class GcdX
	{



		public static decimal Gcd(this decimal a) {
			return Math.Abs(a);	//for it's GREATEST.
		}
		

	


		public static decimal Gcd( decimal a, decimal b)
		{
			if (a == 0)
			{
				return Gcd(b);//for it's GREATEST.
			}
			else
			{
				return Gcd(b % a, a);	///% is,when confronted with negative numbers, first to compute the 2 number,then add the sign.
			}
		}




		static public decimal Gcd(decimal[] a, int n)
		{
			if (n <= 0)
			{
				throw new Exception("Cannot compute among 0 or less numbers.");
			}
			if (n > a.Length)
			{
				throw new Exception("Then number given exceeds the length of the array.");
			}
			if (n == 1)
			{
				return Math.Abs(a[0]);	//For it's Greatest.
			}
			else
			{
				return Gcd(a[n - 1], Gcd(a, n - 1));
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <param name="n">1,a.len</param>
		/// <returns></returns>
		static private decimal _Gcd(decimal[] a, int n)
		{

			if (n == 1)
			{
				return Math.Abs(a[0]);	//For it's Greatest.
			}
			else
			{
				return Gcd(a[n - 1], _Gcd(a, n - 1));
			}
		}

		static public decimal Gcd(this decimal[] a) {

			return  GcdParams(a);
			
		
		}


		public static decimal GcdParams(params decimal[] a){

			if (a.Length==0)
			{
				throw new Exception();
				
			}

			return _Gcd(a, a.Length);
			
		}

		static void Main(string[] args)
		{
			Console.WriteLine(
				GcdParams(
					-3.36m
					,
					2.9121m
					,
					-3.3m
					,
					0
				)
			);
			Console.Read();
		}

		
		
	}
}
