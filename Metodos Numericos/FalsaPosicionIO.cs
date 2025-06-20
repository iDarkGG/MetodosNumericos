using MathNet.Symbolics;

namespace Metodos_Numericos;

public class FalsaPosicionIO
{
    private HerramientasCalculo hr = new HerramientasCalculo();
    private static List<FalsaPosicionIO> _lista = new List<FalsaPosicionIO>();

    public FalsaPosicionIO(){}
    
    public FalsaPosicionIO(Expression expression, double error, int contador, double result)
    {
        Expression = expression;
        Error = error;
        Contador = contador;
        Result = result;
    }

    public Expression Expression { get; set; } 
    public double Error { get; set; } 
    public int Contador { get; set; }
    public double Result { get; set; }


    public void Agregar(FalsaPosicionIO falsaPosicionIo)
    {
        _lista.Add(falsaPosicionIo);
    }
    
    public List<String> CSV_Syntax()
    {
        var listCopy = _lista.ToList();
        List<String> resultSet = new List<string>();
        foreach (var var in listCopy)
        {
            if (var.Contador == 1)
            {
                resultSet.Add("'"+hr.StringSyntax(var.Expression).TrimStart('=')+"'");
                resultSet.Add("Iteracion"+","+"Raiz"+","+"Error Aprox");
            }
            resultSet.Add(var.Contador+","+var.Result+","+var.Error+"%");
        }
        
        return resultSet;
    }

    public void Cleaner()
    {
        _lista.Clear();
    }

    public List<FalsaPosicionIO> Copy()
    {
        return _lista.ToList();
    }
}