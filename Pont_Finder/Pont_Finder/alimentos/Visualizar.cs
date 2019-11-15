﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.alimentos
{
    public partial class Visualizar : Form
    {
        private string nomeFantasia, Emprua, Empbairro;
        private List<string> Empcategoria;
        private int numero, Empcep, Empcontato;
        public Visualizar(string fantasia, string Rua, string Bairro, List<string> Categorias, int Num, int Cep, int Contato)
        {
            nomeFantasia = fantasia;
            Emprua = Rua;
            Empbairro = Bairro;
            Empcategoria = Categorias;
            numero = Num;
            Empcep = Cep;
            Empcontato = Contato;            
            InitializeComponent();
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Visualizar_Paint(object sender, PaintEventArgs e)
        {
            lbRestaurante.Text = nomeFantasia;
            lbRua.Text = Emprua;
            lbBairro.Text = Empbairro;
            lbNum.Text = numero.ToString();
            lbCep.Text = Empcep.ToString();
            lbContato.Text = Empcontato.ToString();
            foreach (var item in Empcategoria)
            {
                if (Empcategoria.IndexOf(item) == 0)
                {
                    lbCategorias.Text = item;
                }
                else
                {
                    lbCategorias.Text += " / " + item;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Visualizar_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
