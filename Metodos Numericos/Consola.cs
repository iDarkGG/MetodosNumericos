using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
using System.Linq;

namespace Metodos_Numericos;

public class Consola 
{
    public static void Main(string[] args)
    {

        MetodoBiseccion mb = new MetodoBiseccion();
        MetodoPuntoFijo pf = new MetodoPuntoFijo();
        MetodoPosicionFalsa mv = new MetodoPosicionFalsa();
        MetodoNewtonRaphson mn = new MetodoNewtonRaphson();
        
        int menu = 0;
        var eqq = String.Empty;

        do
        {
            Console.WriteLine("Por favor seleccione el Metodo con el que aproximar");
            Console.WriteLine("1. Biseccion \n2. Posicion Falsa \n3. Punto Fijo \n4. Newton Raphson \n0. Determinar el mas optimo");
            Console.WriteLine("5. Salir");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Metodo de Biseccion");
                    Console.WriteLine("Por favor ingrese la funcion");
                    eqq = Console.ReadLine();
                    var expreB = Infix.ParseOrThrow(eqq);
                    Console.WriteLine("Ingrese el limite inferior");
                    double limInf = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el limite superior");
                    double limSup = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tolerancia");
                    double tol = double.Parse(Console.ReadLine());
                    Console.WriteLine("Maxima Cantidad de Iteraciones");
                    int iteracionesB = int.Parse(Console.ReadLine());
                    Console.WriteLine(Constantes.headerBisecc);
                    mb.MetodoBiseccionEV(expreB, limInf, limSup, tol,maxIteracion: iteracionesB );
                    break;
                case 2:
                    Console.WriteLine("Por favor ingrese la funcion");
                    eqq = Console.ReadLine();
                    var expreP = Infix.ParseOrThrow(eqq);
                    Console.WriteLine("Metodo de Posicion Falsa");
                    Console.WriteLine("Ingrese el limite inferior");
                    double limInfPS = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el limite superior");
                    double limSupPS = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tolerancia");
                    double tolPS = double.Parse(Console.ReadLine());
                    Console.WriteLine("Maxima Cantidad de Iteraciones");
                    int iteracionesPF = int.Parse(Console.ReadLine());
                    Console.WriteLine(Constantes.headerValorFalso);
                    mv.MetodoPosicionFalsoEV(expreP, limInfPS, limSupPS, tolPS, maxIteraciones:  iteracionesPF);
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
                    pf.MetodoPuntoFijoEV(gX, posicionInicial, tolerancia, iteracionesMax: iterMax);
                    break;
                case 4:
                    Console.WriteLine("Metodo Newton-Raphson");
                    Console.WriteLine("Por favor ingrese la funcion");
                    eqq = Console.ReadLine();
                    var expreN = Infix.ParseOrThrow(eqq);
                    Console.WriteLine("Ingrese el valor Inicial");
                    double valInicial = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tolerancia");
                    double toleranciaMn = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el maximo de iteraciones");
                    int maxIteraciones = int.Parse(Console.ReadLine());
                    Console.WriteLine(Constantes.headerNewton);
                    mn.MetodoNewton(expreN, valInicial, toleranciaMn, maxIteraciones);
                    break;
                case 0:
                    Console.WriteLine("Evaluando el Mejor metodo");
                    Console.WriteLine("Por favor ingrese la funcion");
                    eqq = Console.ReadLine();
                    var expre = Infix.ParseOrThrow(eqq);
                    Console.WriteLine("Ingrese el limite inferior, para los metodos Biseccion y Posicion Falsa");
                    double limInfTe = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el limite superior, para los metodos Biseccion y Posicion Falsa");
                    double limSupTe = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese  g(x)");
                    var gxT = Console.ReadLine();
                    var gXT = Infix.ParseOrThrow(gxT);
                    Console.WriteLine("Ingrese la posicion Inicial para el metodo Punto Fijo, Newton Raphson(Xi)");
                    double posicionPuntoFijo = double.Parse(Console.ReadLine());
                    //Console.WriteLine("Ingrese el valor Xi-1 para el Metodo Secante");
                    //double valXi1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la tolerancia");
                    double toleranciaTE = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad maxima de Iteraciones");
                    int iterMaxT = int.Parse(Console.ReadLine());
                    Console.WriteLine("Evaluando...");
                    Thread.Sleep(1000);
                    int[] ItersMax = new int[5];
        
                    Console.WriteLine(Constantes.headerBisecc);
                    ItersMax[0] = mb.MetodoBiseccionEV(expre, limInfTe, limSupTe, toleranciaTE, maxIteracion: iterMaxT);
                    Console.WriteLine();
                    
                    Console.WriteLine();
                    Thread.Sleep(1000);
        
                    Console.WriteLine(Constantes.headerValorFalso);
                    ItersMax[1] =  mv.MetodoPosicionFalsoEV(expre, limInfTe, limSupTe, toleranciaTE,  maxIteraciones: iterMaxT);
        
                    Console.WriteLine();
                    Thread.Sleep(1000);
        
                    Console.WriteLine(Constantes.headerPuntoFijo);
                    ItersMax[2] = pf.MetodoPuntoFijoEV(gXT, posicionPuntoFijo, toleranciaTE, iteracionesMax: iterMaxT);

                    Console.WriteLine();
                    Thread.Sleep(1000);
                    
                    Console.WriteLine(Constantes.headerNewton);
                    ItersMax[3] = mn.MetodoNewton(expre, posicionPuntoFijo, toleranciaTE, iterMaxT);
        
        
                    int min = ItersMax.Where(x => x > 0).DefaultIfEmpty(int.MinValue).Min();
                    
                    int minInd = min <=0 ? -4 : Array.IndexOf(ItersMax, min);
        
                    string mejorMe = minInd switch
                    {
                        0 => "Metodo Biseccion",
                        1 => "Metodo Posicion Falsa",
                        2 => "Metodo Punto Fijo",
                        3 => "Metodo Newton Raphson",
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

