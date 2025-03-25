using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
namespace Metodos_Numericos;

public class MetodoBiseccion
{
    HerramientasCalculo hr = new HerramientasCalculo();
    public void MetodoBiseccionEV(Expression xp, double limInf, double limSup, double tolerancia, int maxIteracion = 0)
    {
        if (Constantes.verif > tolerancia)
        {
            if (hr.VerificadorBolzano(xp, limInf, limSup))
            {
                GenerarRaizBiseccion(limInf, limSup, xp, tolerancia);   
            }
        }
    }
    
    
    public void GenerarRaizBiseccion(double limInf, double limSup, Expression exp, double tolerancia = 0)
    {
        Constantes.contador++;
        var result = (limSup + limInf) / 2;
        if (hr.VerificadorBolzano(exp, limInf, result) & !hr.VerificadorBolzano(exp, result, limSup))
        {
            hr.TableBuilder(Constantes.contador, result, hr.ErrorAproximadoPorcentual(result, limInf ));
            MetodoBiseccionEV(exp,limInf, result, tolerancia);
        }
        else
        { 
            hr.TableBuilder(Constantes.contador, result, hr.ErrorAproximadoPorcentual(result, limSup ));
            MetodoBiseccionEV(exp,result, limSup ,tolerancia);
        }
    }
}