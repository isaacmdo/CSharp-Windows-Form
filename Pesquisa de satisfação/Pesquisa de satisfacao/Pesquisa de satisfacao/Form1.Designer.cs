namespace Pesquisa_de_satisfacao
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
            this.btnsim = new System.Windows.Forms.Button();
            this.btnnao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contsim = new System.Windows.Forms.Label();
            this.contnao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsim
            // 
            this.btnsim.BackColor = System.Drawing.Color.PaleGreen;
            this.btnsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsim.Location = new System.Drawing.Point(174, 136);
            this.btnsim.Name = "btnsim";
            this.btnsim.Size = new System.Drawing.Size(158, 81);
            this.btnsim.TabIndex = 0;
            this.btnsim.Text = "Sim";
            this.btnsim.UseVisualStyleBackColor = false;
            this.btnsim.Click += new System.EventHandler(this.btnsim_Click);
            // 
            // btnnao
            // 
            this.btnnao.BackColor = System.Drawing.Color.Tomato;
            this.btnnao.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnao.Location = new System.Drawing.Point(456, 136);
            this.btnnao.Name = "btnnao";
            this.btnnao.Size = new System.Drawing.Size(158, 81);
            this.btnnao.TabIndex = 1;
            this.btnnao.Text = "Não";
            this.btnnao.UseVisualStyleBackColor = false;
            this.btnnao.Click += new System.EventHandler(this.btnnao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 69);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(747, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Você ficou satisfeito com o atendimento da nossa loja?";
            // 
            // contsim
            // 
            this.contsim.AutoSize = true;
            this.contsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contsim.Location = new System.Drawing.Point(243, 256);
            this.contsim.Name = "contsim";
            this.contsim.Size = new System.Drawing.Size(20, 24);
            this.contsim.TabIndex = 5;
            this.contsim.Text = "0";
            // 
            // contnao
            // 
            this.contnao.AutoSize = true;
            this.contnao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contnao.Location = new System.Drawing.Point(527, 256);
            this.contnao.Name = "contnao";
            this.contnao.Size = new System.Drawing.Size(20, 24);
            this.contnao.TabIndex = 6;
            this.contnao.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.contnao);
            this.Controls.Add(this.contsim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnao);
            this.Controls.Add(this.btnsim);
            this.Name = "Form1";
            this.Text = "Pesquisa de safisfação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsim;
        private System.Windows.Forms.Button btnnao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label contsim;
        private System.Windows.Forms.Label contnao;
    }
}

