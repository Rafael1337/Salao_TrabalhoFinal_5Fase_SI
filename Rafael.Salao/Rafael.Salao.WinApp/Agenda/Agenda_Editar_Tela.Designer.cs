namespace Rafael.Salao.WinApp.Agenda
{
    partial class Agenda_Editar_Tela
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
            this.label6 = new System.Windows.Forms.Label();
            this.data_agenda = new System.Windows.Forms.DateTimePicker();
            this.atualizar_agenda_btn = new System.Windows.Forms.Button();
            this.telefone_cliente_textbox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.agenda_funcionario_combobox = new System.Windows.Forms.ComboBox();
            this.agenda_servico_combobox = new System.Windows.Forms.ComboBox();
            this.nome_cliente_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.horario_agenda = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Data:";
            // 
            // data_agenda
            // 
            this.data_agenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_agenda.Location = new System.Drawing.Point(73, 166);
            this.data_agenda.Name = "data_agenda";
            this.data_agenda.Size = new System.Drawing.Size(82, 20);
            this.data_agenda.TabIndex = 24;
            // 
            // atualizar_agenda_btn
            // 
            this.atualizar_agenda_btn.Location = new System.Drawing.Point(88, 210);
            this.atualizar_agenda_btn.Name = "atualizar_agenda_btn";
            this.atualizar_agenda_btn.Size = new System.Drawing.Size(199, 23);
            this.atualizar_agenda_btn.TabIndex = 23;
            this.atualizar_agenda_btn.Text = "Atualizar!";
            this.atualizar_agenda_btn.UseVisualStyleBackColor = true;
            this.atualizar_agenda_btn.Click += new System.EventHandler(this.atualizar_agenda_btn_Click);
            // 
            // telefone_cliente_textbox
            // 
            this.telefone_cliente_textbox.Location = new System.Drawing.Point(104, 46);
            this.telefone_cliente_textbox.Name = "telefone_cliente_textbox";
            this.telefone_cliente_textbox.Size = new System.Drawing.Size(183, 21);
            this.telefone_cliente_textbox.TabIndex = 22;
            this.telefone_cliente_textbox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefone:";
            // 
            // agenda_funcionario_combobox
            // 
            this.agenda_funcionario_combobox.FormattingEnabled = true;
            this.agenda_funcionario_combobox.Location = new System.Drawing.Point(104, 138);
            this.agenda_funcionario_combobox.Name = "agenda_funcionario_combobox";
            this.agenda_funcionario_combobox.Size = new System.Drawing.Size(196, 21);
            this.agenda_funcionario_combobox.TabIndex = 20;
            // 
            // agenda_servico_combobox
            // 
            this.agenda_servico_combobox.FormattingEnabled = true;
            this.agenda_servico_combobox.Location = new System.Drawing.Point(88, 106);
            this.agenda_servico_combobox.Name = "agenda_servico_combobox";
            this.agenda_servico_combobox.Size = new System.Drawing.Size(175, 21);
            this.agenda_servico_combobox.TabIndex = 19;
            // 
            // nome_cliente_txtbox
            // 
            this.nome_cliente_txtbox.Location = new System.Drawing.Point(129, 15);
            this.nome_cliente_txtbox.Name = "nome_cliente_txtbox";
            this.nome_cliente_txtbox.Size = new System.Drawing.Size(158, 20);
            this.nome_cliente_txtbox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Horario:";
            // 
            // horario_agenda
            // 
            this.horario_agenda.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horario_agenda.Location = new System.Drawing.Point(220, 166);
            this.horario_agenda.Name = "horario_agenda";
            this.horario_agenda.Size = new System.Drawing.Size(82, 20);
            this.horario_agenda.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Serviço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Funcionário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome do cliente:";
            // 
            // Agenda_Editar_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 248);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.data_agenda);
            this.Controls.Add(this.atualizar_agenda_btn);
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
            this.Name = "Agenda_Editar_Tela";
            this.Text = "Editar Agendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker data_agenda;
        private System.Windows.Forms.Button atualizar_agenda_btn;
        private System.Windows.Forms.RichTextBox telefone_cliente_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox agenda_funcionario_combobox;
        private System.Windows.Forms.ComboBox agenda_servico_combobox;
        private System.Windows.Forms.TextBox nome_cliente_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker horario_agenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}