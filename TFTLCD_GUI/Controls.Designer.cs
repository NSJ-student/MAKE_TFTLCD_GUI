namespace TFTLCD_GUI
{
    partial class Controls
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tpFile = new System.Windows.Forms.TabPage();
			this.lblAreaHeight = new System.Windows.Forms.Label();
			this.lblAreaWidth = new System.Windows.Forms.Label();
			this.btnBackGround = new System.Windows.Forms.Button();
			this.btnMake = new System.Windows.Forms.Button();
			this.tbAreaHeight = new System.Windows.Forms.TextBox();
			this.tbAreaWidth = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.tpEdit = new System.Windows.Forms.TabPage();
			this.tbObjName = new System.Windows.Forms.TextBox();
			this.lblObjName = new System.Windows.Forms.Label();
			this.lblObjHeight = new System.Windows.Forms.Label();
			this.lblObjWidth = new System.Windows.Forms.Label();
			this.tbObjHeight = new System.Windows.Forms.TextBox();
			this.tbObjWidth = new System.Windows.Forms.TextBox();
			this.lblPosY = new System.Windows.Forms.Label();
			this.lblPosX = new System.Windows.Forms.Label();
			this.tbObjPosY = new System.Windows.Forms.TextBox();
			this.tbObjPosX = new System.Windows.Forms.TextBox();
			this.tpObject = new System.Windows.Forms.TabPage();
			this.cbFillColorNone = new System.Windows.Forms.CheckBox();
			this.btnCircle = new System.Windows.Forms.Button();
			this.btnImage = new System.Windows.Forms.Button();
			this.btnText = new System.Windows.Forms.Button();
			this.btnRect = new System.Windows.Forms.Button();
			this.tbString = new System.Windows.Forms.TextBox();
			this.btnImageLoad = new System.Windows.Forms.Button();
			this.btnFillColor = new System.Windows.Forms.Button();
			this.btnLineColor = new System.Windows.Forms.Button();
			this.tbImagePath = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tpFile.SuspendLayout();
			this.tpEdit.SuspendLayout();
			this.tpObject.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tpFile);
			this.tabControl.Controls.Add(this.tpEdit);
			this.tabControl.Controls.Add(this.tpObject);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.ItemSize = new System.Drawing.Size(80, 18);
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(729, 92);
			this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl.TabIndex = 0;
			// 
			// tpFile
			// 
			this.tpFile.Controls.Add(this.btnClear);
			this.tpFile.Controls.Add(this.lblAreaHeight);
			this.tpFile.Controls.Add(this.lblAreaWidth);
			this.tpFile.Controls.Add(this.btnBackGround);
			this.tpFile.Controls.Add(this.btnMake);
			this.tpFile.Controls.Add(this.tbAreaHeight);
			this.tpFile.Controls.Add(this.tbAreaWidth);
			this.tpFile.Controls.Add(this.btnLoad);
			this.tpFile.Controls.Add(this.btnSave);
			this.tpFile.Location = new System.Drawing.Point(4, 22);
			this.tpFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tpFile.Name = "tpFile";
			this.tpFile.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tpFile.Size = new System.Drawing.Size(721, 66);
			this.tpFile.TabIndex = 0;
			this.tpFile.Text = "File";
			this.tpFile.UseVisualStyleBackColor = true;
			// 
			// lblAreaHeight
			// 
			this.lblAreaHeight.AutoSize = true;
			this.lblAreaHeight.Location = new System.Drawing.Point(403, 36);
			this.lblAreaHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAreaHeight.Name = "lblAreaHeight";
			this.lblAreaHeight.Size = new System.Drawing.Size(92, 15);
			this.lblAreaHeight.TabIndex = 6;
			this.lblAreaHeight.Text = "Area Height :";
			// 
			// lblAreaWidth
			// 
			this.lblAreaWidth.AutoSize = true;
			this.lblAreaWidth.Location = new System.Drawing.Point(403, 10);
			this.lblAreaWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAreaWidth.Name = "lblAreaWidth";
			this.lblAreaWidth.Size = new System.Drawing.Size(88, 15);
			this.lblAreaWidth.TabIndex = 5;
			this.lblAreaWidth.Text = "Area Width :";
			// 
			// btnBackGround
			// 
			this.btnBackGround.BackColor = System.Drawing.Color.White;
			this.btnBackGround.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackGround.Location = new System.Drawing.Point(579, 33);
			this.btnBackGround.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnBackGround.Name = "btnBackGround";
			this.btnBackGround.Size = new System.Drawing.Size(61, 25);
			this.btnBackGround.TabIndex = 4;
			this.btnBackGround.Text = "Color";
			this.btnBackGround.UseVisualStyleBackColor = false;
			this.btnBackGround.Click += new System.EventHandler(this.btnBackGround_Click);
			// 
			// btnMake
			// 
			this.btnMake.Location = new System.Drawing.Point(199, 7);
			this.btnMake.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnMake.Name = "btnMake";
			this.btnMake.Size = new System.Drawing.Size(75, 48);
			this.btnMake.TabIndex = 4;
			this.btnMake.Text = "Make";
			this.btnMake.UseVisualStyleBackColor = true;
			this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
			// 
			// tbAreaHeight
			// 
			this.tbAreaHeight.Location = new System.Drawing.Point(504, 33);
			this.tbAreaHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbAreaHeight.Name = "tbAreaHeight";
			this.tbAreaHeight.Size = new System.Drawing.Size(53, 25);
			this.tbAreaHeight.TabIndex = 3;
			this.tbAreaHeight.Text = "240";
			this.tbAreaHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAreaHeight_KeyUp);
			// 
			// tbAreaWidth
			// 
			this.tbAreaWidth.Location = new System.Drawing.Point(504, 7);
			this.tbAreaWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbAreaWidth.Name = "tbAreaWidth";
			this.tbAreaWidth.Size = new System.Drawing.Size(53, 25);
			this.tbAreaWidth.TabIndex = 2;
			this.tbAreaWidth.Text = "320";
			this.tbAreaWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAreaWidth_KeyUp);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(91, 7);
			this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 48);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(9, 7);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 48);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tpEdit
			// 
			this.tpEdit.Controls.Add(this.tbObjName);
			this.tpEdit.Controls.Add(this.lblObjName);
			this.tpEdit.Controls.Add(this.lblObjHeight);
			this.tpEdit.Controls.Add(this.lblObjWidth);
			this.tpEdit.Controls.Add(this.tbObjHeight);
			this.tpEdit.Controls.Add(this.tbObjWidth);
			this.tpEdit.Controls.Add(this.lblPosY);
			this.tpEdit.Controls.Add(this.lblPosX);
			this.tpEdit.Controls.Add(this.tbObjPosY);
			this.tpEdit.Controls.Add(this.tbObjPosX);
			this.tpEdit.Location = new System.Drawing.Point(4, 22);
			this.tpEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tpEdit.Name = "tpEdit";
			this.tpEdit.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tpEdit.Size = new System.Drawing.Size(721, 66);
			this.tpEdit.TabIndex = 1;
			this.tpEdit.Text = "Edit";
			this.tpEdit.UseVisualStyleBackColor = true;
			// 
			// tbObjName
			// 
			this.tbObjName.Location = new System.Drawing.Point(283, 7);
			this.tbObjName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbObjName.Name = "tbObjName";
			this.tbObjName.Size = new System.Drawing.Size(170, 25);
			this.tbObjName.TabIndex = 9;
			this.tbObjName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbObjName_KeyUp);
			// 
			// lblObjName
			// 
			this.lblObjName.AutoSize = true;
			this.lblObjName.Location = new System.Drawing.Point(222, 10);
			this.lblObjName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblObjName.Name = "lblObjName";
			this.lblObjName.Size = new System.Drawing.Size(53, 15);
			this.lblObjName.TabIndex = 8;
			this.lblObjName.Text = "Name :";
			// 
			// lblObjHeight
			// 
			this.lblObjHeight.AutoSize = true;
			this.lblObjHeight.Location = new System.Drawing.Point(111, 36);
			this.lblObjHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblObjHeight.Name = "lblObjHeight";
			this.lblObjHeight.Size = new System.Drawing.Size(58, 15);
			this.lblObjHeight.TabIndex = 7;
			this.lblObjHeight.Text = "Height :";
			// 
			// lblObjWidth
			// 
			this.lblObjWidth.AutoSize = true;
			this.lblObjWidth.Location = new System.Drawing.Point(111, 10);
			this.lblObjWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblObjWidth.Name = "lblObjWidth";
			this.lblObjWidth.Size = new System.Drawing.Size(54, 15);
			this.lblObjWidth.TabIndex = 6;
			this.lblObjWidth.Text = "Width :";
			// 
			// tbObjHeight
			// 
			this.tbObjHeight.Location = new System.Drawing.Point(173, 33);
			this.tbObjHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbObjHeight.Name = "tbObjHeight";
			this.tbObjHeight.Size = new System.Drawing.Size(41, 25);
			this.tbObjHeight.TabIndex = 5;
			this.tbObjHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbObjHeight_KeyPress);
			this.tbObjHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbObjHeight_KeyUp);
			// 
			// tbObjWidth
			// 
			this.tbObjWidth.Location = new System.Drawing.Point(173, 7);
			this.tbObjWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbObjWidth.Name = "tbObjWidth";
			this.tbObjWidth.Size = new System.Drawing.Size(41, 25);
			this.tbObjWidth.TabIndex = 4;
			this.tbObjWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbObjWidth_KeyPress);
			this.tbObjWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbObjWidth_KeyUp);
			// 
			// lblPosY
			// 
			this.lblPosY.AutoSize = true;
			this.lblPosY.Location = new System.Drawing.Point(16, 36);
			this.lblPosY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPosY.Name = "lblPosY";
			this.lblPosY.Size = new System.Drawing.Size(25, 15);
			this.lblPosY.TabIndex = 3;
			this.lblPosY.Text = "Y :";
			// 
			// lblPosX
			// 
			this.lblPosX.AutoSize = true;
			this.lblPosX.Location = new System.Drawing.Point(16, 10);
			this.lblPosX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPosX.Name = "lblPosX";
			this.lblPosX.Size = new System.Drawing.Size(26, 15);
			this.lblPosX.TabIndex = 2;
			this.lblPosX.Text = "X :";
			// 
			// tbObjPosY
			// 
			this.tbObjPosY.Location = new System.Drawing.Point(50, 33);
			this.tbObjPosY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbObjPosY.Name = "tbObjPosY";
			this.tbObjPosY.Size = new System.Drawing.Size(41, 25);
			this.tbObjPosY.TabIndex = 1;
			this.tbObjPosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbObjPosY_KeyPress);
			this.tbObjPosY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbObjPosY_KeyUp);
			// 
			// tbObjPosX
			// 
			this.tbObjPosX.Location = new System.Drawing.Point(50, 7);
			this.tbObjPosX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbObjPosX.Name = "tbObjPosX";
			this.tbObjPosX.Size = new System.Drawing.Size(41, 25);
			this.tbObjPosX.TabIndex = 0;
			this.tbObjPosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbObjPosX_KeyPress);
			this.tbObjPosX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbObjPosX_KeyUp);
			// 
			// tpObject
			// 
			this.tpObject.Controls.Add(this.cbFillColorNone);
			this.tpObject.Controls.Add(this.btnCircle);
			this.tpObject.Controls.Add(this.btnImage);
			this.tpObject.Controls.Add(this.btnText);
			this.tpObject.Controls.Add(this.btnRect);
			this.tpObject.Controls.Add(this.tbString);
			this.tpObject.Controls.Add(this.btnImageLoad);
			this.tpObject.Controls.Add(this.btnFillColor);
			this.tpObject.Controls.Add(this.btnLineColor);
			this.tpObject.Controls.Add(this.tbImagePath);
			this.tpObject.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tpObject.Location = new System.Drawing.Point(4, 22);
			this.tpObject.Name = "tpObject";
			this.tpObject.Size = new System.Drawing.Size(721, 66);
			this.tpObject.TabIndex = 2;
			this.tpObject.Text = "Object";
			this.tpObject.UseVisualStyleBackColor = true;
			// 
			// cbFillColorNone
			// 
			this.cbFillColorNone.AutoSize = true;
			this.cbFillColorNone.Checked = true;
			this.cbFillColorNone.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbFillColorNone.Location = new System.Drawing.Point(446, 38);
			this.cbFillColorNone.Name = "cbFillColorNone";
			this.cbFillColorNone.Size = new System.Drawing.Size(103, 19);
			this.cbFillColorNone.TabIndex = 26;
			this.cbFillColorNone.Text = "Color None";
			this.cbFillColorNone.UseVisualStyleBackColor = true;
			this.cbFillColorNone.CheckedChanged += new System.EventHandler(this.cbFillColorNone_CheckedChanged);
			// 
			// btnCircle
			// 
			this.btnCircle.Location = new System.Drawing.Point(20, 36);
			this.btnCircle.Name = "btnCircle";
			this.btnCircle.Size = new System.Drawing.Size(71, 24);
			this.btnCircle.TabIndex = 25;
			this.btnCircle.Text = "Circle";
			this.btnCircle.UseVisualStyleBackColor = true;
			this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
			// 
			// btnImage
			// 
			this.btnImage.Location = new System.Drawing.Point(119, 35);
			this.btnImage.Name = "btnImage";
			this.btnImage.Size = new System.Drawing.Size(60, 26);
			this.btnImage.TabIndex = 24;
			this.btnImage.Text = "Image";
			this.btnImage.UseVisualStyleBackColor = true;
			this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
			// 
			// btnText
			// 
			this.btnText.Location = new System.Drawing.Point(119, 7);
			this.btnText.Name = "btnText";
			this.btnText.Size = new System.Drawing.Size(60, 26);
			this.btnText.TabIndex = 23;
			this.btnText.Text = "Text";
			this.btnText.UseVisualStyleBackColor = true;
			this.btnText.Click += new System.EventHandler(this.btnText_Click);
			// 
			// btnRect
			// 
			this.btnRect.Location = new System.Drawing.Point(20, 7);
			this.btnRect.Name = "btnRect";
			this.btnRect.Size = new System.Drawing.Size(71, 26);
			this.btnRect.TabIndex = 22;
			this.btnRect.Text = "Rect";
			this.btnRect.UseVisualStyleBackColor = true;
			this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
			// 
			// tbString
			// 
			this.tbString.Location = new System.Drawing.Point(185, 7);
			this.tbString.Name = "tbString";
			this.tbString.Size = new System.Drawing.Size(127, 25);
			this.tbString.TabIndex = 21;
			this.tbString.Text = "default";
			// 
			// btnImageLoad
			// 
			this.btnImageLoad.Location = new System.Drawing.Point(281, 35);
			this.btnImageLoad.Name = "btnImageLoad";
			this.btnImageLoad.Size = new System.Drawing.Size(31, 25);
			this.btnImageLoad.TabIndex = 18;
			this.btnImageLoad.Text = "...";
			this.btnImageLoad.UseVisualStyleBackColor = true;
			this.btnImageLoad.Click += new System.EventHandler(this.btnImageLoad_Click);
			// 
			// btnFillColor
			// 
			this.btnFillColor.BackColor = System.Drawing.Color.White;
			this.btnFillColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFillColor.Location = new System.Drawing.Point(366, 36);
			this.btnFillColor.Name = "btnFillColor";
			this.btnFillColor.Size = new System.Drawing.Size(74, 24);
			this.btnFillColor.TabIndex = 19;
			this.btnFillColor.Text = "Fill";
			this.btnFillColor.UseVisualStyleBackColor = false;
			this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
			// 
			// btnLineColor
			// 
			this.btnLineColor.BackColor = System.Drawing.Color.Red;
			this.btnLineColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLineColor.Location = new System.Drawing.Point(366, 7);
			this.btnLineColor.Name = "btnLineColor";
			this.btnLineColor.Size = new System.Drawing.Size(74, 26);
			this.btnLineColor.TabIndex = 20;
			this.btnLineColor.Text = "Line";
			this.btnLineColor.UseVisualStyleBackColor = false;
			this.btnLineColor.Click += new System.EventHandler(this.btnObjColor_Click);
			// 
			// tbImagePath
			// 
			this.tbImagePath.Location = new System.Drawing.Point(185, 36);
			this.tbImagePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.tbImagePath.Name = "tbImagePath";
			this.tbImagePath.ReadOnly = true;
			this.tbImagePath.Size = new System.Drawing.Size(89, 25);
			this.tbImagePath.TabIndex = 17;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(306, 7);
			this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 48);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Controls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 92);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Controls";
			this.Text = "Controls";
			this.tabControl.ResumeLayout(false);
			this.tpFile.ResumeLayout(false);
			this.tpFile.PerformLayout();
			this.tpEdit.ResumeLayout(false);
			this.tpEdit.PerformLayout();
			this.tpObject.ResumeLayout(false);
			this.tpObject.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbAreaHeight;
        private System.Windows.Forms.TextBox tbAreaWidth;
        private System.Windows.Forms.TextBox tbObjPosY;
        private System.Windows.Forms.TextBox tbObjPosX;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Label lblAreaHeight;
        private System.Windows.Forms.Label lblAreaWidth;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.TextBox tbObjHeight;
        private System.Windows.Forms.TextBox tbObjWidth;
        private System.Windows.Forms.Label lblObjWidth;
        private System.Windows.Forms.Label lblObjHeight;
        private System.Windows.Forms.Label lblObjName;
        private System.Windows.Forms.TextBox tbObjName;
		private System.Windows.Forms.Button btnBackGround;
		private System.Windows.Forms.TabPage tpObject;
		private System.Windows.Forms.Button btnCircle;
		private System.Windows.Forms.Button btnImage;
		private System.Windows.Forms.Button btnText;
		private System.Windows.Forms.Button btnRect;
		private System.Windows.Forms.TextBox tbString;
		private System.Windows.Forms.Button btnImageLoad;
		private System.Windows.Forms.Button btnFillColor;
		private System.Windows.Forms.Button btnLineColor;
		private System.Windows.Forms.TextBox tbImagePath;
		private System.Windows.Forms.CheckBox cbFillColorNone;
		private System.Windows.Forms.Button btnClear;
	}
}