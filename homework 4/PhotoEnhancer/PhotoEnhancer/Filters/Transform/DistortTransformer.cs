using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class DistortTransformer : ITransformer<DistortionParameters>
    {
        Size oldSize { get; set; }
        double angleInRadians { get; set; }

        public Size ResultSize { get; private set; }

        public void Initialize(Size size, DistortionParameters parameters)
        {
            oldSize = size;
            angleInRadians = parameters.AngleInDegrees * Math.PI / 180;
            ResultSize = new Size(
                (int)(oldSize.Width + oldSize.Height * Math.Tan(angleInRadians)),
                oldSize.Height);
        }

        public Point? MapPoint(Point point)
        {
            point = new Point(point.X, point.Y);
            var x = (int)(point.X - point.Y * Math.Tan(angleInRadians));
            var y = point.Y;

            if (x < 0 || x >= oldSize.Width || y < 0 || y >= oldSize.Height)
                return null;

            return new Point(x, y);
        }
    }
}