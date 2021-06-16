
namespace PO2aula5
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculaArea = new System.Windows.Forms.Button();
            this.btnCalculaComprimento = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para realizar o calculo do perímetro e a área do circulo digite o valor do raio:";
            // 
            // btnCalculaArea
            // 
            this.btnCalculaArea.Location = new System.Drawing.Point(45, 51);
            this.btnCalculaArea.Name = "btnCalculaArea";
            this.btnCalculaArea.Size = new System.Drawing.Size(129, 23);
            this.btnCalculaArea.TabIndex = 2;
            this.btnCalculaArea.Text = "Calcular Área";
            this.btnCalculaArea.UseVisualStyleBackColor = true;
            this.btnCalculaArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalculaComprimento
            // 
            this.btnCalculaComprimento.Location = new System.Drawing.Point(214, 51);
            this.btnCalculaComprimento.Name = "btnCalculaComprimento";
            this.btnCalculaComprimento.Size = new System.Drawing.Size(129, 23);
            this.btnCalculaComprimento.TabIndex = 3;
            this.btnCalculaComprimento.Text = "Calcular Comprimento";
            this.btnCalculaComprimento.UseVisualStyleBackColor = true;
            this.btnCalculaComprimento.Click += new System.EventHandler(this.btnCalculaComprimento_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 112);
            this.Controls.Add(this.btnCalculaComprimento);
            this.Controls.Add(this.btnCalculaArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculaArea;
        private System.Windows.Forms.Button btnCalculaComprimento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

