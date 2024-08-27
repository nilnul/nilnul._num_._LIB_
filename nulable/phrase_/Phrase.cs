using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.nulable.phrase_
{
	static public class _NulEmptyX
	{

		static public string Phrase(nilnul.Num nulabe) {
			return nulabe  is null ? "" : nilnul.num.phrase_.dec_._NilNotEmptyX.Phrase(nulabe);
		}
	}
}
