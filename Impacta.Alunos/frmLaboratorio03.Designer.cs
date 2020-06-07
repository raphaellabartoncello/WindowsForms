namespace Impacta.Alunos
{
    partial class frmLaboratorio03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratorio03));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.calcularButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.valor1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor3NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valor1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor3NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Verificar qual o maior número entre três números";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.toolStrip1.Size = new System.Drawing.Size(946, 25);
            this.toolStrip1.TabIndex = 5;
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
            // calcularButton
            // 
            this.calcularButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcularButton.Location = new System.Drawing.Point(373, 224);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(200, 23);
            this.calcularButton.TabIndex = 7;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor 3:";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(373, 262);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(200, 88);
            this.resultadoLabel.TabIndex = 11;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valor1NumericUpDown
            // 
            this.valor1NumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valor1NumericUpDown.Location = new System.Drawing.Point(453, 138);
            this.valor1NumericUpDown.Name = "valor1NumericUpDown";
            this.valor1NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valor1NumericUpDown.TabIndex = 12;
            this.valor1NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valor2NumericUpDown
            // 
            this.valor2NumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valor2NumericUpDown.Location = new System.Drawing.Point(453, 164);
            this.valor2NumericUpDown.Name = "valor2NumericUpDown";
            this.valor2NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valor2NumericUpDown.TabIndex = 13;
            this.valor2NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valor3NumericUpDown
            // 
            this.valor3NumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valor3NumericUpDown.Location = new System.Drawing.Point(453, 190);
            this.valor3NumericUpDown.Name = "valor3NumericUpDown";
            this.valor3NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valor3NumericUpDown.TabIndex = 14;
            this.valor3NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLaboratorio03
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 521);
            this.Controls.Add(this.valor3NumericUpDown);
            this.Controls.Add(this.valor2NumericUpDown);
            this.Controls.Add(this.valor1NumericUpDown);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLaboratorio03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impacta Alunos - Laboratório 03 - Verificar qual o maior número";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valor1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor3NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.NumericUpDown valor1NumericUpDown;
        private System.Windows.Forms.NumericUpDown valor2NumericUpDown;
        private System.Windows.Forms.NumericUpDown valor3NumericUpDown;
    }
}