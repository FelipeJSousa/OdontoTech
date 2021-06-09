
namespace OdontoTech
{
    partial class Criar_Usuario
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
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncriar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(272, 213);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(252, 20);
            this.txtsenha.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label8.Location = new System.Drawing.Point(267, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 41;
            this.label8.Text = "Senha:";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(271, 141);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(252, 20);
            this.txtuser.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(267, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 51);
            this.label1.TabIndex = 38;
            this.label1.Text = "Criar Usuario";
            // 
            // btncriar
            // 
            this.btncriar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btncriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btncriar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncriar.Location = new System.Drawing.Point(315, 286);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(166, 52);
            this.btncriar.TabIndex = 47;
            this.btncriar.Text = "Criar";
            this.btncriar.UseVisualStyleBackColor = false;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // Criar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Criar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar_Usuario";
            this.Load += new System.EventHandler(this.Criar_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncriar;
    }
}