using System;
using Gtk;

namespace MultiCalc
{
	public partial class SpeedConvWindow : Gtk.Window
	{
		public SpeedConvWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButtonCalc1Clicked (object sender, EventArgs e)
		{
			//Kilometers per hour to miles per hour
			//Creates two variables of the type double
			double kph, mph;

			kph = Convert.ToDouble (entryKPH.Text);
			//Formula that convert kph to mph
			mph = kph / 1.6093;

			//Makes the number into a string and store it in the label
			label21.Text =  mph.ToString ();
		}

		protected void OnButtonCalc2Clicked (object sender, EventArgs e)
		{
			//Miles per hour to kilometers per hour
			//Creates two variables of the type double
			double kph2, mph2;

			mph2 = Convert.ToDouble (entryMPH.Text);
			//Formula that convert mph to kph
			kph2 = mph2 * 1.6093;

			//Makes the number into a string and store it in the label
			label22.Text =  kph2.ToString ();		
		}

		protected void OnButtonClear1Clicked (object sender, EventArgs e)
		{
			//Clear the old data from the fields
			entryKPH.Text = label21.Text = "";
		}

		protected void OnButtonClear2Clicked (object sender, EventArgs e)
		{
			//Clear the old data from the fields
			entryMPH.Text = label22.Text = "";

		}
	}
}

