﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.eventos.classes
{
    class CaEmpresa
    {
        public string nome;
        public string nome_fantasia;
        public string email;
        public long cnpj;
        public string telefone;
        public string endereco;
        public string modulo;
        public bool ativo;
       
        public string Nome
        {
            get {return nome; }
            set {nome = value;}
        }

        public string Nome_Fantasia
        {
            get { return nome_fantasia; }
            set { nome_fantasia = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        
        public long Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

    }
}
