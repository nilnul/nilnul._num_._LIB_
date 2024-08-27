using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.duo
{
	/// <summary>
	/// </summary>
	public class Coord : nilnul.obj.Box<Duo1>, CoordI
	{

		public Num x
		{
			get
			{
				return this.boxed.Item1;
				//throw new NotImplementedException();
			}
		}

		public Num y
		{
			get
			{
				return this.boxed.Item2;
				//throw new NotImplementedException();
			}
		}

		NumI CoordI.x
		{
			get
			{
				return x;
				throw new NotImplementedException();
			}
		}

		NumI CoordI.y
		{
			get
			{
				return y;
				throw new NotImplementedException();
			}
		}

		public Coord(Duo1 val) : base(val)
		{

		}

		public Coord(Num item11, Num item12):this(new Duo1(item11,item12))
		{
		}
		public Coord(NumI item11, NumI item12):this(new Duo1(item11,item12))
		{
		}


		public Coord(int x1, int y1):this(
			( Num)(x1), (Num)y1
		)
		{
		}

		public Coord(int index1, uint index2):this(
			new Num(index1),index2
		)
		{
		}

		static public explicit operator int[] (Coord coord) {
			return new int[] {
				(int)coord.x.toBigint()
				,
				(int) coord.y.toBigint()
			};
		}
	}
}
