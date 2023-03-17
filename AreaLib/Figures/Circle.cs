using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.Figures
{
    public class Circle : IFigure
    {
        private double radius = -1;

        public double GetArea()
        {
            if (radius == -1)
                throw new InvalidDataException($"Parameters weren't initialized. Use \"{nameof(SetParameters)}\" to initialize data.");

            return Math.PI * radius * radius;
        }

        public void SetParameters(params double[] @params)
        {
            if (@params.Length != 1)
                throw new InvalidDataException($"Expected 1 parameter, but received {@params.Length}");

            radius = @params[0];
        }
    }
}
