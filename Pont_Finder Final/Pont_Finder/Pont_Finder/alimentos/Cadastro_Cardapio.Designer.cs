﻿namespace Pont_Finder.alimentos
{
    partial class Cadastro_Cardapio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Cardapio));
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.pb_img_1 = new System.Windows.Forms.PictureBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.input_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_qtdprato = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddIngrediente = new System.Windows.Forms.Button();
            this.inputIngrediente = new System.Windows.Forms.TextBox();
            this.Ingredientes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(259, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 38);
            this.label7.TabIndex = 32;
            this.label7.Text = "Informe os dados do prato!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(389, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 51);
            this.button1.TabIndex = 31;
            this.button1.Text = "Adicionar Foto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(240, 585);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(415, 24);
            this.tb_nome.TabIndex = 0;
            this.tb_nome.TextChanged += new System.EventHandler(this.Tb_nome_TextChanged);
            // 
            // pb_img_1
            // 
            this.pb_img_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_img_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_img_1.InitialImage")));
            this.pb_img_1.Location = new System.Drawing.Point(228, 216);
            this.pb_img_1.Name = "pb_img_1";
            this.pb_img_1.Size = new System.Drawing.Size(450, 225);
            this.pb_img_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img_1.TabIndex = 30;
            this.pb_img_1.TabStop = false;
            this.pb_img_1.Click += new System.EventHandler(this.Pb_img_1_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.ForeColor = System.Drawing.Color.White;
            this.bt_cadastrar.Location = new System.Drawing.Point(289, 1104);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(300, 50);
            this.bt_cadastrar.TabIndex = 6;
            this.bt_cadastrar.Text = "Cadastrar Prato";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.Bt_cadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 1000);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Informe o valor do prato:";
            // 
            // input_valor
            // 
            this.input_valor.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_valor.Location = new System.Drawing.Point(349, 1035);
            this.input_valor.Name = "input_valor";
            this.input_valor.Size = new System.Drawing.Size(200, 27);
            this.input_valor.TabIndex = 4;
            this.input_valor.TextChanged += new System.EventHandler(this.Input_valor_TextChanged);
            this.input_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_valor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Informe a quantidade servida(kg): ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 1038);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "R$";
            // 
            // tb_qtdprato
            // 
            this.tb_qtdprato.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qtdprato.Location = new System.Drawing.Point(343, 689);
            this.tb_qtdprato.Name = "tb_qtdprato";
            this.tb_qtdprato.Size = new System.Drawing.Size(200, 27);
            this.tb_qtdprato.TabIndex = 2;
            this.tb_qtdprato.TextChanged += new System.EventHandler(this.Tb_qtdprato_TextChanged);
            this.tb_qtdprato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qtdprato_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 100);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o nome do prato: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddIngrediente);
            this.panel2.Controls.Add(this.inputIngrediente);
            this.panel2.Controls.Add(this.Ingredientes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tb_nome);
            this.panel2.Controls.Add(this.pb_img_1);
            this.panel2.Controls.Add(this.bt_cadastrar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.input_valor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tb_qtdprato);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 1209);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // btnAddIngrediente
            // 
            this.btnAddIngrediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.btnAddIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngrediente.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngrediente.ForeColor = System.Drawing.Color.White;
            this.btnAddIngrediente.Location = new System.Drawing.Point(518, 771);
            this.btnAddIngrediente.Name = "btnAddIngrediente";
            this.btnAddIngrediente.Size = new System.Drawing.Size(109, 34);
            this.btnAddIngrediente.TabIndex = 39;
            this.btnAddIngrediente.Text = "Adicionar ";
            this.btnAddIngrediente.UseVisualStyleBackColor = false;
            this.btnAddIngrediente.Click += new System.EventHandler(this.BtnAddIngrediente_Click);
            // 
            // inputIngrediente
            // 
            this.inputIngrediente.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIngrediente.Location = new System.Drawing.Point(266, 775);
            this.inputIngrediente.Name = "inputIngrediente";
            this.inputIngrediente.Size = new System.Drawing.Size(200, 27);
            this.inputIngrediente.TabIndex = 38;
            this.inputIngrediente.TextChanged += new System.EventHandler(this.InputIngrediente_TextChanged);
            // 
            // Ingredientes
            // 
            this.Ingredientes.FormattingEnabled = true;
            this.Ingredientes.Location = new System.Drawing.Point(275, 849);
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.Size = new System.Drawing.Size(332, 121);
            this.Ingredientes.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 733);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Informe os ingredientes:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Location = new System.Drawing.Point(12, 24);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 64;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            // 
            // Cadastro_Cardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro_Cardapio";
            this.Text = "Cadastro_Cardapio";
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.PictureBox pb_img_1;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_qtdprato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Ingredientes;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.TextBox inputIngrediente;
        private System.Windows.Forms.Button btnAddIngrediente;
        private System.Windows.Forms.OpenFileDialog openIcone;
    }
}