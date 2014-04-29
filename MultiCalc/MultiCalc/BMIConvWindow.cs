using System;
using Gtk;

namespace MultiCalc
{
	public partial class BMIConvWindow : Gtk.Window
	{
		public BMIConvWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

		}

		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			double a, b, c;

			a = Convert.ToDouble (num1.Text);
			b = Convert.ToDouble (num2.Text);

			b = b * 0.01;

			c = a / (b * b);

			c = Math.Round (c, 2);

			num3.Text = c.ToString ();

			if (c < 18.5) {
				label5.Text = "...Underweight...";
			}
			if (c >= 18.5 && c < 25) {
				label5.Text = "...Normal weight...";
			}
			if (c >= 25 && c < 30) {
				label5.Text = "...Overweight...";
			}
			if (c >= 30 && c < 40) {
				label5.Text = "...Obese...";
			}
			if (c >= 40) {
				label5.Text = "...Severely Obese...";
			}
		}
	}
}

