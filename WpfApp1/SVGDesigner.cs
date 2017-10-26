using System;

namespace WpfApp1
{
    public class SVGDesigner
    {
        public static String makeQuader(int height, int depth, int width)
        {
            SvgQuaderTemplate page = new SvgQuaderTemplate(height, width, depth, 200);
            return page.TransformText();
           // System.IO.File.WriteAllText("outputPage.html", pageContent);
        }

        public static string makeZylinder(int v1, int v2, int v3)
        {
            SvgZylinderTemplate temp = new SvgZylinderTemplate(v1, v2, v1+v2+v3, v1+v2+v3);
            return temp.TransformText();
        }
    }
}
