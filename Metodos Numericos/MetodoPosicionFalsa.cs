using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
namespace Metodos_Numericos;

public class MetodoPosicionFalsa
{
    HerramientasCalculo hr = new HerramientasCalculo();
    public void MetodoPosicionFalsoEV(Expression xp, double limInf, double limSup, double tolerancia,  double RaizAnterior = 0)
    {
        double raiz = RaizAnterior;
        if (Constantes.verif > tolerancia)
        {
            if (hr.VerificadorBolzano(xp, limInf, limSup))
            {
                GenerarRaizValorFalso(limInf, limSup, xp, raiz, tolerancia);
            }
        } 
    }



    public void GenerarRaizValorFalso(double limInf, double limSup, Expression exp, double raizAnterior = 0, double tolerancia = 0)
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
                    MetodoPosicionFalsoEV(exp, raiz, limSup,tolerancia , raiz);
                }
                else
                {
                    hr.TableBuilderValorFalso(Constantes.contador, raiz, limSup, hr.EvaluarEcuacion(exp, raiz), 
                        hr.EvaluarEcuacion(exp, limSup), raiz, evRaiz, hr.ErrorAproximadoPorcentual(raiz, raizAnterior));
                    MetodoPosicionFalsoEV(exp, limInf, raiz, tolerancia);
                    Console.WriteLine("Nuevo lim sup");
                }
            }
        }
    }
}