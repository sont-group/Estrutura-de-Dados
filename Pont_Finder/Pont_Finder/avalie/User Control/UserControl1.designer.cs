﻿namespace Pont_Finder.avalie
{
    partial class UserControl1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userboxdesc = new System.Windows.Forms.TextBox();
            this.userboxlocalizacao = new System.Windows.Forms.TextBox();
            this.userboxproblema = new System.Windows.Forms.TextBox();
            this.userhora = new System.Windows.Forms.Label();
            this.NomePos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_obter = new System.Windows.Forms.Button();
            this.checado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_editar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_deslike = new System.Windows.Forms.Label();
            this.lb_like = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.imagemuser = new Pont_Finder.classes.CircularPicBox();
            ((System.ComponentModel.ISupportInitialize)(this.checado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemuser)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(218, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Localização";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(218, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(218, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo do Problema";
            // 
            // userboxdesc
            // 
            this.userboxdesc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userboxdesc.Enabled = false;
            this.userboxdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userboxdesc.Location = new System.Drawing.Point(221, 176);
            this.userboxdesc.Multiline = true;
            this.userboxdesc.Name = "userboxdesc";
            this.userboxdesc.ReadOnly = true;
            this.userboxdesc.Size = new System.Drawing.Size(262, 50);
            this.userboxdesc.TabIndex = 2;
            // 
            // userboxlocalizacao
            // 
            this.userboxlocalizacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userboxlocalizacao.Enabled = false;
            this.userboxlocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userboxlocalizacao.Location = new System.Drawing.Point(221, 135);
            this.userboxlocalizacao.Name = "userboxlocalizacao";
            this.userboxlocalizacao.ReadOnly = true;
            this.userboxlocalizacao.Size = new System.Drawing.Size(262, 20);
            this.userboxlocalizacao.TabIndex = 1;
            // 
            // userboxproblema
            // 
            this.userboxproblema.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userboxproblema.Enabled = false;
            this.userboxproblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userboxproblema.Location = new System.Drawing.Point(221, 92);
            this.userboxproblema.Name = "userboxproblema";
            this.userboxproblema.ReadOnly = true;
            this.userboxproblema.Size = new System.Drawing.Size(259, 20);
            this.userboxproblema.TabIndex = 0;
            // 
            // userhora
            // 
            this.userhora.AutoSize = true;
            this.userhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.userhora.ForeColor = System.Drawing.Color.White;
            this.userhora.Location = new System.Drawing.Point(173, 46);
            this.userhora.Name = "userhora";
            this.userhora.Size = new System.Drawing.Size(41, 13);
            this.userhora.TabIndex = 6;
            this.userhora.Text = "label4";
            this.userhora.Click += new System.EventHandler(this.userhora_Click);
            // 
            // NomePos
            // 
            this.NomePos.AutoSize = true;
            this.NomePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.NomePos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NomePos.Location = new System.Drawing.Point(71, 5);
            this.NomePos.Name = "NomePos";
            this.NomePos.Size = new System.Drawing.Size(41, 13);
            this.NomePos.TabIndex = 6;
            this.NomePos.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Postagem:";
            // 
            // bt_obter
            // 
            this.bt_obter.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_obter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bt_obter.ForeColor = System.Drawing.Color.White;
            this.bt_obter.Location = new System.Drawing.Point(489, 200);
            this.bt_obter.Margin = new System.Windows.Forms.Padding(15);
            this.bt_obter.Name = "bt_obter";
            this.bt_obter.Size = new System.Drawing.Size(127, 28);
            this.bt_obter.TabIndex = 24;
            this.bt_obter.Text = "Visualizar";
            this.bt_obter.UseVisualStyleBackColor = false;
            this.bt_obter.Click += new System.EventHandler(this.bt_obter_Click);
            // 
            // checado
            // 
            this.checado.BackColor = System.Drawing.Color.Transparent;
            this.checado.Image = global::Pont_Finder.Properties.Resources.Checked_icon;
            this.checado.Location = new System.Drawing.Point(588, 5);
            this.checado.Name = "checado";
            this.checado.Size = new System.Drawing.Size(27, 28);
            this.checado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checado.TabIndex = 25;
            this.checado.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(422, 5);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(127, 28);
            this.bt_editar.TabIndex = 98;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Visible = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_editar);
            this.panel1.Controls.Add(this.imagemuser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.userhora);
            this.panel1.Controls.Add(this.checado);
            this.panel1.Controls.Add(this.NomePos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 70);
            this.panel1.TabIndex = 100;
            // 
            // lb_deslike
            // 
            this.lb_deslike.AutoSize = true;
            this.lb_deslike.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deslike.Location = new System.Drawing.Point(553, 157);
            this.lb_deslike.Name = "lb_deslike";
            this.lb_deslike.Size = new System.Drawing.Size(15, 16);
            this.lb_deslike.TabIndex = 104;
            this.lb_deslike.Text = "0";
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_like.Location = new System.Drawing.Point(553, 80);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(15, 16);
            this.lb_like.TabIndex = 101;
            this.lb_like.Text = "0";
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.Location = new System.Drawing.Point(501, 157);
            this.pb_down.Margin = new System.Windows.Forms.Padding(15);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(37, 32);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 103;
            this.pb_down.TabStop = false;
            this.pb_down.Click += new System.EventHandler(this.pb_down_Click);
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.Location = new System.Drawing.Point(501, 80);
            this.pb_up.Margin = new System.Windows.Forms.Padding(15);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(37, 32);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 102;
            this.pb_up.TabStop = false;
            this.pb_up.Click += new System.EventHandler(this.pb_up_Click);
            // 
            // imagemuser
            // 
            this.imagemuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemuser.Location = new System.Drawing.Point(5, 2);
            this.imagemuser.Name = "imagemuser";
            this.imagemuser.Size = new System.Drawing.Size(57, 57);
            this.imagemuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemuser.TabIndex = 101;
            this.imagemuser.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_like);
            this.Controls.Add(this.lb_deslike);
            this.Controls.Add(this.bt_obter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_up);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_down);
            this.Controls.Add(this.userboxdesc);
            this.Controls.Add(this.userboxlocalizacao);
            this.Controls.Add(this.userboxproblema);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(626, 243);
            ((System.ComponentModel.ISupportInitialize)(this.checado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userboxdesc;
        private System.Windows.Forms.TextBox userboxlocalizacao;
        private System.Windows.Forms.TextBox userboxproblema;
        private System.Windows.Forms.Label NomePos;
        private System.Windows.Forms.Label userhora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_obter;
        private System.Windows.Forms.PictureBox checado;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.Label lb_deslike;
        private Pont_Finder.classes.CircularPicBox imagemuser;
    }
}
