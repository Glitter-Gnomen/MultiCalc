
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Label label1;
	private global::Gtk.VBox vbox2;
	private global::Gtk.VBox vbox4;
	private global::Gtk.Button button5;
	private global::Gtk.Button button6;
	private global::Gtk.Button button7;
	private global::Gtk.Button button4;
	private global::Gtk.VBox vbox3;
	private global::Gtk.Button button3;
	private global::Gtk.Button button2;
	private global::Gtk.Button button1;
	private global::Gtk.Button buttonTemperature;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("MultiCalc");
		this.vbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.button5 = new global::Gtk.Button ();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString ("Inverse Polish Notation");
		this.vbox4.Add (this.button5);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.button5]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.button6 = new global::Gtk.Button ();
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.vbox4.Add (this.button6);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.button6]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.button7 = new global::Gtk.Button ();
		this.button7.CanFocus = true;
		this.button7.Name = "button7";
		this.button7.UseUnderline = true;
		this.button7.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.vbox4.Add (this.button7);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.button7]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox2.Add (this.vbox4);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox4]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button ();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString ("BMICalc");
		this.vbox2.Add (this.button4);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.button4]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button ();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString ("Single-SavingCalc");
		this.vbox3.Add (this.button3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.button3]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("Multiple-SavingsCalc");
		this.vbox3.Add (this.button2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.button2]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString ("DebtCalc");
		this.vbox3.Add (this.button1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.button1]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox3]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.buttonTemperature = new global::Gtk.Button ();
		this.buttonTemperature.CanFocus = true;
		this.buttonTemperature.Name = "buttonTemperature";
		this.buttonTemperature.UseUnderline = true;
		this.buttonTemperature.Label = global::Mono.Unix.Catalog.GetString ("Temperature Converter");
		this.vbox1.Add (this.buttonTemperature);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonTemperature]));
		w12.Position = 2;
		w12.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 318;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button5.Clicked += new global::System.EventHandler (this.OnButton5Clicked);
		this.button4.Clicked += new global::System.EventHandler (this.OnButton4Clicked);
		this.button3.Clicked += new global::System.EventHandler (this.OnButton3Clicked);
		this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
		this.buttonTemperature.Clicked += new global::System.EventHandler (this.OnButtonTemperatureClicked);
	}
}
