using MathNet.Symbolics;

namespace Metodos_Numericos;

public class MetodoRungeKutta_4
{
    RungeKuttaIO rIO = new RungeKuttaIO();
    HerramientasCalculo hr = new HerramientasCalculo();
    public void RungeKutta(Expression expression, double xA, double yA, double xN, double h, double x0=0, double y0=0 ,double k1 = 0, double k2 = 0, double k3 = 0, double k4 = 0)
    {
        if (Math.Round(xA,3) <= xN)
        {

            Calculo(expression, xA, yA, xN, h, x0, y0);
        }

        
    }

    public void Calculo(Expression exp, double xi, double yi, double xN, double h, double x0, double y0)
    {
        double k1,k2,k3,k4;
        double xC = xi + (h / 2);
        k1=hr.EvaluarEcuacionDoble(exp, xi, yi);
        k2=hr.EvaluarEcuacionDoble(exp, xC, yCalc(yi,h,k1,2));
        k3=hr.EvaluarEcuacionDoble(exp, xC, yCalc(yi,h,k2,3));
        k4=hr.EvaluarEcuacionDoble(exp, xi+h, yCalc(yi,h,k3,4));
        double result = yi + (h / 6) * (k1 + 2 * (k2 + k3) + k4);

        if (Math.Round(xi, 3) == xN)
        {
            Console.WriteLine("|"+Math.Round(xi,3)+"|"+yi+"|----------|-----------|---------|---------------|");
            rIO.Agregar(new RungeKuttaIO(exp, Math.Round(xi,3), yi, 0d, 0d, 0d, 0d));

        }
        else
        {
            rIO.Agregar(new RungeKuttaIO(exp, Math.Round(xi,3), yi, k1, k2, k3, k4));
            Console.WriteLine("|"+Math.Round(xi,3)+"|"+yi+"|"+k1+"|"+k2+"|"+k3+"|"+k4);
        }
        

        
        RungeKutta(exp, (xi+h), result, xN,h, x0,y0 ,k1, k2, k3, k4);
    }
    

    public double yCalc(double y, double h, double kN, int C)
    {
        double result = 0d;
        if (C == 4)
        {
            result = y + kN*h;
            return result;
        }
        result = y + ((h*kN)/2) ;
        return result;
    }
    
    // public double xCalc(double x, double h, double kN, int C)
    // {
    //     double result = 0d;
    //     if (C == 4)
    //     {
    //         result = x + h;
    //         return result;
    //     }
    //     return x + (h/2) ;
    // }
}