/*
 * Created by SharpDevelop.
 * User: boyer
 * Date: 12/6/2013
 * Time: 8:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace AmpFriend
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private bool rmsVolts = true;
		
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
		
		/// <summary>
		/// Voltage box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void TextBox1KeyUp(object sender, KeyEventArgs e)
		{
			updateWatts();
		}
		
		void updateWatts() {
			TextBox theBox = textBox1;
			
		    // Assuming we're all numbers, let's do the maths!
		    if (!theBox.Text.Equals("") && rmsVolts) {
		    	label6.Text = Maths.findPFromRMS(decimal.Parse(theBox.Text), 2).ToString() + " W";
		    	label7.Text = Maths.findPFromRMS(decimal.Parse(theBox.Text), 4).ToString() + " W";
		    	label8.Text = Maths.findPFromRMS(decimal.Parse(theBox.Text), 8).ToString() + " W";
		    	label9.Text = Maths.findPFromRMS(decimal.Parse(theBox.Text), 16).ToString() + " W";
		    }
		    else if (!theBox.Text.Equals("") && !rmsVolts) {
		    	label6.Text = Maths.findPFromPeak(decimal.Parse(theBox.Text), 2).ToString() + " W";
		    	label7.Text = Maths.findPFromPeak(decimal.Parse(theBox.Text), 4).ToString() + " W";
		    	label8.Text = Maths.findPFromPeak(decimal.Parse(theBox.Text), 8).ToString() + " W";
		    	label9.Text = Maths.findPFromPeak(decimal.Parse(theBox.Text), 16).ToString() + " W";
		    }
		    else {
		    	label6.Text = "";
		    	label7.Text = "";
		    	label8.Text = "";
		    	label9.Text = "";
		    	
		    	return; // Nothing left to do
		    }
		    
		    // Update the opposite volts label
		    label15.Text = rmsVolts ? 
		    	Maths.rms2Peak(double.Parse(theBox.Text)).ToString() + " VP2P" :
		    	Maths.peak2RMS(double.Parse(theBox.Text)).ToString() + " VRMS";
		}
		
		
		/// <summary>
		/// Wattage box validation
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		
		
		/// <summary>
		/// Wattage box handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		
		/// <summary>
		/// RMS Radio Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rb = (RadioButton) sender;
			
			radioButton2.Checked = !rb.Checked;
			rmsVolts = rb.Checked;
			
			updateWatts();
		}
		
		/// <summary>
		/// P2P Radio Button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rb = (RadioButton) sender;
			
			radioButton1.Checked = !rb.Checked;
			rmsVolts = !rb.Checked;
			
			updateWatts();
		}
	}
}
