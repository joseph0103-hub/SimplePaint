using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        private enum DrawShape { Line, Rectangle, Circle }
        private DrawShape selectedShape = DrawShape.Line;
        private Color selectedColor = Color.Black;
        private int selectedLineWidth = 2;
        private Bitmap canvasBitmap = null!;
        private bool isDrawing = false;
        private Point startPoint;
        private Point currentPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            cmbColor.SelectedIndex = 0;
            SelectShape(DrawShape.Line);
            CreateBlankCanvas(picCanvas.Width, picCanvas.Height);
        }

        private void SelectShape(DrawShape shape)
        {
            selectedShape = shape;
            btnLine.BackColor = shape == DrawShape.Line ? Color.LightSkyBlue : SystemColors.Control;
            btnRectangle.BackColor = shape == DrawShape.Rectangle ? Color.LightSkyBlue : SystemColors.Control;
            btnCircle.BackColor = shape == DrawShape.Circle ? Color.LightSkyBlue : SystemColors.Control;
        }

        private void btnLine_Click(object? sender, EventArgs e) => SelectShape(DrawShape.Line);
        private void btnRectangle_Click(object? sender, EventArgs e) => SelectShape(DrawShape.Rectangle);
        private void btnCircle_Click(object? sender, EventArgs e) => SelectShape(DrawShape.Circle);

        private void cmbColor_SelectedIndexChanged(object? sender, EventArgs e)
        {
            selectedColor = cmbColor.SelectedIndex switch
            {
                1 => Color.Red,
                2 => Color.Blue,
                3 => Color.Green,
                _ => Color.Black
            };
        }

        private void trbLineWidth_ValueChanged(object? sender, EventArgs e)
        {
            selectedLineWidth = trbLineWidth.Value;
        }

        private void btnOpenFile_Click(object? sender, EventArgs e)
        {
        }

        private void btnSaveFile_Click(object? sender, EventArgs e)
        {
            using SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "그림 저장";
            sfd.Filter = "PNG 파일 (*.png)|*.png|JPG 파일 (*.jpg)|*.jpg|BMP 파일 (*.bmp)|*.bmp";
            sfd.FileName = "simplepaint";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format;

                if (sfd.FilterIndex == 1)
                {
                    format = ImageFormat.Png;
                }
                else if (sfd.FilterIndex == 2)
                {
                    format = ImageFormat.Jpeg;
                }
                else if (sfd.FilterIndex == 3)
                {
                    format = ImageFormat.Bmp;
                }
                else
                {
                    format = ImageFormat.Png;
                }

                canvasBitmap.Save(sfd.FileName, format);
                MessageBox.Show("이미지 파일로 저장했습니다.");
            }
        }

        private void picCanvas_MouseDown(object? sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            currentPoint = e.Location;
        }

        private void picCanvas_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            currentPoint = e.Location;
            picCanvas.Invalidate();
        }

        private void picCanvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (!isDrawing) return;
            isDrawing = false;
            currentPoint = e.Location;
            using Graphics g = Graphics.FromImage(canvasBitmap);
            DrawSelectedShape(g, startPoint, currentPoint);
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object? sender, PaintEventArgs e)
        {
            if (!isDrawing) return;
            DrawSelectedShape(e.Graphics, startPoint, currentPoint);
        }

        private void CreateBlankCanvas(int width, int height)
        {
            canvasBitmap?.Dispose();
            canvasBitmap = new Bitmap(width, height);
            using Graphics g = Graphics.FromImage(canvasBitmap);
            g.Clear(Color.White);
            picCanvas.Image = canvasBitmap;
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y), Math.Abs(p1.X - p2.X), Math.Abs(p1.Y - p2.Y));
        }

        private void DrawSelectedShape(Graphics g, Point p1, Point p2)
        {
            using Pen pen = new Pen(selectedColor, selectedLineWidth);
            Rectangle rect = GetRectangle(p1, p2);
            switch (selectedShape)
            {
                case DrawShape.Line:
                    g.DrawLine(pen, p1, p2);
                    break;
                case DrawShape.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case DrawShape.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }
    }
}
