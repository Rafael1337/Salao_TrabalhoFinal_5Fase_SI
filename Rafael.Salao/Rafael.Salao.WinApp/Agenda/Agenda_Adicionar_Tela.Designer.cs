namespace Rafael.Salao.WinApp.Agenda
{
    partial class Agenda_Adicionar_Tela
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.horario_agenda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nome_cliente_txtbox = new System.Windows.Forms.TextBox();
            this.agenda_servico_combobox = new System.Windows.Forms.ComboBox();
            this.agenda_funcionario_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefone_cliente_textbox = new System.Windows.Forms.RichTextBox();
            this.adicionar_agenda_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.data_agenda = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Funcionário:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serviço:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // horario_agenda
            // 
            this.horario_agenda.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horario_agenda.Location = new System.Drawing.Point(200, 165);
            this.horario_agenda.Name = "horario_agenda";
            this.horario_agenda.Size = new System.Drawing.Size(82, 20);
            this.horario_agenda.TabIndex = 3;
            this.horario_agenda.ValueChanged += new System.EventHandler(this.horario_agenda_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Horario:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nome_cliente_txtbox
            // 
            this.nome_cliente_txtbox.Location = new System.Drawing.Point(109, 14);
            this.nome_cliente_txtbox.Name = "nome_cliente_txtbox";
            this.nome_cliente_txtbox.Size = new System.Drawing.Size(158, 20);
            this.nome_cliente_txtbox.TabIndex = 5;
            this.nome_cliente_txtbox.TextChanged += new System.EventHandler(this.nome_cliente_txtbox_TextChanged);
            // 
            // agenda_servico_combobox
            // 
            this.agenda_servico_combobox.FormattingEnabled = true;
            this.agenda_servico_combobox.Location = new System.Drawing.Point(68, 105);
            this.agenda_servico_combobox.Name = "agenda_servico_combobox";
            this.agenda_servico_combobox.Size = new System.Drawing.Size(175, 21);
            this.agenda_servico_combobox.TabIndex = 6;
            this.agenda_servico_combobox.SelectedIndexChanged += new System.EventHandler(this.agenda_servico_combobox_SelectedIndexChanged);
            // 
            // agenda_funcionario_combobox
            // 
            this.agenda_funcionario_combobox.FormattingEnabled = true;
            this.agenda_funcionario_combobox.Location = new System.Drawing.Point(84, 137);
            this.agenda_funcionario_combobox.Name = "agenda_funcionario_combobox";
            this.agenda_funcionario_combobox.Size = new System.Drawing.Size(196, 21);
            this.agenda_funcionario_combobox.TabIndex = 7;
            this.agenda_funcionario_combobox.SelectedIndexChanged += new System.EventHandler(this.agenda_funcionario_combobox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // telefone_cliente_textbox
            // 
            this.telefone_cliente_textbox.Location = new System.Drawing.Point(84, 45);
            this.telefone_cliente_textbox.Name = "telefone_cliente_textbox";
            this.telefone_cliente_textbox.Size = new System.Drawing.Size(183, 21);
            this.telefone_cliente_textbox.TabIndex = 9;
            this.telefone_cliente_textbox.Text = "";
            this.telefone_cliente_textbox.TextChanged += new System.EventHandler(this.telefone_cliente_textbox_TextChanged);
            // 
            // adicionar_agenda_btn
            // 
            this.adicionar_agenda_btn.Location = new System.Drawing.Point(68, 209);
            this.adicionar_agenda_btn.Name = "adicionar_agenda_btn";
            this.adicionar_agenda_btn.Size = new System.Drawing.Size(199, 23);
            this.adicionar_agenda_btn.TabIndex = 10;
            this.adicionar_agenda_btn.Text = "Registrar";
            this.adicionar_agenda_btn.UseVisualStyleBackColor = true;
            this.adicionar_agenda_btn.Click += new System.EventHandler(this.adicionar_agenda_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // data_agenda
            // 
            this.data_agenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_agenda.Location = new System.Drawing.Point(53, 165);
            this.data_agenda.Name = "data_agenda";
            this.data_agenda.Size = new System.Drawing.Size(82, 20);
            this.data_agenda.TabIndex = 11;
            this.data_agenda.ValueChanged += new System.EventHandler(this.data_agenda_ValueChanged);
            // 
            // Agenda_Adicionar_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 253);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data_agenda);
            this.Controls.Add(this.adicionar_agenda_btn);
            this.Controls.Add(this.telefone_cliente_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agenda_funcionario_combobox);
            this.Controls.Add(this.agenda_servico_combobox);
            this.Controls.Add(this.nome_cliente_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.horario_agenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agenda_Adicionar_Tela";
            this.Text = "Adicionar Horario na Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker horario_agenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nome_cliente_txtbox;
        private System.Windows.Forms.ComboBox agenda_servico_combobox;
        private System.Windows.Forms.ComboBox agenda_funcionario_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox telefone_cliente_textbox;
        private System.Windows.Forms.Button adicionar_agenda_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker data_agenda;
    }
}