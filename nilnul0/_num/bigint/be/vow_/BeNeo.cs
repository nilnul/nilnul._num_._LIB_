using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.be.vow_
{
	/// <summary>
	/// vow by reference
	/// </summary>
	/// <typeparam name="TBe"></typeparam>
	public class BeNeo<TBe> :
		bigint.be.Vow_byRef
		

	where TBe:nilnul._num.bigint.BeOfRefI,new()
	{
		public BeNeo() : base(
				 nilnul._obj.typ_._UnisonX<TBe>.Unison
				)
		{
		}

		static public BeNeo<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<BeNeo<TBe>>.Unison;
			}
		}

	}
}
