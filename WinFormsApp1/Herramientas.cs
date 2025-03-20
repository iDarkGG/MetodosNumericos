using Metodos_Numericos;

namespace WinFormsApp1;

public class Herramientas : Form
{
    HerramientasCalculo hr = new HerramientasCalculo();
    
    public bool TextBoxChecker(List<Control> controls, string txtName = null)
    {
        foreach (var control in controls)
        {
            if (control is TextBox)
            {
                if ((control as TextBox).Text.Trim() != ""  & control.Name == txtName)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public DialogResult SyntaxChecker(string texto, double limInf, double limSup)
    {
        try
        {
            hr.ExpressionSintax(texto);
        }
        catch (Exception e)
        {
            return MessageBox.Show("Tenga en cuenta que ingreso una Ecuacion!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //if(!hr.VerificadorBolzano(texto, limInf, limSup))
        return MessageBox.Show("Sintaxis Correcta \nPuede Proceder", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    
}