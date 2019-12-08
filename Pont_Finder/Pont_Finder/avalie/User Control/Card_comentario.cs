﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.avalie.User_Control
{
    public partial class Card_comentario : UserControl
    {

        private classes.Comentario post;
        Bitmap imgLike = new Bitmap("..\\..\\Resources\\servicos\\like\\Like_null.png");
        Bitmap imgDeslike = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_null.png");
        Bitmap imgLikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\like.png");
        Bitmap imgDeslikeBlue = new Bitmap("..\\..\\Resources\\servicos\\like\\Deslike_blue.png");

        public Card_comentario(long postid)
        {
            InitializeComponent();
            post = classes.ComentariosList.PosterId(postid);

            
            
            datapost.Text = (post.Data);
            nome.Text = (post.Username);
            imagem.ImageLocation = (post.ImgUser);
            comentarios.Text = post.Comment;


            lb_like.Text = this.post.Joinha + "";
            lb_deslike.Text = this.post.DeJoinha + "";



            pb_up.Image = imgLike;
            pb_down.Image = imgDeslike;

            if (Session.Online)
            {
                long userlike = this.post.userLike(Session.Cpf);

                if (userlike == 1)
                    pb_up.Image = imgLikeBlue;
                else if (userlike == -1)
                    pb_down.Image = imgDeslikeBlue;
            }


           

            if (Session.Cpf == post.UserCpf)
            {
                bt_editar.Visible = true;
            }
            else
            {
                bt_editar.Visible = false;
            }

           

            if (Session.Cpf == post.UserCpf)
            {
                bt_remover.Visible = true;
            }
            else
            {
                bt_remover.Visible = false;
            }


        }

        private void lb_comentario_Click(object sender, EventArgs e)
        {

        }

        private void pb_up_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                if (pb_up.Image == imgLikeBlue)
                {
                    post.like(0, Session.Cpf);
                    pb_up.Image = imgLike;
                    pb_down.Image = imgDeslike;
                }
                else
                {
                    post.like(1, Session.Cpf);
                    pb_up.Image = imgLikeBlue;
                    pb_down.Image = imgDeslike;
                }
                lb_like.Text = "" + post.Joinha;
                lb_deslike.Text = "" + post.DeJoinha;

            }
            else
            {
                MessageBox.Show("É necessário estar logado para avaliar");
            }
        }

        private void pb_down_Click(object sender, EventArgs e)
        {

            if (Session.Online)
            {
                if (pb_down.Image == imgDeslikeBlue)
                {
                    post.like(0, Session.Cpf);
                    pb_down.Image = imgDeslike;
                    pb_up.Image = imgLike;
                }
                else
                {
                    post.like(-1, Session.Cpf);
                    pb_down.Image = imgDeslikeBlue;
                    pb_up.Image = imgLike;
                }
                lb_like.Text = "" + post.Joinha;
                lb_deslike.Text = "" + post.DeJoinha;
            }
            else
            {
                MessageBox.Show("É necessário estar logado para avaliar");
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {



        }

        private void bt_remover_Click(object sender, EventArgs e)
        {

        }
    }
}
