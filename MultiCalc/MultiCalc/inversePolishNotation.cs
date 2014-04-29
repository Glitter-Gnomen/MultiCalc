//Inverse Polish Notation style calculator 
//v1.2 with GUI in Gtk#

using System;

namespace MultiCalc
{
	//Gtk# Window Class
	public partial class inversePolishNotation : Gtk.Window
	{
		//Declaration of the variables used througout the program
		double var1, var2, result;
		public inversePolishNotation () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		//Addition operation
		protected void OnButtonPlusClicked (object sender, EventArgs e)
		{
			//Instatiation of variables through a user input
			//The input is is regarded as a string, through typecasting this is converted to type double
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			//Calculation of the result
			result = var1 + var2;
			//The result is converted to a string and parsed to a entry field
			entry3.Text = result.ToString ();

		}
		//Modulus operation
		protected void OnButtonModulusClicked (object sender, EventArgs e)
		{
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			result = var1 % var2;
			entry3.Text = result.ToString ();
		}
		//Division operation
		protected void OnButtonDivideClicked (object sender, EventArgs e)
		{
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			result = var1 / var2;
			entry3.Text = result.ToString ();
		}
		//Multiplying operation
		protected void OnButtonMultiplyClicked (object sender, EventArgs e)
		{
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			result = var1 * var2;
			entry3.Text = result.ToString ();
		}
		//Subtraction operation
		protected void OnButtonMinusClicked (object sender, EventArgs e)
		{
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			result = var1 - var2;
			entry3.Text = result.ToString ();
		}
	}
}