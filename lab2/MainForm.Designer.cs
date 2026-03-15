namespace lab2
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
            pictureBox = new PictureBox();
            shapesCombo = new ComboBox();
            transformsCombo = new ComboBox();
            shapesTLP = new TableLayoutPanel();
            mainGroupBox = new GroupBox();
            btnTLP = new TableLayoutPanel();
            applyBtn = new Button();
            mainPanel = new Panel();
            sheerPanel = new TableLayoutPanel();
            xLabelSheer = new Label();
            yLabelSheer = new Label();
            xBoxSheer = new TextBox();
            yBoxSheer = new TextBox();
            rotatePanel = new TableLayoutPanel();
            angleBox = new TextBox();
            angleLabel = new Label();
            scalePanel = new TableLayoutPanel();
            sxLabel = new Label();
            syLabel = new Label();
            sxBox = new TextBox();
            syBox = new TextBox();
            movePanel = new TableLayoutPanel();
            xLabelMove = new Label();
            yLabelMove = new Label();
            xBoxMove = new TextBox();
            yBoxMove = new TextBox();
            transformsTLP = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            shapesTLP.SuspendLayout();
            mainGroupBox.SuspendLayout();
            btnTLP.SuspendLayout();
            mainPanel.SuspendLayout();
            sheerPanel.SuspendLayout();
            rotatePanel.SuspendLayout();
            scalePanel.SuspendLayout();
            movePanel.SuspendLayout();
            transformsTLP.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Cursor = Cursors.Cross;
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(741, 576);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // shapesCombo
            // 
            shapesCombo.Anchor = AnchorStyles.None;
            shapesCombo.Font = new Font("Segoe UI", 12F);
            shapesCombo.FormattingEnabled = true;
            shapesCombo.Items.AddRange(new object[] { "Прямоугольник", "Треугольник", "Звезда" });
            shapesCombo.Location = new Point(58, 21);
            shapesCombo.Name = "shapesCombo";
            shapesCombo.Size = new Size(172, 29);
            shapesCombo.TabIndex = 0;
            // 
            // transformsCombo
            // 
            transformsCombo.Anchor = AnchorStyles.None;
            transformsCombo.Font = new Font("Segoe UI", 12F);
            transformsCombo.FormattingEnabled = true;
            transformsCombo.Items.AddRange(new object[] { "Перемещение", "Масштабирование", "Вращение", "Сдвиг" });
            transformsCombo.Location = new Point(55, 23);
            transformsCombo.Name = "transformsCombo";
            transformsCombo.Size = new Size(172, 29);
            transformsCombo.TabIndex = 0;
            // 
            // shapesTLP
            // 
            shapesTLP.ColumnCount = 3;
            shapesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            shapesTLP.ColumnStyles.Add(new ColumnStyle());
            shapesTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            shapesTLP.Controls.Add(shapesCombo, 1, 0);
            shapesTLP.Dock = DockStyle.Top;
            shapesTLP.Location = new Point(741, 0);
            shapesTLP.Name = "shapesTLP";
            shapesTLP.RowCount = 1;
            shapesTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            shapesTLP.Size = new Size(289, 71);
            shapesTLP.TabIndex = 1;
            // 
            // mainGroupBox
            // 
            mainGroupBox.Controls.Add(btnTLP);
            mainGroupBox.Controls.Add(mainPanel);
            mainGroupBox.Controls.Add(transformsTLP);
            mainGroupBox.Dock = DockStyle.Fill;
            mainGroupBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mainGroupBox.Location = new Point(741, 71);
            mainGroupBox.Name = "mainGroupBox";
            mainGroupBox.Size = new Size(289, 505);
            mainGroupBox.TabIndex = 2;
            mainGroupBox.TabStop = false;
            mainGroupBox.Text = "Преобразования";
            // 
            // btnTLP
            // 
            btnTLP.ColumnCount = 3;
            btnTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            btnTLP.ColumnStyles.Add(new ColumnStyle());
            btnTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            btnTLP.Controls.Add(applyBtn, 1, 0);
            btnTLP.Dock = DockStyle.Fill;
            btnTLP.Location = new Point(3, 321);
            btnTLP.Name = "btnTLP";
            btnTLP.RowCount = 1;
            btnTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            btnTLP.Size = new Size(283, 181);
            btnTLP.TabIndex = 2;
            // 
            // applyBtn
            // 
            applyBtn.Anchor = AnchorStyles.None;
            applyBtn.Location = new Point(80, 69);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(123, 43);
            applyBtn.TabIndex = 0;
            applyBtn.Text = "Применить";
            applyBtn.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(movePanel);
            mainPanel.Controls.Add(sheerPanel);
            mainPanel.Controls.Add(rotatePanel);
            mainPanel.Controls.Add(scalePanel);
            mainPanel.Dock = DockStyle.Top;
            mainPanel.Location = new Point(3, 104);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(283, 217);
            mainPanel.TabIndex = 1;
            // 
            // sheerPanel
            // 
            sheerPanel.ColumnCount = 2;
            sheerPanel.ColumnStyles.Add(new ColumnStyle());
            sheerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sheerPanel.Controls.Add(xLabelSheer, 0, 0);
            sheerPanel.Controls.Add(yLabelSheer, 0, 1);
            sheerPanel.Controls.Add(xBoxSheer, 1, 0);
            sheerPanel.Controls.Add(yBoxSheer, 1, 1);
            sheerPanel.Dock = DockStyle.Fill;
            sheerPanel.Location = new Point(0, 0);
            sheerPanel.Name = "sheerPanel";
            sheerPanel.RowCount = 2;
            sheerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sheerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sheerPanel.Size = new Size(283, 217);
            sheerPanel.TabIndex = 3;
            // 
            // xLabelSheer
            // 
            xLabelSheer.Anchor = AnchorStyles.None;
            xLabelSheer.AutoSize = true;
            xLabelSheer.Location = new Point(3, 41);
            xLabelSheer.Name = "xLabelSheer";
            xLabelSheer.Size = new Size(23, 25);
            xLabelSheer.TabIndex = 0;
            xLabelSheer.Text = "X";
            // 
            // yLabelSheer
            // 
            yLabelSheer.Anchor = AnchorStyles.None;
            yLabelSheer.AutoSize = true;
            yLabelSheer.Location = new Point(3, 150);
            yLabelSheer.Name = "yLabelSheer";
            yLabelSheer.Size = new Size(23, 25);
            yLabelSheer.TabIndex = 1;
            yLabelSheer.Text = "Y";
            // 
            // xBoxSheer
            // 
            xBoxSheer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            xBoxSheer.Location = new Point(32, 37);
            xBoxSheer.Name = "xBoxSheer";
            xBoxSheer.Size = new Size(248, 33);
            xBoxSheer.TabIndex = 2;
            // 
            // yBoxSheer
            // 
            yBoxSheer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yBoxSheer.Location = new Point(32, 146);
            yBoxSheer.Name = "yBoxSheer";
            yBoxSheer.Size = new Size(248, 33);
            yBoxSheer.TabIndex = 3;
            // 
            // rotatePanel
            // 
            rotatePanel.ColumnCount = 2;
            rotatePanel.ColumnStyles.Add(new ColumnStyle());
            rotatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rotatePanel.Controls.Add(angleBox, 1, 0);
            rotatePanel.Controls.Add(angleLabel, 0, 0);
            rotatePanel.Dock = DockStyle.Fill;
            rotatePanel.Location = new Point(0, 0);
            rotatePanel.Name = "rotatePanel";
            rotatePanel.RowCount = 1;
            rotatePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rotatePanel.Size = new Size(283, 217);
            rotatePanel.TabIndex = 3;
            // 
            // angleBox
            // 
            angleBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            angleBox.Location = new Point(146, 92);
            angleBox.Name = "angleBox";
            angleBox.Size = new Size(134, 33);
            angleBox.TabIndex = 1;
            // 
            // angleLabel
            // 
            angleLabel.Anchor = AnchorStyles.None;
            angleLabel.AutoSize = true;
            angleLabel.Location = new Point(3, 96);
            angleLabel.Name = "angleLabel";
            angleLabel.Size = new Size(137, 25);
            angleLabel.TabIndex = 2;
            angleLabel.Text = "Угол (градусы)";
            // 
            // scalePanel
            // 
            scalePanel.ColumnCount = 2;
            scalePanel.ColumnStyles.Add(new ColumnStyle());
            scalePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            scalePanel.Controls.Add(sxLabel, 0, 0);
            scalePanel.Controls.Add(syLabel, 0, 1);
            scalePanel.Controls.Add(sxBox, 1, 0);
            scalePanel.Controls.Add(syBox, 1, 1);
            scalePanel.Dock = DockStyle.Fill;
            scalePanel.Location = new Point(0, 0);
            scalePanel.Name = "scalePanel";
            scalePanel.RowCount = 2;
            scalePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            scalePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            scalePanel.Size = new Size(283, 217);
            scalePanel.TabIndex = 3;
            // 
            // sxLabel
            // 
            sxLabel.Anchor = AnchorStyles.None;
            sxLabel.AutoSize = true;
            sxLabel.Location = new Point(3, 41);
            sxLabel.Name = "sxLabel";
            sxLabel.Size = new Size(31, 25);
            sxLabel.TabIndex = 0;
            sxLabel.Text = "Sx";
            // 
            // syLabel
            // 
            syLabel.Anchor = AnchorStyles.None;
            syLabel.AutoSize = true;
            syLabel.Location = new Point(3, 150);
            syLabel.Name = "syLabel";
            syLabel.Size = new Size(30, 25);
            syLabel.TabIndex = 1;
            syLabel.Text = "Sy";
            // 
            // sxBox
            // 
            sxBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sxBox.Location = new Point(40, 37);
            sxBox.Name = "sxBox";
            sxBox.Size = new Size(240, 33);
            sxBox.TabIndex = 2;
            // 
            // syBox
            // 
            syBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            syBox.Location = new Point(40, 146);
            syBox.Name = "syBox";
            syBox.Size = new Size(240, 33);
            syBox.TabIndex = 3;
            // 
            // movePanel
            // 
            movePanel.ColumnCount = 2;
            movePanel.ColumnStyles.Add(new ColumnStyle());
            movePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            movePanel.Controls.Add(xLabelMove, 0, 0);
            movePanel.Controls.Add(yLabelMove, 0, 1);
            movePanel.Controls.Add(xBoxMove, 1, 0);
            movePanel.Controls.Add(yBoxMove, 1, 1);
            movePanel.Dock = DockStyle.Fill;
            movePanel.Location = new Point(0, 0);
            movePanel.Name = "movePanel";
            movePanel.RowCount = 2;
            movePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            movePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            movePanel.Size = new Size(283, 217);
            movePanel.TabIndex = 3;
            // 
            // xLabelMove
            // 
            xLabelMove.Anchor = AnchorStyles.None;
            xLabelMove.AutoSize = true;
            xLabelMove.Location = new Point(3, 41);
            xLabelMove.Name = "xLabelMove";
            xLabelMove.Size = new Size(23, 25);
            xLabelMove.TabIndex = 0;
            xLabelMove.Text = "X";
            // 
            // yLabelMove
            // 
            yLabelMove.Anchor = AnchorStyles.None;
            yLabelMove.AutoSize = true;
            yLabelMove.Location = new Point(3, 150);
            yLabelMove.Name = "yLabelMove";
            yLabelMove.Size = new Size(23, 25);
            yLabelMove.TabIndex = 1;
            yLabelMove.Text = "Y";
            // 
            // xBoxMove
            // 
            xBoxMove.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            xBoxMove.Location = new Point(32, 37);
            xBoxMove.Name = "xBoxMove";
            xBoxMove.Size = new Size(248, 33);
            xBoxMove.TabIndex = 2;
            // 
            // yBoxMove
            // 
            yBoxMove.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yBoxMove.Location = new Point(32, 146);
            yBoxMove.Name = "yBoxMove";
            yBoxMove.Size = new Size(248, 33);
            yBoxMove.TabIndex = 3;
            // 
            // transformsTLP
            // 
            transformsTLP.ColumnCount = 3;
            transformsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            transformsTLP.ColumnStyles.Add(new ColumnStyle());
            transformsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            transformsTLP.Controls.Add(transformsCombo, 1, 0);
            transformsTLP.Dock = DockStyle.Top;
            transformsTLP.Location = new Point(3, 29);
            transformsTLP.Name = "transformsTLP";
            transformsTLP.RowCount = 1;
            transformsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            transformsTLP.Size = new Size(283, 75);
            transformsTLP.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1030, 576);
            Controls.Add(mainGroupBox);
            Controls.Add(shapesTLP);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "ЛР2";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            shapesTLP.ResumeLayout(false);
            mainGroupBox.ResumeLayout(false);
            btnTLP.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            sheerPanel.ResumeLayout(false);
            sheerPanel.PerformLayout();
            rotatePanel.ResumeLayout(false);
            rotatePanel.PerformLayout();
            scalePanel.ResumeLayout(false);
            scalePanel.PerformLayout();
            movePanel.ResumeLayout(false);
            movePanel.PerformLayout();
            transformsTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private ComboBox shapesCombo;
        private ComboBox transformsCombo;
        private TableLayoutPanel shapesTLP;
        private GroupBox mainGroupBox;
        private TableLayoutPanel transformsTLP;
        private TableLayoutPanel btnTLP;
        private Button applyBtn;
        private Panel mainPanel;
        private TableLayoutPanel movePanel;
        private Label xLabelMove;
        private Label yLabelMove;
        private TextBox xBoxMove;
        private TextBox yBoxMove;
        private TableLayoutPanel rotatePanel;
        private TableLayoutPanel scalePanel;
        private Label sxLabel;
        private Label syLabel;
        private TextBox sxBox;
        private TextBox syBox;
        private TextBox angleBox;
        private Label angleLabel;
        private TableLayoutPanel sheerPanel;
        private Label xLabelSheer;
        private Label yLabelSheer;
        private TextBox xBoxSheer;
        private TextBox yBoxSheer;
    }
}
