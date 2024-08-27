using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num_
{
	/// <summary>
	/// defined by recursion (three clauses):
	///		base clause: 0 is natural number,
	///		extension: if x is natural number, then s(x) is natural number,
	///		except|exclusion: except the above, no other things are called natural number.
	/// </summary>
	/// <remarks>
	/// the above recursion can be represented using set theory:
	///		Φ -> 0, that is: 丨Φ丨=0
	///		{Φ} -> 1，
	///		丨{Φ，{Φ}}丨 = 2
	///		丨{Φ，{Φ}，{ Φ，{ Φ} }丨 = 3
	///		，……
	///	,the benefit of this is that: we can use the well established set theory, and we don't need "+1", or successor operator(S) in recursion as the set construction (append new element) has been enough to represent that.
	/// </remarks>
	/// this is a semi-decidable collection.
	/// 
	/// s(x) means x+1
	internal class _ByRecursionX
	{
	}
}
