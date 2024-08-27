using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

using N = nilnul.num.natural.Natural_bigInteger;
using nilnul.num.natural;

namespace nilnul.num.op
{
	[Obsolete()]
	static public partial class SqrtX
	{

		static public BigInteger Eval_retBigInt(N n)
		{

			return _Eval_ofNatural_retFloor(n.val);


		}


		static public Natural Eval(N n)
		{


			if (n == 0)
			{
				return new Natural(0);

			}
			return new natural.Count(_Eval_positive_retFloor(n.val));



		}
		static public Tuple<BigInteger,BigInteger> _Eval_ofNatural_retInterval(BigInteger _natural) {
			if (_natural==0)
			{
				return new Tuple<BigInteger, BigInteger>(0,0);
			}
			return _Eval_ofPositive_retInterval(_natural);
		}

		static public BigInteger _Eval_ofNatural_retFloor(BigInteger _natural) {
			if (_natural==0)
			{
				return 0;
			}
			return _Eval_positive_retFloor(_natural);
		}
		static public BigInteger _Eval_ofNatural_retCeil(BigInteger _natural) {
			if (_natural==0)
			{
				return 0;
			}
			return _Eval_positive_retCeil(_natural);
		}



		static public BigInteger _Eval_positive_retFloor(this BigInteger _positive)
		{
			return _Eval_ofPositive_retInterval(_positive).Item1;
		}
	

		static public BigInteger _Eval_positive_retCeil(this BigInteger _positive)
		{
			return _Eval_ofPositive_retInterval(_positive).Item2;
		}

		static public Tuple<BigInteger,BigInteger> _Eval_ofPositive_retInterval( BigInteger _positive)
		{
			//truncate half.
			var x = natural.op.LgX._Eval_base2_retFloor(_positive);

			var y = x / 2;   //floor of the number.

			var candidate = PowX.Pow(2, y);
			while (candidate * candidate < _positive)
			{
				candidate++;
			}
			if (candidate*candidate == _positive)
			{
				return new Tuple<BigInteger, BigInteger>(candidate, candidate);
			}

			return new Tuple<BigInteger,BigInteger>(candidate-1 ,candidate);
		}

		static public Natural SqrtFloor(this uint i)
		{
			return SqrtFloor(new Natural(i));


		}

		static public Natural SqrtFloor(this long i)
		{
			return SqrtFloor(new Natural(i));


		}

		static public int Eval(this int i)
		{
			return SqrtFloor(new Natural(i)).ToInt();


		}
		/// <summary>
		/// self loop
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		/// 

		static public Natural SqrtFloor(this BigInteger i)
		{
			return new Natural( _Eval_ofNatural_retFloor((i)));


		}


		static public Count SqrtFloor(this Plural i)
		{
			return new Count(_Eval_positive_retFloor(i.val));


		}


	}
}
namespace nilnul.num.natural.op
{

	static public partial class SqrtX
	{

		static public BigInteger Eval_retBigInt(N n)
		{

			return _Eval_ofNatural_retFloor(n.val);

			



		}


		static public Natural Eval(N n)
		{


			if (n == 0)
			{
				return new Natural(0);

			}
			return new natural.Count(_Eval_positive_retFloor(n.val));



		}
		static public Tuple<BigInteger,BigInteger> _Eval_ofNatural_retInterval(BigInteger _natural) {
			if (_natural==0)
			{
				return new Tuple<BigInteger, BigInteger>(0,0);
			}
			return _Eval_ofPositive_retInterval(_natural);
		}

		static public BigInteger _Eval_ofNatural_retFloor(BigInteger _natural) {
			if (_natural==0)
			{
				return 0;
			}
			return _Eval_positive_retFloor(_natural);
		}
		static public BigInteger _Eval_positive_retFloor(this BigInteger _positive)
		{
			return _Eval_ofPositive_retInterval(_positive).Item1;
		}
		static public Tuple<BigInteger,BigInteger> _Eval_ofPositive_retInterval( BigInteger _positive)
		{
			//truncate half.
			var x = LgX._Eval_base2_retFloor(_positive);

			var y = x / 2;   //floor of the number.

			var candidate = PowX.Pow(2, y);
			while (candidate * candidate < _positive)
			{
				candidate++;
			}
			if (candidate*candidate == _positive)
			{
				return new Tuple<BigInteger, BigInteger>(candidate, candidate);
			}

			return new Tuple<BigInteger,BigInteger>(candidate - 1,candidate);
		}

		static public Natural SqrtFloor(this uint i)
		{
			return SqrtFloor(new Natural(i));


		}

		static public Natural SqrtFloor(this long i)
		{
			return SqrtFloor(new Natural(i));


		}

		static public int Eval(this int i)
		{
			return SqrtFloor(new Natural(i)).ToInt();


		}
		static public Natural SqrtFloor(this BigInteger i)
		{
			return SqrtFloor(new Natural(i));


		}


		static public Count SqrtFloor(this Plural i)
		{
			return new Count(_Eval_positive_retFloor(i.val));


		}


	}
}
