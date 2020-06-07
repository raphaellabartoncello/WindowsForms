namespace Impacta.Alunos
{
    partial class frmLaboratorio04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratorio04));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.freteLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calculadora de fretes";
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 7;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "&Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "&Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "&UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "% &Frete:";
            // 
            // freteLabel
            // 
            this.freteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.freteLabel.Location = new System.Drawing.Point(207, 277);
            this.freteLabel.Name = "freteLabel";
            this.freteLabel.Size = new System.Drawing.Size(121, 23);
            this.freteLabel.TabIndex = 13;
            this.freteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(374, 160);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(330, 185);
            this.totalLabel.TabIndex = 14;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(207, 160);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(121, 20);
            this.clienteTextBox.TabIndex = 15;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(207, 198);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorTextBox.TabIndex = 16;
            // 
            // ufComboBox
            // 
            this.ufComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ufComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ufComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "AM",
            "MG",
            "RJ",
            "SP",
            "Outros"});
            this.ufComboBox.Location = new System.Drawing.Point(207, 235);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(121, 21);
            this.ufComboBox.TabIndex = 17;
            this.ufComboBox.SelectedIndexChanged += new System.EventHandler(this.ufComboBox_SelectedIndexChanged);
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(128, 312);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(200, 33);
            this.calcularButton.TabIndex = 18;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // frmLaboratorio04
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.freteLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmLaboratorio04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impacta Alunos - Laboratório 04 - Calculadora de fretes";
            this.Load += new System.EventHandler(this.frmLaboratorio04_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLaboratorio04_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbInicio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label freteLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.Button calcularButton;
    }
}