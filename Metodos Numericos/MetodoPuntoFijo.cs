using MathNet.Symbolics;

namespace Metodos_Numericos;

public class MetodoPuntoFijo
{
    private PuntoFijoIO p = new PuntoFijoIO();
    HerramientasCalculo hr = new HerramientasCalculo();
    Constantes c = new Constantes();
    public int MetodoPuntoFijoEV(Expression exp, double x0, double tolerancia, int iteracionesMax = 0, int currentCount=0, double currentError =100)
    {
        if (currentCount < iteracionesMax)
        {
            if (currentError > tolerancia)
            {
                double xNext = hr.EvaluarEcuacion(exp, x0);
                currentCount++;
                var error = hr.ErrorAproximadoPorcentual(xNext, x0, currentCount);
                
                p.Agregar(new PuntoFijoIO(exp, error,currentCount, xNext ));
                hr.TableBuilderPuntoFijo(currentCount, xNext, error);
                return MetodoPuntoFijoEV(exp, xNext, tolerancia, iteracionesMax, currentCount, currentError: error);
            }

        }
        return currentCount;
    }
    
}