using AreaLib.Figures;

namespace AreaLib.Helpers;

public static class FigureHelper
{
    public static double GetArea(IFigure figure)
    {
        return figure.GetArea();
    }
}
