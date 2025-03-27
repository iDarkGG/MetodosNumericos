namespace Metodos_Numericos;

public class Constantes
{
    public static readonly string headerBisecc = string.Format("{0,10} | {1,20} | {2,15}", "Iteración", "Raíz", "Error Aprox");
    public static readonly string headerValorFalso =  string.Format("{0,-8} | {1,-18} | {2,-12} | {3,-25} | {4,-25} | {5,-25} | {6,-25} | {7,-20}",
        "Iteración", "LimInf", "LimSup", "f(LimInf)", "f(LimSup)", "Raíz Aprox", "f(Raíz)", "Error Aprox");
    public static readonly string headerPuntoFijo = string.Format("{0,10} | {1,20} | {2,15}", "Iteración", "Raíz", "Error Aprox");
    public static readonly string headerNewton = string.Format("{0,-10} | {1,-18} | {2,-18} | {3,-18} | {4,-18} | {5,-18}",
        "Iteración", "Xi", "f(Xi)", "f'(Xi)", "Raíz", "Er%");
    public static readonly string headerSecante = string.Format(
        "{0,10} | {1,20} | {2,20} | {3,20} | {4,20} | {5,20} | {6,20:}",
        "iteracion", "Xi", "Xo", "fXi", "fXo", "Raiz", "errorAprox%");


}