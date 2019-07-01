namespace Rafael.Salao.WinApp.Caixa
{
    partial class Extrato_Dias_Caixa
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
            this.show_extrato = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.show_extrato)).BeginInit();
            this.SuspendLayout();
            // 
            // show_extrato
            // 
            this.show_extrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_extrato.Location = new System.Drawing.Point(12, 12);
            this.show_extrato.Name = "show_extrato";
            this.show_extrato.Size = new System.Drawing.Size(346, 426);
            this.show_extrato.TabIndex = 0;
            // 
            // Extrato_Dias_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.show_extrato);
            this.Name = "Extrato_Dias_Caixa";
            this.Text = "Extrato";
            ((System.ComponentModel.ISupportInitialize)(this.show_extrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView show_extrato;
    }
}