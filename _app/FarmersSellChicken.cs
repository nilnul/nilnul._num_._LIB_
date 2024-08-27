using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.natural._test._app
{
	[TestClass]
	public class FarmersSellChicken
	{
		[TestMethod]
		public void FarmersSellChicken_Solution()
		{

			for (int priceInMorning =1	; priceInMorning <= 3500; priceInMorning++)
			{
				for (int priceInAfternoon = 1; priceInAfternoon < priceInMorning; priceInAfternoon++)
				{
					for (int soldMorningByA = 0; soldMorningByA <= 10; soldMorningByA++)
					{
						for (int soldMorningByB = 0; soldMorningByB <= 16; soldMorningByB++)
						{
							for (int soldMoningByC = 0; soldMoningByC <= 26; soldMoningByC++)
							{
								var soldAfternoonByA = 10 - soldMorningByA;
								var soldAfternoonByB = 16 - soldMorningByB;
								var soldAfternoonByC = 26 - soldMoningByC;

								if (


									soldMorningByA  *priceInMorning +soldAfternoonByA*priceInAfternoon ==3500

									&&
									soldMorningByB *priceInMorning +soldAfternoonByB*priceInAfternoon==3500

									&&
									
									 soldMoningByC*priceInMorning+ soldAfternoonByC*priceInAfternoon==3500


								)
								{
									Debug.WriteLine(
										"{0}*({1}+{2}+{3}) + {4}*({5}+{6}+{7})"  , 
										priceInMorning,
										soldMorningByA,soldMorningByB,soldMoningByC,
										priceInAfternoon,
										soldAfternoonByA,soldAfternoonByB,soldAfternoonByC
									);
									

									
								}
								
							}
						}
						
					}
					
				}

				
			}
			Trace.WriteLine("");
		}
	}
}
