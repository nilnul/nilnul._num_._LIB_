using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num_.positive.str_
{
	public class Enumerable : 
		nilnul.obj.Box<IEnumerable<nilnul.num_.Positive>>
		,
		
		EnumerableI
	{
		public Enumerable(IEnumerable<Positive> val) : base(val)
		{

		}

		public IEnumerator<Positive> GetEnumerator()
		{
			return boxed.GetEnumerator();
			throw new NotImplementedException();
		}

		public Positive[] toArr()
		{
			return boxed.ToArray();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
