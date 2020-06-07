namespace Impacta.Alunos
{
    partial class frmLaboratorio01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratorio01));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInicio,
            this.toolStripSeparator2,
            this.tsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
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
            this.tsbInicio.Click += new System.EventHandler(this.tsbInicio_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um número";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(149, 231);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(372, 96);
            this.resultadoLabel.TabIndex = 2;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valorTextBox.Location = new System.Drawing.Point(152, 182);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(270, 20);
            this.valorTextBox.TabIndex = 0;
            this.valorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcularButton
            // 
            this.calcularButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calcularButton.Location = new System.Drawing.Point(446, 180);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularButton.TabIndex = 1;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Calculadora do quadrado de um número";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLaboratorio01
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLaboratorio01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impacta Alunos - Laboratório 01 - Calculadora do quadrado de um número";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label2;
    }
}