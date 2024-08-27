using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj._slider_;
using N = nilnul.NumI1;

namespace nilnul.num.stream_
{
	

	public interface SliderI4
		:
		nilnul.num.StreamI6
		,
		nilnul.obj.stream_.SliderI<Num1>
	{
	}
	/// <summary>
	/// stream is built on cursor.
	/// </summary>
	public abstract class SliderA :
		nilnul.obj.stream_.SliderA<Num1>
		,
		SliderI4
	{
		
	}



}
