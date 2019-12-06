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
    public partial class FormSolicitados : Form
    {
        public FormSolicitados()
        {
            InitializeComponent();
        }

        private void Visualizar_Solicitado_User_Load(object sender, EventArgs e)
        {
            int y = 5;
            int i = 0;
            foreach (var item in classes.SolicitadoList.Solicitados)
            {
                if (item.Usercpf == Session.Cpf)
                {
                    User_control.ControlSolicitados a = new User_control.ControlSolicitados(item.Id);
                    a.Location = new Point(5, y);
                    y = y + a.Height + 5;
                    painel.Controls.Add(a);
                    i++;
                }
            }


        }

        private void Painel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
