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
			//Declaration of the variables needed for the calculator
			double a, b, c;

			//Takes the users input in the 2 entry-boxes and instantiates them in variable a and b 
			//(and converts them to Double-datatypes in the process)
			a = Convert.ToDouble (num1.Text);
			b = Convert.ToDouble (num2.Text);

			//the value of b is moved two decimalpoints in order to fit it
			//into the formula
			b = b * 0.01;

			//The actual formula: Weight (kg)/Height (m)^2
			c = a / (b * b);

			//The result is rounded up to only hold 2 decimals after the point
			c = Math.Round (c, 2);

			//Casting c to a string, displayed in third entry-box
			num3.Text = c.ToString ();

			//A list of if-statements, outputting the relevant statement to the user
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


		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			//All boxes and labels are cleared (filled with nothing) for the user to start over
			num1.Text = num2.Text = num3.Text = label5.Text = "";
		}
	}
}

