namespace Projeto1
{
    partial class Projeto1
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
            this.btSair = new System.Windows.Forms.Button();
            this.btExecutar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lboxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(414, 398);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(98, 35);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // btExecutar
            // 
            this.btExecutar.Location = new System.Drawing.Point(414, 357);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(98, 35);
            this.btExecutar.TabIndex = 1;
            this.btExecutar.Text = "Executar";
            this.btExecutar.UseVisualStyleBackColor = true;
            this.btExecutar.Click += new System.EventHandler(this.BtExecutar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.Location = new System.Drawing.Point(12, 9);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(500, 55);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "Resultado:";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lboxResultado
            // 
            this.lboxResultado.FormattingEnabled = true;
            this.lboxResultado.Location = new System.Drawing.Point(15, 78);
            this.lboxResultado.Name = "lboxResultado";
            this.lboxResultado.Size = new System.Drawing.Size(393, 355);
            this.lboxResultado.TabIndex = 3;
            // 
            // Projeto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 440);
            this.Controls.Add(this.lboxResultado);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btExecutar);
            this.Controls.Add(this.btSair);
            this.Name = "Projeto1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btExecutar;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.ListBox lboxResultado;
    }
}

