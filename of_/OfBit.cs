using System.Runtime.CompilerServices;

namespace nilnul.num.of_
{
	public class OfBit : num.OfI<bool>
	{
		[MethodImpl( MethodImplOptions.AggressiveInlining)]
		static public int OfAsInt(in bool x) {
			return   x ? 1 : 0 ;

		}
		public Num_ofIn op(in bool arg)
		{
			return  Num_ofIn.Of( arg ? 1 : 0 );
		}
		public Num_ofIn op(bool arg)
		{
			return  Num_ofIn.Of( arg ? 1 : 0 );
		}


		static public OfBit Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OfBit>.Instance;
			}
		}

	}
}
