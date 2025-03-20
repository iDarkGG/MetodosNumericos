namespace Metodos_Numericos;

public class Constantes
{
    public static double verif = 100;
    public static int contador = 0;
    public static readonly string headerBisecc = string.Format("{0,10} | {1,20} | {2,15}", "Iteración", "Raíz", "Error Aprox");
    public static readonly string headerValorFalso =  string.Format("{0,-12} | {1,-18} | {2,-12} | {3,-25} | {4,-25} | {5,-25} | {6,-25} | {7,-20}",
        "Iteración", "LimInf", "LimSup", "f(LimInf)", "f(LimSup)", "Raíz Aprox", "f(Raíz)", "Error Aprox");
    
    
    
}