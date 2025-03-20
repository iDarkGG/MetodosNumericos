using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;

namespace Metodos_Numericos;

public class Consola 
{
    public static void Main(string[] args)
    {
        Constantes.contador = 0;

        MetodoBiseccion mb = new MetodoBiseccion();
        HerramientasCalculo hr = new HerramientasCalculo();
        MetodoValorFalso mv = new MetodoValorFalso();

        Console.WriteLine("Por favor ingrese la funcion");
        var eqq = Console.ReadLine();
        
        Console.WriteLine(hr.EvaluarEcuacion(hr.ExpressionSintax(eqq), 1));
        //Console.WriteLine(hr.ExpressionSintax(eqq));
        
    
        var expre = Infix.ParseOrThrow(eqq);
        Console.WriteLine(expre);
        // Console.WriteLine(Constantes.headerValorFalso);
        // mv.MetodoValorFalsoEV(expre, 0, 0.5, 0.01);
        
        // Console.WriteLine(Constantes.headerBisecc);
        // mb.MetodoBiseccionEV(expre,0,0.5,0.01);

        Console.ReadLine();
        
    }
}

