namespace FilteringApp
{
    partial class Form1
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
            Reset_button = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            uploadPhotoToolStripMenuItem = new ToolStripMenuItem();
            saveResultToolStripMenuItem = new ToolStripMenuItem();
            InputImage = new PictureBox();
            OutputImage = new PictureBox();
            Inverse_button = new Button();
            More_Brightness_button = new Button();
            More_Contrast_button = new Button();
            More_Gamma_button = new Button();
            Less_Contrast_button = new Button();
            Less_Gamma_button = new Button();
            InputLabel = new Label();
            OutputLabel = new Label();
            Blur_button = new Button();
            Smoothing_button = new Button();
            Sharpen_button = new Button();
            Edge_button = new Button();
            Emboss_button = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            Less_Brightness_button = new Button();
            UpDownWidth = new NumericUpDown();
            UpDownHeight = new NumericUpDown();
            WidthLabel = new Label();
            HeightLabel = new Label();
            Auto_button = new Button();
            Divisor_label = new Label();
            UpDownDivisor = new NumericUpDown();
            Custom_button = new Button();
            Offset_label = new Label();
            UpDownRed = new NumericUpDown();
            Filter_combo = new ComboBox();
            Save_button = new Button();
            label1 = new Label();
            UpDownGreen = new NumericUpDown();
            UpDownBlue = new NumericUpDown();
            Apply_button = new Button();
            customFiltersBox = new ComboBox();
            Anchor_label = new Label();
            UpDownAnchorX = new NumericUpDown();
            UpDownAnchorY = new NumericUpDown();
            Anchor_button = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutputImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownDivisor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownAnchorX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownAnchorY).BeginInit();
            SuspendLayout();
            // 
            // Reset_button
            // 
            Reset_button.BackColor = Color.FromArgb(255, 128, 128);
            Reset_button.Location = new Point(12, 50);
            Reset_button.Name = "Reset_button";
            Reset_button.Size = new Size(290, 29);
            Reset_button.TabIndex = 0;
            Reset_button.Text = "Reset";
            Reset_button.UseVisualStyleBackColor = false;
            Reset_button.Click += Reset_button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(971, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uploadPhotoToolStripMenuItem, saveResultToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // uploadPhotoToolStripMenuItem
            // 
            uploadPhotoToolStripMenuItem.Name = "uploadPhotoToolStripMenuItem";
            uploadPhotoToolStripMenuItem.Size = new Size(141, 26);
            uploadPhotoToolStripMenuItem.Text = "Upload";
            uploadPhotoToolStripMenuItem.Click += uploadPhotoToolStripMenuItem_Click;
            // 
            // saveResultToolStripMenuItem
            // 
            saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            saveResultToolStripMenuItem.Size = new Size(141, 26);
            saveResultToolStripMenuItem.Text = "Save as";
            saveResultToolStripMenuItem.Click += saveResultToolStripMenuItem_Click;
            // 
            // InputImage
            // 
            InputImage.BackColor = SystemColors.ControlLight;
            InputImage.Location = new Point(316, 50);
            InputImage.Name = "InputImage";
            InputImage.Size = new Size(646, 399);
            InputImage.TabIndex = 2;
            InputImage.TabStop = false;
            // 
            // OutputImage
            // 
            OutputImage.BackColor = SystemColors.ControlLight;
            OutputImage.Location = new Point(316, 475);
            OutputImage.Name = "OutputImage";
            OutputImage.Size = new Size(646, 390);
            OutputImage.TabIndex = 3;
            OutputImage.TabStop = false;
            // 
            // Inverse_button
            // 
            Inverse_button.Location = new Point(12, 189);
            Inverse_button.Name = "Inverse_button";
            Inverse_button.Size = new Size(142, 29);
            Inverse_button.TabIndex = 4;
            Inverse_button.Text = "Inverse";
            Inverse_button.UseVisualStyleBackColor = true;
            Inverse_button.Click += Inverse_button_Click;
            // 
            // More_Brightness_button
            // 
            More_Brightness_button.Location = new Point(12, 84);
            More_Brightness_button.Name = "More_Brightness_button";
            More_Brightness_button.Size = new Size(142, 29);
            More_Brightness_button.TabIndex = 5;
            More_Brightness_button.Text = "More Brightness";
            More_Brightness_button.UseVisualStyleBackColor = true;
            More_Brightness_button.Click += More_Brightness_button_Click;
            // 
            // More_Contrast_button
            // 
            More_Contrast_button.Location = new Point(12, 119);
            More_Contrast_button.Name = "More_Contrast_button";
            More_Contrast_button.Size = new Size(142, 29);
            More_Contrast_button.TabIndex = 6;
            More_Contrast_button.Text = "More Contrast";
            More_Contrast_button.UseVisualStyleBackColor = true;
            More_Contrast_button.Click += More_Contrast_button_Click;
            // 
            // More_Gamma_button
            // 
            More_Gamma_button.Location = new Point(12, 154);
            More_Gamma_button.Name = "More_Gamma_button";
            More_Gamma_button.Size = new Size(142, 29);
            More_Gamma_button.TabIndex = 7;
            More_Gamma_button.Text = "More Gamma";
            More_Gamma_button.UseVisualStyleBackColor = true;
            More_Gamma_button.Click += More_Gamma_button_Click;
            // 
            // Less_Contrast_button
            // 
            Less_Contrast_button.Location = new Point(160, 119);
            Less_Contrast_button.Name = "Less_Contrast_button";
            Less_Contrast_button.Size = new Size(142, 29);
            Less_Contrast_button.TabIndex = 9;
            Less_Contrast_button.Text = "Less Contrast";
            Less_Contrast_button.UseVisualStyleBackColor = true;
            Less_Contrast_button.Click += Less_Contrast_button_Click;
            // 
            // Less_Gamma_button
            // 
            Less_Gamma_button.Location = new Point(160, 154);
            Less_Gamma_button.Name = "Less_Gamma_button";
            Less_Gamma_button.Size = new Size(142, 29);
            Less_Gamma_button.TabIndex = 10;
            Less_Gamma_button.Text = "Less Gamma";
            Less_Gamma_button.UseVisualStyleBackColor = true;
            Less_Gamma_button.Click += Less_Gamma_button_Click;
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.Location = new Point(583, 26);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(46, 20);
            InputLabel.TabIndex = 11;
            InputLabel.Text = "Input:";
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(592, 452);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(58, 20);
            OutputLabel.TabIndex = 12;
            OutputLabel.Text = "Output:";
            // 
            // Blur_button
            // 
            Blur_button.Location = new Point(160, 189);
            Blur_button.Name = "Blur_button";
            Blur_button.Size = new Size(142, 29);
            Blur_button.TabIndex = 13;
            Blur_button.Text = "Blur";
            Blur_button.UseVisualStyleBackColor = true;
            Blur_button.Click += Blur_button_Click;
            // 
            // Smoothing_button
            // 
            Smoothing_button.Location = new Point(12, 225);
            Smoothing_button.Name = "Smoothing_button";
            Smoothing_button.Size = new Size(142, 29);
            Smoothing_button.TabIndex = 14;
            Smoothing_button.Text = "Smoothing";
            Smoothing_button.UseVisualStyleBackColor = true;
            Smoothing_button.Click += Smoothing_button_Click;
            // 
            // Sharpen_button
            // 
            Sharpen_button.Location = new Point(160, 225);
            Sharpen_button.Name = "Sharpen_button";
            Sharpen_button.Size = new Size(142, 29);
            Sharpen_button.TabIndex = 15;
            Sharpen_button.Text = "Sharpen";
            Sharpen_button.UseVisualStyleBackColor = true;
            Sharpen_button.Click += Sharpen_button_Click;
            // 
            // Edge_button
            // 
            Edge_button.Location = new Point(12, 260);
            Edge_button.Name = "Edge_button";
            Edge_button.Size = new Size(142, 29);
            Edge_button.TabIndex = 16;
            Edge_button.Text = "Edge detection";
            Edge_button.UseVisualStyleBackColor = true;
            Edge_button.Click += Edge_button_Click;
            // 
            // Emboss_button
            // 
            Emboss_button.Location = new Point(160, 260);
            Emboss_button.Name = "Emboss_button";
            Emboss_button.Size = new Size(142, 29);
            Emboss_button.TabIndex = 17;
            Emboss_button.Text = "Emboss";
            Emboss_button.UseVisualStyleBackColor = true;
            Emboss_button.Click += Emboss_button_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Location = new Point(12, 379);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(290, 302);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // Less_Brightness_button
            // 
            Less_Brightness_button.Location = new Point(160, 84);
            Less_Brightness_button.Name = "Less_Brightness_button";
            Less_Brightness_button.Size = new Size(142, 29);
            Less_Brightness_button.TabIndex = 8;
            Less_Brightness_button.Text = "Less Brightness";
            Less_Brightness_button.UseVisualStyleBackColor = true;
            Less_Brightness_button.Click += Less_Brightness_button_Click;
            // 
            // UpDownWidth
            // 
            UpDownWidth.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            UpDownWidth.Location = new Point(70, 346);
            UpDownWidth.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            UpDownWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownWidth.Name = "UpDownWidth";
            UpDownWidth.Size = new Size(84, 27);
            UpDownWidth.TabIndex = 19;
            UpDownWidth.Value = new decimal(new int[] { 9, 0, 0, 0 });
            UpDownWidth.ValueChanged += UpDownWidth_ValueChanged;
            // 
            // UpDownHeight
            // 
            UpDownHeight.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            UpDownHeight.Location = new Point(223, 346);
            UpDownHeight.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            UpDownHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownHeight.Name = "UpDownHeight";
            UpDownHeight.Size = new Size(79, 27);
            UpDownHeight.TabIndex = 21;
            UpDownHeight.Value = new decimal(new int[] { 9, 0, 0, 0 });
            UpDownHeight.ValueChanged += UpDownHeight_ValueChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(12, 348);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(52, 20);
            WidthLabel.TabIndex = 22;
            WidthLabel.Text = "Width:";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Location = new Point(160, 348);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(57, 20);
            HeightLabel.TabIndex = 23;
            HeightLabel.Text = "Height:";
            // 
            // Auto_button
            // 
            Auto_button.Location = new Point(187, 686);
            Auto_button.Name = "Auto_button";
            Auto_button.Size = new Size(115, 29);
            Auto_button.TabIndex = 25;
            Auto_button.Text = "Auto compute";
            Auto_button.UseVisualStyleBackColor = true;
            Auto_button.Click += Auto_button_Click;
            // 
            // Divisor_label
            // 
            Divisor_label.AutoSize = true;
            Divisor_label.Location = new Point(12, 690);
            Divisor_label.Name = "Divisor_label";
            Divisor_label.Size = new Size(58, 20);
            Divisor_label.TabIndex = 28;
            Divisor_label.Text = "Divisor:";
            // 
            // UpDownDivisor
            // 
            UpDownDivisor.Location = new Point(76, 688);
            UpDownDivisor.Name = "UpDownDivisor";
            UpDownDivisor.Size = new Size(105, 27);
            UpDownDivisor.TabIndex = 29;
            UpDownDivisor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownDivisor.Validating += UpDownDivisor_Validating;
            // 
            // Custom_button
            // 
            Custom_button.BackColor = Color.FromArgb(255, 255, 192);
            Custom_button.Location = new Point(187, 295);
            Custom_button.Name = "Custom_button";
            Custom_button.Size = new Size(115, 29);
            Custom_button.TabIndex = 30;
            Custom_button.Text = "Apply custom";
            Custom_button.UseVisualStyleBackColor = false;
            Custom_button.Click += Custom_button_Click;
            // 
            // Offset_label
            // 
            Offset_label.AutoSize = true;
            Offset_label.Location = new Point(12, 728);
            Offset_label.Name = "Offset_label";
            Offset_label.Size = new Size(52, 20);
            Offset_label.TabIndex = 31;
            Offset_label.Text = "Offset:";
            // 
            // UpDownRed
            // 
            UpDownRed.BackColor = Color.Red;
            UpDownRed.Location = new Point(76, 726);
            UpDownRed.Maximum = new decimal(new int[] { 254, 0, 0, 0 });
            UpDownRed.Name = "UpDownRed";
            UpDownRed.Size = new Size(71, 27);
            UpDownRed.TabIndex = 32;
            // 
            // Filter_combo
            // 
            Filter_combo.FormattingEnabled = true;
            Filter_combo.Items.AddRange(new object[] { "Blur", "Smoothing", "Sharpen", "Edge detection", "Emboss", "Custom filter" });
            Filter_combo.Location = new Point(114, 802);
            Filter_combo.Name = "Filter_combo";
            Filter_combo.Size = new Size(188, 28);
            Filter_combo.TabIndex = 33;
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.FromArgb(0, 192, 0);
            Save_button.Location = new Point(160, 836);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(142, 29);
            Save_button.TabIndex = 34;
            Save_button.Text = "Save changes";
            Save_button.UseVisualStyleBackColor = false;
            Save_button.Click += Save_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 805);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 35;
            label1.Text = "Choose filter:";
            // 
            // UpDownGreen
            // 
            UpDownGreen.BackColor = Color.Lime;
            UpDownGreen.Location = new Point(153, 726);
            UpDownGreen.Maximum = new decimal(new int[] { 254, 0, 0, 0 });
            UpDownGreen.Name = "UpDownGreen";
            UpDownGreen.Size = new Size(71, 27);
            UpDownGreen.TabIndex = 36;
            // 
            // UpDownBlue
            // 
            UpDownBlue.BackColor = SystemColors.MenuHighlight;
            UpDownBlue.Location = new Point(230, 726);
            UpDownBlue.Maximum = new decimal(new int[] { 254, 0, 0, 0 });
            UpDownBlue.Name = "UpDownBlue";
            UpDownBlue.Size = new Size(72, 27);
            UpDownBlue.TabIndex = 37;
            // 
            // Apply_button
            // 
            Apply_button.BackColor = Color.FromArgb(255, 255, 192);
            Apply_button.Location = new Point(12, 836);
            Apply_button.Name = "Apply_button";
            Apply_button.Size = new Size(142, 29);
            Apply_button.TabIndex = 38;
            Apply_button.Text = "Apply filter";
            Apply_button.UseVisualStyleBackColor = false;
            Apply_button.Click += Apply_button_Click;
            // 
            // customFiltersBox
            // 
            customFiltersBox.FormattingEnabled = true;
            customFiltersBox.Location = new Point(12, 295);
            customFiltersBox.Name = "customFiltersBox";
            customFiltersBox.Size = new Size(169, 28);
            customFiltersBox.TabIndex = 39;
            customFiltersBox.Text = "Choose custom filter";
            // 
            // Anchor_label
            // 
            Anchor_label.AutoSize = true;
            Anchor_label.Location = new Point(12, 767);
            Anchor_label.Name = "Anchor_label";
            Anchor_label.Size = new Size(59, 20);
            Anchor_label.TabIndex = 40;
            Anchor_label.Text = "Anchor:";
            // 
            // UpDownAnchorX
            // 
            UpDownAnchorX.Location = new Point(76, 765);
            UpDownAnchorX.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            UpDownAnchorX.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownAnchorX.Name = "UpDownAnchorX";
            UpDownAnchorX.Size = new Size(50, 27);
            UpDownAnchorX.TabIndex = 41;
            UpDownAnchorX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownAnchorX.Validating += UpDownAnchorX_Validating;
            // 
            // UpDownAnchorY
            // 
            UpDownAnchorY.Location = new Point(132, 765);
            UpDownAnchorY.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            UpDownAnchorY.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownAnchorY.Name = "UpDownAnchorY";
            UpDownAnchorY.Size = new Size(49, 27);
            UpDownAnchorY.TabIndex = 42;
            UpDownAnchorY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownAnchorY.Validating += UpDownAnchorY_Validating;
            // 
            // Anchor_button
            // 
            Anchor_button.Location = new Point(187, 763);
            Anchor_button.Name = "Anchor_button";
            Anchor_button.Size = new Size(115, 29);
            Anchor_button.TabIndex = 43;
            Anchor_button.Text = "Middle point";
            Anchor_button.UseVisualStyleBackColor = true;
            Anchor_button.Click += Anchor_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 877);
            Controls.Add(Anchor_button);
            Controls.Add(UpDownAnchorY);
            Controls.Add(UpDownAnchorX);
            Controls.Add(Anchor_label);
            Controls.Add(customFiltersBox);
            Controls.Add(Apply_button);
            Controls.Add(UpDownBlue);
            Controls.Add(UpDownGreen);
            Controls.Add(label1);
            Controls.Add(Save_button);
            Controls.Add(Filter_combo);
            Controls.Add(UpDownRed);
            Controls.Add(Offset_label);
            Controls.Add(Custom_button);
            Controls.Add(UpDownDivisor);
            Controls.Add(Divisor_label);
            Controls.Add(Auto_button);
            Controls.Add(HeightLabel);
            Controls.Add(WidthLabel);
            Controls.Add(UpDownHeight);
            Controls.Add(UpDownWidth);
            Controls.Add(Inverse_button);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Emboss_button);
            Controls.Add(Edge_button);
            Controls.Add(Sharpen_button);
            Controls.Add(Smoothing_button);
            Controls.Add(Blur_button);
            Controls.Add(OutputLabel);
            Controls.Add(InputLabel);
            Controls.Add(Less_Gamma_button);
            Controls.Add(Less_Contrast_button);
            Controls.Add(Less_Brightness_button);
            Controls.Add(More_Gamma_button);
            Controls.Add(More_Contrast_button);
            Controls.Add(More_Brightness_button);
            Controls.Add(OutputImage);
            Controls.Add(InputImage);
            Controls.Add(Reset_button);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Filtering App";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutputImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownDivisor).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownAnchorX).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownAnchorY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Reset_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem uploadPhotoToolStripMenuItem;
        private PictureBox InputImage;
        private PictureBox OutputImage;
        private Button Inverse_button;
        private Button More_Brightness_button;
        private ToolStripMenuItem saveResultToolStripMenuItem;
        private Button More_Contrast_button;
        private Button More_Gamma_button;
        private Button Less_Contrast_button;
        private Button Less_Gamma_button;
        private Label InputLabel;
        private Label OutputLabel;
        private Button Blur_button;
        private Button Smoothing_button;
        private Button Sharpen_button;
        private Button Edge_button;
        private Button Emboss_button;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Less_Brightness_button;
        private NumericUpDown UpDownWidth;
        private NumericUpDown UpDownHeight;
        private Label WidthLabel;
        private Label HeightLabel;
        private ComboBox comboBox1;
        private Button Auto_button;
        private Label Divisor_label;
        private NumericUpDown UpDownDivisor;
        private Button Custom_button;
        private Label Offset_label;
        private NumericUpDown UpDownRed;
        private ComboBox Filter_combo;
        private Button Save_button;
        private Label label1;
        private NumericUpDown UpDownGreen;
        private NumericUpDown UpDownBlue;
        private Button Apply_button;
        private ComboBox customFiltersBox;
        private Label Anchor_label;
        private NumericUpDown UpDownAnchorX;
        private NumericUpDown UpDownAnchorY;
        private Button Anchor_button;
    }
}