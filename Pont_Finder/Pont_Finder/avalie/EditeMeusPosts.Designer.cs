﻿namespace Pont_Finder.avalie
{
    partial class EditeMeusPosts
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_hora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NomePos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_remover = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.bt_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.RadioButton();
            this.nr = new System.Windows.Forms.RadioButton();
            this.cb_pro = new System.Windows.Forms.ComboBox();
            this.tb_loc = new System.Windows.Forms.TextBox();
            this.tb_des = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-76, -327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(10, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lb_hora.Location = new System.Drawing.Point(186, 335);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(32, 13);
            this.lb_hora.TabIndex = 82;
            this.lb_hora.Text = "hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Descrição";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lb_data.Location = new System.Drawing.Point(65, 335);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(115, 13);
            this.lb_data.TabIndex = 84;
            this.lb_data.Text = "Data da Postagem:";
            // 
            // pb_icone
            // 
            this.pb_icone.Location = new System.Drawing.Point(68, 41);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(263, 251);
            this.pb_icone.TabIndex = 76;
            this.pb_icone.TabStop = false;
            this.pb_icone.Click += new System.EventHandler(this.pb_icone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Localização";
            // 
            // NomePos
            // 
            this.NomePos.AutoSize = true;
            this.NomePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePos.Location = new System.Drawing.Point(-60, 42);
            this.NomePos.Name = "NomePos";
            this.NomePos.Size = new System.Drawing.Size(51, 16);
            this.NomePos.TabIndex = 83;
            this.NomePos.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Tipo do Problema";
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.ForeColor = System.Drawing.Color.White;
            this.bt_remover.Location = new System.Drawing.Point(665, 327);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(86, 28);
            this.bt_remover.TabIndex = 96;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click_1);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(806, 10);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 14;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(283, 304);
            this.gMapControl1.TabIndex = 85;
            this.gMapControl1.Zoom = 14D;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(357, 327);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(86, 28);
            this.bt_editar.TabIndex = 97;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-59, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Postagem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "label4";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.r);
            this.panel5.Controls.Add(this.nr);
            this.panel5.Controls.Add(this.cb_pro);
            this.panel5.Controls.Add(this.tb_loc);
            this.panel5.Controls.Add(this.tb_des);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.bt_editar);
            this.panel5.Controls.Add(this.gMapControl1);
            this.panel5.Controls.Add(this.bt_remover);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.NomePos);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pb_icone);
            this.panel5.Controls.Add(this.lb_data);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lb_hora);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1199, 561);
            this.panel5.TabIndex = 95;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint_1);
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Location = new System.Drawing.Point(259, 298);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(72, 17);
            this.r.TabIndex = 105;
            this.r.TabStop = true;
            this.r.Text = "Resolvido";
            this.r.UseVisualStyleBackColor = true;
            // 
            // nr
            // 
            this.nr.AutoSize = true;
            this.nr.Location = new System.Drawing.Point(68, 297);
            this.nr.Name = "nr";
            this.nr.Size = new System.Drawing.Size(95, 17);
            this.nr.TabIndex = 104;
            this.nr.TabStop = true;
            this.nr.Text = "Não Resolvido";
            this.nr.UseVisualStyleBackColor = true;
            // 
            // cb_pro
            // 
            this.cb_pro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pro.FormattingEnabled = true;
            this.cb_pro.Items.AddRange(new object[] {
            "Infraestrutura",
            "Serviços",
            "Outros"});
            this.cb_pro.Location = new System.Drawing.Point(357, 41);
            this.cb_pro.Name = "cb_pro";
            this.cb_pro.Size = new System.Drawing.Size(394, 28);
            this.cb_pro.TabIndex = 103;
            // 
            // tb_loc
            // 
            this.tb_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loc.Location = new System.Drawing.Point(357, 99);
            this.tb_loc.Name = "tb_loc";
            this.tb_loc.Size = new System.Drawing.Size(394, 26);
            this.tb_loc.TabIndex = 101;
            // 
            // tb_des
            // 
            this.tb_des.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_des.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_des.Location = new System.Drawing.Point(357, 173);
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(394, 119);
            this.tb_des.TabIndex = 102;
            this.tb_des.Text = "";
            // 
            // EditeMeusPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(950, 556);
            this.Name = "EditeMeusPosts";
            this.Text = "EditeMeusPosts";
            this.Load += new System.EventHandler(this.EditeMeusPosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NomePos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_remover;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cb_pro;
        private System.Windows.Forms.TextBox tb_loc;
        private System.Windows.Forms.RichTextBox tb_des;
        private System.Windows.Forms.RadioButton r;
        private System.Windows.Forms.RadioButton nr;
    }
}