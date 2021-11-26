/*
 * Created by SharpDevelop.
 * User: JUAN PABLO
 * Date: 26/11/2021
 * Time: 02:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace holamundov2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Button btnsaludar;
		private System.Windows.Forms.Label lblsaludo;
		private System.Windows.Forms.RadioButton rbtnrojo;
		private System.Windows.Forms.RadioButton rbtnverde;
		private System.Windows.Forms.RadioButton rbtnazul;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.btnsaludar = new System.Windows.Forms.Button();
			this.lblsaludo = new System.Windows.Forms.Label();
			this.rbtnrojo = new System.Windows.Forms.RadioButton();
			this.rbtnverde = new System.Windows.Forms.RadioButton();
			this.rbtnazul = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// txtnombre
			// 
			this.txtnombre.Location = new System.Drawing.Point(15, 14);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(252, 20);
			this.txtnombre.TabIndex = 0;
			// 
			// btnsaludar
			// 
			this.btnsaludar.Location = new System.Drawing.Point(71, 91);
			this.btnsaludar.Name = "btnsaludar";
			this.btnsaludar.Size = new System.Drawing.Size(143, 91);
			this.btnsaludar.TabIndex = 1;
			this.btnsaludar.Text = "Saludar";
			this.btnsaludar.UseVisualStyleBackColor = true;
			this.btnsaludar.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblsaludo
			// 
			this.lblsaludo.Location = new System.Drawing.Point(15, 41);
			this.lblsaludo.Name = "lblsaludo";
			this.lblsaludo.Size = new System.Drawing.Size(251, 37);
			this.lblsaludo.TabIndex = 2;
			// 
			// rbtnrojo
			// 
			this.rbtnrojo.Location = new System.Drawing.Point(15, 209);
			this.rbtnrojo.Name = "rbtnrojo";
			this.rbtnrojo.Size = new System.Drawing.Size(52, 37);
			this.rbtnrojo.TabIndex = 3;
			this.rbtnrojo.TabStop = true;
			this.rbtnrojo.Text = "Rojo";
			this.rbtnrojo.UseVisualStyleBackColor = true;
			// 
			// rbtnverde
			// 
			this.rbtnverde.Location = new System.Drawing.Point(117, 209);
			this.rbtnverde.Name = "rbtnverde";
			this.rbtnverde.Size = new System.Drawing.Size(56, 37);
			this.rbtnverde.TabIndex = 4;
			this.rbtnverde.TabStop = true;
			this.rbtnverde.Text = "Verde";
			this.rbtnverde.UseVisualStyleBackColor = true;
			// 
			// rbtnazul
			// 
			this.rbtnazul.Location = new System.Drawing.Point(227, 209);
			this.rbtnazul.Name = "rbtnazul";
			this.rbtnazul.Size = new System.Drawing.Size(45, 37);
			this.rbtnazul.TabIndex = 5;
			this.rbtnazul.TabStop = true;
			this.rbtnazul.Text = "Azul";
			this.rbtnazul.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.rbtnazul);
			this.Controls.Add(this.rbtnverde);
			this.Controls.Add(this.rbtnrojo);
			this.Controls.Add(this.lblsaludo);
			this.Controls.Add(this.btnsaludar);
			this.Controls.Add(this.txtnombre);
			this.Name = "MainForm";
			this.Text = "holamundov2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
