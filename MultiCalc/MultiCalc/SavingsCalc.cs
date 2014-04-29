﻿using System;
using Gtk;

namespace MultiCalc
{
	public partial class SavingsCalc : Gtk.Window
	{
		public SavingsCalc () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			double deposit, rate, terms, FTV;

			deposit = Convert.ToDouble (num1.Text);
			rate = Convert.ToDouble (num2.Text);
			terms = Convert.ToDouble (num3.Text);

			rate = rate * 0.01;

			FTV = deposit * Math.Pow ((1 + rate), terms);

			FTV = Math.Round (FTV, 2);

			label5.Text = "Future Value: " + FTV.ToString ();
		}

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			num1.Text = num2.Text = num3.Text = label5.Text = "";
		}
	}
}
