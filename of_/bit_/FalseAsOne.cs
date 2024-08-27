using System.Runtime.CompilerServices;

namespace nilnul.num.of_.bit_
{
	public class FalseAsOne : num.OfI<bool>
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int OfAsInt(in bool x)
		{
			return x ? 0 : 1;

		}

		public Num_ofIn op(in bool arg)
		{
			return  Num_ofIn.Of( arg ? 0 :1 );
		}
		public Num_ofIn op(bool arg)
		{
			return  Num_ofIn.Of( arg ? 0 :1 );
		}




		static public FalseAsOne Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<FalseAsOne>.Instance;
			}
		}


	}
}
