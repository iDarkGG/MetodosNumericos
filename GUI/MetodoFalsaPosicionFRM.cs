using System.Globalization;
using MathNet.Symbolics;
using Metodos_Numericos;

namespace WinFormsApp1;

public partial class MetodoFalsaPosicionFRM : Form
{
    Herramientas hr = new Herramientas();
    private MetodoPosicionFalsa mp = new MetodoPosicionFalsa();
    FalsaPosicionIO fIO = new FalsaPosicionIO();
    public MetodoFalsaPosicionFRM()
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
        fIO.Cleaner();
        foreach (Control control in this.Controls)
        {   
            controls.Add(control);
        }
        lstResultados.Columns.Add("Iteracion", 60, HorizontalAlignment.Center);
        lstResultados.Columns.Add("Raiz Aprox",233,HorizontalAlignment.Center);
        lstResultados.Columns.Add("Error Aprox",233,HorizontalAlignment.Center);
        lstResultados.GridLines = true;
        lstResultados.View = View.Details;
        
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
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.InitialDirectory = Directory.GetCurrentDirectory();

        if (lstResultados.Items.Count != 0)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(sfd.FileName + ".csv"))
                {
                
                    foreach (var line in fIO.CSV_Syntax())
                    {
                        sw.WriteLine(line);
                    }
            
                }
                lstResultados.Clear();
                txtCleaner(controls);
            }
        }
        else
        {
            MessageBox.Show("No hay nada que Guardar!");
        }
        
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        lstResultados.Items.Clear();
        if (hr.TextBoxChecker(controls))
        {
            MessageBox.Show("Error en los campos, verifique que esten llenos y en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            var eqq = Infix.ParseOrThrow(txtFuncion.Text);
            try
            {
                mp.MetodoPosicionFalsoEV(eqq, Convert.ToDouble(txtLimInf.Text), Convert.ToDouble(txtLimSup.Text),
                    Convert.ToDouble(txtTolerancia.Text), maxIteraciones: 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los campos, verifique que esten llenos y en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCleaner(controls);
            }

            ListViewItem lst = new ListViewItem();
            foreach (var data in fIO.Copy())
            {
                lst = new ListViewItem(data.Contador.ToString());
                lst.SubItems.Add(data.Result.ToString(CultureInfo.CurrentCulture));
                lst.SubItems.Add(data.Error.ToString(CultureInfo.CurrentCulture)+"%");
                lstResultados.Items.Add(lst);
            }
            
            hr.DataListener(txtFuncion.Text, lstResultados.Items[^2].SubItems[1].Text, lstResultados.Items[^1].SubItems[1].Text);

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
            
            if (e.ItemIndex == lastRowIndex && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
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

    private void btnGrafico_Click(object sender, EventArgs e)
    {
        using (test tst = new test())
        {
            tst.ShowDialog();
        }
    }
}