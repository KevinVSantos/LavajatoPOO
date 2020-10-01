namespace LavaRapido
{
    partial class ViewNota
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_funcionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b_salvar = new System.Windows.Forms.Button();
            this.b_excluir = new System.Windows.Forms.Button();
            this.list_Notas = new System.Windows.Forms.ListBox();
            this.tb_preco = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(118, 12);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(58, 20);
            this.tb_id.TabIndex = 1;
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(118, 38);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(156, 20);
            this.tb_cliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF do Cliente";
            // 
            // tb_funcionario
            // 
            this.tb_funcionario.Location = new System.Drawing.Point(118, 64);
            this.tb_funcionario.Name = "tb_funcionario";
            this.tb_funcionario.Size = new System.Drawing.Size(156, 20);
            this.tb_funcionario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF do Funcionario";
            // 
            // tb_carro
            // 
            this.tb_carro.Location = new System.Drawing.Point(118, 90);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(156, 20);
            this.tb_carro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Placa do carro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Preço";
            // 
            // b_salvar
            // 
            this.b_salvar.Location = new System.Drawing.Point(477, 161);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(75, 23);
            this.b_salvar.TabIndex = 10;
            this.b_salvar.Text = "Salvar";
            this.b_salvar.UseVisualStyleBackColor = true;
            this.b_salvar.Click += new System.EventHandler(this.b_salvar_Click);
            // 
            // b_excluir
            // 
            this.b_excluir.Location = new System.Drawing.Point(396, 161);
            this.b_excluir.Name = "b_excluir";
            this.b_excluir.Size = new System.Drawing.Size(75, 23);
            this.b_excluir.TabIndex = 11;
            this.b_excluir.Text = "Excluir";
            this.b_excluir.UseVisualStyleBackColor = true;
            this.b_excluir.Click += new System.EventHandler(this.b_excluir_Click);
            // 
            // list_Notas
            // 
            this.list_Notas.FormattingEnabled = true;
            this.list_Notas.Location = new System.Drawing.Point(329, 12);
            this.list_Notas.Name = "list_Notas";
            this.list_Notas.Size = new System.Drawing.Size(223, 134);
            this.list_Notas.TabIndex = 12;
            this.list_Notas.SelectedIndexChanged += new System.EventHandler(this.list_Notas_SelectedIndexChanged);
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(118, 116);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(156, 20);
            this.tb_preco.TabIndex = 13;
            this.tb_preco.ValidatingType = typeof(int);
            this.tb_preco.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_preco_MaskInputRejected);
            // 
            // ViewNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 196);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.list_Notas);
            this.Controls.Add(this.b_excluir);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_funcionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Name = "ViewNota";
            this.Text = "Nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_funcionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_carro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_salvar;
        private System.Windows.Forms.Button b_excluir;
        private System.Windows.Forms.ListBox list_Notas;
        private System.Windows.Forms.MaskedTextBox tb_preco;
    }
}