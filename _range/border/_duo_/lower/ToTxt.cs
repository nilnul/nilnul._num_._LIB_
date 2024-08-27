﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.border._duo_.lower
{
	public class _ToTxtX
	{

		static public string ToTxt(bool openFalseCloseTrue) {
			return openFalseCloseTrue ? "[" : "(";
		}
		static public string ToTxt(Border border) {
			return $"{ToTxt(border.openFalseCloseTrue)}{border.mark}";
		}
	}
}
