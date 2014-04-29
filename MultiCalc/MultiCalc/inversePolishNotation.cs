using System;

namespace MultiCalc
{
	public partial class inversePolishNotation : Gtk.Window
	{
		double var1, var2, result;
		public inversePolishNotation () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}


		protected void OnButtonPlusClicked (object sender, EventArgs e)
		{
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			result = var1 + var2;
			entry3.Text = result.ToString ();
		}

		protected void OnButtonModulusClicked (object sender, EventArgs e)
		{
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			result = var1 % var2;
			entry3.Text = result.ToString ();
		}

		protected void OnButtonDivideClicked (object sender, EventArgs e)
		{
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			result = var1 / var2;
			entry3.Text = result.ToString ();
		}

		protected void OnButtonMultiplyClicked (object sender, EventArgs e)
		{
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			result = var1 * var2;
			entry3.Text = result.ToString ();
		}

		protected void OnButtonMinusClicked (object sender, EventArgs e)
		{
			var1 = Convert.ToDouble (entry1.Text);
			var2 = Convert.ToDouble (entry2.Text);
			result = var1 - var2;
			entry3.Text = result.ToString ();
		}
	}
}

