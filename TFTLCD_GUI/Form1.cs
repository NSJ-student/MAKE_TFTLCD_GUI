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
	public partial class formGUI : Form
	{
		Controls ControlForm;
		DrawingPanel PanelForm;
		GraphicObjList ObjList;

		public formGUI()
		{
			InitializeComponent();
		}

		private void formGUI_Load(object sender, EventArgs e)
		{
			ObjList = new GraphicObjList(this.ClientSize);

			ControlForm = new Controls(ObjList);

			ControlForm.MdiParent = this;
			ControlForm.Dock = DockStyle.Top;
			ControlForm.Show();

			PanelForm = new DrawingPanel(ObjList);
			PanelForm.MdiParent = this;
			PanelForm.StartPosition = FormStartPosition.Manual;
			PanelForm.Location = new Point(this.ClientRectangle.Left,
											this.ClientRectangle.Top + ControlForm.Height);
			PanelForm.Show();

			ObjList.RedrawObjs += new ReDraw(PanelForm.Invalidate);
			ObjList.SetPanelSize += new SetFormSize(SetPanelSize);
			ObjList.DisplayClient += new DisplayClientInfo(ControlForm.DisplayClient);
			ObjList.DisplayObj += new DisplayObjInfo(ControlForm.DisplayObj);
			ObjList.SetPanelColor += new SetFormColor(SetPanelColor);
		}
		
		public void SetPanelSize(int w, int h)
		{
			PanelForm.ClientSize = new Size(w, h);
		}
		public void SetPanelColor(Color clr)
		{
			PanelForm.BackColor = clr;
		}
	}
}
