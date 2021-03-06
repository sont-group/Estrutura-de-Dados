﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos
{
    public partial class PerfilEmpresa : Form
    {
        classes.Empresa empresa;
        Form anterior;

        public PerfilEmpresa(long cpf, Form anterior)
        {
            this.anterior = anterior;
            empresa = classes.ListaEmpresa.thisForCpf(cpf);

            InitializeComponent();

            if (Session.Online)
            {
                if (empresa.Cpf == Session.Cpf)
                    panel_botoes.Visible = true;
                else
                    panel_botoes.Visible = false;
            }
            else
            {
                panel_botoes.Visible = false;
            }

            pb_icone.ImageLocation = empresa.Image;
            lb_fantasia.Text = empresa.NomeFantasia;

            pb_capa.ImageLocation = empresa.ImageCapa;


            
            if (empresa.Slogan.Trim().Length < 10)
                painel_slogan.Visible = false;
            else
                lb_slogan.Text = empresa.Slogan;

            if (empresa.Sobre.Trim().Length < 10)
                painel_sobre.Visible = false;
            else
                lb_sobre.Text = empresa.Sobre;

            if (empresa.Descricao.Trim().Length < 10)
                painel_descricao.Visible = false;
            else
                lb_descricao.Text = empresa.Descricao;


            if (empresa.PoliticaPrivacidade.Trim().Length < 10)
                painel_termos.Visible = false;
            else
                lb_privacidade.Text = empresa.PoliticaPrivacidade;

            lb_categoria.Text = empresa.Categoria;
            lb_email.Text = empresa.Email;
            lb_endereco.Text = empresa.Endereco;
            lb_telefone.Text = empresa.Telefone;
            lb_site.Text = empresa.Site;




        }

        private void NomeFantasia_Click(object sender, EventArgs e)
        {

        }

        private void DescricaoEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Setor_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormServicos());
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Endereço_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormEditarPerfil(anterior));
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void PerfilEmpresa_Load(object sender, EventArgs e)
        {
            panel_detalhes.Height = panel_dentro.Height;
        }

        private void Lb_slogan_Click(object sender, EventArgs e)
        {

        }

        private void PolPrivacidade_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (Session.Online)
                FormPrincipal.MudarForm("servicos", new FormUserCards(new PerfilEmpresa(empresa.Cpf, anterior)));
            else
                MessageBox.Show("É necessário estar logado para gerenciar serviços");
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_mensagens_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new socialist.FormSociaListEmpresa(-1, -1));
        }

        private void Bt_solicitados_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new FormSolicitadosEmpresa());
        }

        private void Btn_back_Click_1(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", anterior);
        }

        private void Btn_back_MouseEnter(object sender, EventArgs e)
        {
            btn_back.Image = Model.Img_Voltar_Click;
        }

        private void Btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Model.Img_Voltar;
        }
    }
}
