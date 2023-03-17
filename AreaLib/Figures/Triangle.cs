using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Figures
{
    public class Triangle : IFigure
    {
        private double a = -1;
        private double b = -1;
        private double c = -1;

        public double GetArea()
        {
            if (a == -1 || b == -1 || c == -1)
                throw new InvalidDataException($"Parameters weren't initialized. Use \"{nameof(SetParameters)}\" to initialize data.");

            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void SetParameters(params double[] @params)
        {
            if (@params.Length != 3)
                throw new InvalidDataException($"Expected 3 parameter, but received {@params.Length}");

            a = @params[0];
            b = @params[1];
            c = @params[2];
        }

        public bool IsRight()
        {
            var sides = (new double[] { a, b, c }).OrderByDescending(x => x).ToList();

            return sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2];
        }
    }
}
