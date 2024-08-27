using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.op_.binary_
{
	public interface CommutableI:BinaryI1
		,
		nilnul.obj.op_.binary_.CommutableI<Num1>
	{
	}
}
