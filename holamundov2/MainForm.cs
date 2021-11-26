/*
 * Created by SharpDevelop.
 * User: JUAN PABLO
 * Date: 26/11/2021
 * Time: 02:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace holamundov2
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
		void Button1Click(object sender, EventArgs e)
		{
	
			lblsaludo.Text = "Hola " + txtnombre.Text;
			
			if (rbtnrojo.Checked) {
				
				lblsaludo.ForeColor=Color.Red;
				
			}
			
			else if (rbtnverde.Checked) {
				
				lblsaludo.ForeColor=Color.Green;
				
			}
			
			else if (rbtnazul.Checked) {
				
				lblsaludo.ForeColor=Color.Blue;
				
			}
			
		}
	}
}
