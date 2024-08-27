using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num;
using nilnul.num.str_;
using nilnul.num.to_;

namespace nilnul.num_.radix_
{
	/// <summary>
	/// express 0123000 as 0123*10^3, where 0123 is the precision, which is allowed space to hold a maximum of gits;
	/// 
	/// </summary>
	/// alias:
	///		CollpaseTrailingNils
	///		precisioned
	public class Precisioned : RadixI
	{


		private IEnumerable<Num_ofIn> _gits;

		public IEnumerable<Num_ofIn> gits
		{
			get { return _gits; }
			set { _gits = value; }
		}


		_radix.radic.Ponented _ponented;

		public _radix.radic.Ponented ponented
		{
			get
			{
				return _ponented;
			}
			set
			{
				_ponented = value;
			}
		}
		public int ponent8int
		{
			get
			{
				return _ponented.ponent8int;
			}
			set
			{
				_ponented.ponent8int = value;
			}
		}
		public ref_.vowless_.Plural radic => _ponented.radic;



		public Precisioned(
			IEnumerable<Num_ofIn> gits_,
			_radix.radic.Ponented ponented_
		)
		{
			_gits = gits_;
			_ponented = ponented_;
		}

		public Precisioned(
			IEnumerable<Num_ofIn> gits_
			,

			num_.ref_.vowless_.Plural radic
						,
			Num_ofIn ponent
		) : this(gits_, new _radix.radic.Ponented(radic, ponent)
		)
		{
		}


		public Precisioned(
			IEnumerable<Num_ofIn> gits_
			,

			num_.ref_.vowless_.Plural radic
						,
			BigInteger ponent
		) : this(gits_, radic, Num_ofIn.Of(ponent)
		)
		{
		}
		public Precisioned(
			IEnumerable<Num_ofIn> gits_
			,

			num_.ref_.vowless_.Plural radic
						,
			int ponent=0
		) : this(gits_, radic, Num_ofIn.Of(ponent)
		)
		{
		}
		public Precisioned(
			IEnumerable<BigInteger> gits_
			,

			num_.ref_.vowless_.Plural radic
						,
			int ponent=0
		) : this(gits_.Select(x=>Num_ofIn.Of(x)), radic, ponent
		)
		{
		}

		public Precisioned(
			num_.RadixI gits_
			
		) : this(
			gits_.gits
			,
			gits_.radic
		)
		{
		}


		public Precisioned(IEnumerable<Num_ofIn> enumerable, BigInteger root, int v)
				: this(
					 enumerable, num_.ref_.vowless_.Plural.Of(root), v
					)
		{
		}

		public Precisioned(IEnumerable<BigInteger> digits, BigInteger root, int v)
			: this(
				 digits.Select(x => Num_ofIn.Of(x))
				  , root
				  , v
				)
		{
		}
		public Precisioned(IEnumerable<Num1> digits, BigInteger root, int v)
			:
			this(digits.Select(x => x.To__Num_ofIn()), root, v)
		{
		}

		public Precisioned(
			IEnumerable<Num1> digits
			,
			nilnul.num_.Plural1 root

		) : this(digits, root, 0)
		{


		}

		public Precisioned(
			IEnumerable<Num1> digits
			,
			BigInteger root

		) : this(

			digits
			,
			root
			,
			0
			)
		{


		}

		public Precisioned(
			IEnumerable<BigInteger> digits
			,
			BigInteger root

		) : this(
			digits
			,

			root,
			0
)
		{

		}


		public Precisioned(
			IEnumerable<int> digits
			,
			BigInteger root

		) : this(
			digits.Select(x=>Num_ofIn.Of(x))
			,
			root
			,
			0
		)
		{


		}


		public void trimInsignificants()
		{
			_gits = _gits.Reverse().SkipWhile(x => x == 0).Reverse();
		}

		public void shrink()
		{
		
			var size=gits.Count();
			_gits=_gits.SkipWhile(x=>x==0);
			if (_gits.Any())
			{
				this._ponented.ponent8int = size - _gits.Count();

			}
			else
			{
				this._ponented.ponent8int = 0;

			}
		}

		public BigInteger toInteger()
		{
			return nilnul.num_.radix_.precisioned.to_._ToNumX.ToInteger(
				this
			);
	
		}

		public nilnul.Num_ofIn toNum()
		{
			return nilnul.num_.radix.to_._ToNumX.ToNum(
				this
			);
	
		}

		public string _phase_assumeValid(char[] _chars)
		{
			return radix._PhraseX._Phrase_1valid(this, _chars);

			//return string.Join(
			//	"",
			//	this.digits.Select(x => _chars[(int)(x.en)]).Reverse()
			//);
		}
		public override string ToString()
		{
			return radix_.precisioned._PhraseX.Phrase(this);
		}

		public BigInteger toBigint()
		{
			return toInteger();
		}

		static public bool operator ==(Precisioned radix, uint i)
		{
			return radix.toInteger() == i;
		}
		static public bool operator !=(Precisioned radix, uint i)
		{
			return !(radix == i);
		}

		static public bool operator ==(uint i, Precisioned radix)
		{
			return radix == i;
		}
		static public bool operator !=(uint i, Precisioned radix)
		{
			return !(i == radix);
		}



	}
}
