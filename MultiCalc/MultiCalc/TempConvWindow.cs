using System;
using Gtk;

namespace MultiCalc
{
	public partial class TempConvWindow : Gtk.Window
	{
		public TempConvWindow () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButtonCalc1Clicked (object sender, EventArgs e)
		{
			//Celsius to Fahrenheit
			//Created two variable of the type double
			double cel, fah;

			cel = Convert.ToDouble (entryCelsius.Text);
			//Formula that converts celsius to fahrenheit
			fah = cel * 9 / 5 + 32;

			labelFahrenheit.Text =  fah.ToString ();
		}

		protected void OnButtonCalc2Clicked (object sender, EventArgs e)
		{
			//Fahrenheit to Celsius
			//Created two variable of the type double
			double cel2, fah2;

			fah2 = Convert.ToDouble (entryFahrenheit.Text);
			//Formula that converts fahrenheit to celsius
			cel2 = (fah2 - 32) * 5 / 9;

			labelCelsius.Text =  cel2.ToString ();
		}

		protected void OnButtonClear1Clicked (object sender, EventArgs e)
		{
			//Clear the fields for old data
			labelFahrenheit.Text = entryCelsius.Text = "";
		}

		protected void OnButtonClear2Clicked (object sender, EventArgs e)
		{
			//Clear the fields for old data
			labelCelsius.Text = entryFahrenheit.Text = "";		}
	}
}

