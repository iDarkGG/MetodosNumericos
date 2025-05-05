using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
namespace Metodos_Numericos;

public class MetodoPosicionFalsa
{
    HerramientasCalculo hr = new HerramientasCalculo();
    FalsaPosicionIO fp = new FalsaPosicionIO();
    public int MetodoPosicionFalsoEV(Expression xp, double limInf, double limSup, double tolerancia, double RaizAnterior = 0, double tolResult = 100, int currentCount=0, int maxIteraciones =0 )
    {   
        double raiz = RaizAnterior;
        if (currentCount < maxIteraciones)
        {
            if (tolResult > tolerancia)
            {
                if (hr.VerificadorBolzano(xp, limInf, limSup))
                {
                    return GenerarRaizValorFalso(limInf, limSup,  xp, raiz, currentCount: currentCount, maxIteraciones: maxIteraciones, tolerancia: tolerancia);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            } 
        }
        
        return currentCount;
    }



    public int GenerarRaizValorFalso(double limInf, double limSup, Expression exp,  double raizAnterior, double tolerancia = 0, int currentCount = 0, int maxIteraciones = 0)
    {
        if (hr.VerificadorBolzano(exp, limInf, limSup))
        {
            currentCount++;
            var raiz = limSup - ((hr.EvaluarEcuacion(exp, limSup) * (limInf - limSup)) /
                                 (hr.EvaluarEcuacion(exp, limInf) - hr.EvaluarEcuacion(exp, limSup)));
            var evRaiz = hr.EvaluarEcuacion(exp, raiz);

            if (evRaiz < 0)
            {
                fp.Agregar(new FalsaPosicionIO(exp, hr.ErrorAproximadoPorcentual(raiz, raizAnterior, currentCount), currentCount, raiz));
                
                hr.TableBuilderValorFalso(currentCount, raiz, limSup, hr.EvaluarEcuacion(exp, raiz),
                    hr.EvaluarEcuacion(exp, limSup), raiz, evRaiz,
                    hr.ErrorAproximadoPorcentual(raiz, raizAnterior, currentCount));
                
                return MetodoPosicionFalsoEV(exp, raiz, limSup, tolerancia, RaizAnterior: raiz,
                    currentCount: currentCount,
                    tolResult: hr.ErrorAproximadoPorcentual(raiz, raizAnterior, currentCount),
                    maxIteraciones: maxIteraciones);
            }
            else
            {
                fp.Agregar(new FalsaPosicionIO(exp, hr.ErrorAproximadoPorcentual(raiz, raizAnterior, currentCount), currentCount, raiz));
                
                hr.TableBuilderValorFalso(currentCount, raiz, limSup, hr.EvaluarEcuacion(exp, raiz),
                    hr.EvaluarEcuacion(exp, limSup), raiz, evRaiz,
                    hr.ErrorAproximadoPorcentual(raiz, raizAnterior, currentCount));
                
                return MetodoPosicionFalsoEV(exp, limInf, raiz, tolerancia, RaizAnterior: raiz, currentCount: currentCount,
                    tolResult: hr.ErrorAproximadoPorcentual(raiz, raizAnterior, currentCount), maxIteraciones: maxIteraciones);
            }
        }
        return currentCount;
    }
    
}