using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumberToWord
{
	public partial class NumberToWord : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			lblmsg.Visible = false;
		}

		public static string NumberToWords(int number)
		{
			if (number == 0) return "zero";
			if (number <= 0) return "minus" + NumberToWords(Math.Abs(number));
			string words = "";

			// check if number is divisible by 1 million
			if ((number / 1000000) > 0)
			{
				words += NumberToWords(number / 1000000) + " million ";
				number %= 1000000;
			}

			// check if number is divisible by 1 thousand
			if ((number / 1000) > 0)
			{
				words += NumberToWords(number / 1000) + " thousand ";
				number %= 1000;
			}
			// check if number is divisible by 1 hundred
			if ((number / 100) > 0)
			{
				words += NumberToWords(number / 100) + " hundred ";
				number %= 100;
			}

			if (number> 0)
			{
				if (words != "") words += " and ";

				var unitsmap = new[] { "zero", "one", "two", "three", "four", "five", "six",
								"seven", "eight", "nine", "ten", "eleven", "twelve",
								"thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
								"eighteen", "nineteen" };
				var tensmap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty",
								 "sixty", "seventy", "eighty", "ninety" };
				// check if number is within teens
				if (number < 20)
				{
					// fetch the appropriate value from unit array
					words += unitsmap[number];
				}
				else
				{
					// fetch the appropriate value from tens array
					words += tensmap[number / 10];
					if ((number % 10) > 0)
					{
						words += " " + unitsmap[number % 10];
					}
				}
			}
			return words;
		}

		protected void ConvertNumberToWord_Click(object sender, EventArgs e)
		{
			if(txtnotoword.Text == string.Empty)
			{
				lblmsg.Text = "Please Enter Number";
				lblmsg.Visible = true;
			}
			else
			{
				lblmsg.Visible = false;
				lblResult.Text = NumberToWords(Convert.ToInt32(txtnotoword.Text));
			}
		}
	}
}