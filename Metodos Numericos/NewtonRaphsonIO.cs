using MathNet.Symbolics;

namespace Metodos_Numericos;

public class NewtonRaphsonIO
{
    private HerramientasCalculo hr = new HerramientasCalculo();
    private static List<NewtonRaphsonIO> _lista = new List<NewtonRaphsonIO>();

    public NewtonRaphsonIO(){}

    public NewtonRaphsonIO(Expression expression, double xi, double fXi, double fPrimeXi, double error, int contador, double result)
    {
        Expression = expression;
        Xi = xi;
        this.fXi = fXi;
        this.fPrimeXi = fPrimeXi;
        Error = error;
        Contador = contador;
        Result = result;
    }


    public Expression Expression { get; set; } 
    public double Xi { get; set; }
    public double fXi { get; set; }
    public double fPrimeXi { get; set; }
    public double Error { get; set; } 
    public int Contador { get; set; }
    public double Result { get; set; }


    public void Agregar(NewtonRaphsonIO newtonRaphsonIo)
    {
        _lista.Add(newtonRaphsonIo);
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
                resultSet.Add("Iteracion"+","+"Xi"+","+"f(Xi)"+","+"f'(Xi)"+","+"Raiz"+","+"Error Aprox");
            }
            resultSet.Add(var.Contador+","+var.Xi+","+var.fXi+","+var.fPrimeXi+","+var.Result+","+var.Error+"%");
        }
        
        return resultSet;
    }

    public void Cleaner()
    {
        _lista.Clear();
    }

    public List<NewtonRaphsonIO> Copy()
    {
        return _lista.ToList();
    }
}