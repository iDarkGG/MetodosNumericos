namespace WinFormsApp1;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }
    
    private void AbrirFormEnPanel(object Formhijo)
    {
        if (this.panelMain.Controls.Count > 0)
            this.panelMain.Controls.RemoveAt(0);
        Form fh = Formhijo as Form;
        fh.TopLevel = false;
        fh.Dock = DockStyle.Fill;
        this.panelMain.Controls.Add(fh);
        this.panelMain.Tag = fh;
        fh.Show();

    }

    private bool menuExpand;
    private bool sideBarExpand = true;
    private void button1_Click(object sender, EventArgs e)
    {
        MenuTransition.Start();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void MenuTransition_Tick(object sender, EventArgs e)
    {
        if (!menuExpand)
        {
            MetodosCerradosContainer.Height += 10;
            if (MetodosCerradosContainer.Height == 120)
            {
                MenuTransition.Stop();
                menuExpand = true;
            }
        }
        else
        {
            MetodosCerradosContainer.Height -= 10;
            if (MetodosCerradosContainer.Height == 40)
            {
                MenuTransition.Stop();
                menuExpand = false;
            }
        }
    }

    private void btnBiseccion_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnPuntoFijo_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnNR_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnSecante_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void btnMenuAbiertos_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void SidebarTransition_Tick(object sender, EventArgs e)
    {
        if (sideBarExpand)
        {
            SideBar.Width -= 10;
            if (SideBar.Width == 30)
            {
                SidebarTransition.Stop();
                sideBarExpand = false;
            }
        }
        else
        {
            SideBar.Width += 10;
            if (SideBar.Width == 150)
            {
                SidebarTransition.Stop();
                sideBarExpand = true;
            }
        }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        SidebarTransition.Start();
        //MessageBox.Show("Test");
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        
        AbrirFormEnPanel(new Form1());
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}