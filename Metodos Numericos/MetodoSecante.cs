using MathNet.Symbolics;

namespace Metodos_Numericos;

public class MetodoSecante
{

    HerramientasCalculo hr = new HerramientasCalculo();

    public int MetodoSecanteEv(Expression exp, double Xi, double Xo, double tolerancia, int maxIteraciones = 0,
        int currentCount = 0, double currentError = 100,  double xAnterior =0)
    {
        if (currentCount < maxIteraciones)
        {
            if (currentError > tolerancia)
            {
                return GenerarRaizSecante(exp, Xi, Xo, tolerancia, maxIteraciones, currentCount, currentError);
            }
        }

        return currentCount;
    }

    public int GenerarRaizSecante(Expression exp, double Xi, double Xo, double tolerancia, int maxIteraciones = 0,
        int currentCount = 0, double currentError = 0, double xAnterior = 0)
    {
        currentCount++;

        hr.EvaluarEcuacion(exp, Xi);
        double raiz = Xi - (hr.EvaluarEcuacion(exp, Xi)*(Xo - Xi) / (hr.EvaluarEcuacion(exp, Xo)-hr.EvaluarEcuacion(exp, Xi)));
        double error = hr.ErrorAproximadoPorcentual(raiz, Xi, currentCount);
        hr.TableBuilderSecante(currentCount, raiz, Xi, hr.EvaluarEcuacion(exp, Xi), hr.EvaluarEcuacion(exp, Xo), raiz, error);
        return MetodoSecanteEv(exp, raiz, Xi, tolerancia, maxIteraciones, currentCount, currentError: error);   

    }
}