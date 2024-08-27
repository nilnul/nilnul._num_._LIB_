using System.Numerics;

namespace nilnul.num_._radix.radic
{
	public class Ponented
	{
		private num_.ref_.vowless_.Plural _radic;

		public num_.ref_.vowless_.Plural radic
		{
			get { return _radic; }
			set { _radic = value; }
		}

		private Num_ofIn _ponent;

		public Num_ofIn ponent
		{
			get { return _ponent; }
			set { _ponent = value; }
		}
		public BigInteger ponent8integer
		{
			get { return _ponent.eeByRef; }
			set { _ponent = Num_ofIn.Of(value); }
		}
		public int ponent8int
		{
			get { return (int)ponent8integer; }
			set { _ponent = Num_ofIn.Of(value); }
		}


		public Ponented(
			num_.ref_.vowless_.Plural radic
						,
			Num_ofIn ponent
		)
		{
			_radic = radic;
			_ponent = ponent;
		}

		public Ponented(
			num_.ref_.vowless_.Plural radic
						,
			BigInteger ponent
		):this(
			radic
			,
			Num_ofIn.Of(ponent)
			)
		{
		}
		public Ponented(
			BigInteger radic
						,
			Num_ofIn ponent
		)
			:this(
				  ref_.vowless_.Plural.Of(radic)
				 ,
				 ponent
			 )
		{
		}

		public Ponented(BigInteger base_, BigInteger indic):this( base_,Num_ofIn.Of(indic) )
		{
		}

	

		public BigInteger toInteger()
		{
			return nilnul.num.op_.binary_._PowX._Op_basePlural_indexNonNeg(
				this._radic.eeByRef
				,
				this.ponent.eeByRef
			);
		}

		public override string ToString()
		{
			return $"{this._radic}^{this._ponent}";
		}

	}

}
