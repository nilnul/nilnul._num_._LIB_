using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.op_.unary
{
	/* Knuth's up-arrow (↑) notation:
a↑b	=	a↑1b	=	ab exponentiation
a↑↑b	=	a↑2b	=	ba tetration
a↑↑↑b	=	a↑3b pentation
a↑↑↑↑b	=	a↑4b hexation
etc.
		*/
	/// <summary>
	/// The next operation beyond tetration is called pentation. Pentation is repeated tetration. You can imagine how big those numbers must be!
	/// with initial; usually this is associative
	/// </summary>
	///

	public class Hyper
		:
		nilnul.num.op_.BinaryI1
	{

		private nilnul.Num1 _ord;


		public nilnul.Num1 ord
		{
			get { return _ord; }
			set { _ord = value; }
		}

		private nilnul.Num1 _arg;

		public nilnul.Num1 arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

	
		public Hyper(Num1 ord, Num1 arg) 
		{
			_ord = ord;
			_arg = arg;
		}
		public Hyper(BigInteger ord1, int v):this(new Num1(ord1), new Num1(v) )
		{
		}

		public Hyper(BigInteger ord1):this(ord1, 0)
		{

		}



		/// <summary>
		/// op of nil.
		/// applied this zero times.
		/// </summary>
		/// <returns></returns>
		public nilnul.Num1 op() {
			if (_ord ==0)
			{
				return 1;
			};
			if (_ord==1)
			{
				return _arg;
			}
			if (_ord==2)
			{
				return 0;
			}
			
			return 1;


		}
		/// <summary>
		/// applied this only once.
		/// </summary>
		/// <param name="cumulated">a^(b-1)</param>
		/// <returns></returns>
		public nilnul.Num1 _op_accumulated(nilnul.Num1 cumulated) {
			if (_ord==0)
			{
				return  cumulated + 1;
			}


			//if (_ord==1)
			//{
			//	return cumulated + _arg;
			//}


			return new Hyper(_ord -1, ).op_binary(  _arg, cumulated);
			/*
			say,
			if this hyper is plus, we need to calcuulate :cumulated+arg, by using decreHyper: a+1+1+...(cumulated) ...+1. 
			if this hyper is multi, the result is expected to be equal to cumulated*arg.
			 if this hyper is pow, we need to calculate in biOp(a,b) as a^b, which is:
			a*a*...(b times)... *a.
			this is equivalent to op_repeat(a, b) of hyperMulti.
				for hyperMulti,
					op_repeat(a,b) = repeatedly for b times of op_once( a) = a* a^(b-1).


			here we calc a*cumulated, by using the decreHyper:
			
			*/

		}


		public Num1 op_binary(Num1 basis, Num1 latter)
		{
			if (_ord==0)
			{
				return latter + 1;
			}


			
			return new Hyper(_ord - 1).op_repeat(
				basis, latter
			);

		}

		/// <summary>
		/// compound the operation. the result of prev operation is used as para for the latter operation.
		/// </summary>
		/// <param name="basis"></param>
		/// <param name="repeation"></param>
		/// <returns></returns>
		public Num1 op_repeat(Num1 basis, Num1 repeation)
		{
			_arg = basis;
			var r = op();
			while (repeation-->0)
			{
				r = _op_accumulated(r);
			}
			return r;

		}

		public Num1 op_repeat( Num1 repeation)
		{
			
			var r = op();
			while (repeation-->0)
			{
				r = _op_accumulated(r);
			}
			return r;

		}


		public Num1 op(BigInteger x, BigInteger y)
		{
			return op_repeat(
				new Num1(x),
				new Num1(y)
			);
		}

		static public Num1 Op(Num1 ord, Num1 a, Num1 b) {

			return new Hyper(ord, a).op_repeat(a, b);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="n_theOrder"></param>
		/// <param name="base_natural"></param>
		/// <param name="index_natural"></param>
		/// <returns></returns>
		public static BigInteger Eval_0multi(BigInteger n_theOrder, BigInteger base_natural, BigInteger index_natural)
		{
			if (n_theOrder == 0)
			{
				return base_natural * index_natural;

			}

			if (index_natural == 0)
			{
				return 1;

			}
			return Eval_0multi(n_theOrder - 1, base_natural, Eval_0multi(n_theOrder, base_natural, index_natural - 1));

		}

		public static BigInteger Eval_0Inc(BigInteger n_theOrder, BigInteger base_natural, BigInteger index_natural)
		{
			if (n_theOrder == 0)
			{
				return  index_natural+1;

			}

			if (index_natural == 0)
			{
				if (n_theOrder==1)
				{
					return base_natural;
				}
				if (n_theOrder==2)
				{
					return 0;
				}

				return 1;

			}

			return Eval_0Inc(n_theOrder - 1, base_natural, Eval_0multi(n_theOrder, base_natural, index_natural - 1));

		}


		public static Num1 Op(BigInteger ord, BigInteger x, BigInteger y)
		{

			return Op(
				new Num1(ord)
				,
				new Num1(x)
				,
				new Num1(y)
			);
		}
	}
}
