using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.natural.op
{

	public  class ToStrX
	{
		static public string _Eval_0notEmpty(BigInteger _nonNeg) {

			return _Eval_0notEmpty(_nonNeg, Radix.Decimal.Singleton.Instance);
		}

		static public string _Eval_0Empty(BigInteger _nonNeg) {
			return _Eval_0Empty(_nonNeg, Radix.Decimal.Singleton.Instance);
		}


		static public string _Eval_0notEmpty(BigInteger _nonNeg, Radix radix) {

			var t=_Eval_0Empty(_nonNeg, radix) ;

			return t == "" ? "0" : t;

		}


		[Obsolete()]
		static public string Do(BigInteger n_nonNeg, Radix radix)
		{
			if (n_nonNeg == 0)
			{
				return "0";

			}

			BigInteger remainder;//=n_nonNeg;
			//n_nonNeg = BigInteger.DivRem(n_nonNeg, radix.count, out remainder);

			StringBuilder r = new StringBuilder();

			while (n_nonNeg != 0)
			{
				n_nonNeg = BigInteger.DivRem(n_nonNeg, radix.count, out remainder);

				r.Insert(0,
					radix.digits.ElementAt((int)remainder).ToString()
				);


			}
			return r.ToString();

		}

		static public string _Eval_0Empty(BigInteger _nonNeg, Radix radix)
		{
			if (_nonNeg == 0)
			{
				return "";

			}

			BigInteger remainder;//=n_nonNeg;
			//n_nonNeg = BigInteger.DivRem(n_nonNeg, radix.count, out remainder);

			StringBuilder r = new StringBuilder();

			while (_nonNeg != 0)
			{
				_nonNeg = BigInteger.DivRem(_nonNeg, radix.count, out remainder);

				r.Insert(0,
					radix.digits.ElementAt((int)remainder).ToString()
				);


			}
			return r.ToString();

		}
		[Obsolete(nameof(_Eval_0Empty))]
		static public string Do_0empty(BigInteger n_nonNeg, Radix radix)
		{
			if (n_nonNeg == 0)
			{
				return "";

			}

			BigInteger remainder;//=n_nonNeg;
			//n_nonNeg = BigInteger.DivRem(n_nonNeg, radix.count, out remainder);

			StringBuilder r = new StringBuilder();

			while (n_nonNeg != 0)
			{
				n_nonNeg = BigInteger.DivRem(n_nonNeg, radix.count, out remainder);

				r.Insert(0,
					radix.digits.ElementAt((int)remainder).ToString()
				);


			}
			return r.ToString();

		}

		static public string Do(BigInteger n_nonNeg, int radix_withinHex)
		{
			return Do(n_nonNeg, Radix.Create(radix_withinHex));

		}

		static public string _Eval_0Empty(BigInteger n_nonNeg, BigInteger radix_withinHex) {
			return _Eval_0Empty(n_nonNeg, Radix.Create(radix_withinHex));


		}

		[Obsolete(nameof(_Eval_0Empty))]
		static public string Do(BigInteger n_nonNeg, BigInteger radix_withinHex)
		{
			return Do(n_nonNeg, Radix.Create(radix_withinHex));

		}


		static public string Do_binary(BigInteger n_nonNeg)
		{
			return Do(n_nonNeg, Radix.Binary.Singleton.Instance);

		}
		static public string Do_binary(int n_nonNeg)
		{
			return Do(n_nonNeg, Radix.Binary.Singleton.Instance);

		}
		static public string Do_binary0empty(BigInteger n_nonNeg)
		{
			return Do_0empty(n_nonNeg, Radix.Binary.Singleton.Instance);

		}
		static public string Do_binary0empty(int n_nonNeg)
		{
			return Do_0empty(n_nonNeg, Radix.Binary.Singleton.Instance);

		}

		static public string Do_oct(BigInteger n_nonNeg)
		{
			return Do(n_nonNeg, Radix.Oct.Binary.Singleton.Instance);

		}

		static public string Do_decimal(BigInteger n_nonNeg)
		{
			return Do(n_nonNeg, Radix.Decimal.Singleton.Instance);

		}

		static public string Do_hex(BigInteger n_nonNeg)
		{
			return Do(n_nonNeg, Radix.Hex.Singleton.Instance);

		}






	}
}
