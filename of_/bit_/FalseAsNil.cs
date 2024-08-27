using System.Runtime.CompilerServices;

namespace nilnul.num.of_.bit_
{
	/// <summary>
	/// </summary>
	/// <remarks>
	/// this is the default;
	/// </remarks>
	public class FalseAsNil : num.OfI<bool>
	{

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public int OfAsInt(in bool x)
		{
			return x ? 1 : 0;

		}

		public Num_ofIn op(in bool arg)
		{
			return  Num_ofIn.Of( arg ? 0 :1 );
		}
		public Num_ofIn op(bool arg)
		{
			return  Num_ofIn.Of( arg ? 0 :1 );
		}



		static public FalseAsNil Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<FalseAsNil>.Instance;
			}
		}


	}
}
