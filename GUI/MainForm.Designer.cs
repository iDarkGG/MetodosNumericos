using System.ComponentModel;

namespace WinFormsApp1;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        SideBar = new System.Windows.Forms.FlowLayoutPanel();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        MetodosCerradosContainer = new System.Windows.Forms.FlowLayoutPanel();
        btnMenuCerrados = new System.Windows.Forms.Button();
        btnBiseccion = new System.Windows.Forms.Button();
        btnFP = new System.Windows.Forms.Button();
        contenedorMetodosAbiertos = new System.Windows.Forms.FlowLayoutPanel();
        btnMenuAbiertos = new System.Windows.Forms.Button();
        btnPuntoFijo = new System.Windows.Forms.Button();
        btnNR = new System.Windows.Forms.Button();
        btnSecante = new System.Windows.Forms.Button();
        btnSENL = new System.Windows.Forms.Button();
        MenuTransition = new System.Windows.Forms.Timer(components);
        SidebarTransition = new System.Windows.Forms.Timer(components);
        panelMain = new System.Windows.Forms.Panel();
        MenuAbiertos = new System.Windows.Forms.Timer(components);
        btnRungeKutta = new System.Windows.Forms.Button();
        SideBar.SuspendLayout();
        MetodosCerradosContainer.SuspendLayout();
        contenedorMetodosAbiertos.SuspendLayout();
        SuspendLayout();
        // 
        // SideBar
        // 
        SideBar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        SideBar.Controls.Add(label2);
        SideBar.Controls.Add(MetodosCerradosContainer);
        SideBar.Controls.Add(contenedorMetodosAbiertos);
        SideBar.Controls.Add(btnSENL);
        SideBar.Controls.Add(label1);
        SideBar.Controls.Add(btnRungeKutta);
        SideBar.Dock = System.Windows.Forms.DockStyle.Left;
        SideBar.Location = new System.Drawing.Point(0, 0);
        SideBar.Name = "SideBar";
        SideBar.Size = new System.Drawing.Size(150, 510);
        SideBar.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(3, 184);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(150, 52);
        label1.TabIndex = 10;
        label1.Text = "Ecuaciones Diferenciales";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.White;
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Margin = new System.Windows.Forms.Padding(0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(150, 52);
        label2.TabIndex = 8;
        label2.Text = "Metodos Numericos";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // MetodosCerradosContainer
        // 
        MetodosCerradosContainer.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        MetodosCerradosContainer.Controls.Add(btnMenuCerrados);
        MetodosCerradosContainer.Controls.Add(btnBiseccion);
        MetodosCerradosContainer.Controls.Add(btnFP);
        MetodosCerradosContainer.Location = new System.Drawing.Point(0, 52);
        MetodosCerradosContainer.Margin = new System.Windows.Forms.Padding(0);
        MetodosCerradosContainer.Name = "MetodosCerradosContainer";
        MetodosCerradosContainer.Size = new System.Drawing.Size(150, 40);
        MetodosCerradosContainer.TabIndex = 7;
        // 
        // btnMenuCerrados
        // 
        btnMenuCerrados.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnMenuCerrados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnMenuCerrados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnMenuCerrados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnMenuCerrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnMenuCerrados.ForeColor = System.Drawing.Color.White;
        btnMenuCerrados.Location = new System.Drawing.Point(0, 0);
        btnMenuCerrados.Margin = new System.Windows.Forms.Padding(0);
        btnMenuCerrados.Name = "btnMenuCerrados";
        btnMenuCerrados.Size = new System.Drawing.Size(150, 40);
        btnMenuCerrados.TabIndex = 2;
        btnMenuCerrados.Text = "METODOS CERRADOS";
        btnMenuCerrados.UseVisualStyleBackColor = false;
        btnMenuCerrados.Click += button1_Click;
        // 
        // btnBiseccion
        // 
        btnBiseccion.BackColor = System.Drawing.Color.Gray;
        btnBiseccion.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        btnBiseccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnBiseccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnBiseccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnBiseccion.ForeColor = System.Drawing.Color.White;
        btnBiseccion.Location = new System.Drawing.Point(0, 40);
        btnBiseccion.Margin = new System.Windows.Forms.Padding(0);
        btnBiseccion.Name = "btnBiseccion";
        btnBiseccion.Size = new System.Drawing.Size(150, 40);
        btnBiseccion.TabIndex = 4;
        btnBiseccion.Text = "BISECCION";
        btnBiseccion.UseVisualStyleBackColor = false;
        btnBiseccion.Click += btnBiseccion_Click;
        // 
        // btnFP
        // 
        btnFP.BackColor = System.Drawing.Color.Gray;
        btnFP.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        btnFP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnFP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnFP.ForeColor = System.Drawing.Color.White;
        btnFP.Location = new System.Drawing.Point(0, 80);
        btnFP.Margin = new System.Windows.Forms.Padding(0);
        btnFP.Name = "btnFP";
        btnFP.Size = new System.Drawing.Size(150, 40);
        btnFP.TabIndex = 4;
        btnFP.Text = "FALSA POSICION";
        btnFP.UseVisualStyleBackColor = false;
        btnFP.Click += btnFP_Click;
        // 
        // contenedorMetodosAbiertos
        // 
        contenedorMetodosAbiertos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        contenedorMetodosAbiertos.Controls.Add(btnMenuAbiertos);
        contenedorMetodosAbiertos.Controls.Add(btnPuntoFijo);
        contenedorMetodosAbiertos.Controls.Add(btnNR);
        contenedorMetodosAbiertos.Controls.Add(btnSecante);
        contenedorMetodosAbiertos.Location = new System.Drawing.Point(3, 95);
        contenedorMetodosAbiertos.Name = "contenedorMetodosAbiertos";
        contenedorMetodosAbiertos.Size = new System.Drawing.Size(150, 40);
        contenedorMetodosAbiertos.TabIndex = 6;
        // 
        // btnMenuAbiertos
        // 
        btnMenuAbiertos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnMenuAbiertos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnMenuAbiertos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnMenuAbiertos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnMenuAbiertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnMenuAbiertos.ForeColor = System.Drawing.Color.White;
        btnMenuAbiertos.Location = new System.Drawing.Point(0, 0);
        btnMenuAbiertos.Margin = new System.Windows.Forms.Padding(0);
        btnMenuAbiertos.Name = "btnMenuAbiertos";
        btnMenuAbiertos.Size = new System.Drawing.Size(150, 40);
        btnMenuAbiertos.TabIndex = 3;
        btnMenuAbiertos.Text = "METODOS ABIERTOS";
        btnMenuAbiertos.UseVisualStyleBackColor = false;
        btnMenuAbiertos.Click += btnMenuAbiertos_Click;
        // 
        // btnPuntoFijo
        // 
        btnPuntoFijo.BackColor = System.Drawing.Color.Gray;
        btnPuntoFijo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        btnPuntoFijo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnPuntoFijo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnPuntoFijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPuntoFijo.ForeColor = System.Drawing.Color.White;
        btnPuntoFijo.Location = new System.Drawing.Point(0, 40);
        btnPuntoFijo.Margin = new System.Windows.Forms.Padding(0);
        btnPuntoFijo.Name = "btnPuntoFijo";
        btnPuntoFijo.Size = new System.Drawing.Size(150, 40);
        btnPuntoFijo.TabIndex = 9;
        btnPuntoFijo.Text = "PUNTO FIJO";
        btnPuntoFijo.UseVisualStyleBackColor = false;
        btnPuntoFijo.Click += btnPuntoFijo_Click;
        // 
        // btnNR
        // 
        btnNR.BackColor = System.Drawing.Color.Gray;
        btnNR.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        btnNR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnNR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnNR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnNR.ForeColor = System.Drawing.Color.White;
        btnNR.Location = new System.Drawing.Point(0, 80);
        btnNR.Margin = new System.Windows.Forms.Padding(0);
        btnNR.Name = "btnNR";
        btnNR.Size = new System.Drawing.Size(150, 40);
        btnNR.TabIndex = 8;
        btnNR.Text = "NEWTON RAPHSON";
        btnNR.UseVisualStyleBackColor = false;
        btnNR.Click += btnNR_Click;
        // 
        // btnSecante
        // 
        btnSecante.BackColor = System.Drawing.Color.Gray;
        btnSecante.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
        btnSecante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnSecante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnSecante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSecante.ForeColor = System.Drawing.Color.White;
        btnSecante.Location = new System.Drawing.Point(0, 120);
        btnSecante.Margin = new System.Windows.Forms.Padding(0);
        btnSecante.Name = "btnSecante";
        btnSecante.Size = new System.Drawing.Size(150, 40);
        btnSecante.TabIndex = 5;
        btnSecante.Text = "SECANTE";
        btnSecante.UseVisualStyleBackColor = false;
        btnSecante.Click += btnSecante_Click;
        // 
        // btnSENL
        // 
        btnSENL.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnSENL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnSENL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnSENL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnSENL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSENL.ForeColor = System.Drawing.Color.White;
        btnSENL.Location = new System.Drawing.Point(3, 141);
        btnSENL.Name = "btnSENL";
        btnSENL.Size = new System.Drawing.Size(150, 40);
        btnSENL.TabIndex = 5;
        btnSENL.Text = "NEWTON RAPHSON SENL";
        btnSENL.UseVisualStyleBackColor = false;
        btnSENL.Click += btnSENL_Click;
        // 
        // MenuTransition
        // 
        MenuTransition.Interval = 10;
        MenuTransition.Tick += MenuTransition_Tick;
        // 
        // SidebarTransition
        // 
        SidebarTransition.Interval = 10;
        SidebarTransition.Tick += SidebarTransition_Tick;
        // 
        // panelMain
        // 
        panelMain.BackColor = System.Drawing.Color.White;
        panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
        panelMain.Location = new System.Drawing.Point(150, 0);
        panelMain.Name = "panelMain";
        panelMain.Size = new System.Drawing.Size(854, 510);
        panelMain.TabIndex = 3;
        // 
        // MenuAbiertos
        // 
        MenuAbiertos.Interval = 10;
        MenuAbiertos.Tick += MenuAbiertos_Tick;
        // 
        // btnRungeKutta
        // 
        btnRungeKutta.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnRungeKutta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnRungeKutta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRungeKutta.ForeColor = System.Drawing.Color.Transparent;
        btnRungeKutta.Location = new System.Drawing.Point(0, 236);
        btnRungeKutta.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
        btnRungeKutta.Name = "btnRungeKutta";
        btnRungeKutta.Size = new System.Drawing.Size(153, 40);
        btnRungeKutta.TabIndex = 11;
        btnRungeKutta.Text = "RUNGE-KUTTA 4to ORDEN";
        btnRungeKutta.UseVisualStyleBackColor = false;
        btnRungeKutta.Click += btnRungeKutta_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(1004, 510);
        Controls.Add(panelMain);
        Controls.Add(SideBar);
        Location = new System.Drawing.Point(15, 15);
        Load += MainForm_Load;
        SideBar.ResumeLayout(false);
        MetodosCerradosContainer.ResumeLayout(false);
        contenedorMetodosAbiertos.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnRungeKutta;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Timer MenuAbiertos;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Panel panelMain;

    private System.Windows.Forms.Timer SidebarTransition;

    private System.Windows.Forms.Button btnNR;
    private System.Windows.Forms.Button btnPuntoFijo;

    private System.Windows.Forms.FlowLayoutPanel contenedorMetodosAbiertos;

    private System.Windows.Forms.Timer MenuTransition;

    private System.Windows.Forms.Button btnSecante;

    private System.Windows.Forms.Button btnSENL;
    private System.Windows.Forms.Button btnFP;
    private System.Windows.Forms.FlowLayoutPanel MetodosCerradosContainer;

    private System.Windows.Forms.Button btnMenuAbiertos;
    private System.Windows.Forms.Button btnBiseccion;

    private System.Windows.Forms.Button btnMenuCerrados;

    private System.Windows.Forms.FlowLayoutPanel SideBar;

    #endregion
}