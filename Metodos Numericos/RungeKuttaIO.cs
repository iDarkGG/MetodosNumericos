using MathNet.Symbolics;

namespace Metodos_Numericos;

public class RungeKuttaIO
{
    private HerramientasCalculo hr = new HerramientasCalculo();
    private static List<RungeKuttaIO> _lista = new List<RungeKuttaIO>();

    public RungeKuttaIO(){}

    public RungeKuttaIO(Expression expression, double xi, double yi, double k1, double k2, double k3, double k4)
    {
        Expression = expression;
        this.xi = xi;
        this.yi = yi;
        this.k1 = k1;
        this.k2 = k2;
        this.k3 = k3;
        this.k4 = k4;
    }

    public Expression Expression { get; set; } 
    public double xi { get; set; }
    public double yi { get; set; }
    public double k1 { get; set; }
    public double k2 { get; set; }
    public double k3 { get; set; }
    public double k4 { get; set; }



    public void Agregar(RungeKuttaIO rungeKuttaIo)
    {
        _lista.Add(rungeKuttaIo);
    }
    
    public List<String> CSV_Syntax()
    {
        var listCopy = _lista.ToList();
        List<String> resultSet = new List<string>();
        int counter= 0;
        foreach (var var in listCopy)
        {
            if (counter == 0)
            {
                resultSet.Add("'"+hr.StringSyntax(var.Expression).TrimStart('=')+"'");
                resultSet.Add("Iteracion"+","+"xi"+","+"yi"+","+"k1"+","+"k2"+","+"k3"+","+"k4");
            }
            resultSet.Add(counter+","+var.xi+","+var.yi+","+var.k1+","+var.k2+","+var.k3+","+var.k4);
        
            counter++;
            
        }
        
        return resultSet;
    }

    public void Cleaner()
    {
        Console.WriteLine("UwU");
        _lista.Clear();
    }

    public List<RungeKuttaIO> Copy()
    {
        return _lista.ToList();
    }
}