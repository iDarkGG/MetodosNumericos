namespace WinFormsApp1;

public partial class Form1 : Form
{
    Herramientas hr = new Herramientas();
    public Form1()
    {
        InitializeComponent();
    }
    private List<Control> controls = new List<Control>();
    
    private void Form1_Load(object sender, EventArgs e)
    {
        foreach (Control control in this.Controls)
        {   
            controls.Add(control);
        }
    }


    private void btnChckSyntax_Click(object sender, EventArgs e)
    {
        if (!hr.TextBoxChecker(controls, txtFuncion.Name))
        {
            MessageBox.Show("Por favor ingrese una funcion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            hr.SyntaxChecker(txtFuncion.Text, 1.0, 1.5);
        }
        
        
    }
}