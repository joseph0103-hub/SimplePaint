using System.Drawing;
using System.Windows.Forms;

namespace SimplePaint
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblAppName;
        private GroupBox grpShape;
        private Button btnLine;
        private Button btnRectangle;
        private Button btnCircle;
        private GroupBox grpColor;
        private ComboBox cmbColor;
        private GroupBox grpLineWidth;
        private TrackBar trbLineWidth;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private PictureBox picCanvas;
        private Panel pnlCanvas;
        private GroupBox grpZoom;
        private TrackBar trbZoom;
        private Label lblZoom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblAppName = new Label();
            grpShape = new GroupBox();
            btnLine = new Button();
            btnRectangle = new Button();
            btnCircle = new Button();
            grpColor = new GroupBox();
            cmbColor = new ComboBox();
            grpLineWidth = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            picCanvas = new PictureBox();
            pnlCanvas = new Panel();
            grpZoom = new GroupBox();
            trbZoom = new TrackBar();
            lblZoom = new Label();

            grpShape.SuspendLayout();
            grpColor.SuspendLayout();
            grpLineWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            pnlCanvas.SuspendLayout();
            grpZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbZoom).BeginInit();

            SuspendLayout();

            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(16, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(188, 37);
            lblAppName.Text = "Simple Paint";

            grpShape.Controls.Add(btnLine);
            grpShape.Controls.Add(btnRectangle);
            grpShape.Controls.Add(btnCircle);
            grpShape.Location = new Point(16, 72);
            grpShape.Name = "grpShape";
            grpShape.Size = new Size(150, 72);
            grpShape.Text = "도형 선택";

            btnLine.Location = new Point(10, 22);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(40, 40);
            btnLine.Text = "직선";
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;

            btnRectangle.Location = new Point(55, 22);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(40, 40);
            btnRectangle.Text = "사각형";
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;

            btnCircle.Location = new Point(100, 22);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(40, 40);
            btnCircle.Text = "원";
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;

            grpColor.Controls.Add(cmbColor);
            grpColor.Location = new Point(176, 72);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(116, 72);
            grpColor.Text = "색 선택";

            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 초록" });
            cmbColor.Location = new Point(10, 30);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(96, 23);
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;

            grpLineWidth.Controls.Add(trbLineWidth);
            grpLineWidth.Location = new Point(302, 72);
            grpLineWidth.Name = "grpLineWidth";
            grpLineWidth.Size = new Size(138, 72);
            grpLineWidth.Text = "선 두께";

            trbLineWidth.Location = new Point(8, 24);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Minimum = 1;
            trbLineWidth.Maximum = 10;
            trbLineWidth.Value = 2;
            trbLineWidth.TickFrequency = 1;
            trbLineWidth.Size = new Size(124, 45);
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;

            btnOpenFile.BackColor = Color.LightYellow;
            btnOpenFile.Location = new Point(580, 84);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(48, 60);
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;

            btnSaveFile.BackColor = Color.PaleTurquoise;
            btnSaveFile.Location = new Point(636, 84);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(48, 60);
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;

            grpZoom.Controls.Add(lblZoom);
            grpZoom.Controls.Add(trbZoom);
            grpZoom.Location = new Point(450, 72);
            grpZoom.Name = "grpZoom";
            grpZoom.Size = new Size(120, 72);
            grpZoom.Text = "확대/축소";

            trbZoom.Location = new Point(6, 22);
            trbZoom.Name = "trbZoom";
            trbZoom.Minimum = 25;
            trbZoom.Maximum = 200;
            trbZoom.TickFrequency = 25;
            trbZoom.Value = 100;
            trbZoom.Size = new Size(108, 45);
            trbZoom.ValueChanged += trbZoom_ValueChanged;

            lblZoom.AutoSize = true;
            lblZoom.Location = new Point(42, 50);
            lblZoom.Name = "lblZoom";
            lblZoom.Text = "100%";


            picCanvas.BackColor = Color.White;
            picCanvas.BorderStyle = BorderStyle.FixedSingle;
            picCanvas.Location = new Point(0, 0);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(538, 330);
            picCanvas.TabStop = false;
            picCanvas.Paint += picCanvas_Paint;
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;

            pnlCanvas.AutoScroll = true;
            pnlCanvas.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvas.Controls.Add(picCanvas);
            pnlCanvas.Location = new Point(16, 160);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(672, 400);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 578);
            Controls.Add(pnlCanvas);
            Controls.Add(grpZoom);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(grpLineWidth);
            Controls.Add(grpColor);
            Controls.Add(grpShape);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Simple Paint v1.0";
            Load += Form1_Load;
            grpShape.ResumeLayout(false);
            grpColor.ResumeLayout(false);
            grpLineWidth.ResumeLayout(false);
            grpLineWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            pnlCanvas.ResumeLayout(false);
            grpZoom.ResumeLayout(false);
            grpZoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbZoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
