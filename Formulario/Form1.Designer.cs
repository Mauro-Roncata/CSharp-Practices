namespace Formulario
{
    partial class FormMain
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnSECFORM = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mFileSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mSobreDev = new System.Windows.Forms.ToolStripMenuItem();
            this.mSobreVer = new System.Windows.Forms.ToolStripMenuItem();
            this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.mPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 105);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(776, 159);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSec.Location = new System.Drawing.Point(12, 373);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(286, 65);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Second Form";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnSECFORM
            // 
            this.btnSECFORM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSECFORM.Location = new System.Drawing.Point(304, 373);
            this.btnSECFORM.Name = "btnSECFORM";
            this.btnSECFORM.Size = new System.Drawing.Size(365, 65);
            this.btnSECFORM.TabIndex = 2;
            this.btnSECFORM.Text = "Second Form Thread";
            this.btnSECFORM.UseVisualStyleBackColor = true;
            this.btnSECFORM.Click += new System.EventHandler(this.btnSECFORM_Click);
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuHelp,
            this.comboMenu,
            this.mPesquisar});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 32);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNovo,
            this.mFileAbrir,
            this.toolStripSeparator1,
            this.mFileSair});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(46, 28);
            this.MenuFile.Text = "File";
            // 
            // mFileNovo
            // 
            this.mFileNovo.Name = "mFileNovo";
            this.mFileNovo.Size = new System.Drawing.Size(224, 26);
            this.mFileNovo.Text = "Novo";
            this.mFileNovo.Click += new System.EventHandler(this.mFileNovo_Click);
            // 
            // mFileAbrir
            // 
            this.mFileAbrir.Name = "mFileAbrir";
            this.mFileAbrir.Size = new System.Drawing.Size(224, 26);
            this.mFileAbrir.Text = "Abrir";
            this.mFileAbrir.Click += new System.EventHandler(this.mFileAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mFileSair
            // 
            this.mFileSair.Name = "mFileSair";
            this.mFileSair.Size = new System.Drawing.Size(224, 26);
            this.mFileSair.Text = "Sair";
            this.mFileSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobre});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(55, 28);
            this.MenuHelp.Text = "Help";
            // 
            // mHelpSobre
            // 
            this.mHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSobreDev,
            this.mSobreVer});
            this.mHelpSobre.Name = "mHelpSobre";
            this.mHelpSobre.Size = new System.Drawing.Size(224, 26);
            this.mHelpSobre.Text = "Sobre";
            // 
            // mSobreDev
            // 
            this.mSobreDev.Name = "mSobreDev";
            this.mSobreDev.Size = new System.Drawing.Size(224, 26);
            this.mSobreDev.Text = "Desenvolvedor";
            this.mSobreDev.Click += new System.EventHandler(this.mSobreDev_Click);
            // 
            // mSobreVer
            // 
            this.mSobreVer.Name = "mSobreVer";
            this.mSobreVer.Size = new System.Drawing.Size(224, 26);
            this.mSobreVer.Text = "Versão";
            this.mSobreVer.Click += new System.EventHandler(this.mSobreVer_Click);
            // 
            // comboMenu
            // 
            this.comboMenu.Items.AddRange(new object[] {
            "Inglês",
            "Português",
            "Espanhol"});
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(121, 28);
            this.comboMenu.SelectedIndexChanged += new System.EventHandler(this.comboMenu_SelectedIndexChanged);
            // 
            // mPesquisar
            // 
            this.mPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mPesquisar.Name = "mPesquisar";
            this.mPesquisar.Size = new System.Drawing.Size(200, 28);
            this.mPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mPesquisar_KeyUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSECFORM);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnSECFORM;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNovo;
        private System.Windows.Forms.ToolStripMenuItem mFileAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mFileSair;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobre;
        private System.Windows.Forms.ToolStripMenuItem mSobreDev;
        private System.Windows.Forms.ToolStripMenuItem mSobreVer;
        private System.Windows.Forms.ToolStripComboBox comboMenu;
        private System.Windows.Forms.ToolStripTextBox mPesquisar;
    }
}

