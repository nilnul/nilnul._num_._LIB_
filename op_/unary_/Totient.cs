using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.op_.unary_
{
	/// <summary>
	/// counts the number of positive integers less than or equal to n that are relatively prime to n. 
	/// <example>
	/// Totient(0) =#{}= 0
	/// Totient(1)=#{1}=1
	/// Totient(2)=#{1}=1
	/// T(3) = #{1,2} =2
	/// T(4) = #{1,3}=2
	/// Totient(5)=#{1,2,3,4,5}=5;
	/// T(6) = #{1,4,5} =3
	/// Totient(9)=#{1,2,4,5,7,8}=6
	/// </example>
	/// </summary>
	/// alias:
	///  Euler phi function or totient function
	///  prime counting function;
	public class _TotientX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="x">
		/// ge 2
		/// eg:
		///		2,3,5
		/// </param>
		/// <returns></returns>
		static public int _Op_assumePrime(int x) {
			return x - 1;
		}

	



	}
}
