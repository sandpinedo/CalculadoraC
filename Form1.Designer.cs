namespace Calculadora2
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cajaResultado = new TextBox();
            lblHistorial = new Label();
            btnuno = new Button();
            btndos = new Button();
            btntres = new Button();
            btnseis = new Button();
            btncinco = new Button();
            btncuatro = new Button();
            btnnueve = new Button();
            btnocho = new Button();
            btnsiete = new Button();
            btnReset = new Button();
            btnDivision = new Button();
            btnModulo = new Button();
            btncero = new Button();
            btnpunto = new Button();
            btnresultado = new Button();
            btnBorrar = new Button();
            btnmultiplicar = new Button();
            btnresta = new Button();
            btnsuma = new Button();
            SuspendLayout();
            // 
            // cajaResultado
            // 
            cajaResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cajaResultado.Location = new Point(35, 37);
            cajaResultado.Name = "cajaResultado";
            cajaResultado.ReadOnly = true;
            cajaResultado.Size = new Size(230, 35);
            cajaResultado.TabIndex = 0;
            cajaResultado.Text = "0";
            cajaResultado.TextAlign = HorizontalAlignment.Right;
            cajaResultado.TextChanged += cajaResultado_TextChanged;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Location = new Point(17, 16);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(0, 15);
            lblHistorial.TabIndex = 1;
            // 
            // btnuno
            // 
            btnuno.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnuno.Location = new Point(35, 269);
            btnuno.Name = "btnuno";
            btnuno.Size = new Size(53, 54);
            btnuno.TabIndex = 2;
            btnuno.Text = "1";
            btnuno.UseVisualStyleBackColor = true;
            btnuno.Click += btnuno_Click;
            // 
            // btndos
            // 
            btndos.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndos.Location = new Point(94, 269);
            btndos.Name = "btndos";
            btndos.Size = new Size(53, 54);
            btndos.TabIndex = 3;
            btndos.Text = "2";
            btndos.UseVisualStyleBackColor = true;
            btndos.Click += btndos_Click;
            // 
            // btntres
            // 
            btntres.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btntres.Location = new Point(153, 269);
            btntres.Name = "btntres";
            btntres.Size = new Size(53, 54);
            btntres.TabIndex = 4;
            btntres.Text = "3";
            btntres.UseVisualStyleBackColor = true;
            btntres.Click += btntres_Click;
            // 
            // btnseis
            // 
            btnseis.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnseis.Location = new Point(153, 209);
            btnseis.Name = "btnseis";
            btnseis.Size = new Size(53, 54);
            btnseis.TabIndex = 7;
            btnseis.Text = "6";
            btnseis.UseVisualStyleBackColor = true;
            btnseis.Click += btnseis_Click;
            // 
            // btncinco
            // 
            btncinco.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncinco.Location = new Point(94, 209);
            btncinco.Name = "btncinco";
            btncinco.Size = new Size(53, 54);
            btncinco.TabIndex = 6;
            btncinco.Text = "5";
            btncinco.UseVisualStyleBackColor = true;
            btncinco.Click += btncinco_Click;
            // 
            // btncuatro
            // 
            btncuatro.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncuatro.Location = new Point(35, 209);
            btncuatro.Name = "btncuatro";
            btncuatro.Size = new Size(53, 54);
            btncuatro.TabIndex = 5;
            btncuatro.Text = "4";
            btncuatro.UseVisualStyleBackColor = true;
            btncuatro.Click += btncuatro_Click;
            // 
            // btnnueve
            // 
            btnnueve.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnnueve.Location = new Point(153, 149);
            btnnueve.Name = "btnnueve";
            btnnueve.Size = new Size(53, 54);
            btnnueve.TabIndex = 10;
            btnnueve.Text = "9";
            btnnueve.UseVisualStyleBackColor = true;
            btnnueve.Click += btnnueve_Click;
            // 
            // btnocho
            // 
            btnocho.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnocho.Location = new Point(94, 149);
            btnocho.Name = "btnocho";
            btnocho.Size = new Size(53, 54);
            btnocho.TabIndex = 9;
            btnocho.Text = "8";
            btnocho.UseVisualStyleBackColor = true;
            btnocho.Click += btnocho_Click;
            // 
            // btnsiete
            // 
            btnsiete.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsiete.Location = new Point(35, 149);
            btnsiete.Name = "btnsiete";
            btnsiete.Size = new Size(53, 54);
            btnsiete.TabIndex = 8;
            btnsiete.Text = "7";
            btnsiete.UseVisualStyleBackColor = true;
            btnsiete.Click += btnsiete_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(153, 89);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(53, 54);
            btnReset.TabIndex = 13;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivision.Location = new Point(94, 89);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(53, 54);
            btnDivision.TabIndex = 12;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btnModulo
            // 
            btnModulo.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModulo.Location = new Point(35, 89);
            btnModulo.Name = "btnModulo";
            btnModulo.Size = new Size(53, 54);
            btnModulo.TabIndex = 11;
            btnModulo.Text = "%";
            btnModulo.UseVisualStyleBackColor = true;
            btnModulo.Click += btnModulo_Click;
            // 
            // btncero
            // 
            btncero.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btncero.Location = new Point(35, 329);
            btncero.Name = "btncero";
            btncero.Size = new Size(112, 54);
            btncero.TabIndex = 14;
            btncero.Text = "0";
            btncero.UseVisualStyleBackColor = true;
            btncero.Click += btncero_Click;
            // 
            // btnpunto
            // 
            btnpunto.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnpunto.Location = new Point(153, 329);
            btnpunto.Name = "btnpunto";
            btnpunto.Size = new Size(53, 54);
            btnpunto.TabIndex = 15;
            btnpunto.Text = ".";
            btnpunto.UseVisualStyleBackColor = true;
            // 
            // btnresultado
            // 
            btnresultado.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnresultado.Location = new Point(212, 329);
            btnresultado.Name = "btnresultado";
            btnresultado.Size = new Size(53, 54);
            btnresultado.TabIndex = 20;
            btnresultado.Text = "=";
            btnresultado.UseVisualStyleBackColor = true;
            btnresultado.Click += btnresultado_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.Location = new Point(212, 89);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(53, 54);
            btnBorrar.TabIndex = 19;
            btnBorrar.Text = "<";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnmultiplicar.Location = new Point(212, 149);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(53, 54);
            btnmultiplicar.TabIndex = 18;
            btnmultiplicar.Text = "X";
            btnmultiplicar.UseVisualStyleBackColor = true;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btnresta
            // 
            btnresta.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnresta.Location = new Point(212, 209);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(53, 54);
            btnresta.TabIndex = 17;
            btnresta.Text = "-";
            btnresta.UseVisualStyleBackColor = true;
            btnresta.Click += btnresta_Click;
            // 
            // btnsuma
            // 
            btnsuma.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsuma.Location = new Point(212, 269);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(53, 54);
            btnsuma.TabIndex = 16;
            btnsuma.Text = "+";
            btnsuma.UseVisualStyleBackColor = true;
            btnsuma.Click += btnsuma_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 407);
            Controls.Add(btnresultado);
            Controls.Add(btnBorrar);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnresta);
            Controls.Add(btnsuma);
            Controls.Add(btnpunto);
            Controls.Add(btncero);
            Controls.Add(btnReset);
            Controls.Add(btnDivision);
            Controls.Add(btnModulo);
            Controls.Add(btnnueve);
            Controls.Add(btnocho);
            Controls.Add(btnsiete);
            Controls.Add(btnseis);
            Controls.Add(btncinco);
            Controls.Add(btncuatro);
            Controls.Add(btntres);
            Controls.Add(btndos);
            Controls.Add(btnuno);
            Controls.Add(lblHistorial);
            Controls.Add(cajaResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cajaResultado;
        private Label lblHistorial;
        private Button btnuno;
        private Button btndos;
        private Button btntres;
        private Button btnseis;
        private Button btncinco;
        private Button btncuatro;
        private Button btnnueve;
        private Button btnocho;
        private Button btnsiete;
        private Button btnReset;
        private Button btnDivision;
        private Button btnModulo;
        private Button btncero;
        private Button btnpunto;
        private Button btnresultado;
        private Button btnBorrar;
        private Button btnmultiplicar;
        private Button btnresta;
        private Button btnsuma;
    }
}