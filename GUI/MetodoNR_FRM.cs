using System.Globalization;
using MathNet.Symbolics;
using Metodos_Numericos;

namespace WinFormsApp1;

public partial class MetodoNR_FRM : Form
{
    Herramientas hr = new Herramientas();
    MetodoNewtonRaphson mn = new MetodoNewtonRaphson();
    HerramientasCalculo ha = new HerramientasCalculo();
    NewtonRaphsonIO io = new NewtonRaphsonIO();
    public MetodoNR_FRM()
    {
        InitializeComponent();
    }
    private List<Control> controls = new List<Control>();


    private void txtCleaner(List<Control> controls)
    {
        foreach (Control c in controls)
        {
            if (c is TextBox)
            {
                c.Text = string.Empty;
            }
        }
    }
    
    
    private void Form1_Load(object sender, EventArgs e)
    {
        foreach (Control control in this.Controls)
        {   
            controls.Add(control);
        }
        lstResultados.Columns.Add("Iteracion", 60, HorizontalAlignment.Center);
        lstResultados.Columns.Add("Xi",102,HorizontalAlignment.Center);
        lstResultados.Columns.Add("f(Xi)",102,HorizontalAlignment.Center);
        lstResultados.Columns.Add("f'(Xi)",102,HorizontalAlignment.Center);
        lstResultados.Columns.Add("Raiz Aprox",102,HorizontalAlignment.Center);
        lstResultados.Columns.Add("Error Aprox",102,HorizontalAlignment.Center);
        lstResultados.GridLines = true;
        lstResultados.View = View.Details;
        
        //ToDo
        btnGrafico.Enabled = false;
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

    private void btnSalir_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var eq1 = ha.DerivativeSyntax(Infix.ParseOrThrow(txtFuncion.Text));
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.InitialDirectory = Directory.GetCurrentDirectory();
        if (sfd.ShowDialog() == DialogResult.OK)
        {
            using(StreamWriter sw = File.CreateText(sfd.FileName + ".csv"))
            {
                foreach (var line in io.CSV_Syntax(eq1))
                {
                    sw.WriteLine(line);
                }
            
            }
            txtCleaner(controls);
            lstResultados.Clear();
        }
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        if (hr.TextBoxChecker(controls))
        {
            MessageBox.Show("Error en los campos, verifique que esten llenos y en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            var eqq = Infix.ParseOrThrow(txtFuncion.Text);
            try
            {
                mn.MetodoNewton(eqq,Convert.ToDouble(txtPosInicial.Text),Convert.ToDouble(txtTolerancia.Text), iterMax:100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los campos, verifique que esten llenos y en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCleaner(controls);
            }

            ListViewItem lst = new ListViewItem();
            foreach (var data in io.Copy())
            {
                lst = new ListViewItem(data.Contador.ToString());
                lst.SubItems.Add(data.Xi.ToString(CultureInfo.InvariantCulture));
                lst.SubItems.Add(data.fXi.ToString(CultureInfo.InvariantCulture));
                lst.SubItems.Add(data.fPrimeXi.ToString(CultureInfo.InvariantCulture));
                lst.SubItems.Add(data.Result.ToString(CultureInfo.CurrentCulture));
                lst.SubItems.Add(data.Error.ToString(CultureInfo.CurrentCulture)+"%");
                lstResultados.Items.Add(lst);
            }
            

        }
        
        
        lstResultados.OwnerDraw = true;

        lstResultados.DrawColumnHeader += (s, e) =>
        {
            e.DrawDefault = true;
        };

        lstResultados.DrawItem += (s, e) =>
        {
        };

        lstResultados.DrawSubItem += (s, e) =>
        {
            int lastRowIndex = lstResultados.Items.Count - 1;
            
            if (e.ItemIndex == lastRowIndex && (e.ColumnIndex == 1 || e.ColumnIndex == 2 || e.ColumnIndex==3 || e.ColumnIndex == 4 || e.ColumnIndex == 5))
            {
                e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, lstResultados.Font, e.Bounds, Color.Black, TextFormatFlags.HorizontalCenter);
            }
            else
            {
                e.DrawDefault = true;
            }
        };



    }
}