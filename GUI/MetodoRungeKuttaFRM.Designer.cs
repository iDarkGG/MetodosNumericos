namespace WinFormsApp1;

partial class MetodoRungeKuttaFRM
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoRungeKuttaFRM));
        txtFuncion = new System.Windows.Forms.TextBox();
        txtX0 = new System.Windows.Forms.TextBox();
        txtY0 = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        txtXN = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        lstResultados = new System.Windows.Forms.ListView();
        btnChckSyntax = new System.Windows.Forms.Button();
        btnSave = new System.Windows.Forms.Button();
        btnCalcular = new System.Windows.Forms.Button();
        btnSalir = new System.Windows.Forms.Button();
        label7 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        txtValorPaso = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // txtFuncion
        // 
        txtFuncion.Location = new System.Drawing.Point(60, 72);
        txtFuncion.Name = "txtFuncion";
        txtFuncion.Size = new System.Drawing.Size(165, 23);
        txtFuncion.TabIndex = 0;
        // 
        // txtX0
        // 
        txtX0.Location = new System.Drawing.Point(60, 134);
        txtX0.Name = "txtX0";
        txtX0.Size = new System.Drawing.Size(40, 23);
        txtX0.TabIndex = 1;
        // 
        // txtY0
        // 
        txtY0.Location = new System.Drawing.Point(161, 134);
        txtY0.Name = "txtY0";
        txtY0.Size = new System.Drawing.Size(40, 23);
        txtY0.TabIndex = 3;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.SystemColors.ControlText;
        label4.Location = new System.Drawing.Point(60, 109);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(113, 22);
        label4.TabIndex = 6;
        label4.Text = "x0";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.SystemColors.ControlText;
        label5.Location = new System.Drawing.Point(88, 47);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(113, 22);
        label5.TabIndex = 7;
        label5.Text = "FUNCION";
        // 
        // txtXN
        // 
        txtXN.Location = new System.Drawing.Point(60, 189);
        txtXN.Name = "txtXN";
        txtXN.Size = new System.Drawing.Size(40, 23);
        txtXN.TabIndex = 8;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.SystemColors.ControlText;
        label6.Location = new System.Drawing.Point(161, 109);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(135, 22);
        label6.TabIndex = 9;
        label6.Text = "y0";
        // 
        // lstResultados
        // 
        lstResultados.Location = new System.Drawing.Point(313, 47);
        lstResultados.Name = "lstResultados";
        lstResultados.Size = new System.Drawing.Size(529, 333);
        lstResultados.TabIndex = 10;
        lstResultados.UseCompatibleStateImageBehavior = false;
        // 
        // btnChckSyntax
        // 
        btnChckSyntax.BackColor = System.Drawing.Color.White;
        btnChckSyntax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnChckSyntax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnChckSyntax.Location = new System.Drawing.Point(231, 72);
        btnChckSyntax.Name = "btnChckSyntax";
        btnChckSyntax.Size = new System.Drawing.Size(76, 23);
        btnChckSyntax.TabIndex = 12;
        btnChckSyntax.Text = "chckSyntax";
        btnChckSyntax.UseVisualStyleBackColor = false;
        btnChckSyntax.Click += btnChckSyntax_Click;
        // 
        // btnSave
        // 
        btnSave.BackColor = System.Drawing.Color.White;
        btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnSave.Location = new System.Drawing.Point(686, 403);
        btnSave.Name = "btnSave";
        btnSave.Size = new System.Drawing.Size(87, 24);
        btnSave.TabIndex = 13;
        btnSave.Text = "Guardar CSV";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // btnCalcular
        // 
        btnCalcular.BackColor = System.Drawing.Color.White;
        btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCalcular.Location = new System.Drawing.Point(72, 236);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new System.Drawing.Size(129, 47);
        btnCalcular.TabIndex = 15;
        btnCalcular.Text = "Calcular";
        btnCalcular.UseVisualStyleBackColor = false;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // btnSalir
        // 
        btnSalir.Image = ((System.Drawing.Image)resources.GetObject("btnSalir.Image"));
        btnSalir.Location = new System.Drawing.Point(814, 445);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(28, 23);
        btnSalir.TabIndex = 16;
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(231, 9);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(300, 35);
        label7.TabIndex = 17;
        label7.Text = "RUNGE-KUTTA 4to ORDEN";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlText;
        label1.Location = new System.Drawing.Point(60, 164);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(135, 22);
        label1.TabIndex = 18;
        label1.Text = "xN";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlText;
        label2.Location = new System.Drawing.Point(161, 164);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(135, 22);
        label2.TabIndex = 20;
        label2.Text = "h";
        // 
        // txtValorPaso
        // 
        txtValorPaso.Location = new System.Drawing.Point(161, 189);
        txtValorPaso.Name = "txtValorPaso";
        txtValorPaso.Size = new System.Drawing.Size(40, 23);
        txtValorPaso.TabIndex = 19;
        // 
        // MetodoRungeKuttaFRM
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Gray;
        ClientSize = new System.Drawing.Size(854, 480);
        Controls.Add(label2);
        Controls.Add(txtValorPaso);
        Controls.Add(label1);
        Controls.Add(label7);
        Controls.Add(btnSalir);
        Controls.Add(btnCalcular);
        Controls.Add(btnSave);
        Controls.Add(btnChckSyntax);
        Controls.Add(lstResultados);
        Controls.Add(label6);
        Controls.Add(txtXN);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(txtY0);
        Controls.Add(txtX0);
        Controls.Add(txtFuncion);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        MaximizeBox = false;
        Text = "MetodoBiseccion";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtValorPaso;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Button btnSalir;

    private System.Windows.Forms.Button btnSave;

    private System.Windows.Forms.Button btnCalcular;

    private System.Windows.Forms.Button btnChckSyntax;

    private System.Windows.Forms.ListView lstResultados;

    private System.Windows.Forms.TextBox txtXN;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox txtY0;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox txtFuncion;
    private System.Windows.Forms.TextBox txtX0;

    #endregion
}