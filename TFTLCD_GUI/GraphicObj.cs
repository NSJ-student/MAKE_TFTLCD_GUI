using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TFTLCD_GUI
{
    public enum GraphicType { Image, Circle, Rectangle, Text };
    public class GraphicObj
	{
		static int ObjCount = 0;
		public Color LineColor;
		public Color FillColor;
		public GraphicType ObjType;	// 그래픽 종류
		public object Obj;			// 그릴 대상
		public Point ObjPos;		// 위치
		public Size ObjSize;		// 사이즈
		public Size ObjOffset;
		public string Name;
		bool Selected;

		public GraphicObj(OBjInfo info, Rectangle r)
		{
			ObjType = info.ObjType;
			if(ObjType == GraphicType.Image)
			{
				Obj = info.ObjImage;
			}
			else if(ObjType == GraphicType.Text)
			{
				Obj = info.ObjString;
				r.Height = 20;
			}
			else
			{
				Obj = null;
			}
			LineColor = info.LineColor;
			FillColor = info.ObjColor;

			ObjPos.X = r.Left;
			ObjPos.Y = r.Top;

			ObjSize.Width = r.Width;
			ObjSize.Height = r.Height;

			ObjOffset.Width = 0;
			ObjOffset.Height = 0;

			Selected = false;
			Name = "OBJ_NUM" + ObjCount;
			ObjCount++;
		}

		public void Draw(PaintEventArgs e)
		{
			if (ObjSize.Width == 0 || ObjSize.Height == 0)
				return;

			Rectangle rect = new Rectangle(
				ObjPos.X + ObjOffset.Width, 
				ObjPos.Y + ObjOffset.Height,
				ObjSize.Width, 
				ObjSize.Height);

			Pen pen = new Pen(LineColor);
			Brush brush = null;
			if (Selected)
			{
				pen.DashStyle = DashStyle.Dash;
			}
			else
			{
				pen.DashStyle = DashStyle.Solid;
			}
			if(FillColor != Color.Empty)
			{
				brush = new SolidBrush(FillColor);
			}

			switch (ObjType)
			{
				case GraphicType.Rectangle:
					if (brush != null)
					{
						e.Graphics.FillRectangle(brush, rect);
					}
					e.Graphics.DrawRectangle(pen, rect);
					break;
				case GraphicType.Circle:
					if (brush != null)
					{
						e.Graphics.FillEllipse(brush, rect);
					}
					e.Graphics.DrawEllipse(pen, rect);
					break;
				case GraphicType.Image:
					if (Obj == null) return;
					e.Graphics.DrawImage((Image)Obj, rect);
					if (Selected) e.Graphics.DrawRectangle(pen, rect);
					break;
				case GraphicType.Text:
					if (Obj == null) return;
					e.Graphics.DrawString((string)Obj, 
										new Font(SystemFonts.StatusFont, FontStyle.Bold), 
										Brushes.Black,
										rect);
					if (Selected) e.Graphics.DrawRectangle(pen, rect);
					break;
			}
		}

		public bool IsObjArea(int x, int y)
		{
			if ((x >= ObjPos.X) && (x <= ObjPos.X + ObjSize.Width))
			{
				if ((y >= ObjPos.Y) && (y <= ObjPos.Y + ObjSize.Height))
				{
					Selected = true;
					return true;
				}
			}
			return false;
		}

		public void SetSelected(bool sel)
		{
			Selected = sel;
		}

		public void ResetPosition(int x_moved, int y_moved)
		{
			ObjOffset.Width = x_moved;
			ObjOffset.Height = y_moved;
		}

		public void ResetDone()
		{
			ObjPos.X += ObjOffset.Width;
			ObjPos.Y += ObjOffset.Height;
			ObjOffset.Width = 0;
			ObjOffset.Height = 0;
		}
	}
}
