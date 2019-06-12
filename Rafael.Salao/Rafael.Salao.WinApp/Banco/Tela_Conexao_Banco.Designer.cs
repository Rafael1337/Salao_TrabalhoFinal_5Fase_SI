namespace Rafael.Salao.WinApp.Banco
{
    partial class Tela_Conexao_Banco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Conexao_Banco));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.servidor_txtbox = new System.Windows.Forms.TextBox();
            this.banco_txtbox = new System.Windows.Forms.TextBox();
            this.usuario_txtbox = new System.Windows.Forms.TextBox();
            this.senha_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gravar_database_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Banco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha:";
            // 
            // servidor_txtbox
            // 
            this.servidor_txtbox.Location = new System.Drawing.Point(71, 10);
            this.servidor_txtbox.Name = "servidor_txtbox";
            this.servidor_txtbox.Size = new System.Drawing.Size(200, 20);
            this.servidor_txtbox.TabIndex = 4;
            // 
            // banco_txtbox
            // 
            this.banco_txtbox.Enabled = false;
            this.banco_txtbox.Location = new System.Drawing.Point(71, 51);
            this.banco_txtbox.Name = "banco_txtbox";
            this.banco_txtbox.Size = new System.Drawing.Size(200, 20);
            this.banco_txtbox.TabIndex = 5;
            this.banco_txtbox.Text = "SALAO_DATABASE";
            // 
            // usuario_txtbox
            // 
            this.usuario_txtbox.Location = new System.Drawing.Point(71, 91);
            this.usuario_txtbox.Name = "usuario_txtbox";
            this.usuario_txtbox.Size = new System.Drawing.Size(200, 20);
            this.usuario_txtbox.TabIndex = 6;
            // 
            // senha_txtbox
            // 
            this.senha_txtbox.Location = new System.Drawing.Point(71, 128);
            this.senha_txtbox.Name = "senha_txtbox";
            this.senha_txtbox.Size = new System.Drawing.Size(200, 20);
            this.senha_txtbox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // gravar_database_btn
            // 
            this.gravar_database_btn.Location = new System.Drawing.Point(139, 170);
            this.gravar_database_btn.Name = "gravar_database_btn";
            this.gravar_database_btn.Size = new System.Drawing.Size(132, 23);
            this.gravar_database_btn.TabIndex = 9;
            this.gravar_database_btn.Text = "Gravar";
            this.gravar_database_btn.UseVisualStyleBackColor = true;
            this.gravar_database_btn.Click += new System.EventHandler(this.gravar_database_btn_Click);
            // 
            // Tela_Conexao_Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 205);
            this.Controls.Add(this.gravar_database_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.senha_txtbox);
            this.Controls.Add(this.usuario_txtbox);
            this.Controls.Add(this.banco_txtbox);
            this.Controls.Add(this.servidor_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tela_Conexao_Banco";
            this.Text = "Configurar nova conexão com o banco de dados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gravar_database_btn;
        public System.Windows.Forms.TextBox servidor_txtbox;
        public System.Windows.Forms.TextBox banco_txtbox;
        public System.Windows.Forms.TextBox usuario_txtbox;
        public System.Windows.Forms.TextBox senha_txtbox;
    }
}