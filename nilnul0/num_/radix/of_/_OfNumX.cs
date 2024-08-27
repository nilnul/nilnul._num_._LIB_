using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.str_;

namespace nilnul.num_.radix.of_
{
	/// <summary>
	/// convert a num to radix;
	/// input is: (radic,num);
	/// </summary>
	static public class _OfNumX
	{
	
		static public Radix2 _Of_1nonneg(nilnul.num_._radix.Root1 root, BigInteger x)
		{
			return new Radix2(
				root.radic
				,
				(root)._toPositions_0nonneg((x))
			);
		}

	static public Radix2 _Of_1nonneg(BigInteger root, BigInteger x)
		{
			return _Of_1nonneg(new _radix.Root1(root),x);
		}
		static public Radix2 Of(nilnul.num_._radix.Root1 root, nilnul.Num1 x)
		{
			return _Of_1nonneg(root,x.en);
		}

		static public Radix2 Of(nilnul.num_._radix.Root1 root, BigInteger x)
		{
			return Of(root, new Num1(x));
		}

		static public Radix2 Of(nilnul.num_._radix.Root root, nilnul.Num1 x)
		{
			return new Radix2(
				root.radic
				,
				(root)._toDigits1((x))
			);
		}

		static public Radix2 Of(nilnul.num_.Plural root, nilnul.Num1 x)
		{
			return new Radix2(
				root
				,
				new _radix.Root(root)._toDigits1((x))
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="root">par0 is radic;</param>
		/// <param name="x">par1 is num</param>
		/// <returns></returns>
		static public Radix2 Of(nilnul.num_.Plural root, BigInteger x)
		{
			return Of(root, new Num1(x));
		}


	


	}
}
