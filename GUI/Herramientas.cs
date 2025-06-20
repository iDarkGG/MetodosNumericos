using System.Globalization;
using Metodos_Numericos;

namespace WinFormsApp1;

public class Herramientas : Form
{
    HerramientasCalculo hr = new HerramientasCalculo();
    
    private static List<string> _list = new List<string>();
    
    public bool TextBoxChecker(List<Control> controls, string txtName = null)
    {
        foreach (var control in controls)
        {
            if (control is TextBox)
            {
                if ((control as TextBox).Text.Trim() == ""  | (control as TextBox).Text == null)
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
        return MessageBox.Show("Sintaxis Correcta \nPuede Proceder", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }


    public void FileIo(List<string> list, string fileName)
    {
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.InitialDirectory = Directory.GetCurrentDirectory();
        if (sfd.ShowDialog() == DialogResult.OK)
        {
            using (StreamWriter sw = File.CreateText(fileName + ".csv"))
            {
                foreach (var line in list)
                {
                    sw.WriteLine(line);
                }
            
            }
        }
    }


    public void DataListener(string exp, string x1,  string x2)
    {
       _list.Clear();
        
        _list.Add(exp);
        _list.Add(x1.ToString(CultureInfo.InvariantCulture));
        _list.Add(x2.ToString(CultureInfo.InvariantCulture));
    }

    public List<string> DataPayload()
    {
        return _list.ToList();
    }
    
}