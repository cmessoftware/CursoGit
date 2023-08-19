public interface ICalculator
{
    /// <summary>
    /// Suma algebraica
    /// </summary>
    /// <param name="a"></param>
    /// <param name="y"></param>
    /// <returns></returns>
     double Add(double a, double y);

     double Mult(double x, double y);

     double Div(double x, double y);

     double Abs(double x, int module);

}