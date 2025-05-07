namespace WinFormsApp1;

partial class MetodoSecanteFRM
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoSecanteFRM));
        txtFuncion = new System.Windows.Forms.TextBox();
        txtXi = new System.Windows.Forms.TextBox();
        txtXo = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        txtTolerancia = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        lstResultados = new System.Windows.Forms.ListView();
        btnChckSyntax = new System.Windows.Forms.Button();
        btnSave = new System.Windows.Forms.Button();
        btnGrafico = new System.Windows.Forms.Button();
        btnCalcular = new System.Windows.Forms.Button();
        btnSalir = new System.Windows.Forms.Button();
        label7 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // txtFuncion
        // 
        txtFuncion.Location = new System.Drawing.Point(22, 73);
        txtFuncion.Name = "txtFuncion";
        txtFuncion.Size = new System.Drawing.Size(165, 23);
        txtFuncion.TabIndex = 0;
        // 
        // txtXi
        // 
        txtXi.Location = new System.Drawing.Point(22, 162);
        txtXi.Name = "txtXi";
        txtXi.Size = new System.Drawing.Size(40, 23);
        txtXi.TabIndex = 1;
        // 
        // txtXo
        // 
        txtXo.Location = new System.Drawing.Point(95, 162);
        txtXo.Name = "txtXo";
        txtXo.Size = new System.Drawing.Size(40, 23);
        txtXo.TabIndex = 3;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.SystemColors.ControlText;
        label4.Location = new System.Drawing.Point(22, 125);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(113, 22);
        label4.TabIndex = 6;
        label4.Text = "Xi              Xi-1";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.SystemColors.ControlText;
        label5.Location = new System.Drawing.Point(50, 48);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(113, 22);
        label5.TabIndex = 7;
        label5.Text = "FUNCION";
        // 
        // txtTolerancia
        // 
        txtTolerancia.Location = new System.Drawing.Point(52, 234);
        txtTolerancia.Name = "txtTolerancia";
        txtTolerancia.Size = new System.Drawing.Size(40, 23);
        txtTolerancia.TabIndex = 8;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.SystemColors.ControlText;
        label6.Location = new System.Drawing.Point(22, 209);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(135, 22);
        label6.TabIndex = 9;
        label6.Text = "TOLERANCIA %";
        // 
        // lstResultados
        // 
        lstResultados.Location = new System.Drawing.Point(272, 47);
        lstResultados.Name = "lstResultados";
        lstResultados.Size = new System.Drawing.Size(570, 333);
        lstResultados.TabIndex = 10;
        lstResultados.UseCompatibleStateImageBehavior = false;
        // 
        // btnChckSyntax
        // 
        btnChckSyntax.BackColor = System.Drawing.Color.White;
        btnChckSyntax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnChckSyntax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnChckSyntax.Location = new System.Drawing.Point(193, 73);
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
        // btnGrafico
        // 
        btnGrafico.BackColor = System.Drawing.Color.White;
        btnGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnGrafico.Location = new System.Drawing.Point(779, 403);
        btnGrafico.Name = "btnGrafico";
        btnGrafico.Size = new System.Drawing.Size(63, 24);
        btnGrafico.TabIndex = 14;
        btnGrafico.Text = "Grafico";
        btnGrafico.UseVisualStyleBackColor = false;
        // 
        // btnCalcular
        // 
        btnCalcular.BackColor = System.Drawing.Color.White;
        btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnCalcular.Location = new System.Drawing.Point(50, 283);
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
        label7.Location = new System.Drawing.Point(290, 9);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(190, 35);
        label7.TabIndex = 17;
        label7.Text = "SECANTE";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // MetodoSecanteFRM
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Gray;
        ClientSize = new System.Drawing.Size(854, 480);
        Controls.Add(label7);
        Controls.Add(btnSalir);
        Controls.Add(btnCalcular);
        Controls.Add(btnGrafico);
        Controls.Add(btnSave);
        Controls.Add(btnChckSyntax);
        Controls.Add(lstResultados);
        Controls.Add(label6);
        Controls.Add(txtTolerancia);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(txtXo);
        Controls.Add(txtXi);
        Controls.Add(txtFuncion);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        MaximizeBox = false;
        Text = "MetodoBiseccion";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Button btnSalir;

    private System.Windows.Forms.Button btnSave;

    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Button btnGrafico;

    private System.Windows.Forms.Button btnChckSyntax;

    private System.Windows.Forms.ListView lstResultados;

    private System.Windows.Forms.TextBox txtTolerancia;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox txtXo;

    private System.Windows.Forms.TextBox txtFuncion;
    private System.Windows.Forms.TextBox txtXi;

    #endregion
}