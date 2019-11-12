﻿namespace Pont_Finder.servicos
{
    partial class PostCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostCard));
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.bt_obter = new System.Windows.Forms.Button();
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_like = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(13, 180);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(35, 13);
            this.lb_data.TabIndex = 30;
            this.lb_data.Text = "label1";
            this.lb_data.Click += new System.EventHandler(this.Lb_data_Click);
            // 
            // lb_descricao
            // 
            this.lb_descricao.BackColor = System.Drawing.Color.White;
            this.lb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_descricao.Location = new System.Drawing.Point(220, 25);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(250, 150);
            this.lb_descricao.TabIndex = 29;
            this.lb_descricao.Text = "descricao";
            this.lb_descricao.Click += new System.EventHandler(this.Lb_descricao_Click);
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_down.BackgroundImage")));
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.downgrey;
            this.pb_down.Location = new System.Drawing.Point(476, 81);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(25, 25);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 28;
            this.pb_down.TabStop = false;
            this.pb_down.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_up.BackgroundImage")));
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.upgrey;
            this.pb_up.Location = new System.Drawing.Point(476, 32);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(25, 25);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 27;
            this.pb_up.TabStop = false;
            this.pb_up.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(563, 65);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(27, 13);
            this.lb_username.TabIndex = 25;
            this.lb_username.Text = "user";
            // 
            // pb_user
            // 
            this.pb_user.Location = new System.Drawing.Point(552, 12);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(50, 50);
            this.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_user.TabIndex = 24;
            this.pb_user.TabStop = false;
            // 
            // bt_obter
            // 
            this.bt_obter.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_obter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bt_obter.ForeColor = System.Drawing.Color.White;
            this.bt_obter.Location = new System.Drawing.Point(476, 141);
            this.bt_obter.Name = "bt_obter";
            this.bt_obter.Size = new System.Drawing.Size(127, 32);
            this.bt_obter.TabIndex = 23;
            this.bt_obter.Text = "Visualizar";
            this.bt_obter.UseVisualStyleBackColor = false;
            this.bt_obter.Click += new System.EventHandler(this.bt_obter_Click);
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.ForeColor = System.Drawing.Color.Green;
            this.lb_valor.Location = new System.Drawing.Point(476, 109);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(55, 26);
            this.lb_valor.TabIndex = 22;
            this.lb_valor.Text = "valor";
            this.lb_valor.Click += new System.EventHandler(this.valor_Click);
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_like.Location = new System.Drawing.Point(482, 62);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(12, 14);
            this.lb_like.TabIndex = 20;
            this.lb_like.Text = "L";
            this.lb_like.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(12, 3);
            this.lb_titulo.MaximumSize = new System.Drawing.Size(500, 20);
            this.lb_titulo.MinimumSize = new System.Drawing.Size(500, 20);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(500, 20);
            this.lb_titulo.TabIndex = 15;
            this.lb_titulo.Text = "titulo";
            this.lb_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_titulo.Click += new System.EventHandler(this.lb_titulo_Click);
            // 
            // pb_icone
            // 
            this.pb_icone.Location = new System.Drawing.Point(13, 25);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(200, 150);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 14;
            this.pb_icone.TabStop = false;
            this.pb_icone.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // PostCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_descricao);
            this.Controls.Add(this.pb_down);
            this.Controls.Add(this.pb_icone);
            this.Controls.Add(this.pb_up);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_like);
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.bt_obter);
            this.Name = "PostCard";
            this.Size = new System.Drawing.Size(625, 196);
            this.Load += new System.EventHandler(this.PostCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.Button bt_obter;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.Label lb_data;
    }
}
