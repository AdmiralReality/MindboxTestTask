using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Figures
{
    public class Polygon : IFigure
    {
        private List<(double x, double y)> points = null;

        public double GetArea()
        {
            if (points is null)
                throw new InvalidDataException($"Parameters weren't initialized. Use \"{nameof(SetParameters)}\" to initialize data.");

            double result = 0;
            for (var i = 0; i < points.Count; i++)
            {
                var nextId = i + 1 == points.Count ? 0 : i + 1;
                result += points[i].x * points[nextId].y;
            }

            for (var i = 0; i < points.Count; i++)
            {
                var prevId = i - 1 < 0 ? points.Count - 1 : i - 1;
                result -= points[i].x * points[prevId].y;
            }

            return Math.Abs(result) * 0.5;
        }

        public void SetParameters(params double[] @params)
        {
            if (@params.Length % 2 != 0)
                throw new InvalidDataException($"Expected divisible by 2 parameters ({@params.Length - 1} or {@params.Length - 2}), but received {@params.Length}");

            points = new();
            for (var i = 0; i < @params.Length; i += 2)
                points.Add((@params[i], @params[i + 1]));
        }
    }
}
