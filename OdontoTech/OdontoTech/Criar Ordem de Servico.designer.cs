
namespace OdontoTech
{
    partial class Criar_Ordem_de_Servico
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
            this.btncriarcliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomecliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpeca = new System.Windows.Forms.TextBox();
            this.txtqtde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpdatarecebimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btncriar = new System.Windows.Forms.Button();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncriarcliente
            // 
            this.btncriarcliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btncriarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncriarcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btncriarcliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncriarcliente.Location = new System.Drawing.Point(594, 98);
            this.btncriarcliente.Name = "btncriarcliente";
            this.btncriarcliente.Size = new System.Drawing.Size(156, 36);
            this.btncriarcliente.TabIndex = 2;
            this.btncriarcliente.Text = "Novo Cliente";
            this.btncriarcliente.UseVisualStyleBackColor = false;
            this.btncriarcliente.Click += new System.EventHandler(this.btncriarcliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ordem de Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(287, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Cliente:";
            // 
            // txtnomecliente
            // 
            this.txtnomecliente.Location = new System.Drawing.Point(291, 114);
            this.txtnomecliente.Name = "txtnomecliente";
            this.txtnomecliente.ReadOnly = true;
            this.txtnomecliente.Size = new System.Drawing.Size(271, 20);
            this.txtnomecliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(87, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Peça:";
            // 
            // txtpeca
            // 
            this.txtpeca.Location = new System.Drawing.Point(91, 208);
            this.txtpeca.Name = "txtpeca";
            this.txtpeca.Size = new System.Drawing.Size(166, 20);
            this.txtpeca.TabIndex = 7;
            // 
            // txtqtde
            // 
            this.txtqtde.Location = new System.Drawing.Point(279, 208);
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.Size = new System.Drawing.Size(104, 20);
            this.txtqtde.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.Location = new System.Drawing.Point(275, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label5.Location = new System.Drawing.Point(472, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Recebimento:";
            // 
            // dtpdatarecebimento
            // 
            this.dtpdatarecebimento.Enabled = false;
            this.dtpdatarecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatarecebimento.Location = new System.Drawing.Point(476, 205);
            this.dtpdatarecebimento.Name = "dtpdatarecebimento";
            this.dtpdatarecebimento.Size = new System.Drawing.Size(184, 20);
            this.dtpdatarecebimento.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label6.Location = new System.Drawing.Point(87, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descrição da peça:";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(91, 300);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(292, 86);
            this.txtdescricao.TabIndex = 13;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(493, 300);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(104, 20);
            this.txtvalor.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label7.Location = new System.Drawing.Point(489, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label8.Location = new System.Drawing.Point(454, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "R$";
            // 
            // btncriar
            // 
            this.btncriar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btncriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btncriar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncriar.Location = new System.Drawing.Point(494, 334);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(166, 52);
            this.btncriar.TabIndex = 17;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = false;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(91, 114);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(166, 20);
            this.txtcpf.TabIndex = 19;
            this.txtcpf.TextChanged += new System.EventHandler(this.txtcpf_TextChanged);
            this.txtcpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcpf_KeyUp);
            this.txtcpf.Leave += new System.EventHandler(this.txtcpf_Leave);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label0.Location = new System.Drawing.Point(87, 89);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(112, 22);
            this.label0.TabIndex = 18;
            this.label0.Text = "CPF Cliente:";
            // 
            // Criar_Ordem_de_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpdatarecebimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtqtde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpeca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnomecliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncriarcliente);
            this.Name = "Criar_Ordem_de_Servico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Ordem de Serviço - OdontoTech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncriarcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomecliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpeca;
        private System.Windows.Forms.TextBox txtqtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpdatarecebimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncriar;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label label0;
    }
}