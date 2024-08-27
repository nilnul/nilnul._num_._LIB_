using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._slider.slider_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// aka:
	/// The secant numbers S_k, also called the zig numbers or the Euler numbers
	/// 
	/// E_n^*=|E_(2n)| numbers than can be defined either in terms of a generating function given as the Maclaurin series of  secx or as the numbers of alternating permutations on n=2, 4, 6, ... symbols (where permutations that are the reverses of one another counted as equivalent). The first few S_n for n=1, 2, ... are 1, 5, 61, 1385, ... (OEIS A000364).
	/// For example, the reversal-nonequivalent alternating permutations on n=2 and 4 numbers are {1,2}, and {1,3,2,4}, {1,4,2,3}, {2,1,4,3}, {2,3,1,4}, {2,4,1,3}, respectively.
	/// The secant numbers have the generating function
	/// secx = sum_(k = 0) ^ (infty)(S_kx ^ (2k))/((2k)!)	
	/// (1)
	/// =	1+1/2x^2+5/(24)x^4+(61)/(720)x^6+....
	/// An odd alternating permutation number, more commonly called an Euler number or secant number.
	/// </remarks>
	public class SecantCoef
	{
	}
}
