using nilnul.num_._radix.radic;
using nilnul.num_.radix_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace nilnul.num_.radix.to_
{
	static public class _ToNumX
	{

		public static BigInteger _ToInteger_radic0plural_gits1nonnegs(BigInteger _radic8plural, IEnumerable<BigInteger> _gits8nonnegs)
		{
			var slider = new nilnul.num.integer.stream_.slider_.multi_._Std(
				_radic8plural
			);

			BigInteger r = 0;
			foreach (var item in _gits8nonnegs)
			{
				r += item * slider.current;
				slider.moveNext();
			}
			return r;
		}


		public static BigInteger _ToInteger_gits0nonnegs_radic1plural(
			IEnumerable<BigInteger> _gits8nonnegs
			,
			BigInteger _radic8plural
		)
		{
			var slider = new nilnul.num.integer.stream_.slider_.multi_._Std(
				_radic8plural
			);

			BigInteger r = 0;
			foreach (var item in _gits8nonnegs)
			{
				r += item * slider.current;
				slider.moveNext();
			}
			return r;
		}

	

		public static Num_ofIn _ToNum_plural0radic_nonnegs1gits(BigInteger _radic8plural, IEnumerable<BigInteger> _gits8nonngegs)
		{
			
			return Num_ofIn.Of(
				_ToInteger_radic0plural_gits1nonnegs( _radic8plural,_gits8nonngegs )
			);
		}

		public static BigInteger _ToInteger_nonnegs1gits(ref_.vowless_.Plural radic, IEnumerable<BigInteger> enumerable)
		{
			return _ToInteger_radic0plural_gits1nonnegs(radic.eeByRef,enumerable);
		}
		public static Num_ofIn _ToNum_nonnegs1gits(ref_.vowless_.Plural radic, IEnumerable<BigInteger> enumerable)
		{
			return _ToNum_plural0radic_nonnegs1gits(radic.eeByRef,enumerable);
		}

		public static BigInteger ToInteger(ref_.vowless_.Plural radic, IEnumerable<Num_ofIn> gits)
		{
			return _ToInteger_nonnegs1gits(radic,gits.Select(x=>x.eeByRef));
			//throw new NotImplementedException();
		}
		public static Num_ofIn ToNum(ref_.vowless_.Plural radic, IEnumerable<Num_ofIn> gits)
		{
			return _ToNum_nonnegs1gits(radic,gits.Select(x=>x.eeByRef));
			//throw new NotImplementedException();
		}

		static public BigInteger ToInteger(nilnul.num_.RadixI radix) {
			return ToInteger(
				radix.radic
				,
				radix.gits
			);
		}

		static public nilnul.Num_ofIn ToNum(nilnul.num_.RadixI radix) {
			return ToNum(
				radix.radic
				,
				radix.gits
			);
		}



		
	}


}
