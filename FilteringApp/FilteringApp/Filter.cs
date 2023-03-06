using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringApp
{
    public class Filter
    {
        public string Name { get; set; }
        public double[,] kernel { get; set; }
        public double divisor { get; set; }
        public double redOffset { get; set; }
        public double greenOffset { get; set; }
        public double blueOffset { get; set; }
        public int anchorX { get; set; }
        public int anchorY { get; set; }

        public Filter(string name) {
            Name = name;
            kernel = new double[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            divisor = kernel.Cast<double>().Sum() == 0 ? 1 : kernel.Cast<double>().Sum();
            redOffset = 0; greenOffset = 0; blueOffset = 0;
            anchorY = kernel.GetLength(0) / 2 + 1;
            anchorX = kernel.GetLength(1) / 2 + 1;
        }
        public void Apply(Form1 form)
        {
            form.ApplyConvultionFilter(kernel, divisor, redOffset, greenOffset, blueOffset, anchorX, anchorY);
        }
    }
}
