using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.co
{
	public interface VowI:nilnul.obj.VowI<nilnul.num.ord.Co>
	{
	}

	public interface VowI<TCol, TRow>
		:nilnul.obj.VowI2<
			nilnul.num.ord.Co<TCol,TRow>
		>
		where TCol:nilnul.num.OrdI2
		where TRow:nilnul.num.OrdI2

	{

	}

	public interface VowI<TCol>
		:VowI<
			TCol,TCol
		>
		,nilnul.obj.VowI2<
			nilnul.num.ord.Co<TCol>
		>

		where TCol:nilnul.num.OrdI2

	{

	}




}
