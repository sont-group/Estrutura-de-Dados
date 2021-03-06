﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.servicos.socialist
{
    public partial class UserControl_ChatEmpresa : UserControl
    {
        classes.Post post;
        classes.Empresa empresa;
        string tipo;

        public UserControl_ChatEmpresa(int postId, string tipo)
        {       
            InitializeComponent();
            this.tipo = tipo;
            this.post = classes.PostList.thisSelectId(postId);
            empresa = classes.ListaEmpresa.ForCpf(this.post.Cpf);
        }

        private void UserControl_ChatEmpresa_Load(object sender, EventArgs e)
        {
            pb_icone.ImageLocation = post.Image;
            lb_servico.Text += post.Titulo;
            lb_empresa.Text += empresa.NomeFantasia;
            //lb_status.Text += "Em Beta!";
        }

        private void Button1_Click(object sender, EventArgs e)
        {

                                         
        }

        private void UserControl_ChatEmpresa_Click(object sender, EventArgs e)
        {
            FormPrincipal.MudarForm("servicos", new socialist.FormSociaListUser(post.Id));
        }
    }
}
