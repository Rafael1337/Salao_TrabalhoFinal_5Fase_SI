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
            this.remover_horario_agenda_button = new System.Windows.Forms.Button();
            this.editar_horario_agenda_button = new System.Windows.Forms.Button();
            this.adicionar_horario_agenda_button = new System.Windows.Forms.Button();
            this.agenda_datagrid = new System.Windows.Forms.DataGridView();
            this.funcionarios_aba = new System.Windows.Forms.TabPage();
            this.remover_funcionario_button = new System.Windows.Forms.Button();
            this.editar_funcionario_button = new System.Windows.Forms.Button();
            this.add_funcionario_button = new System.Windows.Forms.Button();
            this.funcionario_datagrid = new System.Windows.Forms.DataGridView();
            this.caixa_aba = new System.Windows.Forms.TabPage();
            this.fechar_caixa = new System.Windows.Forms.Button();
            this.add_saldo = new System.Windows.Forms.Button();
            this.saldo_caixa_label = new System.Windows.Forms.Label();
            this.saldo_atual_txtbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.agenda_aba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenda_datagrid)).BeginInit();
            this.funcionarios_aba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionario_datagrid)).BeginInit();
            this.caixa_aba.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(654, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // inicio_aba
            // 
            this.inicio_aba.Location = new System.Drawing.Point(4, 22);
            this.inicio_aba.Name = "inicio_aba";
            this.inicio_aba.Padding = new System.Windows.Forms.Padding(3);
            this.inicio_aba.Size = new System.Drawing.Size(646, 300);
            this.inicio_aba.TabIndex = 0;
            this.inicio_aba.Text = "Inicio";
            this.inicio_aba.UseVisualStyleBackColor = true;
            // 
            // agenda_aba
            // 
            this.agenda_aba.Controls.Add(this.remover_horario_agenda_button);
            this.agenda_aba.Controls.Add(this.editar_horario_agenda_button);
            this.agenda_aba.Controls.Add(this.adicionar_horario_agenda_button);
            this.agenda_aba.Controls.Add(this.agenda_datagrid);
            this.agenda_aba.Location = new System.Drawing.Point(4, 22);
            this.agenda_aba.Name = "agenda_aba";
            this.agenda_aba.Padding = new System.Windows.Forms.Padding(3);
            this.agenda_aba.Size = new System.Drawing.Size(646, 300);
            this.agenda_aba.TabIndex = 1;
            this.agenda_aba.Text = "Agenda";
            this.agenda_aba.UseVisualStyleBackColor = true;
            // 
            // remover_horario_agenda_button
            // 
            this.remover_horario_agenda_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remover_horario_agenda_button.BackgroundImage")));
            this.remover_horario_agenda_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remover_horario_agenda_button.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.remover_horario_agenda_button.FlatAppearance.BorderSize = 0;
            this.remover_horario_agenda_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remover_horario_agenda_button.Location = new System.Drawing.Point(102, 6);
            this.remover_horario_agenda_button.Name = "remover_horario_agenda_button";
            this.remover_horario_agenda_button.Size = new System.Drawing.Size(42, 39);
            this.remover_horario_agenda_button.TabIndex = 3;
            this.remover_horario_agenda_button.UseVisualStyleBackColor = true;
            this.remover_horario_agenda_button.Click += new System.EventHandler(this.remover_horario_agenda_button_Click);
            // 
            // editar_horario_agenda_button
            // 
            this.editar_horario_agenda_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar_horario_agenda_button.BackgroundImage")));
            this.editar_horario_agenda_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editar_horario_agenda_button.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.editar_horario_agenda_button.FlatAppearance.BorderSize = 0;
            this.editar_horario_agenda_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar_horario_agenda_button.Location = new System.Drawing.Point(54, 6);
            this.editar_horario_agenda_button.Name = "editar_horario_agenda_button";
            this.editar_horario_agenda_button.Size = new System.Drawing.Size(42, 39);
            this.editar_horario_agenda_button.TabIndex = 2;
            this.editar_horario_agenda_button.UseVisualStyleBackColor = true;
            this.editar_horario_agenda_button.Click += new System.EventHandler(this.editar_horario_agenda_button_Click);
            // 
            // adicionar_horario_agenda_button
            // 
            this.adicionar_horario_agenda_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adicionar_horario_agenda_button.BackgroundImage")));
            this.adicionar_horario_agenda_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adicionar_horario_agenda_button.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.adicionar_horario_agenda_button.FlatAppearance.BorderSize = 0;
            this.adicionar_horario_agenda_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionar_horario_agenda_button.Location = new System.Drawing.Point(6, 6);
            this.adicionar_horario_agenda_button.Name = "adicionar_horario_agenda_button";
            this.adicionar_horario_agenda_button.Size = new System.Drawing.Size(42, 39);
            this.adicionar_horario_agenda_button.TabIndex = 1;
            this.adicionar_horario_agenda_button.UseVisualStyleBackColor = true;
            this.adicionar_horario_agenda_button.Click += new System.EventHandler(this.adicionar_horario_agenda_button_Click);
            // 
            // agenda_datagrid
            // 
            this.agenda_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agenda_datagrid.Location = new System.Drawing.Point(6, 48);
            this.agenda_datagrid.Name = "agenda_datagrid";
            this.agenda_datagrid.Size = new System.Drawing.Size(634, 246);
            this.agenda_datagrid.TabIndex = 0;
            // 
            // funcionarios_aba
            // 
            this.funcionarios_aba.Controls.Add(this.remover_funcionario_button);
            this.funcionarios_aba.Controls.Add(this.editar_funcionario_button);
            this.funcionarios_aba.Controls.Add(this.add_funcionario_button);
            this.funcionarios_aba.Controls.Add(this.funcionario_datagrid);
            this.funcionarios_aba.Location = new System.Drawing.Point(4, 22);
            this.funcionarios_aba.Name = "funcionarios_aba";
            this.funcionarios_aba.Padding = new System.Windows.Forms.Padding(3);
            this.funcionarios_aba.Size = new System.Drawing.Size(646, 300);
            this.funcionarios_aba.TabIndex = 2;
            this.funcionarios_aba.Text = "Funcionarios";
            this.funcionarios_aba.UseVisualStyleBackColor = true;
            // 
            // remover_funcionario_button
            // 
            this.remover_funcionario_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remover_funcionario_button.BackgroundImage")));
            this.remover_funcionario_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.remover_funcionario_button.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.remover_funcionario_button.FlatAppearance.BorderSize = 0;
            this.remover_funcionario_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remover_funcionario_button.Location = new System.Drawing.Point(102, 6);
            this.remover_funcionario_button.Name = "remover_funcionario_button";
            this.remover_funcionario_button.Size = new System.Drawing.Size(42, 39);
            this.remover_funcionario_button.TabIndex = 7;
            this.remover_funcionario_button.UseVisualStyleBackColor = true;
            this.remover_funcionario_button.Click += new System.EventHandler(this.Remover_funcionario_button_Click);
            // 
            // editar_funcionario_button
            // 
            this.editar_funcionario_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar_funcionario_button.BackgroundImage")));
            this.editar_funcionario_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editar_funcionario_button.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.editar_funcionario_button.FlatAppearance.BorderSize = 0;
            this.editar_funcionario_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar_funcionario_button.Location = new System.Drawing.Point(54, 6);
            this.editar_funcionario_button.Name = "editar_funcionario_button";
            this.editar_funcionario_button.Size = new System.Drawing.Size(42, 39);
            this.editar_funcionario_button.TabIndex = 6;
            this.editar_funcionario_button.UseVisualStyleBackColor = true;
            this.editar_funcionario_button.Click += new System.EventHandler(this.editar_funcionario_button_Click);
            // 
            // add_funcionario_button
            // 
            this.add_funcionario_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_funcionario_button.BackgroundImage")));
            this.add_funcionario_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_funcionario_button.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.add_funcionario_button.FlatAppearance.BorderSize = 0;
            this.add_funcionario_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_funcionario_button.Location = new System.Drawing.Point(6, 6);
            this.add_funcionario_button.Name = "add_funcionario_button";
            this.add_funcionario_button.Size = new System.Drawing.Size(42, 39);
            this.add_funcionario_button.TabIndex = 5;
            this.add_funcionario_button.UseVisualStyleBackColor = true;
            this.add_funcionario_button.Click += new System.EventHandler(this.Add_funcionario_button_Click);
            // 
            // funcionario_datagrid
            // 
            this.funcionario_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionario_datagrid.Location = new System.Drawing.Point(6, 51);
            this.funcionario_datagrid.Name = "funcionario_datagrid";
            this.funcionario_datagrid.Size = new System.Drawing.Size(634, 246);
            this.funcionario_datagrid.TabIndex = 4;
            // 
            // caixa_aba
            // 
            this.caixa_aba.Controls.Add(this.fechar_caixa);
            this.caixa_aba.Controls.Add(this.add_saldo);
            this.caixa_aba.Controls.Add(this.saldo_caixa_label);
            this.caixa_aba.Controls.Add(this.saldo_atual_txtbox);
            this.caixa_aba.Location = new System.Drawing.Point(4, 22);
            this.caixa_aba.Name = "caixa_aba";
            this.caixa_aba.Padding = new System.Windows.Forms.Padding(3);
            this.caixa_aba.Size = new System.Drawing.Size(646, 300);
            this.caixa_aba.TabIndex = 3;
            this.caixa_aba.Text = "Caixa";
            this.caixa_aba.UseVisualStyleBackColor = true;
            // 
            // fechar_caixa
            // 
            this.fechar_caixa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fechar_caixa.BackgroundImage")));
            this.fechar_caixa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fechar_caixa.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.fechar_caixa.FlatAppearance.BorderSize = 0;
            this.fechar_caixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fechar_caixa.Location = new System.Drawing.Point(64, 6);
            this.fechar_caixa.Name = "fechar_caixa";
            this.fechar_caixa.Size = new System.Drawing.Size(42, 39);
            this.fechar_caixa.TabIndex = 3;
            this.fechar_caixa.UseVisualStyleBackColor = true;
            this.fechar_caixa.Click += new System.EventHandler(this.fechar_caixa_Click);
            // 
            // add_saldo
            // 
            this.add_saldo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_saldo.BackgroundImage")));
            this.add_saldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_saldo.FlatAppearance.BorderColor = System.Drawing.Color.Violet;
            this.add_saldo.FlatAppearance.BorderSize = 0;
            this.add_saldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_saldo.Location = new System.Drawing.Point(16, 6);
            this.add_saldo.Name = "add_saldo";
            this.add_saldo.Size = new System.Drawing.Size(42, 39);
            this.add_saldo.TabIndex = 2;
            this.add_saldo.UseVisualStyleBackColor = true;
            this.add_saldo.Click += new System.EventHandler(this.add_saldo_Click);
            // 
            // saldo_caixa_label
            // 
            this.saldo_caixa_label.AutoSize = true;
            this.saldo_caixa_label.Location = new System.Drawing.Point(128, 102);
            this.saldo_caixa_label.Name = "saldo_caixa_label";
            this.saldo_caixa_label.Size = new System.Drawing.Size(106, 13);
            this.saldo_caixa_label.TabIndex = 1;
            this.saldo_caixa_label.Text = "Saldo atual do caixa:";
            // 
            // saldo_atual_txtbox
            // 
            this.saldo_atual_txtbox.Enabled = false;
            this.saldo_atual_txtbox.Location = new System.Drawing.Point(240, 99);
            this.saldo_atual_txtbox.Name = "saldo_atual_txtbox";
            this.saldo_atual_txtbox.Size = new System.Drawing.Size(149, 20);
            this.saldo_atual_txtbox.TabIndex = 0;
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 341);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tela_Inicial";
            this.Text = "Tela Inicial";
            this.tabControl1.ResumeLayout(false);
            this.agenda_aba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agenda_datagrid)).EndInit();
            this.funcionarios_aba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.funcionario_datagrid)).EndInit();
            this.caixa_aba.ResumeLayout(false);
            this.caixa_aba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage inicio_aba;
        private System.Windows.Forms.TabPage agenda_aba;
        private System.Windows.Forms.TabPage funcionarios_aba;
        private System.Windows.Forms.TabPage caixa_aba;
        private System.Windows.Forms.Button adicionar_horario_agenda_button;
        private System.Windows.Forms.DataGridView agenda_datagrid;
        private System.Windows.Forms.Button remover_horario_agenda_button;
        private System.Windows.Forms.Button editar_horario_agenda_button;
        private System.Windows.Forms.Button remover_funcionario_button;
        private System.Windows.Forms.Button editar_funcionario_button;
        private System.Windows.Forms.Button add_funcionario_button;
        private System.Windows.Forms.Label saldo_caixa_label;
        private System.Windows.Forms.Button add_saldo;
        public System.Windows.Forms.TextBox saldo_atual_txtbox;
        private System.Windows.Forms.Button fechar_caixa;
        public System.Windows.Forms.DataGridView funcionario_datagrid;
    }
}