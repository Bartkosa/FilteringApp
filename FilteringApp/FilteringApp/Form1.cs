using System;
using System.Windows.Forms;

namespace FilteringApp
{
    public partial class Form1 : Form
    {
        Filter blurFilter = new Filter("blur");
        Filter smoothingFilter = new Filter("smoothing");
        Filter sharpenFilter = new Filter("sharpen");
        Filter edgeFilter = new Filter("edge");
        Filter embossFilter = new Filter("emboss");
        List<Filter> customFilters = new List<Filter>();

        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.ColumnCount = 9;
            blurFilter.kernel = new double[,] { { 1.0, 1.0, 1.0 }, { 1.0, 1.0, 1.0 }, { 1.0, 1.0, 1.0 } };
            smoothingFilter.kernel = new double[,] { { 0, 1.0, 0 }, { 1.0, 4.0, 1.0 }, { 0, 1.0, 0 } };
            sharpenFilter.kernel = new double[,] { { 0, -1.0, 0 }, { -1.0, 5.0, -1.0 }, { 0, -1.0, 0 } };
            edgeFilter.kernel = new double[,] { { 0, -1.0, 0 }, { -1.0, 4.0, -1.0 }, { 0, -1.0, 0 } };
            embossFilter.kernel = new double[,] { { -1.0, 0, 1.0 }, { -1.0, 1.0, 1.0 }, { -1.0, 0, 1.0 } };
            GenerateTextBoxes(9, 9);
        }

