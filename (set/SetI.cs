using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num
{
	public interface SetI:nilnul.obj.SetI1<nilnul.NumI>
	{
	}

	public abstract class SetA : SetI
	{
		public  IEqualityComparer<NumI> elementEq { get {
				return nilnul.num.Eq.Singleton;
		} }

		public abstract NumI[] toArr();
	}

	public class Set : nilnul.obj.Set<nilnul.NumI, nilnul.num.Eq>
	{
		
	}

	public class SetOfNum : nilnul.obj.Set<nilnul.Num, nilnul.num.Eq>
	{
		
	}



}
