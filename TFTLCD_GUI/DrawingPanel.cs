using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFTLCD_GUI
{
	public partial class DrawingPanel : Form
	{
		GraphicObjList ObjList;
		private bool resizing = false;
		private Point last = new Point(0, 0);
		
		bool bObjDrawing = false;
		bool bObjMoving = false;
		Point DrawStartPos;
		Point DrawingPos;

		public DrawingPanel(GraphicObjList list)
		{
			InitializeComponent();
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.UserPaint, true);

			this.SetStyle(ControlStyles.ResizeRedraw, true);
			ObjList = list;
		}

		private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
		{
			this.resizing = true;
			this.last = e.Location;

			if (ObjList.IsDrawable())
			{
				if (!bObjDrawing)
				{
					if(ObjList.IsDrawable())
					{
						bObjDrawing = true;

						DrawStartPos.X = e.X;
						DrawStartPos.Y = e.Y;
						DrawingPos.X = e.X;
						DrawingPos.Y = e.Y;
					}
				}
				else
				{
					bObjDrawing = false;
				}
			}
			else
			{
				ObjList.SelectObj(e.X, e.Y);

				if (!bObjMoving && ObjList.IsMoveable())
				{
					bObjMoving = true;

					DrawStartPos.X = e.X;
					DrawStartPos.Y = e.Y;
					DrawingPos.X = e.X;
					DrawingPos.Y = e.Y;
				}
				else
				{
					bObjMoving = false;
				}
			}
			Invalidate();
		}

		private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (ObjList.IsDrawable())
			{
				if (bObjDrawing)
				{
					DrawingPos.X = e.X;
					DrawingPos.Y = e.Y;
					ObjList.SetObjInfo(
									Math.Min(DrawingPos.X, DrawStartPos.X),
									Math.Min(DrawingPos.Y, DrawStartPos.Y),
									Math.Abs(DrawStartPos.X - DrawingPos.X),
									Math.Abs(DrawStartPos.Y - DrawingPos.Y));
					Invalidate();
				}
			}
			else
			{
				if (bObjMoving && ObjList.IsMoveable())
				{
					DrawingPos.X = e.X;
					DrawingPos.Y = e.Y;
					ObjList.ResetSelObjLocation(
									(DrawingPos.X - DrawStartPos.X),
									(DrawingPos.Y - DrawStartPos.Y));
					Invalidate();
				}
			}
			if (!resizing) // handle cursor type
			{
				bool resize_x = e.X > (this.Width - 8);
				bool resize_y = e.Y > (this.Height - 8);

				if (resize_x && resize_y)
					this.Cursor = Cursors.SizeNWSE;
				else if (resize_x)
					this.Cursor = Cursors.SizeWE;
				else if (resize_y)
					this.Cursor = Cursors.SizeNS;
				else this.Cursor = Cursors.Default;
			}
			else // handle resize
			{
				int w = this.Size.Width;
				int h = this.Size.Height;

				if (this.Cursor.Equals(Cursors.SizeNWSE))
					this.Size = new Size(w + (e.Location.X - this.last.X), h + (e.Location.Y - this.last.Y));
				else if (this.Cursor.Equals(Cursors.SizeWE))
					this.Size = new Size(w + (e.Location.X - this.last.X), h);
				else if (this.Cursor.Equals(Cursors.SizeNS))
					this.Size = new Size(w, h + (e.Location.Y - this.last.Y));

				this.last = e.Location;
			}
		}

		private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.resizing = false;
			if (ObjList.IsDrawable())
			{
				if (bObjDrawing)
				{
					bObjDrawing = false;
					DrawingPos.X = e.X;
					DrawingPos.Y = e.Y;

					Rectangle rect = new Rectangle(
									Math.Min(DrawingPos.X, DrawStartPos.X),
									Math.Min(DrawingPos.Y, DrawStartPos.Y),
									Math.Abs(DrawStartPos.X - DrawingPos.X),
									Math.Abs(DrawStartPos.Y - DrawingPos.Y));
					ObjList.AddObj(rect);
					Invalidate();
				}
			}
			else
			{
				if (bObjMoving && ObjList.IsMoveable())
				{
					bObjMoving = false;
					DrawingPos.X = e.X;
					DrawingPos.Y = e.Y;
					ObjList.ResetSelObjLocationDone(
									(DrawingPos.X - DrawStartPos.X),
									(DrawingPos.Y - DrawStartPos.Y));
					Invalidate();
				}
			}
		}

		private void DrawingPanel_ParentChanged(object sender, EventArgs e)
		{

		}
		private void DrawingPanel_KeyUp(object sender, KeyEventArgs e)
		{
			if((e.KeyData & Keys.Delete) != 0)
			{
				ObjList.DeleteSelObj();
			}
		}

		private void DrawingPanel_Paint(object sender, PaintEventArgs e)
		{
			ObjList.DrawObjs(e, bObjDrawing);
		}

		private void DrawingPanel_SizeChanged(object sender, EventArgs e)
		{
			ObjList.SetClientSize(this.Size.Width, this.Size.Height);
		}
	}
}
