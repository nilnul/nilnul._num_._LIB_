using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._num.bigint.be;
using System.Numerics;

using N = nilnul.Num;


namespace nilnul.num.slider_
{
	[Obsolete]
	public class Starter
		: 
		nilnul.num.SliderA
		,
		nilnul.num.SliderI1
	{
		private nilnul.Num _current;

		public override nilnul.Num current
		{
			get
			{
				return _current;
				//throw new NotImplementedException();
			}
		}
		public Starter():this(0)
		{

		}
		public Starter(nilnul.Num starter)
		{
			_current = starter;
		}

		public override void moveNext()
		{
			_current++;
		}

		static public Starter CreatePositive() {
			return new Starter(1);
		}

		static public Starter CreatePlural() {
			return new Starter(2);
		}
		static public Starter CreatePoly() {
			return new Starter(3);
		}

		

	}
}
