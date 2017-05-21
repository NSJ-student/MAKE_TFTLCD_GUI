using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace TFTLCD_GUI
{
	public delegate void ReDraw();
	public delegate void SetFormSize(int w, int h);
	public delegate void SetFormColor(Color clr);
	public delegate void DisplayObjInfo(GraphicObj obj);
	public delegate void DisplayClientInfo(int w, int h);
	public delegate bool ControlDrawing(int cmd);
	public enum ObjColorType { Line, Fill };
	public class OBjInfo
	{
		public GraphicType ObjType;
		public Bitmap ObjImage;
		public string ObjString;
		public Color LineColor;
		public Color ObjColor;
		public Point ObjLocation;
		public Size ObjSize;
		
		public OBjInfo()
		{
			ObjType = GraphicType.Rectangle;
			ObjImage = null;
			ObjString = null;
			LineColor = Color.Red;
			ObjColor = Color.Empty;
			ObjLocation = new Point();
			ObjSize = new Size();
		}
		public bool IsDrawable()
		{
			if(ObjType == GraphicType.Image)
			{
				if(ObjImage == null)
				{
					return false;
				}
			}
			if (ObjType == GraphicType.Text)
			{
				if (ObjString == "")
				{
					return false;
				}
			}
			return true;
		}
		public void SetObjInfo(int x, int y, int w, int h)
		{
			ObjLocation.X = x;
			ObjLocation.Y = y;
			ObjSize.Width = w;
			ObjSize.Height = h;
		}
		public void DrawObj(PaintEventArgs e)
		{
			if (ObjSize.Width == 0 || ObjSize.Height == 0)
				return;

			Rectangle rect = new Rectangle(ObjLocation.X, ObjLocation.Y,
											ObjSize.Width, ObjSize.Height);
			Pen pen = new Pen(LineColor);
			Brush brush = null;
			if (ObjColor != Color.Empty)
			{
				brush = new SolidBrush(ObjColor);
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
					if (ObjImage == null) return;
					e.Graphics.DrawImage((Image)ObjImage, rect);
					break;
				case GraphicType.Text:
					if (ObjString == null) return;
					e.Graphics.DrawRectangle(SystemPens.HotTrack, rect);
					e.Graphics.DrawString((string)ObjString,
										new Font(SystemFonts.StatusFont, FontStyle.Bold),
										Brushes.Black,
										rect);
					break;
			}
		}
	}
	public class GraphicObjList
	{
		List<GraphicObj> GraphicList;
		public event ReDraw RedrawObjs;
		public event SetFormSize SetPanelSize;
		public event DisplayObjInfo DisplayObj;
		public event DisplayClientInfo DisplayClient;
		public event SetFormColor SetPanelColor;
		GraphicObj selObj;
		OBjInfo defaultObj;
		Size ClientAreaSize;
		Color BackGroundColor;
		bool bDrawEnable;

		public Color DefaultColor
		{
			get
			{
				return defaultObj.LineColor;
			}
		}

		public GraphicObjList(Size ClientSize)
		{
			GraphicList = new List<GraphicObj>();
			selObj = null;
			defaultObj = new OBjInfo();
			ClientAreaSize = ClientSize;
			BackGroundColor = Color.White;
			bDrawEnable = false;
		}

		public void AddObj(GraphicObj obj)
		{
			GraphicList.Add(obj);
		}
		public void AddObj(Point point, Size size)
		{
			GraphicObj obj = new GraphicObj(defaultObj, new Rectangle(point, size));
			GraphicList.Add(obj);
		}
		public void AddObj(Rectangle rect)
		{
			GraphicObj obj = new GraphicObj(defaultObj, rect);
			GraphicList.Add(obj);
		}
		public void DeleteObj(GraphicObj obj)
		{
			GraphicList.Remove(obj);
			RedrawObjs();
		}
		public void DeleteSelObj()
		{
			if(selObj != null)
			{
				GraphicList.Remove(selObj);
				RedrawObjs();
			}
		}
		public void DeletAllObj()
		{
			GraphicList.Clear();
			RedrawObjs();
		}
		public void DrawObjs(PaintEventArgs e, bool bDrawing)
		{
			foreach(GraphicObj item in GraphicList)
			{
				item.Draw(e);
			}
			if(bDrawing)
			{
				defaultObj.DrawObj(e);
			}
		}
		public bool SelectObj(int x, int y)
		{
			int idx;
			GraphicObj item;
			for(idx = GraphicList.Count-1; idx >= 0; idx--)
			{
				item = GraphicList.ElementAt(idx);
				if (item.IsObjArea(x, y))
				{
					selObj = item;
					item.SetSelected(true);
					DisplayObj(item);
					idx--;
					for (; idx >= 0; idx--)
					{
						item = GraphicList.ElementAt(idx);
						item.SetSelected(false);
					}
					return true;
				}
				else
				{
					item.SetSelected(false);
				}
			}
			selObj = null;
			DisplayObj(null);
			return false;
		}
		public void PrepareDrawing(GraphicType type)
		{
			selObj = null;
			foreach(GraphicObj item in GraphicList)
			{
				item.SetSelected(false);
			}
			SetObjInfo(type);
			bDrawEnable = true;
		}
		public void EndDrawing()
		{
			bDrawEnable = false;
		}
		public bool SetObjInfo(Color clr, ObjColorType type)
		{
			if(selObj != null)
			{
				if (type == ObjColorType.Line) selObj.LineColor = clr;
				else selObj.FillColor = clr;
				RedrawObjs();
				return true;
			}
			else
			{
				if (type == ObjColorType.Line) defaultObj.LineColor = clr;
				else defaultObj.ObjColor = clr;
				RedrawObjs();
				return false;
			}
		}
		public bool SetObjInfo(GraphicType type)
		{
			if (selObj != null)
			{
				selObj.ObjType = type;
				RedrawObjs();
				return true;
			}
			else
			{
				defaultObj.ObjType = type;
				RedrawObjs();
				return false;
			}
		}
		public bool SetObjInfo(Bitmap image)
		{
			if(selObj != null)
			{
				selObj.Obj = image;
				RedrawObjs();
				return true;
			}
			else
			{
				defaultObj.ObjImage = image;
				RedrawObjs();
				return false;
			}
		}
		public bool SetObjInfo(int x, int y, int w, int h)
		{
			if(selObj != null)
			{
				if (selObj.ObjType == GraphicType.Text) h = 20;
				selObj.ObjPos = new Point(x, y);
				selObj.ObjSize = new Size(w, h);
				RedrawObjs();
				return true;
			}
			else
			{
				if (defaultObj.ObjType == GraphicType.Text) h = 20;
				defaultObj.SetObjInfo(x, y, w, h);
				RedrawObjs();
				return false;
			}
		}
		public bool SetObjInfo(string text)
		{
			if (selObj != null)
			{
				if (selObj.ObjType == GraphicType.Text)
					selObj.Obj = text;
				RedrawObjs();
				return true;
			}
			else
			{
				if (defaultObj.ObjType == GraphicType.Text)
					defaultObj.ObjString = text;
				RedrawObjs();
				return false;
			}
		}

		public void SetClientAreaSize(int w, int h)
		{
			ClientAreaSize = new Size(w, h);
			DisplayClient(w, h);
			SetPanelSize(w, h);
		}
		public void SetBackGroundColor(Color clr)
		{
			BackGroundColor = clr;
			SetPanelColor(BackGroundColor);
		}

		public void ResetSelObjLocation(int x, int y)
		{
			if (selObj == null) return;
			selObj.ResetPosition(x, y);
			DisplayObj(selObj);
		}
		public void ResetSelObjLocationDone(int x, int y)
		{
			if (selObj == null) return;
			selObj.ResetPosition(x, y);
			selObj.ResetDone();
			DisplayObj(selObj);
		}

		public bool IsDrawable()
		{
			return (defaultObj.IsDrawable() && bDrawEnable);
		}
		public bool IsMoveable()
		{
			return (selObj != null)&&(!bDrawEnable);
		}
		
		public void SetClientSize(int w, int h)
		{
			DisplayClient?.Invoke(w, h);
		}

		public void MakeSourceFile()
		{
			string def = "#define ";
			string header = "";

			string FileName = "image.c";
			FileStream file = File.Create(FileName);
			StreamWriter writer = new StreamWriter(file);

			writer.WriteLine("void Main_GUI(void)");
			writer.WriteLine("{");
			writer.WriteLine("\tRECT rect;");
			writer.WriteLine();
			foreach (GraphicObj obj in GraphicList)
			{
				if (obj.ObjType == GraphicType.Rectangle)
				{
					writer.WriteLine(SetRectStr(obj.ObjPos, obj.ObjSize));
					writer.WriteLine("\tDraw_Rect(&rect,0x" +
							RGB565Convert(obj.LineColor.R, obj.LineColor.G, obj.LineColor.B).ToString("X")
							+ ");");
				}
				else if (obj.ObjType == GraphicType.Image)
				{
					writer.WriteLine("\tDraw_Object(PATH_" + obj.Name.ToUpper() +
									 ", " + obj.ObjPos.X.ToString() +
									 ", " + obj.ObjPos.Y.ToString() + ");");
					header += def + "PATH_" + obj.Name.ToUpper() + "\t\"0:\\Image\\" + obj.Name + ".bin\"\r\n";
				}
				else if(obj.ObjType == GraphicType.Text)
				{
					writer.WriteLine("\tGUI_Text(\"" + (string)obj.Obj +
									 "\", " + obj.ObjPos.X.ToString() +
									 ", " + obj.ObjPos.Y.ToString() + ");");
				}
			}
			writer.WriteLine("}");

			writer.Close();
			file.Close();

			FileName = "image.h";
			file = File.Create(FileName);
			writer = new StreamWriter(file);

			//			writer.WriteLine("#ifndef __" + tbFileName.Text.ToUpper() + "__");
			//			writer.WriteLine("#define __" + tbFileName.Text.ToUpper() + "__");
			writer.WriteLine("#ifndef __IMAGE_H__");
			writer.WriteLine("#define __IMAGE_H__");
			writer.WriteLine();
			writer.WriteLine();
			writer.WriteLine(header);
			writer.WriteLine();
			writer.WriteLine("#endif /* __IMAGE_H__ */");

			writer.Close();
			file.Close();
			MessageBox.Show("Done!");
		}

		private string SetRectStr(Point StartPos, Size ObjSize)
		{
			string SetRect = "\trect.x = " + StartPos.X + ";";
			SetRect += "\trect.y = " + StartPos.Y + ";";
			SetRect += "\trect.width = " + ObjSize.Width + ";";
			SetRect += "\trect.height = " + ObjSize.Height + ";";
			return SetRect;
		}
		private UInt16 RGB565Convert(int red, int green, int blue)
		{
			int temp = (((red >> 3) << 11) | ((green >> 2) << 5) | (blue >> 3));
			return (UInt16)temp;
		}

		/// <summary>
		///  file format
		///  ['G' 'O']
		///	 [ line color length(4) ] [ line color (string) ]
		///	 [ fill color length(4) ] [ fill color (string) ]
		///	 [ object type(1) ]
		///	 [ object x-positon(4) ] [ object y-position(4) ]
		///	 [ object width(4) ] [ object height(4) ]
		/// optional [ 0x00 ] [ text length(4) ] [ text ]
		///  [ 0x0A ]
		///  
		///  위와 같은 내용이 반복됨
		/// </summary>
		public void SaveGraphicObjs()
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Graphic Info Files (*.bin)|*.bin";
			
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				FileInfo file = new FileInfo(dialog.FileName);
				FileStream fStream = file.Create();
				fStream.WriteByte(Convert.ToByte('G'));
				fStream.WriteByte(Convert.ToByte('O'));

				foreach (GraphicObj item in GraphicList)
				{
					if (item.ObjType == GraphicType.Image)
						continue;
					// line color
					byte[] clrlen = BitConverter.GetBytes(item.LineColor.Name.Length);
					fStream.Write(clrlen, 0, 4);
					byte[] line_clr_data = Encoding.UTF8.GetBytes(item.LineColor.Name);
					fStream.Write(line_clr_data, 0, line_clr_data.Length);
					// fill color
					byte[] clrlen2 = BitConverter.GetBytes(item.FillColor.Name.Length);
					fStream.Write(clrlen2, 0, 4);
					byte[] obj_clr_data = Encoding.UTF8.GetBytes(item.FillColor.Name);
					fStream.Write(obj_clr_data, 0, obj_clr_data.Length);
					// write type
					fStream.WriteByte(Convert.ToByte(item.ObjType));
					// position & size
					byte[] xpos = BitConverter.GetBytes(item.ObjPos.X);
					fStream.Write(xpos, 0, 4);
					byte[] ypos = BitConverter.GetBytes(item.ObjPos.Y);
					fStream.Write(ypos, 0, 4);
					byte[] width = BitConverter.GetBytes(item.ObjSize.Width);
					fStream.Write(width, 0, 4);
					byte[] height = BitConverter.GetBytes(item.ObjSize.Height);
					fStream.Write(height, 0, 4);
					// string info
					if ((item.Obj != null) && (item.ObjType == GraphicType.Text))
					{
						fStream.WriteByte(0x00);
						byte[] objlen = BitConverter.GetBytes(((string)item.Obj).Length);
						fStream.Write(objlen, 0, 4);
						byte[] string_data = Encoding.UTF8.GetBytes((string)item.Obj);
						fStream.Write(string_data, 0, string_data.Length);
					}
					fStream.WriteByte(0x0A);
				}
				fStream.Close();
				MessageBox.Show("Done!");
			}
		}

		int ReadInt(FileStream fs)
		{
			byte[] arrLen = new byte[4];

			for (int i = 0; i < 4; i++)
			{
				arrLen[i] = Convert.ToByte(fs.ReadByte());
			}
			
			return BitConverter.ToInt32(arrLen, 0);
		}
		string ReadString(FileStream fs, int length)
		{
			byte[] arr = new byte[length];

			for (int i = 0; i < length; i++)
			{
				arr[i] = Convert.ToByte(fs.ReadByte());
			}
			return Encoding.UTF8.GetString(arr);
		}
		public void LoadGraphicObjs()
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Graphic Info Files (*.bin)|*.bin";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				FileInfo file = new FileInfo(dialog.FileName);
				FileStream fStream = file.OpenRead();

				int length = 0;
				string str;
				int objcnt = 0;
				ColorConverter converter = new ColorConverter();
				str = ReadString(fStream, 2);
				if(str.Equals("GO") == false)
				{
					fStream.Close();
					MessageBox.Show("Error : Wrong File Format");
					return;
				}
				while (fStream.Position < fStream.Length)
				{
					OBjInfo info = new OBjInfo();
					length = ReadInt(fStream);
					str = ReadString(fStream, length);
					info.LineColor = (Color)converter.ConvertFromString(str);
					length = ReadInt(fStream);
					str = ReadString(fStream, length);
					if(str.Equals("ff80ffff"))
					{
						info.ObjColor = Color.Empty;
					}
					else
					{
						info.ObjColor = (Color)converter.ConvertFromString(str);
					}
					info.ObjType = (GraphicType)fStream.ReadByte();
					info.ObjLocation.X = ReadInt(fStream);
					info.ObjLocation.Y = ReadInt(fStream);
					info.ObjSize.Width = ReadInt(fStream);
					info.ObjSize.Height = ReadInt(fStream);
					if(fStream.ReadByte() == 0x00)
					{
						length = ReadInt(fStream);
						info.ObjString = ReadString(fStream, length);
						fStream.ReadByte();
					}
					objcnt++;
					Rectangle rect = new Rectangle(info.ObjLocation, info.ObjSize);
					GraphicList.Add(new GraphicObj(info, rect));
				}
				fStream.Close();
				RedrawObjs();
				MessageBox.Show("Done : " + objcnt.ToString() + " Objects Added.");
			}
		}
	}
}
