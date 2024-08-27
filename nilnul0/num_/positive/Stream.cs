using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = nilnul.NumI;
using P = nilnul.num_.Positive1;

namespace nilnul.num_.positive
{
	public interface StreamI
		:nilnul.obj.StreamI1<P>
	{
	}

	public interface StreamI1
		:nilnul.obj.StreamI2<P>
	{ }
}
