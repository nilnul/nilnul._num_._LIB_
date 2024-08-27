using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ord.str_
{
	public interface SeqI:StrI, nilnul.num.ord.SeqI
	{

	}

	public abstract class SeqA: nilnul.num.ord.SeqA, SeqI
	{

	}
}
