namespace Impacta.Alunos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExercicios = new System.Windows.Forms.ToolStripButton();
            this.tscExercicios = new System.Windows.Forms.ToolStripDropDownButton();
            this.laboratório01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório03ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório04ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório05ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório06ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório07ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório08ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório09ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosExercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaçãoDeJogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coleçãoStackPilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coleçãoQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coleçãoHashtableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssNomeData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNomeHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDataHora = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInicio,
            this.toolStripSeparator2,
            this.tsbExercicios,
            this.tscExercicios,
            this.toolStripSeparator1,
            this.tsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(976, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbInicio
            // 
            this.tsbInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInicio.Image = global::Impacta.Alunos.Properties.Resources.home;
            this.tsbInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInicio.Name = "tsbInicio";
            this.tsbInicio.Size = new System.Drawing.Size(23, 22);
            this.tsbInicio.Text = "Página Inicial";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbExercicios
            // 
            this.tsbExercicios.Image = global::Impacta.Alunos.Properties.Resources.desenvolvimentos;
            this.tsbExercicios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExercicios.Name = "tsbExercicios";
            this.tsbExercicios.Size = new System.Drawing.Size(122, 22);
            this.tsbExercicios.Text = "Lista de Exercícios";
            // 
            // tscExercicios
            // 
            this.tscExercicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratório01ToolStripMenuItem,
            this.laboratório02ToolStripMenuItem,
            this.laboratório03ToolStripMenuItem,
            this.laboratório04ToolStripMenuItem,
            this.laboratório05ToolStripMenuItem,
            this.laboratório06ToolStripMenuItem1,
            this.laboratório07ToolStripMenuItem,
            this.laboratório08ToolStripMenuItem,
            this.laboratório09ToolStripMenuItem,
            this.laboratório10ToolStripMenuItem,
            this.outrosExercíciosToolStripMenuItem});
            this.tscExercicios.Name = "tscExercicios";
            this.tscExercicios.Size = new System.Drawing.Size(13, 22);
            // 
            // laboratório01ToolStripMenuItem
            // 
            this.laboratório01ToolStripMenuItem.Name = "laboratório01ToolStripMenuItem";
            this.laboratório01ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.laboratório01ToolStripMenuItem.Text = "Laboratório 01 - Calculadora do quadrado de um número";
            this.laboratório01ToolStripMenuItem.Click += new System.EventHandler(this.laboratório01ToolStripMenuItem_Click_1);
            // 
            // laboratório02ToolStripMenuItem
            // 
            this.laboratório02ToolStripMenuItem.Name = "laboratório02ToolStripMenuItem";
            this.laboratório02ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.laboratório02ToolStripMenuItem.Text = "Laboratório 02 - Calculadora de troco com separação de moedas";
            this.laboratório02ToolStripMenuItem.Click += new System.EventHandler(this.laboratório02ToolStripMenuItem_Click);
            // 
            // laboratório03ToolStripMenuItem
            // 
            this.laboratório03ToolStripMenuItem.Name = "laboratório03ToolStripMenuItem";
            this.laboratório03ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.laboratório03ToolStripMenuItem.Text = "Laboratório 03 - Verificar qual o maior número entre três números";
            this.laboratório03ToolStripMenuItem.Click += new System.EventHandler(this.laboratório03ToolStripMenuItem_Click);
            // 
            // laboratório04ToolStripMenuItem
            // 
            this.laboratório04ToolStripMenuItem.Name = "laboratório04ToolStripMenuItem";
            this.laboratório04ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.laboratório04ToolStripMenuItem.Text = "Laboratório 04 - Calculadora de fretes";
            this.laboratório04ToolStripMenuItem.Click += new System.EventHandler(this.laboratório04ToolStripMenuItem_Click);
            // 
            // laboratório05ToolStripMenuItem
            // 
            this.laboratório05ToolStripMenuItem.Name = "laboratório05ToolStripMenuItem";
            this.laboratório05ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.laboratório05ToolStripMenuItem.Text = "Laboratório 05 - Tabuada";
            this.laboratório05ToolStripMenuItem.Click += new System.EventHandler(this.laboratório05ToolStripMenuItem_Click);
            // 
            // laboratório06ToolStripMenuItem1
            // 
            this.laboratório06ToolStripMenuItem1.Name = "laboratório06ToolStripMenuItem1";
            this.laboratório06ToolStripMenuItem1.Size = new System.Drawing.Size(420, 22);
            this.laboratório06ToolStripMenuItem1.Text = "Laboratório 06 - Validação dos dígitos do CPF";
            this.laboratório06ToolStripMenuItem1.Click += new System.EventHandler(this.laboratório06ToolStripMenuItem1_Click);
            // 
            // laboratório07ToolStripMenuItem
            // 
            this.laboratório07ToolStripMenuItem.Name = "laboratório07ToolStripMenuItem";
            this.laboratório07ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.laboratório07ToolStripMenuItem.Text = "Laboratório 07 - Cadastro de veículos";
            this.laboratório07ToolStripMenuItem.Click += new System.EventHandler(this.laboratório07ToolStripMenuItem_Click);
            // 
            // laboratório08ToolStripMenuItem
            // 
            this.laboratório08ToolStripMenuItem.Name = "laboratório08ToolStripMenuItem";
            this.laboratório08ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.laboratório08ToolStripMenuItem.Text = "Laboratório 08 - Leitor de arquivos .CSV";
            this.laboratório08ToolStripMenuItem.Click += new System.EventHandler(this.laboratório08ToolStripMenuItem_Click);
            // 
            // laboratório09ToolStripMenuItem
            // 
            this.laboratório09ToolStripMenuItem.Name = "laboratório09ToolStripMenuItem";
            this.laboratório09ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.laboratório09ToolStripMenuItem.Text = "Laboratório 09 - Trocar nome de um arquivo";
            this.laboratório09ToolStripMenuItem.Click += new System.EventHandler(this.laboratório09ToolStripMenuItem_Click);
            // 
            // laboratório10ToolStripMenuItem
            // 
            this.laboratório10ToolStripMenuItem.Name = "laboratório10ToolStripMenuItem";
            this.laboratório10ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.laboratório10ToolStripMenuItem.Text = "Laboratório 10 - Cálculo de combustível: Rendimento e consumo";
            this.laboratório10ToolStripMenuItem.Click += new System.EventHandler(this.laboratório10ToolStripMenuItem_Click);
            // 
            // outrosExercíciosToolStripMenuItem
            // 
            this.outrosExercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalaçãoDeJogadoresToolStripMenuItem,
            this.coleçãoStackPilhaToolStripMenuItem,
            this.coleçãoQueueToolStripMenuItem,
            this.coleçãoHashtableToolStripMenuItem,
            this.cadastroDeAlunosToolStripMenuItem});
            this.outrosExercíciosToolStripMenuItem.Name = "outrosExercíciosToolStripMenuItem";
            this.outrosExercíciosToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.outrosExercíciosToolStripMenuItem.Text = "Outros exercícios";
            // 
            // escalaçãoDeJogadoresToolStripMenuItem
            // 
            this.escalaçãoDeJogadoresToolStripMenuItem.Name = "escalaçãoDeJogadoresToolStripMenuItem";
            this.escalaçãoDeJogadoresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.escalaçãoDeJogadoresToolStripMenuItem.Text = "Escalação de jogadores";
            this.escalaçãoDeJogadoresToolStripMenuItem.Click += new System.EventHandler(this.escalaçãoDeJogadoresToolStripMenuItem_Click);
            // 
            // coleçãoStackPilhaToolStripMenuItem
            // 
            this.coleçãoStackPilhaToolStripMenuItem.Name = "coleçãoStackPilhaToolStripMenuItem";
            this.coleçãoStackPilhaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.coleçãoStackPilhaToolStripMenuItem.Text = "Coleção Stack LIFO";
            this.coleçãoStackPilhaToolStripMenuItem.Click += new System.EventHandler(this.coleçãoStackPilhaToolStripMenuItem_Click);
            // 
            // coleçãoQueueToolStripMenuItem
            // 
            this.coleçãoQueueToolStripMenuItem.Name = "coleçãoQueueToolStripMenuItem";
            this.coleçãoQueueToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.coleçãoQueueToolStripMenuItem.Text = "Coleção Queue FIFO";
            this.coleçãoQueueToolStripMenuItem.Click += new System.EventHandler(this.coleçãoQueueToolStripMenuItem_Click);
            // 
            // coleçãoHashtableToolStripMenuItem
            // 
            this.coleçãoHashtableToolStripMenuItem.Name = "coleçãoHashtableToolStripMenuItem";
            this.coleçãoHashtableToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.coleçãoHashtableToolStripMenuItem.Text = "Coleção Hashtable";
            this.coleçãoHashtableToolStripMenuItem.Click += new System.EventHandler(this.coleçãoHashtableToolStripMenuItem_Click);
            // 
            // cadastroDeAlunosToolStripMenuItem
            // 
            this.cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
            this.cadastroDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cadastroDeAlunosToolStripMenuItem.Text = "Cadastro de alunos";
            this.cadastroDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = global::Impacta.Alunos.Properties.Resources.exit;
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(23, 22);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssNomeData,
            this.tssData,
            this.tssNomeHora,
            this.tssHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(976, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssNomeData
            // 
            this.tssNomeData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssNomeData.Name = "tssNomeData";
            this.tssNomeData.Size = new System.Drawing.Size(104, 17);
            this.tssNomeData.Text = "Último acesso em:";
            // 
            // tssData
            // 
            this.tssData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssData.Name = "tssData";
            this.tssData.Size = new System.Drawing.Size(48, 17);
            this.tssData.Text = "<data>";
            // 
            // tssNomeHora
            // 
            this.tssNomeHora.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssNomeHora.Name = "tssNomeHora";
            this.tssNomeHora.Size = new System.Drawing.Size(22, 17);
            this.tssNomeHora.Text = "às:";
            // 
            // tssHora
            // 
            this.tssHora.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssHora.Name = "tssHora";
            this.tssHora.Size = new System.Drawing.Size(49, 17);
            this.tssHora.Text = "<hora>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Impacta.Alunos.Properties.Resources.Impacta;
            this.pictureBox1.Location = new System.Drawing.Point(223, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // lblDataHora
            // 
            this.lblDataHora.Location = new System.Drawing.Point(281, 340);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(431, 66);
            this.lblDataHora.TabIndex = 4;
            this.lblDataHora.Text = "label1";
            this.lblDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 546);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impacta Alunos - Página Inicial";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbInicio;
        private System.Windows.Forms.ToolStripButton tsbExercicios;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssNomeData;
        private System.Windows.Forms.ToolStripStatusLabel tssData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.ToolStripStatusLabel tssNomeHora;
        private System.Windows.Forms.ToolStripStatusLabel tssHora;
        private System.Windows.Forms.ToolStripDropDownButton tscExercicios;
        private System.Windows.Forms.ToolStripMenuItem laboratório01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório03ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório04ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório05ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório06ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outrosExercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório07ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório08ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório09ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaçãoDeJogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coleçãoStackPilhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coleçãoQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coleçãoHashtableToolStripMenuItem;
    }
}