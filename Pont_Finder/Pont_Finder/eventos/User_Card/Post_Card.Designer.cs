﻿namespace Pont_Finder.eventos
{
    partial class Post_Card
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_ingressos = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_local = new System.Windows.Forms.Label();
            this.lb_classifica = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_horario = new System.Windows.Forms.Label();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.lb_like = new System.Windows.Forms.Label();
            this.lb_deslike = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.lb_valor.Location = new System.Drawing.Point(557, 45);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(44, 54);
            this.lb_valor.TabIndex = 11;
            this.lb_valor.Text = "V";
            // 
            // lb_ingressos
            // 
            this.lb_ingressos.AutoSize = true;
            this.lb_ingressos.BackColor = System.Drawing.Color.Transparent;
            this.lb_ingressos.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ingressos.ForeColor = System.Drawing.Color.Blue;
            this.lb_ingressos.Location = new System.Drawing.Point(333, 63);
            this.lb_ingressos.Name = "lb_ingressos";
            this.lb_ingressos.Size = new System.Drawing.Size(19, 25);
            this.lb_ingressos.TabIndex = 9;
            this.lb_ingressos.Text = "v";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(193, 0);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(63, 32);
            this.lb_nome.TabIndex = 8;
            this.lb_nome.Text = "Nome";
            // 
            // pb_imagem
            // 
            this.pb_imagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_imagem.Location = new System.Drawing.Point(22, 14);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(150, 125);
            this.pb_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagem.TabIndex = 7;
            this.pb_imagem.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(501, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 54);
            this.label1.TabIndex = 14;
            this.label1.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(195, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingressos disponíveis:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data:";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(231, 96);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(21, 25);
            this.lb_data.TabIndex = 18;
            this.lb_data.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Categoria:";
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoria.Location = new System.Drawing.Point(262, 33);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(19, 25);
            this.lb_categoria.TabIndex = 12;
            this.lb_categoria.Text = "v";
            this.lb_categoria.Click += new System.EventHandler(this.Lb_categoria_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor do Ingresso";
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_visualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_visualizar.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_visualizar.ForeColor = System.Drawing.Color.White;
            this.bt_visualizar.Location = new System.Drawing.Point(501, 113);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(110, 34);
            this.bt_visualizar.TabIndex = 29;
            this.bt_visualizar.Text = "Visualizar";
            this.bt_visualizar.UseVisualStyleBackColor = false;
            this.bt_visualizar.Click += new System.EventHandler(this.Bt_visualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Local:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Classificação:";
            // 
            // lb_local
            // 
            this.lb_local.AutoSize = true;
            this.lb_local.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_local.Location = new System.Drawing.Point(401, 28);
            this.lb_local.Name = "lb_local";
            this.lb_local.Size = new System.Drawing.Size(19, 25);
            this.lb_local.TabIndex = 32;
            this.lb_local.Text = "v";
            // 
            // lb_classifica
            // 
            this.lb_classifica.AutoSize = true;
            this.lb_classifica.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_classifica.Location = new System.Drawing.Point(441, 97);
            this.lb_classifica.Name = "lb_classifica";
            this.lb_classifica.Size = new System.Drawing.Size(19, 25);
            this.lb_classifica.TabIndex = 33;
            this.lb_classifica.Text = "v";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Horario:";
            // 
            // lb_horario
            // 
            this.lb_horario.AutoSize = true;
            this.lb_horario.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_horario.Location = new System.Drawing.Point(416, 63);
            this.lb_horario.Name = "lb_horario";
            this.lb_horario.Size = new System.Drawing.Size(19, 25);
            this.lb_horario.TabIndex = 35;
            this.lb_horario.Text = "v";
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.Location = new System.Drawing.Point(200, 122);
            this.pb_up.Margin = new System.Windows.Forms.Padding(15);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(25, 25);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 56;
            this.pb_up.TabStop = false;
            this.pb_up.Click += new System.EventHandler(this.Pb_up_Click);
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_like.Location = new System.Drawing.Point(243, 131);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(15, 16);
            this.lb_like.TabIndex = 55;
            this.lb_like.Text = "0";
            // 
            // lb_deslike
            // 
            this.lb_deslike.AutoSize = true;
            this.lb_deslike.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deslike.Location = new System.Drawing.Point(310, 131);
            this.lb_deslike.Name = "lb_deslike";
            this.lb_deslike.Size = new System.Drawing.Size(15, 16);
            this.lb_deslike.TabIndex = 58;
            this.lb_deslike.Text = "0";
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.Location = new System.Drawing.Point(267, 122);
            this.pb_down.Margin = new System.Windows.Forms.Padding(15);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(25, 25);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 57;
            this.pb_down.TabStop = false;
            this.pb_down.Click += new System.EventHandler(this.Pb_down_Click);
            // 
            // Post_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_deslike);
            this.Controls.Add(this.pb_down);
            this.Controls.Add(this.pb_up);
            this.Controls.Add(this.lb_like);
            this.Controls.Add(this.lb_horario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_classifica);
            this.Controls.Add(this.lb_local);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.lb_ingressos);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.pb_imagem);
            this.Name = "Post_Card";
            this.Size = new System.Drawing.Size(623, 158);
            this.Load += new System.EventHandler(this.Post_Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_ingressos;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.PictureBox pb_imagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_visualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_local;
        private System.Windows.Forms.Label lb_classifica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_horario;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.Label lb_deslike;
        private System.Windows.Forms.PictureBox pb_down;
    }
}
