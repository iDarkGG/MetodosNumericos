
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Symbolics;

namespace Metodos_Numericos;

public class MetodoNewtonRaphsonSenl
{
    HerramientasCalculo hr = new HerramientasCalculo();
    public int MetodoNewtonSenl(List<Expression> exp, List<double> Xo, double tolerancia, int maxIter = 0, int currentCount = 0,
        Matrix<double> currentErrorMatrix = null)
    {
        if (currentCount < maxIter)
        {
            if (currentCount == 0)
            {
                currentErrorMatrix = Matrix<double>.Build.Dense(2, 1);
                currentErrorMatrix[0, 0] = 100;
                currentErrorMatrix[1, 0] = 100;
            }
            if (currentErrorMatrix[0,0] > tolerancia | currentErrorMatrix[1,0] > tolerancia)
            {
                currentCount++;
                List<double> raices = new List<double>();

                Matrix<double> XoMatrix = Matrix<double>.Build.Dense(2, 1);
                List<double> nextXo = new List<double>();

                for (int m = 0; m < Xo.Count; m++)
                {
                    XoMatrix[m, 0] = Xo[m];
                }
        
                Matrix<double> result =XoMatrix -(hr.MatrizJacobiana(exp,Xo,2)*hr.MatrizEvaluacion(exp,Xo));

                for (int j = 0; j < Xo.Count(); j++)
                {
                    nextXo.Add(result[j, 0]);
                }

                Matrix<double> errorMatrix = Matrix<double>.Build.Dense(2, 1);
                for (int l = 0; l < Xo.Count(); l++)
                {
                    errorMatrix[l, 0] = hr.ErrorAproximadoPorcentual(result[l, 0], Xo[l],currentCount);
                }
                Console.WriteLine("----------------------------------------------------------------------");    
                 for (int countR = 0; countR < currentErrorMatrix.RowCount; countR++)
                 {
                     for (int countC = 0; countC < currentErrorMatrix.ColumnCount; countC++)
                     {
                         if (countR == 0)
                         {
                             string row = string.Format("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}", currentCount, Xo[countR],(hr.MatrizJacobiana(exp,Xo,2)[0,0]+" "+hr.MatrizJacobiana(exp,Xo,2)[0,1]),hr.MatrizEvaluacion(exp,Xo)[countR,countC],result[countR,countC], errorMatrix[countR,countC]+"%");
                             Console.WriteLine(row);
                         }
                         else
                         {
                             string row2 = string.Format("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-10}", currentCount, Xo[countR],(hr.MatrizJacobiana(exp,Xo,2)[1,0]+" "+hr.MatrizJacobiana(exp,Xo,2)[1,1]),hr.MatrizEvaluacion(exp,Xo)[countR,countC],result[countR,countC], errorMatrix[countR,countC]+"%");
                             Console.WriteLine(row2);
                         }
                        
                         
                     }
                 }
                 
                return MetodoNewtonSenl(exp, nextXo, tolerancia, maxIter, currentCount, currentErrorMatrix:errorMatrix);
            } }
        return currentCount;
       
    }
    
}