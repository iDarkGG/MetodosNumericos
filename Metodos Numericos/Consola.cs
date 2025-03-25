using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;

namespace Metodos_Numericos;

public class Consola 
{
    public static void Main(string[] args)
    {
        Constantes.contador = 0;

        MetodoBiseccion mb = new MetodoBiseccion();
        MetodoPuntoFijo pf = new MetodoPuntoFijo();
        HerramientasCalculo hr = new HerramientasCalculo();
        MetodoPosicionFalsa mv = new MetodoPosicionFalsa();

        Console.WriteLine("Por favor ingrese la funcion");
        var eqq = Console.ReadLine();
        
        //Console.WriteLine(hr.EvaluarEcuacion(hr.ExpressionSintax(eqq), 1));
        //Console.WriteLine(hr.ExpressionSintax(eqq));
        
    
        var expre = Infix.ParseOrThrow(eqq);
        //Console.WriteLine(expre);
        Console.WriteLine(Constantes.headerValorFalso); 
        mv.MetodoPosicionFalsoEV(expre, 1, 2, 0.01);
        
        //Console.WriteLine(Constantes.headerBisecc);
       // mb.MetodoBiseccionEV(expre,3,5,0.01);
       //Console.WriteLine(Constantes.headerPuntoFijo);
       //pf.MetodoPuntoFijoEV(expre, 2, 0.01, 5);
       Console.ReadLine();
        
    }
}

