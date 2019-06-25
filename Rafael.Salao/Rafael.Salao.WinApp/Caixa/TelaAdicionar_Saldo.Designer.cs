namespace Rafael.Salao.WinApp.Caixa
{
    partial class TelaAdicionar_Saldo
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
            this.saldo_adicionar_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_saldo_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saldo_adicionar_txtbox
            // 
            this.saldo_adicionar_txtbox.Location = new System.Drawing.Point(105, 34);
            this.saldo_adicionar_txtbox.Name = "saldo_adicionar_txtbox";
            this.saldo_adicionar_txtbox.Size = new System.Drawing.Size(100, 20);
            this.saldo_adicionar_txtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor:";
            // 
            // add_saldo_btn
            // 
            this.add_saldo_btn.Location = new System.Drawing.Point(68, 72);
            this.add_saldo_btn.Name = "add_saldo_btn";
            this.add_saldo_btn.Size = new System.Drawing.Size(141, 23);
            this.add_saldo_btn.TabIndex = 2;
            this.add_saldo_btn.Text = "Confirmar";
            this.add_saldo_btn.UseVisualStyleBackColor = true;
            this.add_saldo_btn.Click += new System.EventHandler(this.add_saldo_btn_Click);
            // 
            // TelaAdicionar_Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 125);
            this.Controls.Add(this.add_saldo_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saldo_adicionar_txtbox);
            this.Name = "TelaAdicionar_Saldo";
            this.Text = "Adicionar Saldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox saldo_adicionar_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_saldo_btn;
    }
}