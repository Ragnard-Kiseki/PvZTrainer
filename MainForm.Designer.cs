using System.Drawing.Text;
using System.Runtime.Versioning;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace PvZTrainer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            pnlForm = new Panel();
            lblForm = new Label();
            pnlCtrlBox = new Panel();
            ctrlMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            ctrlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlHeader = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tgleInfiniteSun = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            label1 = new Label();
            pnlContent = new Bunifu.UI.WinForms.BunifuShadowPanel();
            tblContent = new TableLayoutPanel();
            tgleNoDmg = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            tgleAutoCollect = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            tgleOneHit = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            tgleNoCD = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2DragControl5 = new Guna.UI2.WinForms.Guna2DragControl(components);
            pnlForm.SuspendLayout();
            pnlCtrlBox.SuspendLayout();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlContent.SuspendLayout();
            tblContent.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 15;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.ResizeForm = false;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.FromArgb(42, 41, 63);
            pnlForm.Controls.Add(lblForm);
            pnlForm.Controls.Add(pnlCtrlBox);
            pnlForm.Dock = DockStyle.Top;
            pnlForm.Location = new Point(0, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.Padding = new Padding(133, 0, 0, 0);
            pnlForm.Size = new Size(500, 61);
            pnlForm.TabIndex = 1;
            // 
            // lblForm
            // 
            lblForm.Dock = DockStyle.Left;
            lblForm.Font = new Font("HouseofTerror", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblForm.ForeColor = SystemColors.Control;
            lblForm.Location = new Point(133, 0);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(234, 61);
            lblForm.TabIndex = 3;
            lblForm.Text = "PvZ Trainer | Ko0";
            lblForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCtrlBox
            // 
            pnlCtrlBox.AutoSize = true;
            pnlCtrlBox.Controls.Add(ctrlMinimize);
            pnlCtrlBox.Controls.Add(ctrlClose);
            pnlCtrlBox.Dock = DockStyle.Right;
            pnlCtrlBox.Location = new Point(410, 0);
            pnlCtrlBox.Margin = new Padding(0);
            pnlCtrlBox.Name = "pnlCtrlBox";
            pnlCtrlBox.Size = new Size(90, 61);
            pnlCtrlBox.TabIndex = 3;
            // 
            // ctrlMinimize
            // 
            ctrlMinimize.Animated = true;
            ctrlMinimize.BackColor = Color.Transparent;
            ctrlMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            ctrlMinimize.Cursor = Cursors.Hand;
            ctrlMinimize.CustomizableEdges = customizableEdges1;
            ctrlMinimize.Dock = DockStyle.Right;
            ctrlMinimize.FillColor = Color.Transparent;
            ctrlMinimize.HoverState.FillColor = Color.FromArgb(65, 64, 85);
            ctrlMinimize.IconColor = Color.White;
            ctrlMinimize.Location = new Point(0, 0);
            ctrlMinimize.Name = "ctrlMinimize";
            ctrlMinimize.PressedColor = Color.FromArgb(65, 64, 85);
            ctrlMinimize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ctrlMinimize.Size = new Size(45, 61);
            ctrlMinimize.TabIndex = 4;
            // 
            // ctrlClose
            // 
            ctrlClose.Animated = true;
            ctrlClose.Cursor = Cursors.Hand;
            ctrlClose.CustomizableEdges = customizableEdges3;
            ctrlClose.Dock = DockStyle.Right;
            ctrlClose.FillColor = Color.Transparent;
            ctrlClose.HoverState.FillColor = Color.FromArgb(242, 63, 66);
            ctrlClose.IconColor = Color.White;
            ctrlClose.Location = new Point(45, 0);
            ctrlClose.Name = "ctrlClose";
            ctrlClose.PressedColor = Color.FromArgb(242, 63, 66);
            ctrlClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ctrlClose.Size = new Size(45, 61);
            ctrlClose.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = pnlForm;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl2.TargetControl = lblForm;
            guna2DragControl2.UseTransparentDrag = true;
            // 
            // pnlHeader
            // 
            pnlHeader.AutoSize = true;
            pnlHeader.Controls.Add(pictureBox2);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 61);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(500, 150);
            pnlHeader.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Resources.TRAINER_MADE_By_Ko0_9_21_2024;
            pictureBox2.Location = new Point(0, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(500, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Resources.pngwing_com;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tgleInfiniteSun
            // 
            tgleInfiniteSun.Anchor = AnchorStyles.Right;
            tgleInfiniteSun.BackColor = Color.Transparent;
            tgleInfiniteSun.Checked = false;
            tgleInfiniteSun.CheckedBackColor = Color.FromArgb(121, 193, 118);
            tgleInfiniteSun.CheckedSwitchColor = Color.FromArgb(65, 64, 85);
            tgleInfiniteSun.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleInfiniteSun.Cursor = Cursors.Hand;
            tgleInfiniteSun.Location = new Point(67, 8);
            tgleInfiniteSun.Margin = new Padding(0);
            tgleInfiniteSun.Name = "tgleInfiniteSun";
            tgleInfiniteSun.OutlineThickness = 2;
            tgleInfiniteSun.Size = new Size(42, 22);
            tgleInfiniteSun.TabIndex = 5;
            tgleInfiniteSun.UncheckedBackColor = Color.FromArgb(65, 64, 85);
            tgleInfiniteSun.UncheckedSwitchColor = Color.FromArgb(121, 193, 118);
            tgleInfiniteSun.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleInfiniteSun.Click += InfiniteSun;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("HouseofTerror", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(180, 220, 176);
            label1.Location = new Point(109, 7);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(91, 24);
            label1.TabIndex = 6;
            label1.Text = "Infinite Sun";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.Transparent;
            pnlContent.BorderColor = Color.FromArgb(115, 114, 130);
            pnlContent.BorderRadius = 15;
            pnlContent.BorderThickness = 1;
            pnlContent.Controls.Add(tblContent);
            pnlContent.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            pnlContent.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            pnlContent.Location = new Point(109, 229);
            pnlContent.Margin = new Padding(100, 15, 100, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.PanelColor = Color.FromArgb(42, 41, 63);
            pnlContent.PanelColor2 = Color.FromArgb(42, 41, 63);
            pnlContent.ShadowColor = Color.FromArgb(115, 114, 130);
            pnlContent.ShadowDept = 2;
            pnlContent.ShadowDepth = 5;
            pnlContent.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            pnlContent.ShadowTopLeftVisible = false;
            pnlContent.Size = new Size(300, 200);
            pnlContent.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            pnlContent.TabIndex = 7;
            // 
            // tblContent
            // 
            tblContent.ColumnCount = 2;
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 109F));
            tblContent.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tblContent.Controls.Add(tgleNoDmg, 0, 4);
            tblContent.Controls.Add(label1, 1, 0);
            tblContent.Controls.Add(tgleInfiniteSun, 0, 0);
            tblContent.Controls.Add(tgleAutoCollect, 0, 1);
            tblContent.Controls.Add(tgleOneHit, 0, 2);
            tblContent.Controls.Add(tgleNoCD, 0, 3);
            tblContent.Controls.Add(label2, 1, 1);
            tblContent.Controls.Add(label3, 1, 2);
            tblContent.Controls.Add(label4, 1, 3);
            tblContent.Controls.Add(label5, 1, 4);
            tblContent.Dock = DockStyle.Fill;
            tblContent.Location = new Point(0, 0);
            tblContent.Name = "tblContent";
            tblContent.RowCount = 5;
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6078453F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 21.5686283F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6078434F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6078434F));
            tblContent.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6078434F));
            tblContent.Size = new Size(300, 200);
            tblContent.TabIndex = 7;
            // 
            // tgleNoDmg
            // 
            tgleNoDmg.Anchor = AnchorStyles.Right;
            tgleNoDmg.BackColor = Color.Transparent;
            tgleNoDmg.Checked = false;
            tgleNoDmg.CheckedBackColor = Color.FromArgb(121, 193, 118);
            tgleNoDmg.CheckedSwitchColor = Color.FromArgb(65, 64, 85);
            tgleNoDmg.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleNoDmg.Cursor = Cursors.Hand;
            tgleNoDmg.Location = new Point(67, 169);
            tgleNoDmg.Margin = new Padding(0);
            tgleNoDmg.Name = "tgleNoDmg";
            tgleNoDmg.OutlineThickness = 2;
            tgleNoDmg.Size = new Size(42, 22);
            tgleNoDmg.TabIndex = 14;
            tgleNoDmg.UncheckedBackColor = Color.FromArgb(65, 64, 85);
            tgleNoDmg.UncheckedSwitchColor = Color.FromArgb(121, 193, 118);
            tgleNoDmg.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleNoDmg.Click += NoDamagePlant;
            // 
            // tgleAutoCollect
            // 
            tgleAutoCollect.Anchor = AnchorStyles.Right;
            tgleAutoCollect.BackColor = Color.Transparent;
            tgleAutoCollect.Checked = false;
            tgleAutoCollect.CheckedBackColor = Color.FromArgb(121, 193, 118);
            tgleAutoCollect.CheckedSwitchColor = Color.FromArgb(65, 64, 85);
            tgleAutoCollect.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleAutoCollect.Cursor = Cursors.Hand;
            tgleAutoCollect.Location = new Point(67, 49);
            tgleAutoCollect.Margin = new Padding(0);
            tgleAutoCollect.Name = "tgleAutoCollect";
            tgleAutoCollect.OutlineThickness = 2;
            tgleAutoCollect.Size = new Size(42, 22);
            tgleAutoCollect.TabIndex = 7;
            tgleAutoCollect.UncheckedBackColor = Color.FromArgb(65, 64, 85);
            tgleAutoCollect.UncheckedSwitchColor = Color.FromArgb(121, 193, 118);
            tgleAutoCollect.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleAutoCollect.Click += AutoCollect;
            // 
            // tgleOneHit
            // 
            tgleOneHit.Anchor = AnchorStyles.Right;
            tgleOneHit.BackColor = Color.Transparent;
            tgleOneHit.Checked = false;
            tgleOneHit.CheckedBackColor = Color.FromArgb(121, 193, 118);
            tgleOneHit.CheckedSwitchColor = Color.FromArgb(65, 64, 85);
            tgleOneHit.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleOneHit.Cursor = Cursors.Hand;
            tgleOneHit.Location = new Point(67, 90);
            tgleOneHit.Margin = new Padding(0);
            tgleOneHit.Name = "tgleOneHit";
            tgleOneHit.OutlineThickness = 2;
            tgleOneHit.Size = new Size(42, 22);
            tgleOneHit.TabIndex = 8;
            tgleOneHit.UncheckedBackColor = Color.FromArgb(65, 64, 85);
            tgleOneHit.UncheckedSwitchColor = Color.FromArgb(121, 193, 118);
            tgleOneHit.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleOneHit.Click += OneHit;
            // 
            // tgleNoCD
            // 
            tgleNoCD.Anchor = AnchorStyles.Right;
            tgleNoCD.BackColor = Color.Transparent;
            tgleNoCD.Checked = false;
            tgleNoCD.CheckedBackColor = Color.FromArgb(121, 193, 118);
            tgleNoCD.CheckedSwitchColor = Color.FromArgb(65, 64, 85);
            tgleNoCD.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleNoCD.Cursor = Cursors.Hand;
            tgleNoCD.Location = new Point(67, 129);
            tgleNoCD.Margin = new Padding(0);
            tgleNoCD.Name = "tgleNoCD";
            tgleNoCD.OutlineThickness = 2;
            tgleNoCD.Size = new Size(42, 22);
            tgleNoCD.TabIndex = 9;
            tgleNoCD.UncheckedBackColor = Color.FromArgb(65, 64, 85);
            tgleNoCD.UncheckedSwitchColor = Color.FromArgb(121, 193, 118);
            tgleNoCD.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            tgleNoCD.Click += NoCooldown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("HouseofTerror", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(180, 220, 176);
            label2.Location = new Point(109, 39);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(92, 43);
            label2.TabIndex = 10;
            label2.Text = "Auto Collect\r\nSun && Coin\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("HouseofTerror", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(180, 220, 176);
            label3.Location = new Point(109, 89);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(59, 24);
            label3.TabIndex = 11;
            label3.Text = "One Hit";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("HouseofTerror", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(180, 220, 176);
            label4.Location = new Point(109, 128);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(92, 24);
            label4.TabIndex = 12;
            label4.Text = "No Cooldown";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("HouseofTerror", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(180, 220, 176);
            label5.Location = new Point(109, 172);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 13;
            label5.Text = "No Damage Plant";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2DragControl3
            // 
            guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl3.TargetControl = pictureBox1;
            guna2DragControl3.UseTransparentDrag = true;
            // 
            // guna2DragControl4
            // 
            guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl4.TargetControl = pictureBox2;
            guna2DragControl4.UseTransparentDrag = true;
            // 
            // guna2DragControl5
            // 
            guna2DragControl5.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl5.TargetControl = tblContent;
            guna2DragControl5.UseTransparentDrag = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 43);
            ClientSize = new Size(500, 500);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlForm);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "PvZ Trainer | Ko0";
            Load += MainForm_Load;
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlCtrlBox.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContent.ResumeLayout(false);
            tblContent.ResumeLayout(false);
            tblContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Panel pnlForm;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlClose;
        private Panel pnlCtrlBox;
        private Guna.UI2.WinForms.Guna2ControlBox ctrlMinimize;
        private Label lblForm;
        private Panel pnlHeader;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 tgleInfiniteSun;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnlContent;
        private TableLayoutPanel tblContent;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 tgleNoDmg;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 tgleAutoCollect;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 tgleOneHit;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 tgleNoCD;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl5;
    }
}
