using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.plural.vow.ee_
{
	public class VowDefault<TVow> : num_.plural.vow.Ee
		where TVow : num_.plural.VowI, new()
	{
		public VowDefault(Plural1 val) : base(
			val, nilnul.obj_.Singleton<TVow>.Instance
		)
		{
		}
	}
}
