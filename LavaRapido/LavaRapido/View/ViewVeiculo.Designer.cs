namespace LavaRapido
{
    partial class ViewVeiculo
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_placa = new System.Windows.Forms.TextBox();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.b_excluir = new System.Windows.Forms.Button();
            this.b_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(123, 15);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(255, 20);
            this.tb_nome.TabIndex = 0;
            // 
            // tb_placa
            // 
            this.tb_placa.Location = new System.Drawing.Point(123, 41);
            this.tb_placa.Name = "tb_placa";
            this.tb_placa.Size = new System.Drawing.Size(255, 20);
            this.tb_placa.TabIndex = 1;
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(123, 67);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(255, 20);
            this.tb_modelo.TabIndex = 2;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(123, 93);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(100, 20);
            this.tb_ano.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do proprietário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ano";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(448, 18);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(66, 20);
            this.tb_id.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID";
            // 
            // b_excluir
            // 
            this.b_excluir.Location = new System.Drawing.Point(358, 128);
            this.b_excluir.Name = "b_excluir";
            this.b_excluir.Size = new System.Drawing.Size(75, 23);
            this.b_excluir.TabIndex = 27;
            this.b_excluir.Text = "Excluir";
            this.b_excluir.UseVisualStyleBackColor = true;
            // 
            // b_salvar
            // 
            this.b_salvar.Location = new System.Drawing.Point(448, 128);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(75, 23);
            this.b_salvar.TabIndex = 26;
            this.b_salvar.Text = "Salvar";
            this.b_salvar.UseVisualStyleBackColor = true;
            // 
            // ViewVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 163);
            this.Controls.Add(this.b_excluir);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.tb_placa);
            this.Controls.Add(this.tb_nome);
            this.Name = "ViewVeiculo";
            this.Text = "Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_placa;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_excluir;
        private System.Windows.Forms.Button b_salvar;
    }
}