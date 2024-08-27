using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.bit;
using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul.txt;
using nilnul.num_;

namespace nilnul.num_._radix.radic.ponented
{

	public class Amplified
	{


		public const char DOT = '.';

		private Ponented _ponented;

		public Ponented ponented
		{
			get { return _ponented; }
			set { _ponented = value; }
		}




		private nilnul.Num_ofIn _amplitude;

		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		magnitude
		public nilnul.Num_ofIn amplitude
		{
			get { return _amplitude; }
			set { _amplitude = value; }
		}





		public Amplified(
			Ponented ponented
			,
			nilnul.Num_ofIn amplitude

			)
		{
			this._ponented = ponented;
			this._amplitude = amplitude;


		}

		public Amplified(
			Ponented ponented
			,

			BigInteger amplitude
	)
			: this(ponented, Num_ofIn.Of(amplitude))
		{


		}

		public Amplified(Amplified amplified) : this(amplified.ponented, amplified.amplitude)
		{
		}

		public Amplified(ref_.vowless_.Plural radic, Rootless scientific) : this(radic, scientific.ponent, scientific.amplitude)
		{
		}

		public Amplified(ref_.vowless_.Plural radic, Num_ofIn ponent, Num_ofIn amplitude)
			:
			this(
				new Ponented(radic, ponent)
				,
				amplitude
			)
		{

		}

		public Amplified(BigInteger radix_plural, Num_ofIn ponent, BigInteger value) : this(
			new Ponented(radix_plural, ponent), value
		)
		{
		}
		public Amplified(BigInteger radix_plural, BigInteger ponent, BigInteger value) : this(
			new Ponented(radix_plural, ponent), value
		)
		{
		}

		static public Amplified Of_0radic_1pon_2amplific(
			BigInteger radic,
			BigInteger ponent,
			BigInteger amplitude
			)

		{
			return new Amplified(
				  new Ponented(radic, ponent), amplitude
			);

		}

		/// <summary>
		/// no indic;
		/// </summary>
		/// <param name="radic"></param>
		/// <param name="amplitude"></param>
		/// <returns></returns>
		///
		[Obsolete(nameof(of_._OfNumX))]
		static public Amplified OfRadic9amplitude(BigInteger radic, BigInteger amplitude)
		{
			return Of_0radic_1pon_2amplific(radic, 0, amplitude);

		}

		/// <summary>
		/// simplify this to the standard simplest form.
		/// eg:
		///		100*10^1 = 1* 10^3;
		///	this will increase ponent but shrink precision;
		///	to increase precision, <see cref="_incrementPrecision_0nonneg(int)"/>
		/// </summary>
		public void simplify()
		{
			if (amplitude == 0)
			{
				this._ponented.ponent = 0;
				return;

			}

			BigInteger remainder;
			var q = BigInteger.DivRem(amplitude, this._ponented.radic, out remainder);

			while (remainder == 0)
			{
				this.amplitude = Num_ofIn.Of(q);
				this.ponented.ponent++;
				q = BigInteger.DivRem(amplitude, this._ponented.radic, out remainder);
			}
		}
		public BigInteger radicAsInteger
		{
			get { return _ponented.radic; }
		}
		public BigInteger amplitudeAsInteger
		{
			get => this.amplitude;
			private set
			{
				_amplitude = Num_ofIn.Of(value);
			}
		}

		/// <summary>
		/// not change the value; so when incrementing precision, decrease the indic meanwhile;
		/// </summary>
		/// <exception cref="">
		/// this might throw exception if ponent has to be a negative value;
		/// </exception>
		public void incrementPrecision()
		{
			amplitudeAsInteger = amplitude * radicAsInteger;
			this._ponented.ponent--;
		}

		public void _incrementPrecision_0nonneg(int _natural_zeros)
		{
			while (_natural_zeros-- > 0)
			{
				incrementPrecision();
			}
		}

		/// <summary>
		/// eg:
		///		23*10^45  appended by 6,  and we get: 236*10^44
		/// </summary>
		/// <param name="siginificandNewLastDigit">
		/// another git of precision;
		/// </param>
		public void append2precision(BigInteger siginificandNewLastDigit)
		{
			if (siginificandNewLastDigit >= radicAsInteger)
			{
				throw new ArgumentOutOfRangeException($"{siginificandNewLastDigit} shall be less than radic:{this.radicAsInteger};");
			}
			amplitudeAsInteger = amplitudeAsInteger * radicAsInteger + siginificandNewLastDigit;
			_ponented.ponent -= 1;
		}

		public Amplified toMorePresion(
			BigInteger siginificandNewLastDigit
		)
		{

			var r = new Amplified(this);

			r.append2precision(siginificandNewLastDigit);
			return r;
		}

		public Amplified toSimplify()
		{
			var r = new Amplified(this);
			r.simplify();
			return r;
		}

		/// <summary>
		/// <see cref="num.quotient_.Radix2"/>
		/// </summary>
		/// <returns></returns>
		///
		public override string ToString()
		{

			return $"{amplitude}*{this._ponented}"; // as we included the base, there is no need to express each component in the base herein; To express the number in base, we can express it in such way as: 00123010.0310321000 
													//return toTxt();
		}


		public Amplified toSquare()
		{
			return new Amplified(
				this._ponented.radic
				,
				_radix.Rootless.Square_0amplitude_1ponent(this._amplitude, this._ponented.ponent)
			);
		}


		public BigInteger toInteger()
		{

			return this._amplitude * this._ponented.toInteger();
		}


		static public Amplified _Add(

			BigInteger radix_plural,
			_radix.Rootless a,
			_radix.Rootless b
			)
		{

			if (a.ponent <= b.ponent)
			{
				return _Add_2ponentGe(radix_plural, a, b);

			}
			return _Add_2ponentGe(radix_plural, b, a);

		}

		static public Amplified _Add_2ponentGe(
			BigInteger radix_plural, Rootless _powerSmaller, Rootless powerGe)
		{
			var t = powerGe.ponent.eeByRef - _powerSmaller.ponent.eeByRef;
			return new Amplified(
				radix_plural
				,
				_powerSmaller.ponent
				,

				powerGe.amplitude
				*
				nilnul.num.op_.binary_._PowX._Op_basePlural_indexPlural(radix_plural, t)
				+
				_powerSmaller.amplitude
			);
		}
	}
}