using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
namespace Metodos_Numericos;

public class MetodoBiseccion
{
    HerramientasCalculo hr = new HerramientasCalculo();
    private BiseccionIO BIo = new BiseccionIO();

    public int MetodoBiseccionEV(Expression xp, double limInf, double limSup, double tolerancia, int maxIteracion = 0, double tolResult =100, int currentCount =0)
    {
        if (currentCount < maxIteracion)
        {
            if (tolResult > tolerancia)
            {
                if (hr.VerificadorBolzano(xp, limInf, limSup))
                {
                   return GenerarRaizBiseccion(limInf, limSup, xp, maxIteracion , tolerancia: tolerancia, contador: currentCount);   
                }
                else
                {
                    Console.WriteLine("WTFFFFF");
                }
            }
        }
        
        return currentCount;
    }
    
    
    public int GenerarRaizBiseccion(double limInf, double limSup, Expression exp, int maxiteracion, double tolerancia = 0, int contador = 0)
    {
        contador++;
        var result = (limSup + limInf) / 2;
        if (hr.VerificadorBolzano(exp, limInf, result))
        {
            BIo.Agregar(new BiseccionIO(exp,hr.ErrorAproximadoPorcentual(result, limInf, contador ),contador, result ));
            hr.TableBuilder(contador, result, hr.ErrorAproximadoPorcentual(result, limInf, contador ));
            return MetodoBiseccionEV(exp,limInf, result, tolerancia, maxIteracion: maxiteracion, tolResult:hr.ErrorAproximadoPorcentual(result, limInf, contador), currentCount: contador);
        }
        BIo.Agregar(new BiseccionIO(exp,hr.ErrorAproximadoPorcentual(result, limInf, contador ),contador, result ));
        hr.TableBuilder(contador, result, hr.ErrorAproximadoPorcentual(result, limSup, contador ));
        return MetodoBiseccionEV(exp,result, limSup ,tolerancia, maxIteracion: maxiteracion,tolResult:hr.ErrorAproximadoPorcentual(result, limSup, contador), currentCount: contador);
    }
}