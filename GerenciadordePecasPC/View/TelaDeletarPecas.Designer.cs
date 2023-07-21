namespace GerenciadordePecasPC.View
{
    partial class TelaDeletarPecas
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
            this.btnPesquisarCodigo = new System.Windows.Forms.Button();
            this.btndeletarPeça = new System.Windows.Forms.Button();
            this.txtBoxCapacidade = new System.Windows.Forms.TextBox();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.txtBoxPecas = new System.Windows.Forms.TextBox();
            this.txtBoxPesquisarCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPesquisarCodigo
            // 
            this.btnPesquisarCodigo.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarCodigo.BackgroundImage = global::GerenciadordePecasPC.Properties.Resources.lupa;
            this.btnPesquisarCodigo.Image = global::GerenciadordePecasPC.Properties.Resources.lupa__1_;
            this.btnPesquisarCodigo.Location = new System.Drawing.Point(203, 58);
            this.btnPesquisarCodigo.Name = "btnPesquisarCodigo";
            this.btnPesquisarCodigo.Size = new System.Drawing.Size(60, 23);
            this.btnPesquisarCodigo.TabIndex = 28;
            this.btnPesquisarCodigo.UseVisualStyleBackColor = false;
            this.btnPesquisarCodigo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndeletarPeça
            // 
            this.btndeletarPeça.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndeletarPeça.Location = new System.Drawing.Point(43, 397);
            this.btndeletarPeça.Name = "btndeletarPeça";
            this.btndeletarPeça.Size = new System.Drawing.Size(271, 32);
            this.btndeletarPeça.TabIndex = 27;
            this.btndeletarPeça.Text = "Deletar";
            this.btndeletarPeça.UseVisualStyleBackColor = true;
            this.btndeletarPeça.Click += new System.EventHandler(this.btndeletarPeça_Click);
            // 
            // txtBoxCapacidade
            // 
            this.txtBoxCapacidade.Location = new System.Drawing.Point(43, 357);
            this.txtBoxCapacidade.Name = "txtBoxCapacidade";
            this.txtBoxCapacidade.Size = new System.Drawing.Size(221, 23);
            this.txtBoxCapacidade.TabIndex = 26;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(42, 286);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(133, 23);
            this.txtBoxMarca.TabIndex = 25;
            // 
            // txtBoxPecas
            // 
            this.txtBoxPecas.Location = new System.Drawing.Point(42, 201);
            this.txtBoxPecas.Name = "txtBoxPecas";
            this.txtBoxPecas.Size = new System.Drawing.Size(221, 23);
            this.txtBoxPecas.TabIndex = 24;
            // 
            // txtBoxPesquisarCodigo
            // 
            this.txtBoxPesquisarCodigo.Location = new System.Drawing.Point(43, 58);
            this.txtBoxPesquisarCodigo.Name = "txtBoxPesquisarCodigo";
            this.txtBoxPesquisarCodigo.Size = new System.Drawing.Size(144, 23);
            this.txtBoxPesquisarCodigo.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Capacidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Peças";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Digite o Código que deseja deletar.";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(42, 121);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCodigo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Codigo";
            // 
            // TelaDeletarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.btnPesquisarCodigo);
            this.Controls.Add(this.btndeletarPeça);
            this.Controls.Add(this.txtBoxCapacidade);
            this.Controls.Add(this.txtBoxMarca);
            this.Controls.Add(this.txtBoxPecas);
            this.Controls.Add(this.txtBoxPesquisarCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TelaDeletarPecas";
            this.Text = "TelaDeletarPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPesquisarCodigo;
        private Button btndeletarPeça;
        private TextBox txtBoxCapacidade;
        private TextBox txtBoxMarca;
        private TextBox txtBoxPecas;
        private TextBox txtBoxPesquisarCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtBoxCodigo;
        private Label label1;
    }
}