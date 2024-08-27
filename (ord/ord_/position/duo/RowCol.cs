using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.ord.duo
{
	public class RowCol
		: nilnul.obj.Box<Duo>
		,
		_rowCol_.RowI
		,
		_rowCol_.ColI
		,
		nilnul.num.duo.CoordI

	{
		public RowCol(Duo val) : base(val)
		{
		}
		public RowCol(
			nilnul.num_.positive.Ord row
			,
			nilnul.num_.positive.Ord col
		)
			:this(new Duo(row,col))
		{

		}


		/// <summary>
		/// col second
		/// </summary>
		public Ord col
		{
			get
			{
				return boxed.Item2;
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// row first
		/// </summary>
		public Ord row
		{
			get
			{
				return boxed.Item1;
				throw new NotImplementedException();
			}
		}

		public NumI x
		{
			get
			{
				return col.toNum();
				throw new NotImplementedException();
			}
		}

		public NumI y
		{
			get
			{
				return row.toNum();
				throw new NotImplementedException();
			}
		}
	}
}
