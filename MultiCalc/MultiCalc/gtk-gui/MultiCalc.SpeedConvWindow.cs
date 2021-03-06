
// This file has been generated by the GUI designer. Do not modify.
namespace MultiCalc
{
	public partial class SpeedConvWindow
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label1;
		private global::Gtk.Entry entryKPH;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label2;
		private global::Gtk.Label label21;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Button buttonCalc1;
		private global::Gtk.Button buttonClear1;
		private global::Gtk.VBox vbox11;
		private global::Gtk.HBox hbox15;
		private global::Gtk.Label label19;
		private global::Gtk.Label label22;
		private global::Gtk.HBox hbox14;
		private global::Gtk.Label label20;
		private global::Gtk.Entry entryMPH;
		private global::Gtk.HBox hbox13;
		private global::Gtk.Button buttonCalc2;
		private global::Gtk.Button buttonClear2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MultiCalc.SpeedConvWindow
			this.Name = "MultiCalc.SpeedConvWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("SpeedConvWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child MultiCalc.SpeedConvWindow.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Kilometers per hour (km/h): ");
			this.hbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryKPH = new global::Gtk.Entry ();
			this.entryKPH.CanFocus = true;
			this.entryKPH.Name = "entryKPH";
			this.entryKPH.IsEditable = true;
			this.entryKPH.InvisibleChar = '●';
			this.hbox2.Add (this.entryKPH);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entryKPH]));
			w2.Position = 1;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Miles per hour (MPH): ");
			this.hbox3.Add (this.label2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.hbox3.Add (this.label21);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label21]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonCalc1 = new global::Gtk.Button ();
			this.buttonCalc1.CanFocus = true;
			this.buttonCalc1.Name = "buttonCalc1";
			this.buttonCalc1.UseUnderline = true;
			this.buttonCalc1.Label = global::Mono.Unix.Catalog.GetString ("Calculate !");
			this.hbox4.Add (this.buttonCalc1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonCalc1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonClear1 = new global::Gtk.Button ();
			this.buttonClear1.CanFocus = true;
			this.buttonClear1.Name = "buttonClear1";
			this.buttonClear1.UseUnderline = true;
			this.buttonClear1.Label = global::Mono.Unix.Catalog.GetString ("Clear");
			this.hbox4.Add (this.buttonClear1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.buttonClear1]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox11 = new global::Gtk.VBox ();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox15 = new global::Gtk.HBox ();
			this.hbox15.Name = "hbox15";
			this.hbox15.Spacing = 6;
			// Container child hbox15.Gtk.Box+BoxChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("Kilometers per hour (km/h): ");
			this.hbox15.Add (this.label19);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.label19]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox15.Gtk.Box+BoxChild
			this.label22 = new global::Gtk.Label ();
			this.label22.Name = "label22";
			this.hbox15.Add (this.label22);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox15 [this.label22]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox11.Add (this.hbox15);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox15]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox14 = new global::Gtk.HBox ();
			this.hbox14.Name = "hbox14";
			this.hbox14.Spacing = 6;
			// Container child hbox14.Gtk.Box+BoxChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("Miles per hour (MPH): ");
			this.hbox14.Add (this.label20);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.label20]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox14.Gtk.Box+BoxChild
			this.entryMPH = new global::Gtk.Entry ();
			this.entryMPH.CanFocus = true;
			this.entryMPH.Name = "entryMPH";
			this.entryMPH.IsEditable = true;
			this.entryMPH.InvisibleChar = '●';
			this.hbox14.Add (this.entryMPH);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.entryMPH]));
			w14.Position = 1;
			this.vbox11.Add (this.hbox14);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox14]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox11.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox ();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.buttonCalc2 = new global::Gtk.Button ();
			this.buttonCalc2.CanFocus = true;
			this.buttonCalc2.Name = "buttonCalc2";
			this.buttonCalc2.UseUnderline = true;
			this.buttonCalc2.Label = global::Mono.Unix.Catalog.GetString ("Calculate !");
			this.hbox13.Add (this.buttonCalc2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.buttonCalc2]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox13.Gtk.Box+BoxChild
			this.buttonClear2 = new global::Gtk.Button ();
			this.buttonClear2.CanFocus = true;
			this.buttonClear2.Name = "buttonClear2";
			this.buttonClear2.UseUnderline = true;
			this.buttonClear2.Label = global::Mono.Unix.Catalog.GetString ("Clear");
			this.hbox13.Add (this.buttonClear2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.buttonClear2]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox11.Add (this.hbox13);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox13]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			this.vbox2.Add (this.vbox11);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox11]));
			w19.PackType = ((global::Gtk.PackType)(1));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.buttonCalc1.Clicked += new global::System.EventHandler (this.OnButtonCalc1Clicked);
			this.buttonClear1.Clicked += new global::System.EventHandler (this.OnButtonClear1Clicked);
			this.buttonCalc2.Clicked += new global::System.EventHandler (this.OnButtonCalc2Clicked);
			this.buttonClear2.Clicked += new global::System.EventHandler (this.OnButtonClear2Clicked);
		}
	}
}
