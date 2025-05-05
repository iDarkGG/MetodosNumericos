using MathNet.Symbolics;

namespace Metodos_Numericos;

public class PuntoFijoIO
{
    private HerramientasCalculo hr = new HerramientasCalculo();
    private static List<PuntoFijoIO> _lista = new List<PuntoFijoIO>();

    public PuntoFijoIO(){}
    
    public PuntoFijoIO(Expression expression, double error, int contador, double result)
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


    public void Agregar(PuntoFijoIO puntoFijoIo)
    {
        _lista.Add(puntoFijoIo);
    }
    
    public List<String> CSV_Syntax(Expression OptExpression = null)
    {
        var listCopy = _lista.ToList();
        List<String> resultSet = new List<string>();
        foreach (var var in listCopy)
        {
            if (var.Contador == 1)
            {
                resultSet.Add(
                    "'" + hr.StringSyntax(var.Expression).TrimStart('=') + "'," +
                    (OptExpression is null
                        ? ""
                        : "'" + hr.StringSyntax(OptExpression).TrimStart('=') + "'")
                );
                resultSet.Add("Iteracion"+","+"Raiz"+","+"Error Aprox");
            }
            resultSet.Add(var.Contador+","+var.Result+","+var.Error+"%");
        }
        
        return resultSet;
    }


    public List<PuntoFijoIO> Copy()
    {
        return _lista.ToList();
    }
}