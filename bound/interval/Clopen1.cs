using nilnul.num.natural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using N = nilnul._num.bigint.be.Natural.Asserted;

namespace nilnul.num.interval
{
	public partial class Clopen1
		:
		nilnul.num.ext_.border.duo.be.Nonempty1.En
		,
		IntervalI
	{
		private N _upperOpenBound;

		public N upperOpenBound
		{
			get { return _upperOpenBound; }
			set { _upperOpenBound = value; }
		}

		private N _lowerBound;

		public N lowerBound
		{
			get { return _lowerBound; }
			set { _lowerBound = value; }
		}
		

		
		public Clopen1(N lower, N upperOpenBound)
			:base(
				 ext_.Border1.CreateClose( lower)
				 ,
				 ext_.Border1.CreateOpen( 
					 new nilnul.Num( upperOpenBound)
				)
			)
		{
			this.upperOpenBound = upperOpenBound;
			this.lowerBound = lower;

		}

		public Clopen1(int a,N upperBound)
			:this(new N(a),upperBound)
		{

		}

		public Clopen1(int a,int b)
			:this(a,new N(b))
		{

		}
		static public Clopen1 CreateLowerZero(N right) {
			return new Clopen1(0, right);
		
		}
		



		public bool contains(N n) {

			return n >= lowerBound && n < upperOpenBound;
		
		}


		public IEnumerator<N> GetEnumerator()
		{
			for (N i = lowerBound ; i < upperOpenBound; i++)
			{
				yield return i;

			}
			yield break;
			throw new NotImplementedException();
		}

	


	
	}
}
