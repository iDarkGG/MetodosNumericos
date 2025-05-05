namespace WinFormsApp1;

partial class MetodoNR_SENL_FRM
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoNR_SENL_FRM));
        txtSENL1 = new System.Windows.Forms.TextBox();
        txtPI1 = new System.Windows.Forms.TextBox();
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
        txtSENL2 = new System.Windows.Forms.TextBox();
        grpButton = new System.Windows.Forms.GroupBox();
        rbtn3 = new System.Windows.Forms.RadioButton();
        rbtn2 = new System.Windows.Forms.RadioButton();
        txtSENL3 = new System.Windows.Forms.TextBox();
        txtPI2 = new System.Windows.Forms.TextBox();
        txtPI3 = new System.Windows.Forms.TextBox();
        grpButton.SuspendLayout();
        SuspendLayout();
        // 
        // txtSENL1
        // 
        txtSENL1.Location = new System.Drawing.Point(15, 72);
        txtSENL1.Name = "txtSENL1";
        txtSENL1.Size = new System.Drawing.Size(120, 23);
        txtSENL1.TabIndex = 0;
        // 
        // txtPI1
        // 
        txtPI1.Location = new System.Drawing.Point(15, 182);
        txtPI1.Name = "txtPI1";
        txtPI1.Size = new System.Drawing.Size(40, 23);
        txtPI1.TabIndex = 1;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.SystemColors.ControlText;
        label4.Location = new System.Drawing.Point(15, 157);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(153, 22);
        label4.TabIndex = 6;
        label4.Text = "POSICION INICIAL";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.SystemColors.ControlText;
        label5.Location = new System.Drawing.Point(15, 47);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(88, 22);
        label5.TabIndex = 7;
        label5.Text = "SENL";
        // 
        // txtTolerancia
        // 
        txtTolerancia.Location = new System.Drawing.Point(63, 291);
        txtTolerancia.Name = "txtTolerancia";
        txtTolerancia.Size = new System.Drawing.Size(40, 23);
        txtTolerancia.TabIndex = 8;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.SystemColors.ControlText;
        label6.Location = new System.Drawing.Point(15, 266);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(135, 22);
        label6.TabIndex = 9;
        label6.Text = "TOLERANCIA %";
        // 
        // lstResultados
        // 
        lstResultados.Location = new System.Drawing.Point(275, 47);
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
        btnChckSyntax.Location = new System.Drawing.Point(141, 72);
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
        btnCalcular.Location = new System.Drawing.Point(43, 331);
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
        label7.Location = new System.Drawing.Point(195, 9);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(370, 35);
        label7.TabIndex = 17;
        label7.Text = "NEWTON RAPHSON PARA SENL";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtSENL2
        // 
        txtSENL2.Location = new System.Drawing.Point(15, 102);
        txtSENL2.Name = "txtSENL2";
        txtSENL2.Size = new System.Drawing.Size(120, 23);
        txtSENL2.TabIndex = 18;
        // 
        // grpButton
        // 
        grpButton.Controls.Add(rbtn3);
        grpButton.Controls.Add(rbtn2);
        grpButton.Location = new System.Drawing.Point(141, 102);
        grpButton.Name = "grpButton";
        grpButton.Size = new System.Drawing.Size(107, 49);
        grpButton.TabIndex = 19;
        grpButton.TabStop = false;
        grpButton.Text = "# de Ecuaciones";
        // 
        // rbtn3
        // 
        rbtn3.Location = new System.Drawing.Point(73, 22);
        rbtn3.Name = "rbtn3";
        rbtn3.Size = new System.Drawing.Size(37, 24);
        rbtn3.TabIndex = 1;
        rbtn3.TabStop = true;
        rbtn3.Text = "3";
        rbtn3.UseVisualStyleBackColor = true;
        // 
        // rbtn2
        // 
        rbtn2.Location = new System.Drawing.Point(6, 22);
        rbtn2.Name = "rbtn2";
        rbtn2.Size = new System.Drawing.Size(37, 24);
        rbtn2.TabIndex = 0;
        rbtn2.TabStop = true;
        rbtn2.Text = "2";
        rbtn2.UseVisualStyleBackColor = true;
        // 
        // txtSENL3
        // 
        txtSENL3.Location = new System.Drawing.Point(15, 131);
        txtSENL3.Name = "txtSENL3";
        txtSENL3.Size = new System.Drawing.Size(120, 23);
        txtSENL3.TabIndex = 20;
        // 
        // txtPI2
        // 
        txtPI2.Location = new System.Drawing.Point(15, 211);
        txtPI2.Name = "txtPI2";
        txtPI2.Size = new System.Drawing.Size(40, 23);
        txtPI2.TabIndex = 21;
        // 
        // txtPI3
        // 
        txtPI3.Location = new System.Drawing.Point(15, 240);
        txtPI3.Name = "txtPI3";
        txtPI3.Size = new System.Drawing.Size(40, 23);
        txtPI3.TabIndex = 22;
        // 
        // MetodoNR_SENL_FRM
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Gray;
        ClientSize = new System.Drawing.Size(854, 480);
        Controls.Add(txtPI3);
        Controls.Add(txtPI2);
        Controls.Add(txtSENL3);
        Controls.Add(grpButton);
        Controls.Add(txtSENL2);
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
        Controls.Add(txtPI1);
        Controls.Add(txtSENL1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        MaximizeBox = false;
        Text = "MetodoBiseccion";
        Load += Form1_Load;
        grpButton.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtPI2;
    private System.Windows.Forms.TextBox txtPI3;

    private System.Windows.Forms.GroupBox grpButton;
    private System.Windows.Forms.RadioButton rbtn2;
    private System.Windows.Forms.RadioButton rbtn3;
    private System.Windows.Forms.TextBox txtSENL3;

    private System.Windows.Forms.TextBox txtSENL2;

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

    private System.Windows.Forms.TextBox txtSENL1;
    private System.Windows.Forms.TextBox txtPI1;

    #endregion
}