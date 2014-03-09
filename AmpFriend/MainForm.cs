/*
 * Created by SharpDevelop.
 * User: boyer
 * Date: 12/6/2013
 * Time: 8:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AmpFriend
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox theBox = (sender as TextBox);
			
			if (!char.IsControl(e.KeyChar) 
		        && !char.IsDigit(e.KeyChar) 
		        && e.KeyChar != '.')
		    {
		        e.Handled = true;
		    }
		
		    // only allow one decimal point
		    if (e.KeyChar == '.' 
		        && theBox.Text.IndexOf('.') > -1)
		    {
		        e.Handled = true;
		    }
		   
		}
		
		void TextBox1KeyUp(object sender, KeyEventArgs e)
		{
			TextBox theBox = (sender as TextBox);
		    // Assuming we're all numbers, let's do the maths!
		    if (!theBox.Text.Equals("")) {
		    	label6.Text = Maths.findPFromRMS(decimal.Parse(theBox.Text), 2).ToString() + " W";
		    	label7.Text = Maths.findPFromRMS(decimal.Parse(theBox.Text), 4).ToString() + " W";
		    	label8.Text = Maths.findPFromRMS(decimal.Parse(theBox.Text), 8).ToString() + " W";
		    	label9.Text = Maths.findPFromRMS(decimal.Parse(theBox.Text), 16).ToString() + " W";
		    }
		    else {
		    	label6.Text = "";
		    	label7.Text = "";
		    	label8.Text = "";
		    	label9.Text = "";
		    }
		}
		
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox theBox = (sender as TextBox);
			
			if (!char.IsControl(e.KeyChar) 
		        && !char.IsDigit(e.KeyChar) 
		        && e.KeyChar != '.')
		    {
		        e.Handled = true;
		    }
		
		    // only allow one decimal point
		    if (e.KeyChar == '.' 
		        && theBox.Text.IndexOf('.') > -1)
		    {
		        e.Handled = true;
		    }
		}
		
		void TextBox2KeyUp(object sender, KeyEventArgs e)
		{
			TextBox theBox = (sender as TextBox);
		    // Assuming we're all numbers, let's do the maths!
		    if (!theBox.Text.Equals("")) {
		    	label11.Text = Maths.findRMSFromP(double.Parse(theBox.Text), 2).ToString() + " VRMS";
		    	label12.Text = Maths.findRMSFromP(double.Parse(theBox.Text), 4).ToString() + " VRMS";
		    	label13.Text = Maths.findRMSFromP(double.Parse(theBox.Text), 8).ToString() + " VRMS";
		    	label14.Text = Maths.findRMSFromP(double.Parse(theBox.Text), 16).ToString() + " VRMS";
		    }
		    else {
		    	label11.Text = "";
		    	label12.Text = "";
		    	label13.Text = "";
		    	label14.Text = "";
		    }
		}
	}
}
