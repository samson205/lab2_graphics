namespace lab2
{
    public partial class MainForm : Form
    {
        private Bitmap mainBitmap;

        private List<PointF> currentShape = new List<PointF>();

        private bool isDrawing = false;
        private PointF startPoint;
        private PointF currentPoint;

        public MainForm()
        {
            InitializeComponent();
            mainBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(mainBitmap))
            {
                g.Clear(Color.White);
            }
            pictureBox.Image = mainBitmap;
            shapesCombo.SelectedIndex = 0;
            transformsCombo.SelectedIndex = 0;

            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseUp += pictureBox_MouseUp;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.Paint += pictureBox_Paint;

            transformsCombo.SelectedIndexChanged += TransformsCombo_SelectedIndexChanged;

            applyBtn.Click += ApplyBtn_Click;
        }

        private void ApplyBtn_Click(object? sender, EventArgs e)
        {
            switch (transformsCombo.SelectedItem?.ToString())
            {
                case "Перемещение":
                    if (!int.TryParse(xBoxMove.Text, out int dx) || !int.TryParse(yBoxMove.Text, out int dy))
                    {
                        MessageBox.Show("Введите число!", "Ошибка");
                        return;
                    }

                    currentShape = Transforms.Move(currentShape, dx, dy);
                    break;

                case "Масштабирование":
                    if (!float.TryParse(sxBox.Text, out float sx) || !float.TryParse(syBox.Text, out float sy) || 
                        sx <= 0 || sy <= 0)
                    {
                        MessageBox.Show("Введите число!", "Ошибка");
                        return;
                    }

                    currentShape = Transforms.Scale(currentShape, sx, sy);
                    break;

                case "Вращение":
                    if (!int.TryParse(angleBox.Text, out int angle))
                    {
                        MessageBox.Show("Введите число!", "Ошибка");
                        return;
                    }

                    currentShape = Transforms.Rotate(currentShape, angle);
                    break;

                case "Сдвиг":
                    if (!float.TryParse(xBoxSheer.Text, out float x) || !float.TryParse(yBoxSheer.Text, out float y))
                    {
                        MessageBox.Show("Введите число!", "Ошибка");
                        return;
                    }

                    currentShape = Transforms.ShearX(currentShape, x);
                    currentShape = Transforms.ShearY(currentShape, y);
                    break;
            }

            RedrawMainBitmap();
        }

        private void TransformsCombo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            movePanel.Visible = false;
            scalePanel.Visible = false;
            rotatePanel.Visible = false;
            sheerPanel.Visible = false;

            switch (transformsCombo.SelectedItem?.ToString())
            {
                case "Перемещение":
                    movePanel.Visible = true;
                    break;
                case "Масштабирование":
                    scalePanel.Visible = true;
                    break;
                case "Вращение":
                    rotatePanel.Visible = true;
                    break;
                case "Сдвиг":
                    sheerPanel.Visible = true;
                    break;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
                currentPoint = e.Location;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentPoint = e.Location;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                currentPoint = e.Location;

                float x = Math.Min(startPoint.X, currentPoint.X);
                float y = Math.Min(startPoint.Y, currentPoint.Y);
                float w = Math.Abs(currentPoint.X - startPoint.X);
                float h = Math.Abs(currentPoint.Y - startPoint.Y);

                if (w < 2 || h < 2) return;

                currentShape = new List<PointF>();

                switch (shapesCombo.SelectedItem?.ToString())
                {
                    case "Прямоугольник":
                        currentShape.Add(new PointF(x, y)); // Лево верх
                        currentShape.Add(new PointF(x + w, y)); // Право верх
                        currentShape.Add(new PointF(x + w, y + h)); // Право низ
                        currentShape.Add(new PointF(x, y + h)); // Лево низ
                        break;

                    case "Треугольник":
                        currentShape.Add(new PointF(x + w / 2, y)); // Верх центр
                        currentShape.Add(new PointF(x + w, y + h)); // Право низ
                        currentShape.Add(new PointF(x, y + h)); // Лево низ
                        break;

                    case "Звезда":
                        currentShape = CreateStarPoints(x, y, w, h);
                        break;

                    default:
                        MessageBox.Show("Выберите фигуру в списке!", "Ошибка");
                        return;
                }

                RedrawMainBitmap();
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                using (Pen previewPen = new Pen(Color.Red, 1f) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
                {
                    float x = Math.Min(startPoint.X, currentPoint.X);
                    float y = Math.Min(startPoint.Y, currentPoint.Y);
                    float width = Math.Abs(currentPoint.X - startPoint.X);
                    float height = Math.Abs(currentPoint.Y - startPoint.Y);

                    e.Graphics.DrawRectangle(previewPen, x, y, width, height);
                }
            }
        }

        private void RedrawMainBitmap()
        {
            using (Graphics g = Graphics.FromImage(mainBitmap))
            {
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                if (currentShape != null && currentShape.Count > 1)
                {
                    using (SolidBrush solidBrush = new SolidBrush(Color.LightSeaGreen))
                    {
                        g.FillPolygon(solidBrush, currentShape.ToArray());
                    }
                }
            }
            pictureBox.Invalidate();
        }

        private List<PointF> CreateStarPoints(float x, float y, float width, float height)
        {
            List<PointF> points = new List<PointF>();
            float cx = x + width / 2;
            float cy = y + height / 2;
            float rx = width / 2;
            float ry = height / 2;
            float innerRx = rx * 0.5f;
            float innerRy = ry * 0.5f;

            double angle = -Math.PI / 2;
            double step = Math.PI / 5;

            for (int i = 0; i < 10; i++)
            {
                float rX = (i % 2 == 0) ? rx : innerRx;
                float rY = (i % 2 == 0) ? ry : innerRy;

                float px = cx + (float)(Math.Cos(angle) * rX);
                float py = cy + (float)(Math.Sin(angle) * rY);

                points.Add(new PointF(px, py));
                angle += step;
            }
            return points;
        }
    }

    public static class Transforms
    {
        private static PointF GetCenter(List<PointF> points)
        {
            float cx = points.Average(p => p.X);
            float cy = points.Average(p => p.Y);
            return new PointF(cx, cy);
        }

        // Перемещение
        public static List<PointF> Move(List<PointF> points, float dx, float dy)
        {
            var result = new List<PointF>();
            foreach (var p in points)
            {
                result.Add(new PointF(p.X + dx, p.Y - dy));
            }
            return result;
        }

        // Масштабирование
        public static List<PointF> Scale(List<PointF> points, float sx, float sy)
        {
            var center = GetCenter(points);
            var result = new List<PointF>();
            foreach (var p in points)
            {
                float newX = center.X + (p.X - center.X) * sx;
                float newY = center.Y + (p.Y - center.Y) * sy;
                result.Add(new PointF(newX, newY));
            }
            return result;
        }

        // Вращение
        public static List<PointF> Rotate(List<PointF> points, float angleDegrees)
        {
            var center = GetCenter(points);
            var result = new List<PointF>();

            // Перевод градусов в радианы
            double angleRadians = angleDegrees * Math.PI / 180.0;
            float cosA = (float)Math.Cos(angleRadians);
            float sinA = (float)Math.Sin(angleRadians);

            foreach (var p in points)
            {
                float newX = center.X + (p.X - center.X) * cosA - (p.Y - center.Y) * sinA;
                float newY = center.Y + (p.X - center.X) * sinA + (p.Y - center.Y) * cosA;
                result.Add(new PointF(newX, newY));
            }
            return result;
        }

        // Сдвиг по X
        public static List<PointF> ShearX(List<PointF> points, float shx)
        {
            var center = GetCenter(points);
            var result = new List<PointF>();
            foreach (var p in points)
            {
                float newX = center.X + (p.X - center.X) + (p.Y - center.Y) * shx;
                float newY = p.Y;
                result.Add(new PointF(newX, newY));
            }
            return result;
        }

        // Сдвиг по Y
        public static List<PointF> ShearY(List<PointF> points, float shy)
        {
            var center = GetCenter(points);
            var result = new List<PointF>();
            foreach (var p in points)
            {
                float newX = p.X;
                float newY = center.Y + (p.Y - center.Y) + (p.X - center.X) * shy;
                result.Add(new PointF(newX, newY));
            }
            return result;
        }
    }
}
