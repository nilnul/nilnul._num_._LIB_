using nilnul.element.collection.tuple;
using nilnul.obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.tro_
{
	/// https://pi.math.cornell.edu/~gautam/ContinuedFractions.pdf
	/// p40
	/// 
	/// <summary>
	///
	/// A Markov triple (m1, m2, m3) consists of three positive integers such that m^2+n^2+p^2 =3mnp
	/// To each Markov triple there is a way of associating a quadratic form
	/// ax^2 + bxy + cy^2
	/// where a, b, c are integers that depend on m1, m2, m3.A Markov number is an integer that belongs to at least one Markov triple.
	/// </summary>
	/// Two Markov triples are said to be adjacent to each other if two of their Markov numbers are the same.For example, (5, 1, 2) is a Markov triple and its neighbors are(1, 1, 2),(5, 29, 2),(5, 1, 13).
	internal class IMarkov
	{
	}
}
