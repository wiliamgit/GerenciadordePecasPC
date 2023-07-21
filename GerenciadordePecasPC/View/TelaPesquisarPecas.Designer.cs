namespace GerenciadordePecasPC.View
{
    partial class TelaPesquisarPecas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBoxCapacidade = new System.Windows.Forms.TextBox();
            this.txtMerca = new System.Windows.Forms.TextBox();
            this.txtBoxPecas = new System.Windows.Forms.TextBox();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peça = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 369);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPesquisar);
            this.tabPage1.Controls.Add(this.txtBoxCapacidade);
            this.tabPage1.Controls.Add(this.txtMerca);
            this.tabPage1.Controls.Add(this.txtBoxPecas);
            this.tabPage1.Controls.Add(this.txtBoxCodigo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Codigo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::GerenciadordePecasPC.Properties.Resources.lupa__1_;
            this.btnPesquisar.Location = new System.Drawing.Point(295, 43);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(63, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBoxCapacidade
            // 
            this.txtBoxCapacidade.Location = new System.Drawing.Point(18, 255);
            this.txtBoxCapacidade.Name = "txtBoxCapacidade";
            this.txtBoxCapacidade.Size = new System.Drawing.Size(221, 23);
            this.txtBoxCapacidade.TabIndex = 7;
            // 
            // txtMerca
            // 
            this.txtMerca.Location = new System.Drawing.Point(18, 182);
            this.txtMerca.Name = "txtMerca";
            this.txtMerca.Size = new System.Drawing.Size(133, 23);
            this.txtMerca.TabIndex = 6;
            // 
            // txtBoxPecas
            // 
            this.txtBoxPecas.Location = new System.Drawing.Point(18, 103);
            this.txtBoxPecas.Name = "txtBoxPecas";
            this.txtBoxPecas.Size = new System.Drawing.Size(221, 23);
            this.txtBoxPecas.TabIndex = 5;
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(145, 43);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(144, 23);
            this.txtBoxCodigo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Capacidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Peças";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Peças";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Digite Peça:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(112, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(339, 23);
            this.textBox5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Peça,
            this.Marca,
            this.Capacidade});
            this.dataGridView1.Location = new System.Drawing.Point(17, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(434, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Peça
            // 
            this.Peça.HeaderText = "Peça";
            this.Peça.Name = "Peça";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Capacidade
            // 
            this.Capacidade.HeaderText = "Capacidade";
            this.Capacidade.Name = "Capacidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Peças .......";
            // 
            // TelaPesquisarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaPesquisarPecas";
            this.Text = "TelaPesquisarPecas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtBoxCapacidade;
        private TextBox txtMerca;
        private TextBox txtBoxPecas;
        private TextBox txtBoxCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label6;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Peça;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Capacidade;
        private Button btnPesquisar;
    }
}