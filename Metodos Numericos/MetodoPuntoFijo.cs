using MathNet.Symbolics;

namespace Metodos_Numericos;

public class MetodoPuntoFijo
{
    HerramientasCalculo hr = new HerramientasCalculo();
    Constantes c = new Constantes();
    public void MetodoPuntoFijoEV(Expression exp, double x0, double tolerancia, int iteracionesMax = 0)
    {
        if (iteracionesMax == 0)
        {
            Constantes.contador++;
            double xNext = hr.EvaluarEcuacion(exp, x0);
            double error = Constantes.contador == 0 ? 0 : hr.ErrorAproximadoPorcentual(xNext, x0);
            hr.TableBuilderPuntoFijo(Constantes.contador, x0, error);
            if (error <= 0 & Constantes.contador <= 1)
            { 
                MetodoPuntoFijoEV(exp, xNext, tolerancia, 30);
            }
            else
            {
                if (error > tolerancia & Constantes.contador > 1)
                {
                    MetodoPuntoFijoEV(exp, xNext, tolerancia, 30);
                }
            }
        }
        else
        {
            if (Constantes.contador < iteracionesMax)
            {
                Constantes.contador++;
                double xNext = hr.EvaluarEcuacion(exp, x0);
                double error = Constantes.contador == 0 ? 0 : hr.ErrorAproximadoPorcentual(xNext, x0);
                hr.TableBuilderPuntoFijo(Constantes.contador, x0, error);
                if (error <= 0 & Constantes.contador <= 1)
                { 
                    MetodoPuntoFijoEV(exp, xNext, tolerancia, iteracionesMax);
                }
                else
                {
                    if (error > tolerancia & Constantes.contador > 1)
                    {
                        MetodoPuntoFijoEV(exp, xNext, tolerancia, iteracionesMax);
                    }
                }
            }
        }
        
    }
}