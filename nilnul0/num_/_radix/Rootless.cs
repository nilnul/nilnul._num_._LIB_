using nilnul.num_._radix.radic.ponented;
using System;
using System.Numerics;

namespace nilnul.num_._radix
{
	/// <summary>
	/// 3e25; the radic is unknown;
	/// </summary>
	/// alias:
	///		rtless
	///		baseless
	///		nonrt
	///		sansrt
	///		sansroot
	public class Rootless : ScientificI
	{
		private nilnul.Num_ofIn _amplitude;
		public nilnul.Num_ofIn amplitude
		{
			get { return _amplitude; }
			set { _amplitude = value; }
		}

		private nilnul.Num_ofIn _ponent;
		public nilnul.Num_ofIn ponent
		{
			get { return _ponent; }
			set { _ponent = value; }
		}

		public Rootless(nilnul.Num_ofIn amplitude, nilnul.Num_ofIn ponent)
		{
			_amplitude = amplitude;
			_ponent = ponent;
		}

		
		public Rootless(BigInteger amplitude, nilnul.Num_ofIn ponent)
			:this(Num_ofIn.Of(amplitude),ponent)
		{
			
		}

		public Rootless(Num_ofIn amplitude, BigInteger ponent)
			:this((amplitude),Num_ofIn.Of( ponent) )
		{
			
		}

		public Rootless(BigInteger amplitude, BigInteger ponent)
			:this(Num_ofIn.Of(amplitude),ponent)
		{
			
		}



		public override string ToString()
		{
			return $"{_amplitude}e{_ponent}";
		}


		static public Rootless _Multi_0pluralRadic(
				BigInteger radix_plural,
				Rootless significandIndex1
				,
				Rootless significandIndex2
		)
		{
			return new Rootless(
significandIndex1._amplitude * significandIndex2._amplitude
,

significandIndex1._ponent + significandIndex2._ponent
			);


		}

		static public Rootless Square(Rootless a

		)
		{
			return new Rootless(
					a._amplitude * a._amplitude
				,
			
				a.ponent.eeByRef <<1
			);
		}
		public static Rootless Square_0amplitude_1ponent(Num_ofIn amplitude, Num_ofIn ponent)
		{
			return new Rootless(
				
				amplitude*amplitude
				,
				ponent.eeByRef<<1
			);

		}

		static public string Phrase(Rootless rootless)
		{
			return $"{rootless._amplitude}e{rootless._ponent}";

		}

		public static string _Phrase_0nonnegAsAmplitude_1nonnegAsPon(BigInteger amplitude, BigInteger ponent)
		{
			return $"{amplitude}e{ponent}";

		}

	}
}
