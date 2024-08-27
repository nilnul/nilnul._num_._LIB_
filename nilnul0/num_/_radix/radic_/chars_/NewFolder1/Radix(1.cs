using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.character.sorted_.alphabet_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num
{

	[Obsolete( nameof(nilnul.num_.plural._radix.Root) + nameof(nilnul.num_._radix.radic_.Chars))]
	public  class Radix
		:RadixI
	{
		private SortedSet<char> _digits;
		public SortedSet<char> digits
		{
			get { return _digits; }
			set {
				_digits = value; 
			}
		}

		public void set(
			SortedSet<char> digits	
		) {
			nilnul.bit.Assertion.True(digits.Count > 1);
			_digits = digits;
		
		}
		public Radix(SortedSet<char> digits)
		{
			set(digits);
			

		}

		public Radix(Digit singleton)
			:this(  singleton.sortedSet )
		{

		}

		static public Radix _Create(int _2to17_)
		{
			return new Radix(new SortedSet<char>(Hex_Chars.Substring(0, _2to17_)));
		}
		static public Radix _Create1(int _2to37_)
		{
			return new Radix(new SortedSet<char>(_36Digits.Substring(0, _2to37_)));
		}
		static public string _36Digits = Create36Digits();
		static public string Create36Digits() {

			StringBuilder sb = new StringBuilder();
			for (char i = '0'; i <= '9'; i++)
			{
				sb.Append(i);
				
			}
			for (char i = 'A'; i < 'Z'; i++)
			{
				sb.Append(i);
			}

			return sb.ToString();
		}

		static public Radix Create(BigInteger _2to17_)
		{
			return new Radix(new SortedSet<char>(Hex_Chars.Substring(0, (int)_2to17_)));
		}


		//private class Private
		//{
		//	public SortedSet<char> _digits;

		//	public SortedSet<char> digits
		//	{
		//		get { return _digits; }
		//		set { _digits = value; }
		//	}

			
		//}

		public N parse1(string x) {
			x = x.ToUpper();

			BigInteger r = 0;
			//		var enumerator = x.Reverse().GetEnumerator();

			var list=this.digits.ToList();
			var digitsCount = this.digits.Count;
			var enumerator = x.Trim().GetEnumerator();

			while (enumerator.MoveNext())
			{
				r = r * digitsCount;

				var index = list.IndexOf(enumerator.Current);
				if (index==-1)
				{

						throw new ArgumentException("unexpected char");
			
				}
				r += index;



			}
			return  new N( r);




		//	throw new NotImplementedException();
		
		}
		

		public BigInteger parse(string x) {
			x = x.ToUpper();

			BigInteger r = 0;
			//		var enumerator = x.Reverse().GetEnumerator();

			var list=this.digits.ToList();
			var digitsCount = this.digits.Count;
			var enumerator = x.Trim().GetEnumerator();

			while (enumerator.MoveNext())
			{
				r = r * digitsCount;

				var index = list.IndexOf(enumerator.Current);
				if (index==-1)
				{

						throw new ArgumentException("unexpected char");
			
				}
				r += index;



			}
			return  r;




		//	throw new NotImplementedException();
		
		}

		public string encode(BigInteger natural) {

			StringBuilder sb = new StringBuilder();
			BigInteger remainder;



			while (natural!=0)
			{
				natural=BigInteger.DivRem(natural, digits.Count, out remainder);
				
				sb.Insert(0, remainder);


			}

		

			return sb.ToString();


		
		}

		//private Radix(
		//	Private private_
		//)
		//{
		//	this._digits = private_._digits;
		//}


		public int count
		{
			get
			{
				return _digits.Count;
			}
		}

		static public SortedSet<char> HexChars{
			get {
				return new SortedSet<char>(Hex_Chars);
			}
		
		}

		static public SortedSet<char> DecChars {
			get {
				return new SortedSet<char>(Dec_Chars);
			}
		}

		static public SortedSet<char> OctChars {
			get {
				return new SortedSet<char>(Oct_Chars);
			}
		}

		static public SortedSet<char> BiChars {
			get {
				return new SortedSet<char>(Bi_Chars);
			}
		}


		public const string Hex_Chars = "0123456789ABCDEF";

		public static string Dec_Chars = Hex_Chars.Substring(0, 10);
		public static string Oct_Chars = Hex_Chars.Substring(0, 8);
		public static string Bi_Chars = Hex_Chars.Substring(0, 2);

		public class Hex
			:Radix
		{
			public Hex()
				:base(HexChars)
			{

			}

			public class Singleton
				:SingletonByDefaultNew<Hex>
			{
				
			}
			
		}

		public class Decimal
			:Radix
		{
			public Decimal()
				:base(DecChars)
			{

			}

			public class Singleton
				:SingletonByDefaultNew<Decimal>
			{
				
			}
			
		}

		public class Oct
			:Radix
		{
			public Oct()
				:base(OctChars)
			{

			}
			public class Singleton
				:SingletonByDefaultNew<Oct>
			{
				
			}
			
		}

		public class Binary
			:Radix
		{
			public Binary():base(BiChars)
			{

			}

			public class Singleton
				:SingletonByDefaultNew<Binary>
			{
				
			}

		}






		
	}
}
