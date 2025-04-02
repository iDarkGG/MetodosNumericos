using MathNet.Symbolics;
using Expr = MathNet.Symbolics.Expression ;
using MathNet.Numerics.LinearAlgebra;

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
    
    public void TableBuilderSecante(int iteracion, double Xi,double Xo ,double fXi, double fXo, double Raiz,
        double errorAprox)
    {
        string row = string.Format("{0,10} | {1,20} | {2,20} | {3,20} | {4,20} | {5,20} | {6,30}",
            iteracion, Xi, Xo , fXi, fXo, Raiz, errorAprox + "%");
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

    public Expr ExpressionSintax(string Ecuacion)
    {
        string[] expre = [""];
        if (Ecuacion.Contains('='))
        {
            expre = Ecuacion.Split('=');
            throw new Exception("Ten en cuenta que estas ingresando una funcion!");
        }
        
        return Infix.ParseOrThrow(Ecuacion);
    }
    
    public double EvaluarEcuacion(Expr exp, double termino)
    {
        double result = 0d;
        var simbolos = new Dictionary<string, FloatingPoint>{ {"x", termino} };
        try
        {
            result = Evaluate.Evaluate(simbolos, exp).RealValue;
        }
        catch (Exception e)
        {
            
        }

        return result;
    }

    public bool VerificadorBolzano(Expr xp, double limInf, double limSup)
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
        Expr x = Expr.Symbol("x");
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

    public Matrix<double> MatrizJacobiana(List<Expr> exps, List<double> values, int n)
    {
        var valores2 = new Dictionary<string, FloatingPoint>
        {
            { "x", values[0]},
            { "y", values[1] }
        };
        var valores3 = new Dictionary<string, FloatingPoint>
        {
            { "x", values[0] },
            { "y", values[1] },
            { "z", values[2] }
        };
        List<Expression> resultDerivada = new List<Expression>();
        var matrix = Matrix<double>.Build.Dense(n, n);
        EvaluarDerivada(exps, n);
        switch (n)
        {
            case 2:
                if ((resultDerivada.Count > 4 & exps.Count==2) | (resultDerivada.Count < 4 & exps.Count==2))
                {
                    throw new Exception(
                        "Las derivadas resultantes no pueden ser mayor a la cantidad de ecuaciones/funciones");
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Evaluate.Evaluate(valores2, resultDerivada[j]).RealValue;
                        if (i == 1)
                        {
                            matrix[i, j] = Evaluate.Evaluate(valores2, resultDerivada[j+2]).RealValue;
                        }
                    }
                }
                break;
            case 3:
                if ((resultDerivada.Count > 6 & exps.Count!=3) | (resultDerivada.Count < 6 & exps.Count!=3))
                {
                    throw new Exception(
                        "Las derivadas resultantes no pueden ser mayor a la cantidad de ecuaciones/funciones");
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Evaluate.Evaluate(valores3, resultDerivada[j]).RealValue;
                        if (i == 2)
                        {
                            matrix[i, j] = Evaluate.Evaluate(valores3, resultDerivada[j+6]).RealValue;
                        }
                    }
                }
                break;
        }
        //var inversa = matrix.Inverse();
        return matrix;
    }

    public List<Expr> EvaluarDerivada(List<Expr> xp, int n)
    {
        List<Expr> results = new List<Expr>();
        if (n == 2)
        {
            results.Add(Calculus.Differentiate(Expr.Symbol("x"), xp[0]));
            results.Add(Calculus.Differentiate(Expr.Symbol("y"), xp[0]));
            //2
            results.Add(Calculus.Differentiate(Expr.Symbol("x"), xp[1]));
            results.Add(Calculus.Differentiate(Expr.Symbol("y"), xp[1]));
            return results;
        }
        if (n == 3)
        {
            results.Add(Calculus.Differentiate(Expr.Symbol("x"), xp[0]));
            results.Add(Calculus.Differentiate(Expr.Symbol("y"), xp[0]));
            results.Add(Calculus.Differentiate(Expr.Symbol("z"), xp[0]));
            //2
            results.Add(Calculus.Differentiate(Expr.Symbol("x"), xp[1]));
            results.Add(Calculus.Differentiate(Expr.Symbol("y"), xp[1]));
            results.Add(Calculus.Differentiate(Expr.Symbol("z"), xp[1]));
            //3
            results.Add(Calculus.Differentiate(Expr.Symbol("x"), xp[2]));
            results.Add(Calculus.Differentiate(Expr.Symbol("y"), xp[2]));
            results.Add(Calculus.Differentiate(Expr.Symbol("z"), xp[2]));
        }
        
        return results;
    }
}
   