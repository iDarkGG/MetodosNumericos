using MathNet.Numerics.LinearAlgebra;
using MathNet.Symbolics;

namespace Metodos_Numericos;

public class NewtonRaphsonSENL_IO
{
    private HerramientasCalculo hr = new HerramientasCalculo();
    private static List<NewtonRaphsonSENL_IO> _lista = new List<NewtonRaphsonSENL_IO>();

    public NewtonRaphsonSENL_IO(){}

    public NewtonRaphsonSENL_IO(List<Expression> expression, List<double> xi, Matrix<double> fXi, Matrix<double> jacobiano, Matrix<double> error, int contador, Matrix<double> result)
    {
        Expression = expression;
        Xi = xi;
        this.fXi = fXi;
        this.jacobiano = jacobiano;
        Error = error;
        Contador = contador;
        Result = result;
    }

    public List<Expression> Expression { get; set; } 
    public List<double> Xi { get; set; }
    public Matrix<double> fXi { get; set; }
    public Matrix<double> jacobiano { get; set; }
    public Matrix<double> Error { get; set; } 
    public int Contador { get; set; }
    public Matrix<double> Result { get; set; }


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
                resultSet.Add("Iteracion"+","+"Xi"+","+"f(xi)"+","+"J(Xi)^-1"+","+"Raiz"+","+"Error Aprox");
            }
            resultSet.Add(var.Contador+","+var.Xi[0]+","+var.fXi[0,0]+","+'"'+var.jacobiano[0,0]+var.jacobiano[0,1]+'"'+","+var.Result[0,0]+","+var.Error[0,0]+"%");
            resultSet.Add(var.Contador+","+var.Xi[1]+","+var.fXi[1,0]+","+'"'+var.jacobiano[1,0]+var.jacobiano[1,1]+'"'+","+var.Result[1,0]+","+var.Error[1,0]+"%");
        }
        
        return resultSet;
    }


    public List<NewtonRaphsonSENL_IO> Copy()
    {
        return _lista.ToList();
    }
}