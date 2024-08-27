using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.of_.binary_.multi_._algo
{
	/// <summary>
	///
	/// in 1960 Anatoly Karatsuba discovered that better complexity than O(n^2) was possible (with the Karatsuba algorithm).
	/// </summary>
	internal enum Li_
	{
		/// <summary>
		/// If a positional numeral system is used, a natural way of multiplying numbers is taught in schools as long multiplication, sometimes called grade-school multiplication, sometimes called the Standard Algorithm: multiply the multiplicand by each digit of the multiplier and then add up all the properly shifted results. It requires memorization of the multiplication table for single digits.
		/// </summary>
		/// <remarks>
		///Lattice, or sieve, multiplication is algorithmically equivalent to long multiplication. 
		/// </remarks>
		Long
			,
		/// <summary>
		/// The grid method (or box method) is an introductory method for multiple-digit multiplication that is often taught to pupils at primary school or elementary school. It has been a standard part of the national primary school mathematics curriculum in England and Wales since the late 1990s
		/// eg:
		///		34*13= (30+4)* (10+3)= 30*10+ 4*10+3*30+3*4;
		/// </summary>
		Grid
			,
		/// <summary>
		/// time complexity of O(
		///		n^(ln3/ln2)
		///	)
		/// </summary>
		Karatsuba
			,

		/// <summary>
		/// The Schönhage–Strassen algorithm is an asymptotically fast multiplication algorithm for large integers, published by Arnold Schönhage and Volker Strassen in 1971
		///It works by recursively applying number-theoretic transforms (a form of fast Fourier transform) over the integers modulo 2n+1.
		///The run-time bit complexity to multiply two n-digit numbers using the algorithm is O(
		///		n log(n) log(log(n)
		///	);
		///</summary>
		SchönhageStrassen
			,
		/// <summary>
		/// Toom–Cook, sometimes known as Toom-3, named after Andrei Toom, who introduced the new algorithm with its low complexity, and Stephen Cook, who cleaned the description of it, is a multiplication algorithm for large integers.
		/// </summary>
		ToomCook,
		/// <summary>
		/// In March 2019, David Harvey and Joris van der Hoeven announced their discovery of an O(n log n) multiplication algorithm. It was published in the Annals of Mathematics in 2021. Because Schönhage and Strassen predicted that n log(n) is the ‘best possible’ result Harvey said: "...our work is expected to be the end of the road for this problem, although we don't know yet how to prove this rigorously.
		/// </summary>
		HarveyHoeven
	}
}
