using MathNet.Symbolics;
using Expr = MathNet.Symbolics.Expression ;
using MathNet.Numerics;
namespace Metodos_Numericos;

public class HerramientasCalculo
{

    public void TableBuilderPuntoFijo(int iteracion, double raiz, double errorAprox)
    {
        string row = string.Format("{0,10} | {1,20} | {2,15:E6}", iteracion, raiz, errorAprox + "%");
        Console.WriteLine(new string('-', (Constantes.headerBisecc.Length)));
        Console.WriteLine(row);
    }

    public void TableBuilder(int iteracion, double raiz, double errorAprox)
    {
        string row = string.Format("{0,10} | {1,20} | {2,15:E6}", iteracion, raiz, errorAprox + "%");
        Console.WriteLine(new string('-', (Constantes.headerBisecc.Length)));
        Console.WriteLine(row);
    }


    public void TableBuilderNewton(int iteracion, double Xi, double fXi, double fPrimeXi, double Raiz,
        double errorAprox)
    {
        string row = string.Format("{0,10} | {1,20} | {2,20} | {3,20} | {4,20} | {5,20:}",
            iteracion, Xi, fXi, fPrimeXi, Raiz, errorAprox + "%");
        Console.WriteLine(new string('-', (Constantes.headerNewton.Length)));
        Console.WriteLine(row);
    }

    public void TableBuilderValorFalso(int iteracion, double limInf, double limSup, double evLimInf, double evLimSup,
        double raizAprox, double evRaizAprox, double errorAprox, int headerlength = 0)
    {

        string row = string.Format("{0,-8} | {1,-18} | {2,-12} | {3,-25} | {4,-25} | {5,-25} | {6,-25} | {7,-20}",
            iteracion, limInf, limSup, evLimInf, evLimSup, raizAprox, evRaizAprox, errorAprox+ "%");
    
        Console.WriteLine(new string('-', Constantes.headerValorFalso.Length));
        Console.WriteLine(row);
    }

    public Expression ExpressionSintax(string Ecuacion)
    {
        string[] expre = [""];
        if (Ecuacion.Contains('='))
        {
            expre = Ecuacion.Split('=');
            throw new Exception("Ten en cuenta que estas ingresando una funcion!");
        }
        
        return Infix.ParseOrThrow(Ecuacion);
    }
    
    public double EvaluarEcuacion(Expression exp, double termino)
    {
        double result = 0d;
        var simbolos = new Dictionary<string, FloatingPoint>{ {"x", termino} };
        try
        {
            result = Evaluate.Evaluate(simbolos, exp).RealValue;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return result;
    }

    public bool VerificadorBolzano(Expression xp, double limInf, double limSup)
    {
        return (EvaluarEcuacion(xp, limInf) * EvaluarEcuacion(xp, limSup)) < 0;
    }
    
    public double ErrorAproximadoPorcentual(double NuevaRaiz, double RaizAnterior, int contador=0)
    {
        if (contador <= 1) return 100d;
        var result = ((NuevaRaiz - RaizAnterior) / NuevaRaiz) * 100;
        return Math.Abs(result);
    }


    public double EvaluarDerivada(Expr exp, double termino)
    {
        Expression x = Expr.Symbol("x");
        try
        {
            var derivative = Calculus.Differentiate(x, exp);

            return EvaluarEcuacion(derivative, termino);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            return double.NaN;
        }
    }
    

}
   