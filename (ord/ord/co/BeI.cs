using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co
{
	public interface BeI
		:nilnul.obj.BeI1<nilnul.num.ord.Co>
	{

	}

	public interface BeI<TCol,TRow>
		:nilnul.obj.BeI1<nilnul.num.ord.Co<TCol,TRow>>
		where TCol:nilnul.num.OrdI2
		where TRow:nilnul.num.OrdI2

	{

	}

	public interface BeI<TCol>
		:

		BeI<TCol,TCol>
		,
		nilnul.obj.BeI1<nilnul.num.ord.Co<TCol>>

		where TCol:nilnul.num.OrdI2

	{

	}

	public abstract class BeA_OnTOrd<TOrd>
		: BeI<TOrd>
		where TOrd : nilnul.num.OrdI2

	{
		public bool be(Co<TOrd, TOrd> obj)
		{
			return be(new Co<TOrd, TOrd>(obj.Item1,obj.Item2) );
		}

		public abstract bool be(Co<TOrd> obj)
		;
	}



}
