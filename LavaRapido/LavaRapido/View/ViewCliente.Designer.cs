namespace LavaRapido
{
    partial class ViewCliente
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_end = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.b_excluir = new System.Windows.Forms.Button();
            this.b_salvar = new System.Windows.Forms.Button();
            this.lb_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(138, 24);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(307, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(138, 50);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(307, 20);
            this.tb_cpf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // tb_end
            // 
            this.tb_end.Location = new System.Drawing.Point(138, 76);
            this.tb_end.Name = "tb_end";
            this.tb_end.Size = new System.Drawing.Size(307, 20);
            this.tb_end.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço";
            // 
            // tb_idade
            // 
            this.tb_idade.Location = new System.Drawing.Point(138, 102);
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(100, 20);
            this.tb_idade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade";
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(138, 128);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(100, 20);
            this.tb_tel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(515, 27);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(66, 20);
            this.tb_id.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID";
            // 
            // b_excluir
            // 
            this.b_excluir.Location = new System.Drawing.Point(434, 154);
            this.b_excluir.Name = "b_excluir";
            this.b_excluir.Size = new System.Drawing.Size(75, 23);
            this.b_excluir.TabIndex = 27;
            this.b_excluir.Text = "Excluir";
            this.b_excluir.UseVisualStyleBackColor = true;
            this.b_excluir.Click += new System.EventHandler(this.b_excluir_Click);
            // 
            // b_salvar
            // 
            this.b_salvar.Location = new System.Drawing.Point(515, 154);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(75, 23);
            this.b_salvar.TabIndex = 26;
            this.b_salvar.Text = "Salvar";
            this.b_salvar.UseVisualStyleBackColor = true;
            this.b_salvar.Click += new System.EventHandler(this.b_salvar_Click);
            // 
            // lb_list
            // 
            this.lb_list.FormattingEnabled = true;
            this.lb_list.Location = new System.Drawing.Point(670, 27);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(236, 147);
            this.lb_list.TabIndex = 28;
            this.lb_list.SelectedIndexChanged += new System.EventHandler(this.lb_list_SelectedIndexChanged);
            // 
            // ViewCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 189);
            this.Controls.Add(this.lb_list);
            this.Controls.Add(this.b_excluir);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_end);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Name = "ViewCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.ViewCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_excluir;
        private System.Windows.Forms.Button b_salvar;
        private System.Windows.Forms.ListBox lb_list;
    }
}