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
			double kph, mph;

			kph = Convert.ToDouble (entryKPH.Text);
			mph = kph / 1.6093;

			label21.Text =  mph.ToString ();
		}

		protected void OnButtonCalc2Clicked (object sender, EventArgs e)
		{
			//Miles per hour to kilometers per hour
			double kph2, mph2;

			mph2 = Convert.ToDouble (entryMPH.Text);
			kph2 = mph2 * 1.6093;

			label22.Text =  kph2.ToString ();		
		}

		protected void OnButtonClear1Clicked (object sender, EventArgs e)
		{
			entryKPH.Text = label21.Text = "";
		}

		protected void OnButtonClear2Clicked (object sender, EventArgs e)
		{
			entryMPH.Text = label22.Text = "";

		}
	}
}

