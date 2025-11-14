namespace WriteRead
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_ler = new System.Windows.Forms.Button();
            this.btnLerBin = new System.Windows.Forms.Button();
            this.btn_escrevBina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(770, 342);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Excrever Txt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_ler
            // 
            this.bt_ler.Location = new System.Drawing.Point(159, 397);
            this.bt_ler.Name = "bt_ler";
            this.bt_ler.Size = new System.Drawing.Size(174, 41);
            this.bt_ler.TabIndex = 2;
            this.bt_ler.Text = "Ler Txt";
            this.bt_ler.UseVisualStyleBackColor = true;
            this.bt_ler.Click += new System.EventHandler(this.bt_ler_Click);
            // 
            // btnLerBin
            // 
            this.btnLerBin.Location = new System.Drawing.Point(339, 397);
            this.btnLerBin.Name = "btnLerBin";
            this.btnLerBin.Size = new System.Drawing.Size(182, 41);
            this.btnLerBin.TabIndex = 3;
            this.btnLerBin.Text = "Ler Binario";
            this.btnLerBin.UseVisualStyleBackColor = true;
            this.btnLerBin.Click += new System.EventHandler(this.btnLerBin_Click);
            // 
            // btn_escrevBina
            // 
            this.btn_escrevBina.Location = new System.Drawing.Point(527, 397);
            this.btn_escrevBina.Name = "btn_escrevBina";
            this.btn_escrevBina.Size = new System.Drawing.Size(182, 41);
            this.btn_escrevBina.TabIndex = 4;
            this.btn_escrevBina.Text = "Escrever Binario";
            this.btn_escrevBina.UseVisualStyleBackColor = true;
            this.btn_escrevBina.Click += new System.EventHandler(this.btn_escrevBina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_escrevBina);
            this.Controls.Add(this.btnLerBin);
            this.Controls.Add(this.bt_ler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_ler;
        private System.Windows.Forms.Button btnLerBin;
        private System.Windows.Forms.Button btn_escrevBina;
    }
}

