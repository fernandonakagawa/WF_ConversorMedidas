namespace WF_ConversorMedidas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConverter = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lbInstrucoes = new System.Windows.Forms.Label();
            this.lbValorConvertido = new System.Windows.Forms.Label();
            this.rbMetros = new System.Windows.Forms.RadioButton();
            this.rbCentimetros = new System.Windows.Forms.RadioButton();
            this.cbExibir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Helvetica Rounded", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(177, 181);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(151, 53);
            this.btnConverter.TabIndex = 0;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            this.btnConverter.MouseEnter += new System.EventHandler(this.btnConverter_MouseEnter);
            this.btnConverter.MouseLeave += new System.EventHandler(this.btnConverter_MouseLeave);
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Helvetica Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(43, 98);
            this.tbValor.MaxLength = 10;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 33);
            this.tbValor.TabIndex = 1;
            // 
            // lbInstrucoes
            // 
            this.lbInstrucoes.AutoSize = true;
            this.lbInstrucoes.Font = new System.Drawing.Font("Helvetica Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstrucoes.Location = new System.Drawing.Point(38, 25);
            this.lbInstrucoes.Name = "lbInstrucoes";
            this.lbInstrucoes.Size = new System.Drawing.Size(301, 26);
            this.lbInstrucoes.TabIndex = 2;
            this.lbInstrucoes.Text = "Digite o valor a ser convertido";
            // 
            // lbValorConvertido
            // 
            this.lbValorConvertido.AutoSize = true;
            this.lbValorConvertido.Font = new System.Drawing.Font("Helvetica Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorConvertido.Location = new System.Drawing.Point(456, 105);
            this.lbValorConvertido.Name = "lbValorConvertido";
            this.lbValorConvertido.Size = new System.Drawing.Size(24, 26);
            this.lbValorConvertido.TabIndex = 3;
            this.lbValorConvertido.Text = "0";
            // 
            // rbMetros
            // 
            this.rbMetros.AutoSize = true;
            this.rbMetros.Checked = true;
            this.rbMetros.Font = new System.Drawing.Font("Helvetica Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMetros.Location = new System.Drawing.Point(233, 85);
            this.rbMetros.Name = "rbMetros";
            this.rbMetros.Size = new System.Drawing.Size(95, 30);
            this.rbMetros.TabIndex = 4;
            this.rbMetros.TabStop = true;
            this.rbMetros.Text = "metros";
            this.rbMetros.UseVisualStyleBackColor = true;
            // 
            // rbCentimetros
            // 
            this.rbCentimetros.AutoSize = true;
            this.rbCentimetros.Font = new System.Drawing.Font("Helvetica Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCentimetros.Location = new System.Drawing.Point(233, 121);
            this.rbCentimetros.Name = "rbCentimetros";
            this.rbCentimetros.Size = new System.Drawing.Size(142, 30);
            this.rbCentimetros.TabIndex = 5;
            this.rbCentimetros.TabStop = true;
            this.rbCentimetros.Text = "centímetros";
            this.rbCentimetros.UseVisualStyleBackColor = true;
            // 
            // cbExibir
            // 
            this.cbExibir.AutoSize = true;
            this.cbExibir.Font = new System.Drawing.Font("Helvetica Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExibir.Location = new System.Drawing.Point(362, 181);
            this.cbExibir.Name = "cbExibir";
            this.cbExibir.Size = new System.Drawing.Size(253, 30);
            this.cbExibir.TabIndex = 6;
            this.cbExibir.Text = "Exibir nome da medida";
            this.cbExibir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.cbExibir);
            this.Controls.Add(this.rbCentimetros);
            this.Controls.Add(this.rbMetros);
            this.Controls.Add(this.lbValorConvertido);
            this.Controls.Add(this.lbInstrucoes);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btnConverter);
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.Text = "Conversor de Medidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lbInstrucoes;
        private System.Windows.Forms.Label lbValorConvertido;
        private System.Windows.Forms.RadioButton rbMetros;
        private System.Windows.Forms.RadioButton rbCentimetros;
        private System.Windows.Forms.CheckBox cbExibir;
    }
}

