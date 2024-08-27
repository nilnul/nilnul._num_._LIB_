using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._num.bigint.be.vow_.ofIn_
{
	/// <summary>
	/// vow by reference
	/// </summary>
	/// <typeparam name="TBe"></typeparam>
	public class BeDefault<TBe> :
		bigint.be.Vow_ofIn
		

	where TBe:nilnul.obj.BeI_ofIn<BigInteger>,new()
	{
		public BeDefault()
			:
		base(

				 nilnul._obj.typ_._UnisonX<TBe>.Unison


			//nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<BeDefault<TBe>>.Unison;
			}
		}


		

	}
}
