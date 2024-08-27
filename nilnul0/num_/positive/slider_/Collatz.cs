using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using nilnul._num.bigint.be;
using nilnul.num._num.bigint.be;
using nilnul.obj._slider_;
using nilnul.obj.stream_._slider._cursor_;
using N = nilnul._num.bigint.be.Natural.Asserted;
using P = nilnul.num_.Positive1;

namespace nilnul.num_.positive.slider_
{
	/// <summary>
	/// 它似乎最早出现在美国，具体出处不详，已知的，从西拉古斯大学大学传到贝尔实验室，再到芝加哥大学。因早期有众多的传播者，所以在传播过程中，3x+1猜想收获了许多名字：考拉兹猜想、乌拉姆(Ulam)问题、角谷静夫猜想等。
	/// </summary>
	/// <remarks>
	/// 我们甚至还没搞清，数列本身是否有界
	/// </remarks>
	public class Collatz1:SliderI1
		,
		nilnul.num.SliderI3

	{
		

		private P _current;

		

		public P current
		{
			get
			{
				return  _current;
			}
		}

		//NumI1 CurrentI<NumI1>.current => 

		//NumI1 obj.stream_._slider._cursor_.CurrentI<NumI1>.current => current;

		NumI1 obj.stream_._slider._skid_.CurrentI<NumI1>.current => current;

		

		public Collatz1( P p)
		{
			_current = p;

		}

		public Collatz1(NumI1 num):this(new P(num))
		{
		}

		/// <summary>
		/// collatz conjecture states that this always reach the cycle 1,2,4,1,...
		/// </summary>
		public void moveNext()
		{
			var half = _current.en % 2;
			_current = new P( half==0 ?half: 3*_current.en +1);
		}

		
	}
}
