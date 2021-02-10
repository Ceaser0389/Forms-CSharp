
namespace ProjetoFinal
{
    partial class JanelaPrincipal
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Sobrenome = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.lv_Relatorio = new System.Windows.Forms.ListView();
            this.cl_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Sobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Cep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_NovoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Anotacoes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Cep = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Valor = new System.Windows.Forms.MaskedTextBox();
            this.gb_NovoCliente = new System.Windows.Forms.GroupBox();
            this.rb_Nao = new System.Windows.Forms.RadioButton();
            this.rb_Sim = new System.Windows.Forms.RadioButton();
            this.gb_Anotacao = new System.Windows.Forms.GroupBox();
            this.cb_AvisoPrevio = new System.Windows.Forms.CheckBox();
            this.cb_Condominio = new System.Windows.Forms.CheckBox();
            this.cb_HComercial = new System.Windows.Forms.CheckBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.gb_NovoCliente.SuspendLayout();
            this.gb_Anotacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório de Vendas MH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label4.Location = new System.Drawing.Point(49, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label5.Location = new System.Drawing.Point(49, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label6.Location = new System.Drawing.Point(49, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sobrenome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label7.Location = new System.Drawing.Point(49, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label8.Location = new System.Drawing.Point(49, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "CEP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label9.Location = new System.Drawing.Point(408, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Anotações:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label10.Location = new System.Drawing.Point(408, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Data:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label11.Location = new System.Drawing.Point(408, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Valor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label12.Location = new System.Drawing.Point(408, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "Novo Cliente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB", 14F);
            this.label13.Location = new System.Drawing.Point(408, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Status:";
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_ID.Location = new System.Drawing.Point(159, 99);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(119, 22);
            this.tb_ID.TabIndex = 0;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaPressionada_ID);
            // 
            // tb_Nome
            // 
            this.tb_Nome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Nome.Location = new System.Drawing.Point(159, 130);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(119, 22);
            this.tb_Nome.TabIndex = 1;
            // 
            // tb_Sobrenome
            // 
            this.tb_Sobrenome.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Sobrenome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Sobrenome.Location = new System.Drawing.Point(159, 163);
            this.tb_Sobrenome.Name = "tb_Sobrenome";
            this.tb_Sobrenome.Size = new System.Drawing.Size(119, 22);
            this.tb_Sobrenome.TabIndex = 2;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Adicionar.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Adicionar.Location = new System.Drawing.Point(262, 302);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(158, 37);
            this.btn_Adicionar.TabIndex = 23;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.BotaoAdicionar);
            // 
            // lv_Relatorio
            // 
            this.lv_Relatorio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lv_Relatorio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Id,
            this.cl_Nome,
            this.cl_Sobrenome,
            this.cl_Cep,
            this.cl_Telefone,
            this.cl_Status,
            this.cl_NovoCliente,
            this.cl_Valor,
            this.cl_Data,
            this.cl_Anotacoes});
            this.lv_Relatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lv_Relatorio.GridLines = true;
            this.lv_Relatorio.HideSelection = false;
            this.lv_Relatorio.Location = new System.Drawing.Point(1, 356);
            this.lv_Relatorio.Name = "lv_Relatorio";
            this.lv_Relatorio.Size = new System.Drawing.Size(686, 239);
            this.lv_Relatorio.TabIndex = 24;
            this.lv_Relatorio.UseCompatibleStateImageBehavior = false;
            this.lv_Relatorio.View = System.Windows.Forms.View.Details;
            // 
            // cl_Id
            // 
            this.cl_Id.Text = "ID";
            this.cl_Id.Width = 34;
            // 
            // cl_Nome
            // 
            this.cl_Nome.Text = "Nome";
            this.cl_Nome.Width = 81;
            // 
            // cl_Sobrenome
            // 
            this.cl_Sobrenome.Text = "Sobrenome";
            this.cl_Sobrenome.Width = 82;
            // 
            // cl_Cep
            // 
            this.cl_Cep.Text = "CEP";
            this.cl_Cep.Width = 57;
            // 
            // cl_Telefone
            // 
            this.cl_Telefone.Text = "Telefone";
            this.cl_Telefone.Width = 74;
            // 
            // cl_Status
            // 
            this.cl_Status.Text = "Status";
            // 
            // cl_NovoCliente
            // 
            this.cl_NovoCliente.Text = "Novo Cliente";
            this.cl_NovoCliente.Width = 82;
            // 
            // cl_Valor
            // 
            this.cl_Valor.Text = "Valor";
            // 
            // cl_Data
            // 
            this.cl_Data.Text = "Data";
            // 
            // cl_Anotacoes
            // 
            this.cl_Anotacoes.Text = "Anotações";
            this.cl_Anotacoes.Width = 88;
            // 
            // mtb_Telefone
            // 
            this.mtb_Telefone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_Telefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_Telefone.Location = new System.Drawing.Point(159, 198);
            this.mtb_Telefone.Mask = "(99) 9-0000-0000";
            this.mtb_Telefone.Name = "mtb_Telefone";
            this.mtb_Telefone.Size = new System.Drawing.Size(119, 22);
            this.mtb_Telefone.TabIndex = 3;
            // 
            // mtb_Cep
            // 
            this.mtb_Cep.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_Cep.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_Cep.Location = new System.Drawing.Point(159, 232);
            this.mtb_Cep.Mask = "00000-000";
            this.mtb_Cep.Name = "mtb_Cep";
            this.mtb_Cep.Size = new System.Drawing.Size(119, 22);
            this.mtb_Cep.TabIndex = 4;
            // 
            // mtb_Valor
            // 
            this.mtb_Valor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mtb_Valor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtb_Valor.Location = new System.Drawing.Point(535, 175);
            this.mtb_Valor.Mask = "$00.00";
            this.mtb_Valor.Name = "mtb_Valor";
            this.mtb_Valor.Size = new System.Drawing.Size(119, 22);
            this.mtb_Valor.TabIndex = 8;
            // 
            // gb_NovoCliente
            // 
            this.gb_NovoCliente.Controls.Add(this.rb_Nao);
            this.gb_NovoCliente.Controls.Add(this.rb_Sim);
            this.gb_NovoCliente.Location = new System.Drawing.Point(535, 132);
            this.gb_NovoCliente.Name = "gb_NovoCliente";
            this.gb_NovoCliente.Size = new System.Drawing.Size(119, 37);
            this.gb_NovoCliente.TabIndex = 28;
            this.gb_NovoCliente.TabStop = false;
            // 
            // rb_Nao
            // 
            this.rb_Nao.AutoSize = true;
            this.rb_Nao.Location = new System.Drawing.Point(54, 12);
            this.rb_Nao.Name = "rb_Nao";
            this.rb_Nao.Size = new System.Drawing.Size(48, 19);
            this.rb_Nao.TabIndex = 7;
            this.rb_Nao.Text = "Não";
            this.rb_Nao.UseVisualStyleBackColor = true;
            // 
            // rb_Sim
            // 
            this.rb_Sim.AutoSize = true;
            this.rb_Sim.Checked = true;
            this.rb_Sim.Location = new System.Drawing.Point(6, 12);
            this.rb_Sim.Name = "rb_Sim";
            this.rb_Sim.Size = new System.Drawing.Size(43, 19);
            this.rb_Sim.TabIndex = 6;
            this.rb_Sim.TabStop = true;
            this.rb_Sim.Text = "Sim";
            this.rb_Sim.UseVisualStyleBackColor = true;
            // 
            // gb_Anotacao
            // 
            this.gb_Anotacao.Controls.Add(this.cb_AvisoPrevio);
            this.gb_Anotacao.Controls.Add(this.cb_Condominio);
            this.gb_Anotacao.Controls.Add(this.cb_HComercial);
            this.gb_Anotacao.Location = new System.Drawing.Point(537, 240);
            this.gb_Anotacao.Name = "gb_Anotacao";
            this.gb_Anotacao.Size = new System.Drawing.Size(117, 99);
            this.gb_Anotacao.TabIndex = 29;
            this.gb_Anotacao.TabStop = false;
            // 
            // cb_AvisoPrevio
            // 
            this.cb_AvisoPrevio.AutoSize = true;
            this.cb_AvisoPrevio.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.cb_AvisoPrevio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_AvisoPrevio.Location = new System.Drawing.Point(3, 68);
            this.cb_AvisoPrevio.Name = "cb_AvisoPrevio";
            this.cb_AvisoPrevio.Size = new System.Drawing.Size(95, 20);
            this.cb_AvisoPrevio.TabIndex = 11;
            this.cb_AvisoPrevio.Text = "Aviso Prévio";
            this.cb_AvisoPrevio.UseVisualStyleBackColor = true;
            // 
            // cb_Condominio
            // 
            this.cb_Condominio.AutoSize = true;
            this.cb_Condominio.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.cb_Condominio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Condominio.Location = new System.Drawing.Point(3, 43);
            this.cb_Condominio.Name = "cb_Condominio";
            this.cb_Condominio.Size = new System.Drawing.Size(92, 20);
            this.cb_Condominio.TabIndex = 10;
            this.cb_Condominio.Text = "Condominio";
            this.cb_Condominio.UseVisualStyleBackColor = true;
            // 
            // cb_HComercial
            // 
            this.cb_HComercial.AutoSize = true;
            this.cb_HComercial.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.cb_HComercial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_HComercial.Location = new System.Drawing.Point(3, 17);
            this.cb_HComercial.Name = "cb_HComercial";
            this.cb_HComercial.Size = new System.Drawing.Size(96, 20);
            this.cb_HComercial.TabIndex = 9;
            this.cb_HComercial.Text = "H Comercial";
            this.cb_HComercial.UseVisualStyleBackColor = true;
            // 
            // cb_Status
            // 
            this.cb_Status.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cb_Status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Ag Pagamento",
            "Pago",
            "Ag Envio",
            "Enviado",
            "Finalizado"});
            this.cb_Status.Location = new System.Drawing.Point(533, 103);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(121, 23);
            this.cb_Status.TabIndex = 5;
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarMonthBackground = System.Drawing.SystemColors.ControlDark;
            this.dtp_Date.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtp_Date.Font = new System.Drawing.Font("Berlin Sans FB", 9F);
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(535, 212);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(119, 21);
            this.dtp_Date.TabIndex = 9;
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(693, 605);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.gb_Anotacao);
            this.Controls.Add(this.gb_NovoCliente);
            this.Controls.Add(this.mtb_Valor);
            this.Controls.Add(this.mtb_Cep);
            this.Controls.Add(this.mtb_Telefone);
            this.Controls.Add(this.lv_Relatorio);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.tb_Sobrenome);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "JanelaPrincipal";
            this.Text = "Relatório Básico de Vendas";
            this.Load += new System.EventHandler(this.JanelaPrincipal_Load);
            this.gb_NovoCliente.ResumeLayout(false);
            this.gb_NovoCliente.PerformLayout();
            this.gb_Anotacao.ResumeLayout(false);
            this.gb_Anotacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Sobrenome;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.ListView lv_Relatorio;
        private System.Windows.Forms.ColumnHeader cl_Id;
        private System.Windows.Forms.ColumnHeader cl_Nome;
        private System.Windows.Forms.ColumnHeader cl_Sobrenome;
        private System.Windows.Forms.ColumnHeader cl_Cep;
        private System.Windows.Forms.ColumnHeader cl_Telefone;
        private System.Windows.Forms.ColumnHeader cl_Status;
        private System.Windows.Forms.ColumnHeader cl_NovoCliente;
        private System.Windows.Forms.ColumnHeader cl_Valor;
        private System.Windows.Forms.ColumnHeader cl_Data;
        private System.Windows.Forms.ColumnHeader cl_Anotacoes;
        private System.Windows.Forms.MaskedTextBox mtb_Telefone;
        private System.Windows.Forms.MaskedTextBox mtb_Cep;
        private System.Windows.Forms.MaskedTextBox mtb_Valor;
        private System.Windows.Forms.GroupBox gb_NovoCliente;
        private System.Windows.Forms.RadioButton rb_Nao;
        private System.Windows.Forms.RadioButton rb_Sim;
        private System.Windows.Forms.GroupBox gb_Anotacao;
        private System.Windows.Forms.CheckBox cb_AvisoPrevio;
        private System.Windows.Forms.CheckBox cb_Condominio;
        private System.Windows.Forms.CheckBox cb_HComercial;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.DateTimePicker dtp_Date;
    }
}

