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

			//These lines makes it possible for the 
			deposit = Convert.ToDouble (num1.Text);
			rate = Convert.ToDouble (num2.Text);
			terms = Convert.ToDouble (num3.Text);

			rate = rate * 0.01;

			FTV = deposit * ((Math.Pow ((1 + rate), terms) - 1) / rate);

			FTV = Math.Round (FTV, 2);

			label5.Text = "Future Value: " + FTV.ToString ();
		}

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			num1.Text = num2.Text = num3.Text = label5.Text = "";
		}
	}
}

