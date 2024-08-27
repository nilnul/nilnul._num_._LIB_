using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord
{


	public interface CoI<TCol>
		:nilnul.obj.CoI2<TCol>
		where TCol:OrdI2

	{

	}

	public interface CoI
		:CoI<nilnul.num.OrdI2>

	{

	}


	public class Co<TCol,TRow>
		: Tuple<TCol,TRow>
		,
		CoI<OrdI2>
		,CoI

		where TCol:OrdI2
		where TRow:OrdI2
	{

		public Co(TCol x, TRow y): base(x, y)
		{
		}

		public OrdI2 component => this.Item1;

		public OrdI2 component1 => Item2;
	}

	public class Co<TCol>
		: Co<TCol, TCol>
		where TCol:OrdI2

	{
		public Co(TCol x, TCol y) : base(x, y)
		{
		}
	}

}
