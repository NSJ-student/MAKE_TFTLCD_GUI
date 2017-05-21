using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TFTLCD_GUI
{
	public partial class Controls : Form
    {
		GraphicObjList ObjList;

		public Controls(GraphicObjList list)
        {
            InitializeComponent();

			btnImageLoad.Enabled = true;
			ObjList = list;
        }

		private void btnObjColor_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if(dialog.ShowDialog() == DialogResult.OK)
			{
				ObjList.SetObjInfo(dialog.Color, ObjColorType.Line);
				btnLineColor.BackColor = dialog.Color;
			}
		}
		private void btnFillColor_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				if(!cbFillColorNone.Checked)
				{
					ObjList.SetObjInfo(dialog.Color, ObjColorType.Fill);
				}
				btnFillColor.BackColor = dialog.Color;
			}
		}
		private void btnBackGround_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				//	ObjList.SetObjInfo(dialog.Color);
				ObjList.SetBackGroundColor(dialog.Color);
				btnBackGround.BackColor = dialog.Color;
			}
		}
		private void btnImageLoad_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

			DialogResult result = dialog.ShowDialog();

			if (result == DialogResult.OK)
			{
				tbImagePath.Text = dialog.FileName;
				ObjList.SetObjInfo(new Bitmap(dialog.FileName));
			}
		}
		
		private void tbObjPosX_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
			{
				e.Handled = true;
			}
		}
		private void tbObjPosY_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
			{
				e.Handled = true;
			}
		}
		private void tbObjWidth_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
			{
				e.Handled = true;
			}
		}
		private void tbObjHeight_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46)
			{
				e.Handled = true;
			}
		}

		private void tbObjPosX_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				ObjList.SetObjInfo(Int32.Parse(tbObjPosX.Text), Int32.Parse(tbObjPosY.Text),
					Int32.Parse(tbObjWidth.Text), Int32.Parse(tbObjHeight.Text));
			}
		}
		private void tbObjPosY_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ObjList.SetObjInfo(Int32.Parse(tbObjPosX.Text), Int32.Parse(tbObjPosY.Text),
					Int32.Parse(tbObjWidth.Text), Int32.Parse(tbObjHeight.Text));
			}
		}
		private void tbObjWidth_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ObjList.SetObjInfo(Int32.Parse(tbObjPosX.Text), Int32.Parse(tbObjPosY.Text),
					Int32.Parse(tbObjWidth.Text), Int32.Parse(tbObjHeight.Text));
			}
		}
		private void tbObjHeight_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ObjList.SetObjInfo(Int32.Parse(tbObjPosX.Text), Int32.Parse(tbObjPosY.Text),
					Int32.Parse(tbObjWidth.Text), Int32.Parse(tbObjHeight.Text));
			}
		}
		private void tbString_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ObjList.SetObjInfo(tbString.Text);
			}
		}
		private void tbAreaWidth_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if((tbAreaHeight.Text != "")&&(tbAreaWidth.Text != ""))
				{
					ObjList.SetClientAreaSize(Int32.Parse(tbAreaWidth.Text), Int32.Parse(tbAreaHeight.Text));
				}
			}
		}

		private void tbAreaHeight_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if ((tbAreaHeight.Text != "") && (tbAreaWidth.Text != ""))
				{
					ObjList.SetClientAreaSize(Int32.Parse(tbAreaWidth.Text), Int32.Parse(tbAreaHeight.Text));
				}
			}
		}
		private void tbObjName_KeyUp(object sender, KeyEventArgs e)
		{

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ObjList.DeletAllObj();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			ObjList.SaveGraphicObjs();
		}
		private void btnMake_Click(object sender, EventArgs e)
		{
			ObjList.MakeSourceFile();
		}

		public void DisplayObj(GraphicObj obj)
		{
			if(obj == null)
			{
				tbObjHeight.Clear();
				tbObjWidth.Clear();
				tbObjPosX.Clear();
				tbObjPosY.Clear();
				btnLineColor.BackColor = ObjList.DefaultColor;
				tbObjName.Clear();
			}
			else
			{
				tbObjHeight.Text = obj.ObjSize.Height.ToString();
				tbObjWidth.Text = obj.ObjSize.Width.ToString();
				tbObjPosX.Text = (obj.ObjPos.X + obj.ObjOffset.Width).ToString();
				tbObjPosY.Text = (obj.ObjPos.Y + obj.ObjOffset.Height).ToString();
				btnLineColor.BackColor = obj.LineColor;
				tbObjName.Text = obj.Name;
			}
		}
		public void DisplayClient(int client_width, int client_height)
		{
			tbAreaHeight.Text = client_height.ToString();
			tbAreaWidth.Text = client_width.ToString();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			ObjList.LoadGraphicObjs();
		}

		private void btnRect_Click(object sender, EventArgs e)
		{
			if(btnRect.BackColor == Color.Transparent)
			{
				ObjList.PrepareDrawing(GraphicType.Rectangle);
				btnRect.BackColor = Color.Aqua;
				btnCircle.BackColor = Color.Transparent;
				btnImage.BackColor = Color.Transparent;
				btnText.BackColor = Color.Transparent;
			}
			else
			{
				ObjList.EndDrawing();
				btnRect.BackColor = Color.Transparent;
			}
		}

		private void btnText_Click(object sender, EventArgs e)
		{
			if (btnText.BackColor == Color.Transparent)
			{
				ObjList.PrepareDrawing(GraphicType.Text);
				ObjList.SetObjInfo(tbString.Text);
				btnText.BackColor = Color.Aqua;
				btnCircle.BackColor = Color.Transparent;
				btnImage.BackColor = Color.Transparent;
				btnRect.BackColor = Color.Transparent;
			}
			else
			{
				ObjList.EndDrawing();
				btnText.BackColor = Color.Transparent;
			}
		}

		private void btnCircle_Click(object sender, EventArgs e)
		{
			if (btnCircle.BackColor == Color.Transparent)
			{
				ObjList.PrepareDrawing(GraphicType.Circle);
				btnCircle.BackColor = Color.Aqua;
				btnRect.BackColor = Color.Transparent;
				btnImage.BackColor = Color.Transparent;
				btnText.BackColor = Color.Transparent;
			}
			else
			{
				ObjList.EndDrawing();
				btnCircle.BackColor = Color.Transparent;
			}
		}

		private void btnImage_Click(object sender, EventArgs e)
		{
			if (btnImage.BackColor == Color.Transparent)
			{
				ObjList.PrepareDrawing(GraphicType.Image);
				btnImage.BackColor = Color.Aqua;
				btnCircle.BackColor = Color.Transparent;
				btnRect.BackColor = Color.Transparent;
				btnText.BackColor = Color.Transparent;
			}
			else
			{
				ObjList.EndDrawing();
				btnImage.BackColor = Color.Transparent;
			}
		}

		private void cbFillColorNone_CheckedChanged(object sender, EventArgs e)
		{
			if(cbFillColorNone.Checked)
			{
				ObjList.SetObjInfo(Color.Empty, ObjColorType.Fill);
			}
			else
			{
				ObjList.SetObjInfo(btnFillColor.BackColor, ObjColorType.Fill);
			}
		}

	}
}
