namespace WinFormsApp1;

partial class Form1
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
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        textBox4 = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        listView1 = new System.Windows.Forms.ListView();
        groupBox1 = new System.Windows.Forms.GroupBox();
        checkBox2 = new System.Windows.Forms.CheckBox();
        checkBox1 = new System.Windows.Forms.CheckBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(60, 61);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(165, 23);
        textBox1.TabIndex = 0;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(82, 152);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(40, 23);
        textBox2.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(56, 147);
        label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 1);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(20, 23);
        label1.TabIndex = 2;
        label1.Text = "[";
        label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // textBox3
        // 
        textBox3.Location = new System.Drawing.Point(151, 152);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(40, 23);
        textBox3.TabIndex = 3;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(128, 152);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(20, 23);
        label2.TabIndex = 4;
        label2.Text = "-";
        label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(197, 147);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(20, 23);
        label3.TabIndex = 5;
        label3.Text = "]";
        label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.SystemColors.ControlText;
        label4.Location = new System.Drawing.Point(78, 115);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(113, 22);
        label4.TabIndex = 6;
        label4.Text = "INTERVALO";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.SystemColors.ControlText;
        label5.Location = new System.Drawing.Point(88, 36);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(113, 22);
        label5.TabIndex = 7;
        label5.Text = "FUNCION";
        // 
        // textBox4
        // 
        textBox4.Location = new System.Drawing.Point(60, 323);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(40, 23);
        textBox4.TabIndex = 8;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.SystemColors.ControlText;
        label6.Location = new System.Drawing.Point(60, 298);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(135, 22);
        label6.TabIndex = 9;
        label6.Text = "TOLERANCIA %";
        // 
        // listView1
        // 
        listView1.Location = new System.Drawing.Point(268, 61);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(463, 296);
        listView1.TabIndex = 10;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(checkBox2);
        groupBox1.Controls.Add(checkBox1);
        groupBox1.Location = new System.Drawing.Point(60, 206);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(178, 75);
        groupBox1.TabIndex = 11;
        groupBox1.TabStop = false;
        groupBox1.Text = "Metodo";
        // 
        // checkBox2
        // 
        checkBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        checkBox2.Location = new System.Drawing.Point(90, 22);
        checkBox2.Name = "checkBox2";
        checkBox2.Size = new System.Drawing.Size(82, 30);
        checkBox2.TabIndex = 1;
        checkBox2.Text = "Posc. Falsa";
        checkBox2.UseVisualStyleBackColor = true;
        // 
        // checkBox1
        // 
        checkBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        checkBox1.Location = new System.Drawing.Point(6, 22);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(82, 30);
        checkBox1.TabIndex = 0;
        checkBox1.Text = "Biseccion";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(groupBox1);
        Controls.Add(listView1);
        Controls.Add(label6);
        Controls.Add(textBox4);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(textBox3);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        MaximizeBox = false;
        Text = "Form1";
        Load += Form1_Load;
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.CheckBox checkBox2;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox checkBox1;

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    #endregion
}