using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    partial class SvgZylinderTemplate
    {
        public int Height { get; private set; }
        public int Radius { get; private set; }
        public int startY { get; private set; }
        public int startX { get; private set; }
        public SvgZylinderTemplate(int height, int radius, int startY, int startX)
        {
            this.Height = height;
            this.Radius = radius;
            this.startY = startY;
            this.startX = startX;
        }
    }
}
