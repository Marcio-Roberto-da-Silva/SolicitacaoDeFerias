
namespace Solicitacao_de_Ferias {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.dateDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dateDataFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(362, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(32, 224);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(86, 43);
            this.btnSolicitar.TabIndex = 3;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(167, 224);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 43);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(308, 224);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 43);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Informe seu Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Informe Data Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Informe Data Final";
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Location = new System.Drawing.Point(32, 186);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(362, 19);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // dateDataInicial
            // 
            this.dateDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataInicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateDataInicial.Location = new System.Drawing.Point(32, 86);
            this.dateDataInicial.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateDataInicial.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateDataInicial.Name = "dateDataInicial";
            this.dateDataInicial.Size = new System.Drawing.Size(200, 22);
            this.dateDataInicial.TabIndex = 10;
            this.dateDataInicial.Value = new System.DateTime(2023, 1, 18, 0, 0, 0, 0);
            this.dateDataInicial.ValueChanged += new System.EventHandler(this.dateDataInicial_ValueChanged);
            // 
            // dateDataFinal
            // 
            this.dateDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataFinal.Location = new System.Drawing.Point(32, 136);
            this.dateDataFinal.Name = "dateDataFinal";
            this.dateDataFinal.Size = new System.Drawing.Size(200, 22);
            this.dateDataFinal.TabIndex = 11;
            this.dateDataFinal.Value = new System.DateTime(2023, 1, 18, 0, 0, 0, 0);
            this.dateDataFinal.ValueChanged += new System.EventHandler(this.dateDataFinal_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 367);
            this.Controls.Add(this.dateDataFinal);
            this.Controls.Add(this.dateDataInicial);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Solicitação de Férias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.DateTimePicker dateDataFinal;
        private System.Windows.Forms.DateTimePicker dateDataInicial;
    }
}

