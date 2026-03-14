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
            mainTLP = new TableLayoutPanel();
            comboBoxShapes = new ComboBox();
            transfromBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            mainTLP.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(741, 576);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // mainTLP
            // 
            mainTLP.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            mainTLP.ColumnCount = 1;
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mainTLP.Controls.Add(comboBoxShapes, 0, 0);
            mainTLP.Controls.Add(transfromBtn, 0, 1);
            mainTLP.Dock = DockStyle.Fill;
            mainTLP.Location = new Point(741, 0);
            mainTLP.Name = "mainTLP";
            mainTLP.RowCount = 2;
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainTLP.Size = new Size(289, 576);
            mainTLP.TabIndex = 1;
            // 
            // comboBoxShapes
            // 
            comboBoxShapes.Anchor = AnchorStyles.None;
            comboBoxShapes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxShapes.FormattingEnabled = true;
            comboBoxShapes.Items.AddRange(new object[] { "Прямоугольник", "Треугольник", "Звезда" });
            comboBoxShapes.Location = new Point(58, 127);
            comboBoxShapes.Name = "comboBoxShapes";
            comboBoxShapes.Size = new Size(172, 33);
            comboBoxShapes.TabIndex = 0;
            // 
            // transfromBtn
            // 
            transfromBtn.Anchor = AnchorStyles.None;
            transfromBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            transfromBtn.Location = new Point(55, 406);
            transfromBtn.Name = "transfromBtn";
            transfromBtn.Size = new Size(178, 50);
            transfromBtn.TabIndex = 1;
            transfromBtn.Text = "Преобразования";
            transfromBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1030, 576);
            Controls.Add(mainTLP);
            Controls.Add(pictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "ЛР2";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            mainTLP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private TableLayoutPanel mainTLP;
        private ComboBox comboBoxShapes;
        private Button transfromBtn;
    }
}
