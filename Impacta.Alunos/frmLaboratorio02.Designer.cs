namespace Impacta.Alunos
{
    partial class frmLaboratorio02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratorio02));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.calcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trocoLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.moedas1Label = new System.Windows.Forms.Label();
            this.moedas050Label = new System.Windows.Forms.Label();
            this.moedas025Label = new System.Windows.Forms.Label();
            this.moedas010Label = new System.Windows.Forms.Label();
            this.moedas005Label = new System.Windows.Forms.Label();
            this.moedas001Label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.valorCompraTextBox = new System.Windows.Forms.TextBox();
            this.valorPagoTextBox = new System.Windows.Forms.TextBox();
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
            this.toolStrip1.Size = new System.Drawing.Size(965, 25);
            this.toolStrip1.TabIndex = 2;
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
            this.calcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularButton.Location = new System.Drawing.Point(222, 326);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(244, 52);
            this.calcularButton.TabIndex = 2;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(965, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculadora de troco com separação de moedas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor da compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor pago em dinheiro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor do troco:";
            // 
            // trocoLabel
            // 
            this.trocoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trocoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trocoLabel.Location = new System.Drawing.Point(366, 282);
            this.trocoLabel.Name = "trocoLabel";
            this.trocoLabel.Size = new System.Drawing.Size(100, 23);
            this.trocoLabel.TabIndex = 3;
            this.trocoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Moedas para o troco";
            // 
            // moedas1Label
            // 
            this.moedas1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moedas1Label.Location = new System.Drawing.Point(522, 206);
            this.moedas1Label.Name = "moedas1Label";
            this.moedas1Label.Size = new System.Drawing.Size(56, 23);
            this.moedas1Label.TabIndex = 4;
            // 
            // moedas050Label
            // 
            this.moedas050Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moedas050Label.Location = new System.Drawing.Point(522, 235);
            this.moedas050Label.Name = "moedas050Label";
            this.moedas050Label.Size = new System.Drawing.Size(56, 23);
            this.moedas050Label.TabIndex = 5;
            // 
            // moedas025Label
            // 
            this.moedas025Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moedas025Label.Location = new System.Drawing.Point(522, 265);
            this.moedas025Label.Name = "moedas025Label";
            this.moedas025Label.Size = new System.Drawing.Size(56, 23);
            this.moedas025Label.TabIndex = 6;
            // 
            // moedas010Label
            // 
            this.moedas010Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moedas010Label.Location = new System.Drawing.Point(522, 295);
            this.moedas010Label.Name = "moedas010Label";
            this.moedas010Label.Size = new System.Drawing.Size(56, 23);
            this.moedas010Label.TabIndex = 7;
            // 
            // moedas005Label
            // 
            this.moedas005Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moedas005Label.Location = new System.Drawing.Point(522, 326);
            this.moedas005Label.Name = "moedas005Label";
            this.moedas005Label.Size = new System.Drawing.Size(56, 23);
            this.moedas005Label.TabIndex = 8;
            // 
            // moedas001Label
            // 
            this.moedas001Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moedas001Label.Location = new System.Drawing.Point(522, 355);
            this.moedas001Label.Name = "moedas001Label";
            this.moedas001Label.Size = new System.Drawing.Size(56, 23);
            this.moedas001Label.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(598, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Moedas de R$ 1,00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(598, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Moedas de R$ 0,50";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(598, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Moedas de R$ 0,25";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(598, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Moedas de R$ 0,10";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(598, 327);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Moedas de R$ 0,05";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(598, 356);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Moedas de R$ 0,01";
            // 
            // valorCompraTextBox
            // 
            this.valorCompraTextBox.Location = new System.Drawing.Point(366, 206);
            this.valorCompraTextBox.Name = "valorCompraTextBox";
            this.valorCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorCompraTextBox.TabIndex = 0;
            this.valorCompraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valorPagoTextBox
            // 
            this.valorPagoTextBox.Location = new System.Drawing.Point(366, 244);
            this.valorPagoTextBox.Name = "valorPagoTextBox";
            this.valorPagoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorPagoTextBox.TabIndex = 1;
            this.valorPagoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmLaboratorio02
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 520);
            this.Controls.Add(this.valorPagoTextBox);
            this.Controls.Add(this.valorCompraTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.moedas001Label);
            this.Controls.Add(this.moedas005Label);
            this.Controls.Add(this.moedas010Label);
            this.Controls.Add(this.moedas025Label);
            this.Controls.Add(this.moedas050Label);
            this.Controls.Add(this.moedas1Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trocoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLaboratorio02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impacta Alunos - Laboratório 02 - Calculadora de troco";
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
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label trocoLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label moedas1Label;
        private System.Windows.Forms.Label moedas050Label;
        private System.Windows.Forms.Label moedas025Label;
        private System.Windows.Forms.Label moedas010Label;
        private System.Windows.Forms.Label moedas005Label;
        private System.Windows.Forms.Label moedas001Label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox valorCompraTextBox;
        private System.Windows.Forms.TextBox valorPagoTextBox;
    }
}