using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
namespace Metodos_Numericos;

public class MetodoValorFalso
{
    HerramientasCalculo hr = new HerramientasCalculo();
    public void MetodoValorFalsoEV(Expression xp, double limInf, double limSup, double tolerancia,  double RaizAnterior = 0)
    {
        double raiz = RaizAnterior;
        if (Constantes.verif > tolerancia)
        {
            if (hr.VerificadorBolzano(xp, limInf, limSup))
            {
                GenerarRaizValorFalso(limInf, limSup, xp, raiz);
            }
        } 
    }



    public void GenerarRaizValorFalso(double limInf, double limSup, Expression exp, double raizAnterior = 0)
    {
        Constantes.contador++;
        if (hr.VerificadorBolzano(exp, limInf, limSup))
        {
            var raiz = limSup - ((hr.EvaluarEcuacion(exp, limSup) * (limInf - limSup)) /
                                 (hr.EvaluarEcuacion(exp, limInf) - hr.EvaluarEcuacion(exp, limSup)));
            var evRaiz = hr.EvaluarEcuacion(exp, raiz);

            if (evRaiz.ToString().Contains('-'))
            {
                var result1 = hr.EvaluarEcuacion(exp, limInf);
                if (result1.ToString().Contains('-'))
                {
                    hr.TableBuilderValorFalso(Constantes.contador, raiz, limSup, hr.EvaluarEcuacion(exp, raiz),
                        hr.EvaluarEcuacion(exp, limSup), raiz, evRaiz, hr.ErrorAproximadoPorcentual(raiz, raizAnterior));
                    MetodoValorFalsoEV(exp, raiz, limSup, 0.01, raiz);
                }
                else
                {
                    MetodoValorFalsoEV(exp, limInf, raiz, 0.01);
                    Console.WriteLine("Nuevo lim sup");
                }
            }
        }
    }
}