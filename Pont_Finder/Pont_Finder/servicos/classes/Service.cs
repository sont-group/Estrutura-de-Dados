﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.servicos
{
    class Service
    {
        private int id;
        private string tipo;
        private double valor;
        private string detalhes;
        private int sugestoes;
        private int visualizacoes;
        private int like;
        private short avaliacao;
        private bool ativo;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Detalhes
        {
            get { return detalhes; }
            set { detalhes = value; }
        }

        public int Sugestoes
        {
            get { return sugestoes; }
            set { sugestoes = value; }
        }

        public int Visualizacoes
        {
            get { return visualizacoes; }
            set { visualizacoes = value; }
        }

        public int Like
        {
            get { return like; }
            set { like = value; }
        }

        public short Avaliacao
        {
            get { return avaliacao; }
            set { avaliacao = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

    }
}