using System;
using Gtk;

namespace MultiCalc
{
	public partial class ConverterWindow : Gtk.Window
	{
		public ConverterWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

		}

		protected void OnButtonConvertClicked (object sender, EventArgs e)
		{

			//Convert from Cm to M and Km

			double cm, m, km;

			cm = Convert.ToDouble (entryCM.Text);
	
			m = cm / 100;
			km = cm / 100000;

			labelM.Text = "Meters (m): " + m.ToString ();
			labelKM.Text = "Kilometers (km): " + km.ToString ();
		

		}

		protected void OnButtonClearClicked (object sender, EventArgs e)
		{
			entryCM.Text = "";
			labelM.Text = "Meters (m): ";
			labelKM.Text = "Kilometers (km): ";		
		}

		protected void OnButtonConvert2Clicked (object sender, EventArgs e)
		{
			//Convert from M to Cm and Km

			double cm2, m2, km2;

			m2 = Convert.ToDouble (entryM2.Text);

					cm2 = m2 * 100;
					km2 = m2 / 1000;

			label8.Text = "Centimeters (cm): " + cm2.ToString ();
			label10.Text = "Kilometers (km): " + km2.ToString ();
		}

		protected void OnButtonClear2Clicked (object sender, EventArgs e)
		{
			entryM2.Text = "";
			label8.Text = "Centimeters (cm): ";
			label10.Text = "Kilometers (km): ";	
		}

		protected void OnButtonConvert3Clicked (object sender, EventArgs e)
		{
			//Convert from KM to Cm and M

			double cm3, m3, km3;

			km3 = Convert.ToDouble (entryKM3.Text);

			cm3 = km3 * 100000;
			m3 = km3 * 1000;

			label12.Text = "Centimeters (cm): " + cm3.ToString ();
			label32.Text = "Meters (m): " + m3.ToString ();
		}

		protected void OnButton11Clicked (object sender, EventArgs e)
		{
			entryKM3.Text = "";
			label12.Text = "Centimeters (cm): ";
			label32.Text = "Meters (m): ";	
		}
	}


}

