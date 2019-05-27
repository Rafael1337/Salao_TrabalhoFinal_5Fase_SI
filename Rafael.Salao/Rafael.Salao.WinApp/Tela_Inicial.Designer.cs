namespace Rafael.Salao.WinApp
{
    partial class Tela_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.inicio_aba = new System.Windows.Forms.TabPage();
            this.agenda_aba = new System.Windows.Forms.TabPage();
            this.funcionarios_aba = new System.Windows.Forms.TabPage();
            this.caixa_aba = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adicionar_horario_agenda_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.agenda_aba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.inicio_aba);
            this.tabControl1.Controls.Add(this.agenda_aba);
            this.tabControl1.Controls.Add(this.funcionarios_aba);
            this.tabControl1.Controls.Add(this.caixa_aba);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // inicio_aba
            // 
            this.inicio_aba.Location = new System.Drawing.Point(4, 22);
            this.inicio_aba.Name = "inicio_aba";
            this.inicio_aba.Padding = new System.Windows.Forms.Padding(3);
            this.inicio_aba.Size = new System.Drawing.Size(602, 300);
            this.inicio_aba.TabIndex = 0;
            this.inicio_aba.Text = "Inicio";
            this.inicio_aba.UseVisualStyleBackColor = true;
            // 
            // agenda_aba
            // 
            this.agenda_aba.Controls.Add(this.button2);
            this.agenda_aba.Controls.Add(this.button1);
            this.agenda_aba.Controls.Add(this.adicionar_horario_agenda_button);
            this.agenda_aba.Controls.Add(this.dataGridView1);
            this.agenda_aba.Location = new System.Drawing.Point(4, 22);
            this.agenda_aba.Name = "agenda_aba";
            this.agenda_aba.Padding = new System.Windows.Forms.Padding(3);
            this.agenda_aba.Size = new System.Drawing.Size(602, 300);
            this.agenda_aba.TabIndex = 1;
            this.agenda_aba.Text = "Agenda";
            this.agenda_aba.UseVisualStyleBackColor = true;
            // 
            // funcionarios_aba
            // 
            this.funcionarios_aba.Location = new System.Drawing.Point(4, 22);
            this.funcionarios_aba.Name = "funcionarios_aba";
            this.funcionarios_aba.Padding = new System.Windows.Forms.Padding(3);
            this.funcionarios_aba.Size = new System.Drawing.Size(602, 300);
            this.funcionarios_aba.TabIndex = 2;
            this.funcionarios_aba.Text = "Funcionarios";
            this.funcionarios_aba.UseVisualStyleBackColor = true;
            // 
            // caixa_aba
            // 
            this.caixa_aba.Location = new System.Drawing.Point(4, 22);
            this.caixa_aba.Name = "caixa_aba";
            this.caixa_aba.Padding = new System.Windows.Forms.Padding(3);
            this.caixa_aba.Size = new System.Drawing.Size(602, 300);
            this.caixa_aba.TabIndex = 3;
            this.caixa_aba.Text = "Caixa";
            this.caixa_aba.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(102, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 39);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(54, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adicionar_horario_agenda_button
            // 
            this.adicionar_horario_agenda_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adicionar_horario_agenda_button.BackgroundImage")));
            this.adicionar_horario_agenda_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adicionar_horario_agenda_button.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.adicionar_horario_agenda_button.FlatAppearance.BorderSize = 0;
            this.adicionar_horario_agenda_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionar_horario_agenda_button.Location = new System.Drawing.Point(6, 3);
            this.adicionar_horario_agenda_button.Name = "adicionar_horario_agenda_button";
            this.adicionar_horario_agenda_button.Size = new System.Drawing.Size(42, 39);
            this.adicionar_horario_agenda_button.TabIndex = 1;
            this.adicionar_horario_agenda_button.UseVisualStyleBackColor = true;
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 341);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tela_Inicial";
            this.Text = "Tela_Inicial";
            this.tabControl1.ResumeLayout(false);
            this.agenda_aba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage inicio_aba;
        private System.Windows.Forms.TabPage agenda_aba;
        private System.Windows.Forms.TabPage funcionarios_aba;
        private System.Windows.Forms.TabPage caixa_aba;
        private System.Windows.Forms.Button adicionar_horario_agenda_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}