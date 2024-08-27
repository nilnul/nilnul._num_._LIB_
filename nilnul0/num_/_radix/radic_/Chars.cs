using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

using nilnul.character.sorted_.alphabet_;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num_._radix.radic_
{

	public  class Chars
		:
		
		CharsI,
		IRadic
		

	{
		private nilnul.character_.cha.Sortie  _digits;
		public nilnul.character_.cha.Sortie gits
		{
			get { return _digits; }
			set {
				_digits = value; 
			}
		}

		_radix.Root1 _radicCached;

		public Chars(
			nilnul.character_.cha.Sortie digits	
		) {
			
			_digits = digits;
			_radicCached = new Root1(digits.en.Length);
		
		}
		public Chars(string digits):this(new character_.cha.Sortie( digits) )
		{
		}
		public Chars(IEnumerable<char> digits):this(string.Join("",digits)  )
		{
		}

		static public string _Create36gits() {

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

		public N parse2num(string x) {
			return  new N( parse2integer(x));
		}
		

		public BigInteger parse2integer(string x) {
			x = x.ToUpper();
			var list=this.gits.en;
			var digitsCount = list.Length;
			var enumerator = x.Trim().GetEnumerator();
			BigInteger r = 0;
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
		}

		public IEnumerable<char> _toRadixAsChars_0num(BigInteger natural) {

			return  _radicCached._toPositions(natural).Select(
				i=> this.gits.en[(int) i.en]
			);
		}

		/// <summary>
		/// reversed
		/// </summary>
		/// <param name="natural"></param>
		/// <returns></returns>
		public string _toRadixAsImportant1st_0num(BigInteger natural) {
			return string.Join(
				"",
				_toRadixAsChars_0num(natural).Reverse()
			);
		}

		public int count
		{
			get
			{
				return _digits.en.Length;
			}
		}

	
		static public string _36Digits = nilnul.character_.cha.sortie_.alfabet_.Digit9latin.Generated;

		static public Chars _Of_0le16(int _2to17_)
		{
			return new Chars(nilnul.character.sortie_.radix_.hex_._UppercaseX.AS_TXT.Substring(0, _2to17_));
		}
		static public Chars _Of_0le36(int _2to37_)
		{
			return new Chars(_36Digits.Substring(0, _2to37_));
		}
		static public Chars _Of_0le36(BigInteger _2to17_)
		{
			return _Of_0le36((int) _2to17_);
		}









		
	}
}
