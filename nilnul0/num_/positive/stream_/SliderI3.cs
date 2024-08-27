using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj._slider_;
using N = nilnul.NumI1;

namespace nilnul.num_.positive.stream_
{
	

	public interface SliderI2
		:
		nilnul.num_.positive.StreamI1
		,
		nilnul.obj.stream_.SliderI<num_.Positive1>
	{
	}
	/// <summary>
	/// stream is built on cursor.
	/// </summary>
	public abstract class SliderA2 :
		nilnul.obj.stream_.SliderA<num_.Positive1>
		,
		SliderI2
	{
		
	}



}
