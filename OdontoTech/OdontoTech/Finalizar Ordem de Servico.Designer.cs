
namespace OdontoTech
{
    partial class Finalizar_Ordem_de_Servico
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
            this.dgordens = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpeca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgordens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgordens
            // 
            this.dgordens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgordens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgordens.Location = new System.Drawing.Point(0, 134);
            this.dgordens.Name = "dgordens";
            this.dgordens.Size = new System.Drawing.Size(800, 316);
            this.dgordens.TabIndex = 10;
            this.dgordens.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgordens_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(224, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Procurar por Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista de Ordens de Serviço";
            // 
            // txtpeca
            // 
            this.txtpeca.Location = new System.Drawing.Point(228, 85);
            this.txtpeca.Name = "txtpeca";
            this.txtpeca.Size = new System.Drawing.Size(298, 20);
            this.txtpeca.TabIndex = 11;
            this.txtpeca.TextChanged += new System.EventHandler(this.txtpeca_TextChanged);
            // 
            // Finalizar_Ordem_de_Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpeca);
            this.Controls.Add(this.dgordens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Finalizar_Ordem_de_Servico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar_Ordem_de_Servico";
            this.Load += new System.EventHandler(this.Finalizar_Ordem_de_Servico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgordens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgordens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpeca;
    }
}