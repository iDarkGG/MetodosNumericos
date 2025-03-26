using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
namespace Metodos_Numericos;

public class HerramientasCalculo
{

    public void TableBuilderPuntoFijo(int iteracion, double raiz, double errorAprox)
    {
        string row = string.Format("{0,10} | {1,20} | {2,15:E6}", iteracion, raiz, errorAprox + "%");
        Console.WriteLine(new string('-', (Constantes.headerBisecc.Length+5)));
        Console.WriteLine(row);
    }

    public void TableBuilder(int iteracion, double raiz, double errorAprox)
    {

        string row = string.Format("{0,10} | {1,20} | {2,15:E6}", iteracion, raiz, errorAprox + "%");
    
        Console.WriteLine(new string('-', (Constantes.headerBisecc.Length+5)));
        Console.WriteLine(row);
    }

    public void TableBuilderValorFalso(int iteracion, double limInf, double limSup, double evLimInf, double evLimSup,
        double raizAprox, double evRaizAprox, double errorAprox, int headerlength = 0)
    {

        string row = string.Format("{0,-12} | {1,-12} | {2,-12} | {3,-25} | {4,-25} | {5,-25} | {6,-25} | {7,-20}",
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
        return EvaluarEcuacion(xp, limInf).ToString().Contains('-') & !EvaluarEcuacion(xp, limSup).ToString().Contains('-');
    }
    
    public double ErrorAproximadoPorcentual(double NuevaRaiz, double RaizAnterior)
    {
        if (Constantes.contador == 1) return 0d;
        var result = ((NuevaRaiz - RaizAnterior) / NuevaRaiz) * 100;
        if(result.ToString().Contains('-')) result *= -1;
        Constantes.verif = result;
        return result;
    }
    

}
   