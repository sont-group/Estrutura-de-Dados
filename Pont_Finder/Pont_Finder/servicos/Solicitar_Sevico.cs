﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class Solicitar_Sevico : Form
    {
        Form anterior;
        classes.Post post;

        bool img = false;
     
        

        public Solicitar_Sevico(int postid, Form anterior)
        {
            post = classes.PostList.thisForId(postid);
            this.anterior = anterior;
            InitializeComponent();

            if (post.Valor == 0)
            {
                painel_pagamento.Visible = false;
                
            }
            
        }

        private void Bt_continuar_Click(object sender, EventArgs e)
        {      
        }

        private void Solicitar_Sevico_Load(object sender, EventArgs e)
        {

        }

        private void tbBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_solicitar_Click(object sender, EventArgs e)
        {
            

            if (tb_rua.Text.Length < 5)
                MessageBox.Show("O campo Rua não foi preenchido corretamente");
            else if (tb_bairro.Text.Length < 5)
                MessageBox.Show("O campo Bairro não foi preenchido corretamente");
            else if (tb_cep.Text.Length < 8)
                MessageBox.Show("O campo Cep não foi preenchido corretamente");
            else if (tb_descricao.Text.Length < 10)
                MessageBox.Show("O campo Descrição não foi preenchido corretamente");
            else if (post.Valor != 0 && (!rb_cartao.Checked) && (!rb_boleto.Checked))
            {
                MessageBox.Show("Escolha a forma de Pagamento");
            }
            else
            {
                classes.Solicitado solicitado = new classes.Solicitado();

                int id = classes.SolicitadoList.Solicitados.Count;
                string link = null;
                if (img)
                {
                    if (!Directory.Exists("..//..//servicos//data//images//solicitados"))
                        Directory.CreateDirectory("..//..//servicos//data//images//solicitados");

                    pb_icone.Load();
                    pb_icone.Image = Image.FromFile(openIcone.FileName);

                    Image bmp = new Bitmap(pb_icone.Image);

                    Image bmp2 = new Bitmap(bmp, pb_icone.Size);

                    pb_icone.Image = bmp2;

                    link = "..//..//servicos//data//images//solicitados//" + id + ".jpg";
                    pb_icone.Image.Save(link, ImageFormat.Jpeg);
                    solicitado.Imagem = link;
                }
                else
                {
                    solicitado.Imagem = Model.offimage_link;
                }

                solicitado.Id = id;
                solicitado.Status = "Aguardando Pagamento";

                solicitado.Rua = tb_rua.Text;
                solicitado.Bairro = tb_bairro.Text;
                solicitado.Numero = int.Parse("" + tb_numero.Value);
                solicitado.Cep = int.Parse(tb_cep.Text);
                solicitado.Descrição = tb_descricao.Text;
                solicitado.DataAgendada = tb_data.Value;

                solicitado.DataSolicitacao = DateTime.Now;

                solicitado.Usercpf = Session.Cpf;
                solicitado.Postid = post.Id;


                if (rb_boleto.Checked)
                {
                    Boleto.GerarBoleto bol = new Boleto.GerarBoleto(Session.Cpf, post.Valor);
                    bol.ShowDialog();
                    Session.Termos = true;
                }
                else if(rb_cartao.Checked)
                {
                    Boleto.Cartao card = new Boleto.Cartao();
                    card.ShowDialog();
                }
                else
                {
                    classes.SolicitadoList.Solicitados.Add(solicitado);
                    FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, new FormServicos()));
                }

                if (Session.Termos)
                {
                    classes.SolicitadoList.Solicitados.Add(solicitado);
                    FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, new FormServicos()));
                }

                
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, new FormServicos()));
        }

        private void Bt_icone_Click(object sender, EventArgs e)
        {
            if (openIcone.ShowDialog() == DialogResult.OK)
            {
                pb_icone.ImageLocation = openIcone.FileName;
                pb_icone.Load();
                img = true;
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormVisualizarPost(post.Id, new FormServicos()));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tb_rua.Text != "")
            {
                Mapa.Mapa map = new Mapa.Mapa(tb_rua.Text);
                map.ShowDialog();
            }
            else
            {
                MessageBox.Show("Caixa localização não preenchida");
            }
        }
    }
}
