using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Alphabet = nilnul.character.str.distinct.be.Alphabet.En;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.character_.cha.sortie_.plural
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>as number, the leading zeros is not significant; as codec, the leading zeros are significant. In the algorithm, leading zero may be removed or prepended, rendering this not a codec.</remarks>
	/// radix is nilnul.txt.radix, not nilnul.txt_.radix in that radix is a wrapper around or an extension of, txt; it itself is not txt. it's more than txt; it can be "downcast" to txt and txt is only one property of it.
	public class Radix
	{

		private nilnul.character_.cha.sortie_.Plural _alphabet;

		public nilnul.character_.cha.sortie_.Plural alphabet
		{
			get { return _alphabet; }
			set
			{
				_alphabet = value;
			}
		}

		public char[] toCharArray() {
			return _alphabet.str.en.ToArray();//.toCharArray();
		}


		public char zeroChar
		{
			get { return _alphabet.str.en.First(); }
		}



		public int radical
		{
			get { return _alphabet.str.en.Length; }
			//set { _radical = value; }
		}


		

		public Radix(nilnul.character_.cha.sortie_.Plural alphabet)
		{
			this.alphabet = alphabet;
		}

		public Radix(string s):this( new Plural( s))
		{

		}


		

		public IEnumerable<char> multi(string a, string b)
		{
			IEnumerable<char> r = new List<char>();
			var shift = "";

			foreach (var item in a)
			{

				r = add(
					r,
					(shift + multi(item, b))

				);

				shift += zeroChar;
			}
			return r;

		}
		public IEnumerable<char> multi(char a1, string txt)
		{

			IEnumerable<char> r = new List<char>();
			var shift = "";


			foreach (var item in txt)
			{
				r = add(r, shift + multi(item, a1));
				shift += zeroChar;
			}
			return r;


		}

		public string alphabetTxt { get {
				return _alphabet.str.en;
			} }
		public string multi(char a, char b)
		{

			return toRadix(alphabetTxt.IndexOf(a) * alphabetTxt.IndexOf(b));


		}

		//public int radical { get {

		//	} }

		/// <summary>
		/// Note: this is in reverse order in comparision with what we use daily.
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		public string toRadix(int a)
		{
			StringBuilder sb = new StringBuilder();


			while (a != 0)
			{
				var divRem = nilnul.num.op.DivRem.Eval_retInt(a, radical);

				a = divRem[0];


				sb.Append(alphabetTxt[divRem[1]]);
			}

			return sb.ToString();
		}



		public string toTxt_zeroEmpty(int a)
		{
			StringBuilder sb = new StringBuilder();




			while (a != 0)
			{
				var divRem = nilnul.num.op.DivRem.Eval_retInt(a, radical);

				a = divRem[0];


				sb.Prepend(alphabetTxt[divRem[1]]);
			}
			return  sb.ToString();
		}


		public string _toTxt_zeroEmpty(int a_natural)
		{


			StringBuilder sb = new StringBuilder();


			while (a_natural != 0)
			{
				var divRem = nilnul.num.op.DivRem.Eval_retInt(a_natural, radical);

				a_natural = divRem[0];


				sb.Prepend(alphabetTxt[divRem[1]]);
			}

			return sb.ToString();
		}


		public string toTxt_zeroEmpty(N a)
		{
			return string.Join("",
							 new nilnul.num_._radix.Root(alphabet.str.en.Length)._toDigits(
								a
							).Select(x => alphabetTxt[(int)x])
						)
			;
		}
	

		public string toTxt_zeroChar(int a)
		{
			var t = toTxt_zeroEmpty(a);

			return t == "" ? zeroChar.ToString() : t;
		}


		public IEnumerable<char> simplify(IEnumerable<char> txt)
		{
			return txt.SkipWhile(x => x == zeroChar);
		}


		public IEnumerable<char> add(IEnumerable<char> a, IEnumerable<char> b)
		{
			if (a.Count() == 0)
			{
				return b;
			}

			if (b.Count() == 0)
			{
				return a;
			}

			var firstAdd = add(a.First(), b.First());

			return new[] { firstAdd.First() }.Concat(add(firstAdd.Last(), a.Skip(1), b.Skip(1)));

		}





		public IEnumerable<char> add(char carry, IEnumerable<char> a, IEnumerable<char> b)
		{
			if (a.Count() == 0)
			{
				return add(carry, b);
			}

			if (b.Count() == 0)
			{
				return add(carry, a);
			}

			var firstAdd = add(a.First(), b.First());
			return new[] { firstAdd.First() }.Concat(add(firstAdd.Last(), a.Skip(1), b.Skip(1)));
		}






		public string shift(string x)
		{
			return zeroChar + x;
		}

		public IEnumerable<char> shift(IEnumerable<char> x)
		{
			yield return zeroChar;
			foreach (var item in x)
			{
				yield return item;
			}
		}





		private IEnumerable<char> add(char a, IEnumerable<char> b)
		{

			if (b.Count() == 0)
			{
				yield return a;
				yield break;
			}

			var firstAdd = add(a, b.First());
			yield return firstAdd.First();
			foreach (
				var item in add(firstAdd.Last(), b.Skip(1))

			)
			{
				yield return item;

			}



		}





		/// <summary>
		/// big endian
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b_lessThanRoot"></param>
		/// <returns></returns>
		public string add(char a, char b_lessThanRoot)
		{
			return toTxt_zeroEmpty(
				alphabetTxt.IndexOf(a) + alphabetTxt.IndexOf(b_lessThanRoot)
			);



			var divRem = nilnul.num.op.DivRem.Eval_retInt(


				alphabetTxt.IndexOf(a) + alphabetTxt.IndexOf(b_lessThanRoot)
				,
				radical

			);


			return string.Concat(alphabetTxt[divRem[1]], alphabetTxt[divRem[0]]);

		}




		public N parse(string x)
		{
			//x = x.ToUpper();

			BigInteger r = 0;
			//		var enumerator = x.Reverse().GetEnumerator();

			var list = this.alphabetTxt;
			var digitsCount = this.alphabetTxt.Length;
			var enumerator = x.GetEnumerator();

			while (enumerator.MoveNext())
			{
				r = r * digitsCount;

				var index = list.IndexOf(enumerator.Current);
				if (index == -1)
				{

					throw new ArgumentException("unexpected char");

				}
				r += index;



			}
			return new N(r);




			//	throw new NotImplementedException();

		}







	}
}
