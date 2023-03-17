namespace AreaLib.Figures;

public interface IFigure
{
    void SetParameters(params double[] @params);
    double GetArea();
}