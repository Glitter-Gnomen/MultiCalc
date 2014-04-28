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
		new MultiCalc.ConverterWindow ();
	}

	protected void OnButtonSpeedClicked (object sender, EventArgs e)
	{
		new MultiCalc.SpeedConvWindow ();
	}

	protected void OnButtonTemperatureClicked (object sender, EventArgs e)
	{
		new MultiCalc.TempConvWindow ();
	}
}
