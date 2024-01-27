namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.radButton5 = new Telerik.WinControls.UI.RadButton();
			((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
			this.SuspendLayout();
			// 
			// radButton5
			// 
			this.radButton5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.radButton5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
			this.radButton5.ForeColor = System.Drawing.Color.Black;
			this.radButton5.Image = global::WindowsFormsApp1.Properties.Resources.add_45_24;
			this.radButton5.Location = new System.Drawing.Point(109, 169);
			this.radButton5.Name = "radButton5";
			this.radButton5.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			// 
			// 
			// 
			this.radButton5.RootElement.ForeColor = System.Drawing.Color.Black;
			this.radButton5.RootElement.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.radButton5.Size = new System.Drawing.Size(133, 30);
			this.radButton5.TabIndex = 155;
			this.radButton5.Text = "خه‌زن ";
			this.radButton5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
			((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).Image = global::WindowsFormsApp1.Properties.Resources.add_45_24;
			((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
			((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).Text = "خه‌زن ";
			((Telerik.WinControls.UI.RadButtonElement)(this.radButton5.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			((Telerik.WinControls.Primitives.TextPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = System.Drawing.Color.Black;
			((Telerik.WinControls.Primitives.BorderPrimitive)(this.radButton5.GetChildAt(0).GetChildAt(2))).ForeColor = System.Drawing.SystemColors.HotTrack;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.radButton5);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Telerik.WinControls.UI.RadButton radButton5;
	}
}

