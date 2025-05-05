using MathNet.Symbolics;

namespace Metodos_Numericos;

public class NewtonRaphsonSENL_IO
{
    private HerramientasCalculo hr = new HerramientasCalculo();
    private static List<NewtonRaphsonSENL_IO> _lista = new List<NewtonRaphsonSENL_IO>();

    public NewtonRaphsonSENL_IO(){}
    

    public List<Expression> Expression { get; set; } 
    public List<double> Xi { get; set; }
    public double fXi { get; set; }
    public double fPrimeXi { get; set; }
    public double Error { get; set; } 
    public int Contador { get; set; }
    public List<double> Result { get; set; }


    public void Agregar(NewtonRaphsonSENL_IO  newtonRaphsonSenlIo)
    {
        _lista.Add(newtonRaphsonSenlIo);
    }
    
    public List<String> CSV_Syntax(Expression OptExpression = null)
    {
        var listCopy = _lista.ToList();
        List<String> resultSet = new List<string>();
        foreach (var var in listCopy)
        {
            if (var.Contador == 1)
            {
                resultSet.Add("'"+hr.StringSyntax(var.Expression[0]).TrimStart('=')+"'"+","+"'"+hr.StringSyntax(var.Expression[1]).TrimStart('=')+"'");
                resultSet.Add("Iteracion"+","+"Raiz"+","+"Error Aprox");
            }
            resultSet.Add(var.Contador+","+var.Xi+","+var.fXi+","+var.fPrimeXi+","+var.Result+","+var.Error+"%");
        }
        
        return resultSet;
    }


    public List<NewtonRaphsonSENL_IO> Copy()
    {
        return _lista.ToList();
    }
}