        private void UpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownWidth.Value % 2 == 0)
                UpDownWidth.Value--;
            int numCols = (int)UpDownWidth.Value, numRows = tableLayoutPanel1.RowCount;
            tableLayoutPanel1.ColumnCount = numCols;

            tableLayoutPanel1.Controls.Clear();

            GenerateTextBoxes(numRows, numCols);
        }

        private void UpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownHeight.Value % 2 == 0)
                UpDownHeight.Value--;
            int numRows = (int)UpDownHeight.Value, numCols = tableLayoutPanel1.ColumnCount;
            tableLayoutPanel1.RowCount = numRows;

            tableLayoutPanel1.Controls.Clear();

            GenerateTextBoxes(numRows, numCols);
        }

        private void GenerateTextBoxes(int numRows, int numCols)
        {
            TextBox[,] matrixBoxes = new TextBox[numRows, numCols];
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    TextBox textBox = new TextBox();
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.Width = 30;
                    textBox.Name = "Box-" + row + "-" + col;
                    textBox.Text = "0";
                    matrixBoxes[row, col] = textBox;
                    tableLayoutPanel1.RowStyles[0].Height = 30;
                    tableLayoutPanel1.Controls.Add(textBox, col, row);
                }
            }
        }


        private void Auto_button_Click(object sender, EventArgs e)
        {
            int divisor = 0;
            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.RowCount; j++)
                {
                    string boxName = "Box-" + j + "-" + i;
                    Control[] controls = tableLayoutPanel1.Controls.Find(boxName, true);
                    if (controls[0] is TextBox textBox)
                        divisor += int.Parse(textBox.Text);
                }
            }
            UpDownDivisor.Value = divisor == 0 ? 1 : divisor;
        }

        private void UpDownDivisor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UpDownDivisor.Value == 0)
            {
                e.Cancel = true;
                MessageBox.Show("Divisor cannot be equal to 0");
                UpDownDivisor.Value = 1;
            }
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            if (Filter_combo.SelectedItem == null)
            {
                MessageBox.Show("Choose filter!");
                return;
            }

            Dictionary<string, Filter> filters = new Dictionary<string, Filter>()
            {
                { "Blur", blurFilter },
                { "Smoothing", smoothingFilter },
                { "Sharpen", sharpenFilter },
                { "Edge detection", edgeFilter },
                { "Emboss", embossFilter }
            };
            if (Filter_combo.Text == "Custom filter")
            {

                Filter newFilter = new Filter("custom " + (customFilters.Count + 1));
                newFilter.redOffset = (double)UpDownRed.Value;
                newFilter.greenOffset = (double)UpDownGreen.Value;
                newFilter.blueOffset = (double)UpDownBlue.Value;
                newFilter.divisor = (double)UpDownDivisor.Value;
                newFilter.kernel = GetKernel();
                newFilter.anchorX = (int)UpDownAnchorX.Value;
                newFilter.anchorY = (int)UpDownAnchorY.Value;
                customFilters.Add(newFilter);
                customFiltersBox.Items.Add(newFilter.Name);
            }
            else
            {
                string selectedFilterName = Filter_combo.Text;
                Filter selectedFilter = filters[selectedFilterName];

                selectedFilter.redOffset = (double)UpDownRed.Value;
                selectedFilter.greenOffset = (double)UpDownGreen.Value;
                selectedFilter.blueOffset = (double)UpDownBlue.Value;
                selectedFilter.divisor = (double)UpDownDivisor.Value;
                selectedFilter.kernel = GetKernel();
                selectedFilter.anchorX = (int)UpDownAnchorX.Value;
                selectedFilter.anchorY = (int)UpDownAnchorY.Value;

            }
        }

        private double[,] GetKernel()
        {
            TextBox[,] matrixBoxes = new TextBox[tableLayoutPanel1.RowCount, tableLayoutPanel1.ColumnCount];
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is TextBox textBox)
                {
                    int row = tableLayoutPanel1.GetRow(control);
                    int col = tableLayoutPanel1.GetColumn(control);
                    matrixBoxes[row, col] = textBox;
                }
            }

            int numRows = matrixBoxes.GetLength(0);
            int numCols = matrixBoxes.GetLength(1);

            double[,] kernel = new double[numRows, numCols];

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    double value;
                    if (double.TryParse(matrixBoxes[row, col].Text, out value))
                    {
                        kernel[row, col] = value;
                    }
                    else
                    {
                        MessageBox.Show("bla bla bla");
                    }
                }
            }
            return kernel;
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
                ApplyConvultionFilter(GetKernel(), (double)UpDownDivisor.Value,
                    (double)UpDownRed.Value, (double)UpDownGreen.Value, (double)UpDownBlue.Value, (int)UpDownAnchorX.Value, (int)UpDownAnchorY.Value);
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                OutputImage.Image = new Bitmap(InputImage.Image);
                OutputImage.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void Inverse_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                Bitmap outputBitmap = new Bitmap(InputImage.Image.Width, InputImage.Image.Height);

                for (int y = 0; y < InputImage.Image.Height; y++)
                {
                    for (int x = 0; x < InputImage.Image.Width; x++)
                    {
                        Color inputColor;
                        if (OutputImage.Image != null)
                            inputColor = ((Bitmap)OutputImage.Image).GetPixel(x, y);
                        else
                            inputColor = ((Bitmap)InputImage.Image).GetPixel(x, y);

                        int red = 255 - inputColor.R;
                        int green = 255 - inputColor.G;
                        int blue = 255 - inputColor.B;

                        Color outputColor = Color.FromArgb(red, green, blue);
                        outputBitmap.SetPixel(x, y, outputColor);


                    }
                }
                OutputImage.SizeMode = PictureBoxSizeMode.Zoom;
                OutputImage.Image = outputBitmap;
            }
        }

        private void More_Brightness_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                Bitmap outputBitmap = new Bitmap(InputImage.Image.Width, InputImage.Image.Height);

                for (int y = 0; y < InputImage.Image.Height; y++)
                {
                    for (int x = 0; x < InputImage.Image.Width; x++)
                    {
                        Color inputColor;
                        if (OutputImage.Image != null)
                            inputColor = ((Bitmap)OutputImage.Image).GetPixel(x, y);
                        else
                            inputColor = ((Bitmap)InputImage.Image).GetPixel(x, y);

                        int brightness_value = 50;
                        int red = Math.Min(inputColor.R + brightness_value, 255);
                        int green = Math.Min(inputColor.G + brightness_value, 255);
                        int blue = Math.Min(inputColor.B + brightness_value, 255);

                        Color outputColor = Color.FromArgb(red, green, blue);
                        outputBitmap.SetPixel(x, y, outputColor);
                    }
                }
                OutputImage.SizeMode = PictureBoxSizeMode.Zoom;
                OutputImage.Image = outputBitmap;
            }
        }

        private void Less_Brightness_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                Bitmap outputBitmap = new Bitmap(InputImage.Image.Width, InputImage.Image.Height);

                for (int y = 0; y < InputImage.Image.Height; y++)
                {
                    for (int x = 0; x < InputImage.Image.Width; x++)
                    {
                        Color inputColor;
                        if (OutputImage.Image != null)
                            inputColor = ((Bitmap)OutputImage.Image).GetPixel(x, y);
                        else
                            inputColor = ((Bitmap)InputImage.Image).GetPixel(x, y);

                        int brightness_value = 50;
                        int red = Math.Max(inputColor.R - brightness_value, 0);
                        int green = Math.Max(inputColor.G - brightness_value, 0);
                        int blue = Math.Max(inputColor.B - brightness_value, 0);

                        Color outputColor = Color.FromArgb(red, green, blue);
                        outputBitmap.SetPixel(x, y, outputColor);
                    }
                }
                OutputImage.SizeMode = PictureBoxSizeMode.Zoom;
                OutputImage.Image = outputBitmap;
            }
        }

        private void More_Contrast_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                double contrast = Math.Pow((100.0 + 50) / 100.0, 2);

                ApplyContrast(contrast);
            }
        }

        private void Less_Contrast_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                double contrast = Math.Pow((100.0 - 50) / 100.0, 2);

                ApplyContrast(contrast);
            }
        }

        private void ApplyContrast(double contrastValue)
        {
            Bitmap outputBitmap = new Bitmap(InputImage.Image.Width, InputImage.Image.Height);

            for (int y = 0; y < InputImage.Image.Height; y++)
            {
                for (int x = 0; x < InputImage.Image.Width; x++)
                {
                    Color inputColor;
                    if (OutputImage.Image != null)
                        inputColor = ((Bitmap)OutputImage.Image).GetPixel(x, y);
                    else
                        inputColor = ((Bitmap)InputImage.Image).GetPixel(x, y);

                    int red = (int)(((((inputColor.R / 255.0) - 0.5) * contrastValue) + 0.5) * 255.0);
                    int green = (int)(((((inputColor.G / 255.0) - 0.5) * contrastValue) + 0.5) * 255.0);
                    int blue = (int)(((((inputColor.B / 255.0) - 0.5) * contrastValue) + 0.5) * 255.0);

                    if (red < 0) red = 0; else if (red > 255) red = 255;
                    if (green < 0) green = 0; else if (green > 255) green = 255;
                    if (blue < 0) blue = 0; else if (blue > 255) blue = 255;

                    Color outputColor = Color.FromArgb(red, green, blue);
                    outputBitmap.SetPixel(x, y, outputColor);
                }
            }
            OutputImage.SizeMode = PictureBoxSizeMode.Zoom;
            OutputImage.Image = outputBitmap;
        }

        private void More_Gamma_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                double gammaValue = 0.5;

                ApplyGammaCorrection(gammaValue);
            }
        }

        private void Less_Gamma_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                double gammaValue = 2;

                ApplyGammaCorrection(gammaValue);
            }
        }

        private void ApplyGammaCorrection(double gammaValue)
        {
            Bitmap outputBitmap = new Bitmap(InputImage.Image.Width, InputImage.Image.Height);

            for (int y = 0; y < InputImage.Image.Height; y++)
            {
                for (int x = 0; x < InputImage.Image.Width; x++)
                {
                    Color inputColor;
                    if (OutputImage.Image != null)
                        inputColor = ((Bitmap)OutputImage.Image).GetPixel(x, y);
                    else
                        inputColor = ((Bitmap)InputImage.Image).GetPixel(x, y);

                    int red = (int)(255 * Math.Pow(inputColor.R / 255.0, gammaValue));
                    int green = (int)(255 * Math.Pow(inputColor.G / 255.0, gammaValue));
                    int blue = (int)(255 * Math.Pow(inputColor.B / 255.0, gammaValue));

                    if (red < 0) red = 0; else if (red > 255) red = 255;
                    if (green < 0) green = 0; else if (green > 255) green = 255;
                    if (blue < 0) blue = 0; else if (blue > 255) blue = 255;

                    Color outputColor = Color.FromArgb(red, green, blue);
                    outputBitmap.SetPixel(x, y, outputColor);
                }
            }
            OutputImage.SizeMode = PictureBoxSizeMode.Zoom;
            OutputImage.Image = outputBitmap;
        }

        public void ApplyConvultionFilter(double[,] kernel, double divisor, double redOffset, double greenOffset, double blueOffset, int anchorX, int anchorY)
        {
            Bitmap outputBitmap = new Bitmap(InputImage.Image.Width, InputImage.Image.Height);

            int kernelWidth = kernel.GetLength(1), kernelHeight = kernel.GetLength(0);

            for (int y = 0; y < InputImage.Image.Height; y++)
            {
                for (int x = 0; x < InputImage.Image.Width; x++)
                {
                    double red = 0, green = 0, blue = 0;

                    for (int j = -(kernelHeight / 2); j <= (kernelHeight / 2); j++)
                    {
                        for (int i = -(kernelWidth / 2); i <= (kernelWidth / 2); i++)
                        {
                            int pixelX = x + i + (kernelWidth / 2) + 1 - anchorX;
                            int pixelY = y + j + (kernelHeight / 2) + 1 - anchorY;

                            pixelX = Math.Min(Math.Max(pixelX, 0), InputImage.Image.Width - 1);
                            pixelY = Math.Min(Math.Max(pixelY, 0), InputImage.Image.Height - 1);

                            Color pixelColor;
                            if (OutputImage.Image != null)
                                pixelColor = ((Bitmap)OutputImage.Image).GetPixel(pixelX, pixelY);
                            else
                                pixelColor = ((Bitmap)InputImage.Image).GetPixel(pixelX, pixelY);

                            red += redOffset + pixelColor.R * kernel[i + (kernelWidth / 2), j + (kernelHeight / 2)] / divisor;
                            green += greenOffset + pixelColor.G * kernel[i + (kernelWidth / 2), j + (kernelHeight / 2)] / divisor;
                            blue += blueOffset + pixelColor.B * kernel[i + (kernelWidth / 2), j + (kernelHeight / 2)] / divisor;
                        }
                    }
                    int redValue = (int)red;
                    int greenValue = (int)green;
                    int blueValue = (int)blue;

                    if (redValue < 0) redValue = 0; else if (redValue > 255) redValue = 255;
                    if (greenValue < 0) greenValue = 0; else if (greenValue > 255) greenValue = 255;
                    if (blueValue < 0) blueValue = 0; else if (blueValue > 255) blueValue = 255;

                    Color outputColor = Color.FromArgb(redValue, greenValue, blueValue);
                    outputBitmap.SetPixel(x, y, outputColor);
                }
            }
            OutputImage.SizeMode = PictureBoxSizeMode.Zoom;
            OutputImage.Image = outputBitmap;
        }

        private void Blur_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                blurFilter.Apply(this);
            }
        }

        private void Smoothing_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                smoothingFilter.Apply(this);
            }
        }

        private void Sharpen_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                sharpenFilter.Apply(this);
            }
        }

        private void Edge_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                edgeFilter.Apply(this);
            }
        }

        private void Emboss_button_Click(object sender, EventArgs e)
        {
            if (InputImage.Image != null)
            {
                embossFilter.Apply(this);
            }
        }

        private void uploadPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                InputImage.SizeMode = PictureBoxSizeMode.Zoom;
                InputImage.Image = Image.FromFile(fileName);
                OutputImage.SizeMode = PictureBoxSizeMode.Zoom;

                OutputImage.Image = Image.FromFile(fileName);
            }
        }


        private void saveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OutputImage.Image != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
                saveFileDialog1.Title = "Save Output Image";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    OutputImage.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void Custom_button_Click(object sender, EventArgs e)
        {
            if (customFiltersBox.SelectedItem != null)
            {
                Filter selectedFilter = customFilters.FirstOrDefault(f => f.Name == customFiltersBox.SelectedItem.ToString());
                if (selectedFilter != null && InputImage.Image != null)
                {
                    ApplyConvultionFilter(selectedFilter.kernel, selectedFilter.divisor,
                        selectedFilter.redOffset, selectedFilter.greenOffset, selectedFilter.blueOffset,
                        selectedFilter.anchorX, selectedFilter.anchorY);
                }
                else
                {
                    MessageBox.Show("Filter null or image");
                }
            }
            else
            {
                MessageBox.Show("Selected value null");
            }
        }

        private void Anchor_button_Click(object sender, EventArgs e)
        {
            UpDownAnchorX.Value = tableLayoutPanel1.ColumnCount / 2 + 1;
            UpDownAnchorY.Value = tableLayoutPanel1.RowCount / 2 + 1;
        }

        private void UpDownAnchorX_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(UpDownAnchorX.Value > tableLayoutPanel1.ColumnCount)
            {
                e.Cancel = true;
                MessageBox.Show("Anchor coordinates outside of the kernel!");
                UpDownAnchorX.Value = tableLayoutPanel1.ColumnCount / 2 + 1;
            }
        }

        private void UpDownAnchorY_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (UpDownAnchorY.Value > tableLayoutPanel1.RowCount)
            {
                e.Cancel = true;
                MessageBox.Show("Anchor coordinates outside of the kernel!");
                UpDownAnchorY.Value = tableLayoutPanel1.RowCount / 2 + 1;
            }
        }
    }
}