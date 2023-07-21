namespace GerenciadordePecasPC.View
{
    partial class TelaCadastrarPecas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrarPecas = new System.Windows.Forms.Button();
            this.txtBoxPecas = new System.Windows.Forms.TextBox();
            this.txtboxMarca = new System.Windows.Forms.TextBox();
            this.txtBoxCapacidades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Peças";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(66, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peças";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(66, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marcas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(66, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidades";
            // 
            // btnCadastrarPecas
            // 
            this.btnCadastrarPecas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarPecas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrarPecas.Location = new System.Drawing.Point(66, 256);
            this.btnCadastrarPecas.Name = "btnCadastrarPecas";
            this.btnCadastrarPecas.Size = new System.Drawing.Size(192, 36);
            this.btnCadastrarPecas.TabIndex = 7;
            this.btnCadastrarPecas.Text = "Cadastrar";
            this.btnCadastrarPecas.UseVisualStyleBackColor = true;
            this.btnCadastrarPecas.Click += new System.EventHandler(this.btnCadastrarPecas_Click);
            // 
            // txtBoxPecas
            // 
            this.txtBoxPecas.Location = new System.Drawing.Point(66, 99);
            this.txtBoxPecas.Name = "txtBoxPecas";
            this.txtBoxPecas.Size = new System.Drawing.Size(192, 23);
            this.txtBoxPecas.TabIndex = 8;
            // 
            // txtboxMarca
            // 
            this.txtboxMarca.Location = new System.Drawing.Point(66, 162);
            this.txtboxMarca.Name = "txtboxMarca";
            this.txtboxMarca.Size = new System.Drawing.Size(100, 23);
            this.txtboxMarca.TabIndex = 9;
            // 
            // txtBoxCapacidades
            // 
            this.txtBoxCapacidades.Location = new System.Drawing.Point(66, 215);
            this.txtBoxCapacidades.Name = "txtBoxCapacidades";
            this.txtBoxCapacidades.Size = new System.Drawing.Size(192, 23);
            this.txtBoxCapacidades.TabIndex = 11;
            // 
            // TelaCadastrarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.txtBoxCapacidades);
            this.Controls.Add(this.txtboxMarca);
            this.Controls.Add(this.txtBoxPecas);
            this.Controls.Add(this.btnCadastrarPecas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastrarPecas";
            this.Text = "TelaCadastrarPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCadastrarPecas;
        private TextBox txtBoxPecas;
        private TextBox txtboxMarca;
        private TextBox txtBoxCapacidades;
    }
}