namespace Colecoes
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
            this.lista = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnDict = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.btnSortedDict = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 31;
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(548, 407);
            this.lista.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(588, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(153, 74);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.Location = new System.Drawing.Point(588, 92);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(153, 74);
            this.btnHashSet.TabIndex = 2;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // btnDict
            // 
            this.btnDict.Location = new System.Drawing.Point(588, 172);
            this.btnDict.Name = "btnDict";
            this.btnDict.Size = new System.Drawing.Size(153, 74);
            this.btnDict.TabIndex = 3;
            this.btnDict.Text = "Dictionary";
            this.btnDict.UseVisualStyleBackColor = true;
            this.btnDict.Click += new System.EventHandler(this.btnDict_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.Location = new System.Drawing.Point(588, 252);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(153, 74);
            this.btnSortedList.TabIndex = 4;
            this.btnSortedList.Text = "SortedList";
            this.btnSortedList.UseVisualStyleBackColor = true;
            this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
            // 
            // btnSortedDict
            // 
            this.btnSortedDict.Location = new System.Drawing.Point(588, 332);
            this.btnSortedDict.Name = "btnSortedDict";
            this.btnSortedDict.Size = new System.Drawing.Size(153, 74);
            this.btnSortedDict.TabIndex = 5;
            this.btnSortedDict.Text = "SortedDictionary";
            this.btnSortedDict.UseVisualStyleBackColor = true;
            this.btnSortedDict.Click += new System.EventHandler(this.btnSortedDict_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortedDict);
            this.Controls.Add(this.btnSortedList);
            this.Controls.Add(this.btnDict);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas Genericas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnDict;
        private System.Windows.Forms.Button btnSortedList;
        private System.Windows.Forms.Button btnSortedDict;
    }
}

