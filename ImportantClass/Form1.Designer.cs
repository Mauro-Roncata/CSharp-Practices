namespace ImportantClass
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
            this.btncMsgBox = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTimeSpan = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnEnviroment = new System.Windows.Forms.Button();
            this.btnApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncMsgBox
            // 
            this.btncMsgBox.Location = new System.Drawing.Point(16, 439);
            this.btncMsgBox.Margin = new System.Windows.Forms.Padding(4);
            this.btncMsgBox.Name = "btncMsgBox";
            this.btncMsgBox.Size = new System.Drawing.Size(263, 100);
            this.btncMsgBox.TabIndex = 0;
            this.btncMsgBox.Text = "MessageBox";
            this.btncMsgBox.UseVisualStyleBackColor = true;
            this.btncMsgBox.Click += new System.EventHandler(this.btncMsgBox_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(16, 22);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(799, 139);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(287, 439);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(263, 100);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTimeSpan
            // 
            this.btnTimeSpan.Location = new System.Drawing.Point(16, 331);
            this.btnTimeSpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimeSpan.Name = "btnTimeSpan";
            this.btnTimeSpan.Size = new System.Drawing.Size(263, 100);
            this.btnTimeSpan.TabIndex = 3;
            this.btnTimeSpan.Text = "TimeSpan";
            this.btnTimeSpan.UseVisualStyleBackColor = true;
            this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(287, 331);
            this.btnDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(263, 100);
            this.btnDateTime.TabIndex = 4;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(13, 223);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(263, 100);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(558, 439);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(263, 100);
            this.btnFont.TabIndex = 6;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnEnviroment
            // 
            this.btnEnviroment.Location = new System.Drawing.Point(287, 223);
            this.btnEnviroment.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviroment.Name = "btnEnviroment";
            this.btnEnviroment.Size = new System.Drawing.Size(263, 100);
            this.btnEnviroment.TabIndex = 7;
            this.btnEnviroment.Text = "Enviroment";
            this.btnEnviroment.UseVisualStyleBackColor = true;
            this.btnEnviroment.Click += new System.EventHandler(this.btnEnviroment_Click);
            // 
            // btnApp
            // 
            this.btnApp.Location = new System.Drawing.Point(558, 331);
            this.btnApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnApp.Name = "btnApp";
            this.btnApp.Size = new System.Drawing.Size(263, 100);
            this.btnApp.TabIndex = 8;
            this.btnApp.Text = "Application";
            this.btnApp.UseVisualStyleBackColor = true;
            this.btnApp.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 550);
            this.Controls.Add(this.btnApp);
            this.Controls.Add(this.btnEnviroment);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnTimeSpan);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btncMsgBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncMsgBox;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTimeSpan;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnEnviroment;
        private System.Windows.Forms.Button btnApp;
    }
}

