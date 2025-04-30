using MathNet.Symbolics;

namespace Metodos_Numericos;

public class Biseccion(Expression expression, double error, int contador, double result)
{
    private static List<Biseccion> _lista = new List<Biseccion>();
    
    public Expression Expression { get; set; } = expression;
    public double Error { get; set; } = error;
    public int Contador { get; set; } = contador;
    public double Result { get; set; } = result;


    public void Agregar(Biseccion biseccion)
    {
        _lista.Add(biseccion);
    }


    public List<String> CSV_Syntax()
    {
        var listCopy = _lista.ToList();
        List<String> resultSet = new List<string>();
        foreach (var var in listCopy)
        {
            if (var.Contador == 1)
            {
                resultSet.Add(var.Expression.ToString());
                resultSet.Add("Iteración"+","+"Raíz"+","+"Error Aprox");
            }
            resultSet.Add(var.Contador+","+var.Result+","+var.Error);
        }
        
        return resultSet;
    }
    
}