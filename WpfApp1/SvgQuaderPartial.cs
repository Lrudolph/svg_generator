using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    partial class SvgQuaderTemplate
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Depth { get; private set; }
        public int Level { get; private set; }
        public SvgQuaderTemplate(int height, int width, int depth, int level)
        {
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
            this.Level = level;
        }
    }
}
