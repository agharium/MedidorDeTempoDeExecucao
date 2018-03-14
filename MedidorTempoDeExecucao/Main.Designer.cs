namespace MedidorTempoDeExecucao
{
    partial class Main
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnOneHundredTimes = new System.Windows.Forms.Button();
            this.btnOneThousandTimes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(263, 11);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(28, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 13);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(245, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnOneHundredTimes
            // 
            this.btnOneHundredTimes.Location = new System.Drawing.Point(297, 11);
            this.btnOneHundredTimes.Name = "btnOneHundredTimes";
            this.btnOneHundredTimes.Size = new System.Drawing.Size(54, 23);
            this.btnOneHundredTimes.TabIndex = 2;
            this.btnOneHundredTimes.Text = "100x";
            this.btnOneHundredTimes.UseVisualStyleBackColor = true;
            this.btnOneHundredTimes.Click += new System.EventHandler(this.btnOneHundredTimes_Click);
            // 
            // btnOneThousandTimes
            // 
            this.btnOneThousandTimes.Location = new System.Drawing.Point(357, 11);
            this.btnOneThousandTimes.Name = "btnOneThousandTimes";
            this.btnOneThousandTimes.Size = new System.Drawing.Size(54, 23);
            this.btnOneThousandTimes.TabIndex = 3;
            this.btnOneThousandTimes.Text = "1000x";
            this.btnOneThousandTimes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 45);
            this.Controls.Add(this.btnOneThousandTimes);
            this.Controls.Add(this.btnOneHundredTimes);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Form1";
            this.Text = "Medidor de Tempo de Execução";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnOneHundredTimes;
        private System.Windows.Forms.Button btnOneThousandTimes;
    }
}

