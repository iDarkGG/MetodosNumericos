using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
using System.Linq;

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
        
        int menu = 0;
        var eqq = String.Empty;
        
        do
        {
            Constantes.contador = 0;
            Constantes.verif = 100;
            Console.WriteLine("Por favor ingrese la funcion");
            eqq = Console.ReadLine();
            var expre = Infix.ParseOrThrow(eqq);
            Console.WriteLine("Por favor seleccione el Metodo con el que aproximar");
            Console.WriteLine("1. Biseccion \n2. Posicion Falsa \n3. Punto Fijo \n0. Determinar el mas optimo");
            Console.WriteLine("5. Salir");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Metodo de Biseccion");
                    Console.WriteLine("Ingrese el limite inferior");
                    double limInf = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el limite superior");
                    double limSup = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tolerancia");
                    double tol = double.Parse(Console.ReadLine());
                    Console.WriteLine(Constantes.headerBisecc);
                    mb.MetodoBiseccionEV(expre, limInf, limSup, tol);
                    break;
                case 2:
                    Console.WriteLine("Metodo de Posicion Falsa");
                    Console.WriteLine("Ingrese el limite inferior");
                    double limInfPS = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el limite inferior");
                    double limSupPS = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tolerancia");
                    double tolPS = double.Parse(Console.ReadLine());
                    Console.WriteLine(Constantes.headerValorFalso);
                    mv.MetodoPosicionFalsoEV(expre, limInfPS, limSupPS, tolPS);
                    break;
                case 3:
                    Console.WriteLine("Metodo de Punto Fijo");
                    Console.WriteLine("Ingrese x = g(x)");
                    var gx = Console.ReadLine();
                    var gX = Infix.ParseOrThrow(gx);
                    Console.WriteLine("Ingrese la Posicion Inicial");
                    double posicionInicial = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tolerancia");
                    double tolerancia = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad maxima de Iteraciones");
                    int iterMax = int.Parse(Console.ReadLine());
                    Console.WriteLine(Constantes.headerPuntoFijo);
                    pf.MetodoPuntoFijoEV(gX, posicionInicial, tolerancia, iterMax);
                    break;
                case 0:
                    Console.WriteLine("Evaluando el Mejor metodo");
                    Console.WriteLine("Ingrese el limite inferior, para los metodos Biseccion y Posicion Falsa");
                    double limInfTe = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el limite superior, para los metodos Biseccion y Posicion Falsa");
                    double limSupTe = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese x = g(x)");
                    var gxT = Console.ReadLine();
                    var gXT = Infix.ParseOrThrow(gxT);
                    Console.WriteLine("Ingrese la posicion Inicial para el metodo Punto Fijo");
                    double posicionPuntoFijo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tolerancia");
                    double toleranciaTE = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad maxima de Iteraciones");
                    int iterMaxT = int.Parse(Console.ReadLine());
                    Console.WriteLine("Evaluando...");
                    Thread.Sleep(1000);
                    int[] ItersMax = new int[3];

                    Console.WriteLine(Constantes.headerBisecc);
                    mb.MetodoBiseccionEV(expre, limInfTe, limSupTe, toleranciaTE);
                    Console.WriteLine();
                    int Bisec = Constantes.contador;
                    ItersMax[0] = Bisec;
                    Constantes.contador = 0;
                    Constantes.verif = 100;
                    Console.WriteLine();
                    Thread.Sleep(1000);

                    Console.WriteLine(Constantes.headerValorFalso);
                    mv.MetodoPosicionFalsoEV(expre, limInfTe, limSupTe, toleranciaTE);
                    int Falso = Constantes.contador;
                    ItersMax[1] = Falso;
                    Constantes.contador = 0;
                    Console.WriteLine();
                    Thread.Sleep(1000);

                    Console.WriteLine(Constantes.headerPuntoFijo);
                    pf.MetodoPuntoFijoEV(gXT, posicionPuntoFijo, toleranciaTE, iterMaxT);
                    int Fijo = Constantes.contador;
                    ItersMax[2] = Fijo;
                    Constantes.contador = 0;

                    int min = ItersMax.Where(x => x > 0).DefaultIfEmpty(int.MinValue).Min();
                    
                    int minInd = min <=0 ? -4 : Array.IndexOf(ItersMax, min);

                    string mejorMe = minInd switch
                    {
                        0 => "Metodo Biseccion",
                        1 => "Metodo Posicion Falsa",
                        2 => "Metodo Punto Fijo",
                        _ => "Algo Salio Mal"
                    };

                    Console.WriteLine("El metodo mas rapido es: " + mejorMe);
                    break;
                default:
                    Console.WriteLine("Seleccione de Nuevo");
                    break;
                    
            }
        } while (menu != 5);

    }
}

