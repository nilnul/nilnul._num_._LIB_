using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.re.co.or_
{
	public class Defaulted<TRe,TRe1>
		:nilnul.obj.re.co.or_.ReDefault<nilnul.NumI1,TRe,TRe1>
		,
		nilnul.num.ReI
		where TRe: nilnul.num.ReI,new()
		where TRe1: nilnul.num.ReI,new()

	{
	}
}
