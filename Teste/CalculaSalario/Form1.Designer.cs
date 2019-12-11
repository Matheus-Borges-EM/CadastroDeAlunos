namespace CalculaSalario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.lblSalarioMinimo = new System.Windows.Forms.Label();
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.gbxCategoria = new System.Windows.Forms.GroupBox();
            this.rbt = new System.Windows.Forms.RadioButton();
            this.rbtCalouro = new System.Windows.Forms.RadioButton();
            this.gbxTurno = new System.Windows.Forms.GroupBox();
            this.rbtNoturno = new System.Windows.Forms.RadioButton();
            this.rbtVespertino = new System.Windows.Forms.RadioButton();
            this.rbtMatutino = new System.Windows.Forms.RadioButton();
            this.lbxMostrar = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtRemuneracao = new System.Windows.Forms.TextBox();
            this.ttp1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCategoria.SuspendLayout();
            this.gbxTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioMinimo
            // 
            this.lblSalarioMinimo.AutoSize = true;
            this.lblSalarioMinimo.Location = new System.Drawing.Point(12, 9);
            this.lblSalarioMinimo.Name = "lblSalarioMinimo";
            this.lblSalarioMinimo.Size = new System.Drawing.Size(79, 13);
            this.lblSalarioMinimo.TabIndex = 0;
            this.lblSalarioMinimo.Text = "Salário mínimo:";
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(12, 34);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(96, 13);
            this.lblHorasTrabalhadas.TabIndex = 1;
            this.lblHorasTrabalhadas.Text = "Horas trabalhadas:";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(114, 31);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabalhadas.TabIndex = 2;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Location = new System.Drawing.Point(114, 6);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioMinimo.TabIndex = 3;
            this.ttp1.SetToolTip(this.txtSalarioMinimo, "Informe o valor atual para o salario mínimo");
            // 
            // gbxCategoria
            // 
            this.gbxCategoria.Controls.Add(this.rbt);
            this.gbxCategoria.Controls.Add(this.rbtCalouro);
            this.gbxCategoria.Location = new System.Drawing.Point(15, 57);
            this.gbxCategoria.Name = "gbxCategoria";
            this.gbxCategoria.Size = new System.Drawing.Size(200, 42);
            this.gbxCategoria.TabIndex = 4;
            this.gbxCategoria.TabStop = false;
            this.gbxCategoria.Text = "Categoria";
            // 
            // rbt
            // 
            this.rbt.AutoSize = true;
            this.rbt.Location = new System.Drawing.Point(99, 19);
            this.rbt.Name = "rbt";
            this.rbt.Size = new System.Drawing.Size(68, 17);
            this.rbt.TabIndex = 1;
            this.rbt.TabStop = true;
            this.rbt.Text = "Veterano";
            this.rbt.UseVisualStyleBackColor = true;
            // 
            // rbtCalouro
            // 
            this.rbtCalouro.AutoSize = true;
            this.rbtCalouro.Location = new System.Drawing.Point(8, 19);
            this.rbtCalouro.Name = "rbtCalouro";
            this.rbtCalouro.Size = new System.Drawing.Size(61, 17);
            this.rbtCalouro.TabIndex = 0;
            this.rbtCalouro.TabStop = true;
            this.rbtCalouro.Text = "Calouro";
            this.rbtCalouro.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            this.gbxTurno.Controls.Add(this.rbtNoturno);
            this.gbxTurno.Controls.Add(this.rbtVespertino);
            this.gbxTurno.Controls.Add(this.rbtMatutino);
            this.gbxTurno.Location = new System.Drawing.Point(221, 6);
            this.gbxTurno.Name = "gbxTurno";
            this.gbxTurno.Size = new System.Drawing.Size(86, 93);
            this.gbxTurno.TabIndex = 5;
            this.gbxTurno.TabStop = false;
            this.gbxTurno.Text = "Turno";
            // 
            // rbtNoturno
            // 
            this.rbtNoturno.AutoSize = true;
            this.rbtNoturno.Location = new System.Drawing.Point(6, 65);
            this.rbtNoturno.Name = "rbtNoturno";
            this.rbtNoturno.Size = new System.Drawing.Size(63, 17);
            this.rbtNoturno.TabIndex = 2;
            this.rbtNoturno.TabStop = true;
            this.rbtNoturno.Text = "Noturno";
            this.rbtNoturno.UseVisualStyleBackColor = true;
            // 
            // rbtVespertino
            // 
            this.rbtVespertino.AutoSize = true;
            this.rbtVespertino.Location = new System.Drawing.Point(6, 42);
            this.rbtVespertino.Name = "rbtVespertino";
            this.rbtVespertino.Size = new System.Drawing.Size(75, 17);
            this.rbtVespertino.TabIndex = 1;
            this.rbtVespertino.TabStop = true;
            this.rbtVespertino.Text = "Vespertino";
            this.rbtVespertino.UseVisualStyleBackColor = true;
            // 
            // rbtMatutino
            // 
            this.rbtMatutino.AutoSize = true;
            this.rbtMatutino.Location = new System.Drawing.Point(6, 19);
            this.rbtMatutino.Name = "rbtMatutino";
            this.rbtMatutino.Size = new System.Drawing.Size(66, 17);
            this.rbtMatutino.TabIndex = 0;
            this.rbtMatutino.TabStop = true;
            this.rbtMatutino.Text = "Matutino";
            this.rbtMatutino.UseVisualStyleBackColor = true;
            // 
            // lbxMostrar
            // 
            this.lbxMostrar.FormattingEnabled = true;
            this.lbxMostrar.Location = new System.Drawing.Point(12, 105);
            this.lbxMostrar.MultiColumn = true;
            this.lbxMostrar.Name = "lbxMostrar";
            this.lbxMostrar.Size = new System.Drawing.Size(295, 95);
            this.lbxMostrar.TabIndex = 6;
            this.lbxMostrar.SelectedIndexChanged += new System.EventHandler(this.lbxMostrar_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(232, 207);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtRemuneracao
            // 
            this.txtRemuneracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemuneracao.Enabled = false;
            this.txtRemuneracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemuneracao.Location = new System.Drawing.Point(12, 207);
            this.txtRemuneracao.Name = "txtRemuneracao";
            this.txtRemuneracao.Size = new System.Drawing.Size(214, 22);
            this.txtRemuneracao.TabIndex = 8;
            // 
            // ttp1
            // 
            this.ttp1.IsBalloon = true;
            this.ttp1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttp1.ToolTipTitle = "Ajuda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 242);
            this.Controls.Add(this.txtRemuneracao);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbxMostrar);
            this.Controls.Add(this.gbxTurno);
            this.Controls.Add(this.gbxCategoria);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Controls.Add(this.lblSalarioMinimo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxCategoria.ResumeLayout(false);
            this.gbxCategoria.PerformLayout();
            this.gbxTurno.ResumeLayout(false);
            this.gbxTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label lblSalarioMinimo;
        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.GroupBox gbxCategoria;
        private System.Windows.Forms.RadioButton rbt;
        private System.Windows.Forms.RadioButton rbtCalouro;
        private System.Windows.Forms.GroupBox gbxTurno;
        private System.Windows.Forms.RadioButton rbtNoturno;
        private System.Windows.Forms.RadioButton rbtVespertino;
        private System.Windows.Forms.RadioButton rbtMatutino;
        private System.Windows.Forms.ListBox lbxMostrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtRemuneracao;
        private System.Windows.Forms.ToolTip ttp1;
    }
}

