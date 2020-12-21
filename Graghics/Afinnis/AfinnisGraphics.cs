using System.Drawing;

namespace Graghics.Afinnis
{
    class AfinnisGraphics
    {
        public readonly Bitmap _canvas;
        public int _intervalStep = 20;

        public AfinnisGraphics(Bitmap canvas)
        {
            _canvas = canvas;
            Graphics g = Graphics.FromImage(_canvas);
            g.TranslateTransform(_canvas.Width / 3, (_canvas.Height / 3) * 2);
        }

        public void InitCanvas()
        {
            Graphics g = Graphics.FromImage(_canvas);
            g.TranslateTransform(_canvas.Width / 3, (_canvas.Height / 3) * 2);
            Pen axesPen = new Pen(Color.Black);
            Pen gridPen = new Pen(Color.LightGray);

            int xMax, yMax;
            int xStart = 3, yStart = 3;
            int xRepeat = 5, yRepeat = 5;

            //сітка
            for (int i = -_canvas.Width; i < _canvas.Width; i += _intervalStep)
            {
                g.DrawLine(gridPen, -_canvas.Width, i, _canvas.Width, i);
                g.DrawLine(gridPen, i, -_canvas.Height, i, _canvas.Height);
            }

            //осі
            g.DrawLine(axesPen, 0, -_canvas.Height, 0, _canvas.Height); //x
            g.DrawLine(axesPen, -_canvas.Width, 0, _canvas.Width, 0); //y
            g.DrawLine(axesPen, -_canvas.Height, _canvas.Height, _canvas.Height, -_canvas.Height); //xy

            //текст
            Font font = new Font(FontFamily.GenericSerif, 12.0f);

            //X
            int xOffset = _intervalStep * xStart;
            for (int i = xStart, tmpOffset = xOffset; tmpOffset < _canvas.Width; i += xRepeat, tmpOffset += xRepeat * _intervalStep)
            {
                g.DrawString(i.ToString(), font, new SolidBrush(Color.Black), tmpOffset, 0);
            }
            for(int i = xStart, tmpOffset = -xOffset; tmpOffset > -_canvas.Width; i+= xRepeat, tmpOffset -= xRepeat * _intervalStep)
            {
                g.DrawString((-i).ToString(), font, new SolidBrush(Color.Black), tmpOffset, 0);
            }
            g.DrawString("X", font, new SolidBrush(Color.Black), _intervalStep * 25, 0);

            //Y
            int yOffset = -_intervalStep * yStart;
            for (int i = yStart, tmpOffset = yOffset; tmpOffset > -_canvas.Height; i += yRepeat, tmpOffset -= yRepeat * _intervalStep)
            {
                g.DrawString(i.ToString(), font, new SolidBrush(Color.Black), 0, tmpOffset);
            }
            for (int i = yStart, tmpOffset = -yOffset; tmpOffset < _canvas.Height; i += yRepeat, tmpOffset += yRepeat * _intervalStep)
            {
                g.DrawString((-i).ToString(), font, new SolidBrush(Color.Black), 0, tmpOffset);
            }
            g.DrawString("Y", font, new SolidBrush(Color.Black), -_intervalStep, -_intervalStep * 20);

            g.DrawString("0", font, new SolidBrush(Color.Black), 0, 0);

            axesPen.Dispose();
            gridPen.Dispose();
            g.Dispose();
        }

        public void DrawTriangle(Triangle triangle, Color color, bool transformated)
        {
            Graphics g = Graphics.FromImage(_canvas);
            g.TranslateTransform(_canvas.Width / 3, (_canvas.Height / 3) * 2);
            Pen trianglePen = new Pen(color, 3);

            var A = new PointF(triangle.Points[0].X * _intervalStep, -1 * triangle.Points[0].Y * _intervalStep);
            var B = new PointF(triangle.Points[1].X * _intervalStep, -1 * triangle.Points[1].Y * _intervalStep);
            var C = new PointF(triangle.Points[2].X * _intervalStep, -1 * triangle.Points[2].Y * _intervalStep);

            var points = new PointF[] { A, B, C };

            g.DrawLine(trianglePen, A, B);
            g.DrawLine(trianglePen, B, C);
            g.DrawLine(trianglePen, C, A);

            Font font = new Font(FontFamily.GenericSerif, 10.0f);
            if (!transformated)
            {
                g.DrawString("A", font, new SolidBrush(Color.Black), A.X, A.Y);
                g.DrawString("B", font, new SolidBrush(Color.Black), B.X, B.Y);
                g.DrawString("C", font, new SolidBrush(Color.Black), C.X, C.Y);
            }
            else
            {
                g.DrawString("A'", font, new SolidBrush(Color.Black), A.X, A.Y);
                g.DrawString("B'", font, new SolidBrush(Color.Black), B.X, B.Y);
                g.DrawString("C '", font, new SolidBrush(Color.Black), C.X, C.Y);
            }

            trianglePen.Dispose();
            g.Dispose();
        }
    }
}
