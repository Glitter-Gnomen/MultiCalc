using System;
using Gtk;

namespace MultiCalc
{
	public partial class MultiSavingsCalc : Gtk.Window
	{
		public MultiSavingsCalc () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			//The needed variables are declared - all of them as doubles as they are to
			//Be used with Math.Pow
			double deposit, rate, terms, FTV;

			//These lines takes the input from the user and instantiates the values in the variables
			deposit = Convert.ToDouble (num1.Text);
			rate = Convert.ToDouble (num2.Text);
			terms = Convert.ToDouble (num3.Text);

			//Moves the point of the rate-variable 2 times in order for it to be handable
			//in the formula
			rate = rate * 0.01;

			//The actual calculation. The formula: An = b * (((1+r)^n - 1) / r)
			FTV = deposit * ((Math.Pow ((1 + rate), terms) - 1) / rate);

			//The Future Value is rounded up to only hold two decimals
			FTV = Math.Round (FTV, 2);

			//The future value is printed to label5, typecastet to string
			label5.Text = "Future Value: " + FTV.ToString ();
		}

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			//All entry-boxes are cleared by "putting nothing" into them
			num1.Text = num2.Text = num3.Text = label5.Text = "";
		}
	}
}

