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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        panel1 = new System.Windows.Forms.Panel();
        btnSalir = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        SideBar = new System.Windows.Forms.FlowLayoutPanel();
        label2 = new System.Windows.Forms.Label();
        contenedorMetodosAbiertos = new System.Windows.Forms.FlowLayoutPanel();
        btnMenuAbiertos = new System.Windows.Forms.Button();
        btnPuntoFijo = new System.Windows.Forms.Button();
        btnNR = new System.Windows.Forms.Button();
        btnSecante = new System.Windows.Forms.Button();
        btnSENL = new System.Windows.Forms.Button();
        btnHerramientas = new System.Windows.Forms.Button();
        MetodosCerradosContainer = new System.Windows.Forms.FlowLayoutPanel();
        btnMenuCerrados = new System.Windows.Forms.Button();
        btnBiseccion = new System.Windows.Forms.Button();
        btnFP = new System.Windows.Forms.Button();
        MenuTransition = new System.Windows.Forms.Timer(components);
        SidebarTransition = new System.Windows.Forms.Timer(components);
        panelMain = new System.Windows.Forms.Panel();
        MenuAbiertos = new System.Windows.Forms.Timer(components);
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SideBar.SuspendLayout();
        contenedorMetodosAbiertos.SuspendLayout();
        MetodosCerradosContainer.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.White;
        panel1.Controls.Add(btnSalir);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(pictureBox1);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1004, 30);
        panel1.TabIndex = 0;
        // 
        // btnSalir
        // 
        btnSalir.Image = ((System.Drawing.Image)resources.GetObject("btnSalir.Image"));
        btnSalir.Location = new System.Drawing.Point(973, 4);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(28, 23);
        btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        btnSalir.TabIndex = 0;
        btnSalir.TabStop = false;
        btnSalir.Click += btnSalir_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(53, 8);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(175, 18);
        label1.TabIndex = 1;
        label1.Text = "METODOS DE APROXIMACION";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(3, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(27, 23);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        pictureBox1.TabIndex = 1;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // SideBar
        // 
        SideBar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        SideBar.Controls.Add(label2);
        SideBar.Controls.Add(MetodosCerradosContainer);
        SideBar.Controls.Add(contenedorMetodosAbiertos);
        SideBar.Controls.Add(btnSENL);
        SideBar.Controls.Add(btnHerramientas);
        SideBar.Dock = System.Windows.Forms.DockStyle.Left;
        SideBar.Location = new System.Drawing.Point(0, 30);
        SideBar.Name = "SideBar";
        SideBar.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
        SideBar.Size = new System.Drawing.Size(150, 480);
        SideBar.TabIndex = 1;
        // 
        // label2
        // 
        label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.White;
        label2.Location = new System.Drawing.Point(0, 80);
        label2.Margin = new System.Windows.Forms.Padding(0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(150, 47);
        label2.TabIndex = 8;
        label2.Text = "METODOS DE APROXIMACION";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // contenedorMetodosAbiertos
        // 
        contenedorMetodosAbiertos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        contenedorMetodosAbiertos.Controls.Add(btnMenuAbiertos);
        contenedorMetodosAbiertos.Controls.Add(btnPuntoFijo);
        contenedorMetodosAbiertos.Controls.Add(btnNR);
        contenedorMetodosAbiertos.Controls.Add(btnSecante);
        contenedorMetodosAbiertos.Location = new System.Drawing.Point(3, 170);
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
        btnSENL.Location = new System.Drawing.Point(3, 216);
        btnSENL.Name = "btnSENL";
        btnSENL.Size = new System.Drawing.Size(150, 40);
        btnSENL.TabIndex = 5;
        btnSENL.Text = "NEWTON RAPHSON SENL";
        btnSENL.UseVisualStyleBackColor = false;
        btnSENL.Click += btnSENL_Click;
        // 
        // btnHerramientas
        // 
        btnHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnHerramientas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnHerramientas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnHerramientas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        btnHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnHerramientas.ForeColor = System.Drawing.Color.White;
        btnHerramientas.Location = new System.Drawing.Point(3, 262);
        btnHerramientas.Name = "btnHerramientas";
        btnHerramientas.Size = new System.Drawing.Size(150, 40);
        btnHerramientas.TabIndex = 9;
        btnHerramientas.Text = "HERRAMIENTAS";
        btnHerramientas.UseVisualStyleBackColor = false;
        btnHerramientas.Click += btnHerramientas_Click;
        // 
        // MetodosCerradosContainer
        // 
        MetodosCerradosContainer.BackColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
        MetodosCerradosContainer.Controls.Add(btnMenuCerrados);
        MetodosCerradosContainer.Controls.Add(btnBiseccion);
        MetodosCerradosContainer.Controls.Add(btnFP);
        MetodosCerradosContainer.Location = new System.Drawing.Point(0, 127);
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
        panelMain.Location = new System.Drawing.Point(150, 30);
        panelMain.Name = "panelMain";
        panelMain.Size = new System.Drawing.Size(854, 480);
        panelMain.TabIndex = 3;
        // 
        // MenuAbiertos
        // 
        MenuAbiertos.Interval = 10;
        MenuAbiertos.Tick += MenuAbiertos_Tick;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1004, 510);
        ControlBox = false;
        Controls.Add(panelMain);
        Controls.Add(SideBar);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "MainForm";
        Load += MainForm_Load;
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        SideBar.ResumeLayout(false);
        contenedorMetodosAbiertos.ResumeLayout(false);
        MetodosCerradosContainer.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnHerramientas;

    private System.Windows.Forms.Timer MenuAbiertos;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.PictureBox btnSalir;

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

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}