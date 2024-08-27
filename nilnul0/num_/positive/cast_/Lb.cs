using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using nilnul.num;

namespace nilnul.num_.positive.cast_
{
	public class Lb : nilnul.num_.positive.CastI<nilnul.num.Range>
	{
		public Range cast(Positive positive)
		{
			return nilnul.num.duo_.pluralPositive.cast_.Lg.Singleton.cast(( num_.Plural)( 2),positive);
			throw new NotImplementedException();
		}


		static public readonly Lb Singleton = nilnul.obj.SingletonByDefault<Lb>.Instance;

	}
}
