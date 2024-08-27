using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.number.nint
{

	public partial class Gcd
	{

		static private readonly Gcd _Instance = new Gcd();
		static public Gcd Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Gcd()
		{
		}

		/// <summary>
		/// when there is no number input
		/// </summary>
		/// <returns></returns>
		public Nint eval()
		{
			throw new Exception();
		}
				



		public  Nint eval(Nint a) {
			if (a.Equal(0))
			{
				throw new Exception();
			}
			else
			{
				return a;	//for it's GREATEST.;
			}
		}


		public Nint eval(Nint a, Nint b)
		{
			if (a.NolessThan(b))
			{
				return _eval(a, b);

			}
			else
			{
				return _eval(b, a);
			}
		}
		public  Nint _eval( Nint a_NoLessThan, Nint b)
		{
			if (b.Equal(0))
			{
				return eval(a_NoLessThan);
			}
			else
			{
				return _eval(b, a_NoLessThan.Mod(b)); //an divide by zeroException if b is 0.
				///% is,when confronted with negative numbers, first to compute the 2 number,then add the sign. 
			}
		}


		public Nint eval(IEnumerable<Nint> nints) {
			if (nints.Count()==0)
			{
				throw new Exception();
				
			}
			else
			if (nints.Count()==1)
			{
				return eval(nints.ElementAt(0));
				
			}
			else
			if (nints.Count()==2)
			{
				return eval(nints.ElementAt(0), nints.ElementAt(1));


			}
			else
			{
				return eval(
					nints.ElementAt(0)
					,
					eval(
							nints.Skip(1)
						)
					);

			}

			
			
		
		}




		
		
	}
}
