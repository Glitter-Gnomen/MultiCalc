using System;
using Gtk;

namespace MultiCalc
{
	public partial class SavingsCalc : Gtk.Window
	{
		public SavingsCalc () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			//All variables are declared as doubles
			double deposit, rate, terms, FTV;

			//All inputs are instantiated in those variables
			deposit = Convert.ToDouble (num1.Text);
			rate = Convert.ToDouble (num2.Text);
			terms = Convert.ToDouble (num3.Text);

			//Rate is manipulated to be handable in the formula
			rate = rate * 0.01;

			//The actual formula is stored in FTV: Kn = Ko * (1 + r)^n
			FTV = deposit * Math.Pow ((1 + rate), terms);

			//The future value is rounded up to only hold two decimals
			FTV = Math.Round (FTV, 2);

			//The Future Value is printed to the screen
			label5.Text = "Future Value: " + FTV.ToString ();
		}

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			//All boxes are cleared/nothing is stored in all entry-boxes
			num1.Text = num2.Text = num3.Text = label5.Text = "";
		}

	}
}

