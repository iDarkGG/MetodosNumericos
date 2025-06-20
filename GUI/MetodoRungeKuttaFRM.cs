using System.Globalization;
using MathNet.Symbolics;
using Metodos_Numericos;

namespace WinFormsApp1;

public partial class MetodoRungeKuttaFRM : Form
{
    Herramientas hr = new Herramientas();
    private MetodoRungeKutta_4 mr = new MetodoRungeKutta_4();
    private RungeKuttaIO rIO = new RungeKuttaIO();
    public MetodoRungeKuttaFRM()
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
        rIO.Cleaner();
        foreach (Control control in this.Controls)
        {   
            controls.Add(control);
        }
        lstResultados.Columns.Add("Iteracion", 60, HorizontalAlignment.Center);
        lstResultados.Columns.Add("xi",78,HorizontalAlignment.Center);
        lstResultados.Columns.Add("yi",78,HorizontalAlignment.Center);
        lstResultados.Columns.Add("k1",78,HorizontalAlignment.Center);
        lstResultados.Columns.Add("k2",78,HorizontalAlignment.Center);
        lstResultados.Columns.Add("k3",78,HorizontalAlignment.Center);
        lstResultados.Columns.Add("k4",78,HorizontalAlignment.Center);
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
                using(StreamWriter sw = File.CreateText(sfd.FileName + ".csv"))
                {
                    foreach (var line in rIO.CSV_Syntax())
                    {
                        sw.WriteLine(line);
                    }
            
                }
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
                mr.RungeKutta(eqq,Convert.ToDouble(txtX0.Text), Convert.ToDouble(txtY0.Text), Convert.ToDouble(txtXN.Text),Convert.ToDouble(txtValorPaso.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los campos, verifique que esten llenos y en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCleaner(controls);
            }
            ListViewItem lst = new ListViewItem();
            int counter = 0;
            foreach (var data in rIO.Copy())
            {
                if (counter == (rIO.Copy().Count-1))
                {
                    lst = new ListViewItem(counter.ToString());
                    lst.SubItems.Add(data.xi.ToString(CultureInfo.CurrentCulture));
                    lst.SubItems.Add(data.yi.ToString(CultureInfo.CurrentCulture));
                    lst.SubItems.Add("-");
                    lst.SubItems.Add("-");
                    lst.SubItems.Add("-");
                    lst.SubItems.Add("-");
                    lstResultados.Items.Add(lst);
                }
                else
                {
                    lst = new ListViewItem(counter.ToString());
                    lst.SubItems.Add(data.xi.ToString(CultureInfo.CurrentCulture));
                    lst.SubItems.Add(data.yi.ToString(CultureInfo.CurrentCulture));
                    lst.SubItems.Add(data.k1.ToString(CultureInfo.CurrentCulture));
                    lst.SubItems.Add(data.k2.ToString(CultureInfo.CurrentCulture));
                    lst.SubItems.Add(data.k3.ToString(CultureInfo.CurrentCulture));
                    lst.SubItems.Add(data.k4.ToString(CultureInfo.CurrentCulture));
                    lstResultados.Items.Add(lst);
                }

                counter++;
            }

            
            //hr.DataListener(txtFuncion.Text, lstResultados.Items[^2].SubItems[1].Text,lstResultados.Items[lstResultados.Items.Count - 1].SubItems[1].Text);
            

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
            
            if (e.ItemIndex == lastRowIndex && (e.ColumnIndex == 2))
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