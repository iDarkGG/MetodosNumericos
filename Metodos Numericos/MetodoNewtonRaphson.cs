using MathNet.Symbolics;

namespace Metodos_Numericos;

public class MetodoNewtonRaphson
{
    HerramientasCalculo hr = new HerramientasCalculo();
    NewtonRaphsonIO io = new NewtonRaphsonIO();
    public int MetodoNewton(Expression exp, double x0, double tolerancia, int iterMax = 0, double currentErr = 100,
        double raizAnterior = 0, int currentCount = 0)
    {
        if (currentCount < iterMax)
        {
            if (currentErr > tolerancia)
            {
                return CalcularRaizNewton(exp, x0, tolerancia,iterMax, currentErr, raizAnterior, currentCount);
            }
            
        }

        return currentCount;
    }
    
    public int CalcularRaizNewton(Expression exp, double x0, double tolerancia, int iterMax = 0,
        double currentErr = 100, double raizAnterior = 0, int currentCount = 0)
    {
        currentCount++;
        double raiz = x0 - ((hr.EvaluarEcuacion(exp, x0)) / (hr.EvaluarDerivada(exp, x0)));
        
        double error = hr.ErrorAproximadoPorcentual(raiz, raizAnterior, currentCount);
        io.Agregar(new NewtonRaphsonIO(exp, x0,hr.EvaluarEcuacion(exp, x0),hr.EvaluarDerivada(exp, x0), error, currentCount,raiz));
        hr.TableBuilderNewton(currentCount, x0, hr.EvaluarEcuacion(exp, x0), hr.EvaluarDerivada(exp, x0), raiz, error);
        return MetodoNewton(exp, raiz, tolerancia, iterMax, error, x0 , currentCount: currentCount);
    }
}