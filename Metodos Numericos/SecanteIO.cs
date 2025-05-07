using MathNet.Symbolics;

namespace Metodos_Numericos;

public class SecanteIO
{
    private HerramientasCalculo hr = new HerramientasCalculo();
    private static List<SecanteIO> _lista = new List<SecanteIO>();

    public SecanteIO(){}

    public SecanteIO(Expression expression, double xi, double fxi, double error, int contador, double result)
    {
        Expression = expression;
        Xi = xi;
        Fxi = fxi;
        Error = error;
        Contador = contador;
        Result = result;
    }

    public Expression Expression { get; set; } 
    public double Xi {get; set;}
    public double Fxi { get; set; }
    public double Error { get; set; } 
    public int Contador { get; set; }
    public double Result { get; set; }


    public void Agregar(SecanteIO secanteIo)
    {
        _lista.Add(secanteIo);
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
                resultSet.Add("Iteracion"+","+"Xi"+","+"Fxi"+","+"Raiz"+","+"Error Aprox");
            }
            resultSet.Add(var.Contador+","+var.Xi+","+var.Fxi+","+var.Result+","+var.Error+"%");
        }
        
        return resultSet;
    }


    public List<SecanteIO> Copy()
    {
        return _lista.ToList();
    }
}