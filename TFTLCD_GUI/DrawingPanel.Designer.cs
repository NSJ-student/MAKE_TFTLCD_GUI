namespace TFTLCD_GUI
{
	partial class DrawingPanel
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
			this.SuspendLayout();
			// 
			// DrawingPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(320, 240);
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DrawingPanel";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "DrawingPanel";
			this.SizeChanged += new System.EventHandler(this.DrawingPanel_SizeChanged);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DrawingPanel_KeyUp);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseUp);
			this.ParentChanged += new System.EventHandler(this.DrawingPanel_ParentChanged);
			this.ResumeLayout(false);

		}

		#endregion
	}
}