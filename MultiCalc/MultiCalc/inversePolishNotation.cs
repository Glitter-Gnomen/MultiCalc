using System;

namespace MultiCalc
{
	public partial class inversePolishNotation : Gtk.Window
	{
		public inversePolishNotation () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButton0Clicked (object sender, EventArgs e)
		{
			Console.WriteLine ("Test");
		}
	}
}

