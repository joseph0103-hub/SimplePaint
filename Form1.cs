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


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            cmbColor.SelectedIndex = 0;
            SelectShape(DrawShape.Line);

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
        }

        private void picCanvas_MouseDown(object? sender, MouseEventArgs e)
        {
        }

        private void picCanvas_MouseMove(object? sender, MouseEventArgs e)
        {

        }

        private void picCanvas_MouseUp(object? sender, MouseEventArgs e)
        {

        }

        private void picCanvas_Paint(object? sender, PaintEventArgs e)
        {

        }


    }
}
