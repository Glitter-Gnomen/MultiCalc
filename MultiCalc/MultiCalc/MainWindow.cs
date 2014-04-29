using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButtonConverterClicked (object sender, EventArgs e)
	{
		new MultiCalc.MultiSavingsCalc ();
	}

	protected void OnButtonSpeedClicked (object sender, EventArgs e)
	{
		new MultiCalc.SpeedConvWindow ();
	}

	protected void OnButtonTemperatureClicked (object sender, EventArgs e)
	{
		new MultiCalc.TempConvWindow ();
	}

	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		new MultiCalc.BMIConvWindow ();
	}

	protected void OnButton3Clicked (object sender, EventArgs e)
	{
		new MultiCalc.SavingsCalc ();
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		new MultiCalc.MultiSavingsCalc ();
	}

	protected void OnButton5Clicked (object sender, EventArgs e)
	{
		new MultiCalc.inversePolishNotation ();
	}
}
