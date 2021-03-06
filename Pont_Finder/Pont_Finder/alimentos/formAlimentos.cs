﻿using Pont_Finder.alimentos;
using Pont_Finder.alimentos.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder
{
    public partial class formAlimentos : Form
    {
        private int pagTotal;
        private int pagAtual;
        private int pagQuant;
        private int local, local1;
        private bool cat;
        private string filtro;
        private List<Company> lista = new List<Company>();
        private int result;
        public formAlimentos()
        {
            cat = false;
            local = 0;
            local1 = 42;
            pagQuant = 10;
            lista = CompanyList.selectAll();
            foreach (var item in CompanyList.selectAll())
            {
                EvaluationList.ApuraAvaliacao(item.Id);
            }
            InitializeComponent();
            if (Session.Online)
            {
                result = CompanyList.verifEmp(Session.Cpf);
                if(result != -1)
                {
                    Btn_Edit_Empresa.Visible = false;
                    btn_Config.Visible = true;
                    VerPedidos.Visible = true;
                }                
            }
            else btn_Config.Visible = false;
            Listar();            
        }

        private void FormAlimentos_Load(object sender, EventArgs e)
        {
            Propaganda_modulos prop = new Propaganda_modulos();
            prop.Location = new Point(5, 25);
            painel_propaganda.Controls.Add(prop);

            Propaganda_externa propexter = new Propaganda_externa();
            propexter.Location = new Point(5, 25);
            pn_propa_externa.Controls.Add(propexter);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            alimentos.Cadastro_Restaurante cadastrarestabele = new alimentos.Cadastro_Restaurante();
            FormPrincipal.MudarForm("alimentos", cadastrarestabele);

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            if (Categoria() == false)
            {
                if (PesquisaBox.Text.Equals(""))
                {
                    ListarEmpresas.Controls.Clear();
                    lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                    msg.Location = new Point(0, 0);
                    ListarEmpresas.Controls.Add(msg);
                }
                else
                {
                    lista = CompanyList.SearchName(PesquisaBox.Text);
                    ListarEmpresas.Controls.Clear();
                    local = 0;
                    foreach (var item in lista)
                    {
                        Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                        exbEmp.Location = new Point(0, local);
                        local = local + exbEmp.Height + 5;
                        ListarEmpresas.Controls.Add(exbEmp);
                    }
                }
            }
            else
            {
                if (PesquisaBox.Text.Equals(""))
                {
                    ListarEmpresas.Controls.Clear();
                    lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                    msg.Location = new Point(0, 0);
                    ListarEmpresas.Controls.Add(msg);
                }
                else
                {
                    lista = CompanyList.SearchFiltro(PesquisaBox.Text, Filtro());
                    ListarEmpresas.Controls.Clear();
                    local = 0;
                    foreach (var item in lista)
                    {
                        Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                        exbEmp.Location = new Point(0, local);
                        local = local + exbEmp.Height + 5;
                        ListarEmpresas.Controls.Add(exbEmp);
                    }
                }
            }            
        }
        public bool Categoria()
        {
            if (rbChurrascaria.Checked == false && rbPizzaria.Checked == false && rbPetiscaria.Checked == false && rbComidaItaliana.Checked == false && rbComidaJaponesa.Checked == false && rbSorveteria.Checked == false && rbHambúrgueria.Checked == false && rbFrutosDoMar.Checked == false && rbOutros.Checked == false)
            {
                cat = false;
            }
            else
            {
                cat = true;
            }
            return cat;
        }
        public string Filtro()
        {
            if (rbChurrascaria.Checked == true)
            {
                filtro = rbChurrascaria.Text;
            }
            else if(rbPetiscaria.Checked == true)
            {
                filtro = rbPetiscaria.Text;
            }
            else if(rbPizzaria.Checked == true)
            {
                filtro = rbPizzaria.Text;
            }
            else if(rbComidaItaliana.Checked == true)
            {
                filtro = rbComidaItaliana.Text;
            }
            else if(rbComidaJaponesa.Checked == true)
            {
                filtro = rbComidaJaponesa.Text;
            }
            else if(rbSorveteria.Checked == true)
            {
                filtro = rbSorveteria.Text;
            }
            else if(rbHambúrgueria.Checked == true)
            {
                filtro = rbHambúrgueria.Text;
            }
            else if(rbFrutosDoMar.Checked == true)
            {
                filtro = rbFrutosDoMar.Text;
            }
            else if (rbOutros.Checked == true)
            {
                filtro = rbOutros.Text;
            }
            return filtro;
        }

        private void Btn_Edit_Empresa_Click(object sender, EventArgs e)
        {
            if (Session.Online)
            {
                alimentos.Cadastro_Restaurante cadastrarestabele = new alimentos.Cadastro_Restaurante();
                FormPrincipal.MudarForm("alimentos", cadastrarestabele);
            }
            else
            {
                MessageBox.Show("É necessário estar logado para Cadastrar uma empresa. ", "Aviso");
            }            
        }

        private void pb_pesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PesquisaBox.Text))
            {
                MessageBox.Show("Por favor, informe o nome do estabelecimento.", "Aviso!");
            }
            else
            {
                if (Categoria() == false)
                {
                    if (PesquisaBox.Text.Equals(""))
                    {
                        ListarEmpresas.Controls.Clear();
                        lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                        msg.Location = new Point(0, 0);
                        ListarEmpresas.Controls.Add(msg);
                    }
                    else
                    {                        
                        lista = CompanyList.SearchName(PesquisaBox.Text);
                        if (lista.Count == 0)
                        {
                            ListarEmpresas.Controls.Clear();
                            lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                            msg.Location = new Point(0, 0);
                            ListarEmpresas.Controls.Add(msg);
                        }
                        else
                        {
                            ListarEmpresas.Controls.Clear();
                            local = 0;
                            foreach (var item in lista)
                            {
                                Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                                exbEmp.Location = new Point(0, local);
                                local = local + exbEmp.Height + 5;
                                ListarEmpresas.Controls.Add(exbEmp);
                            }
                        }
                    }
                }
                else
                {
                    if (PesquisaBox.Text.Equals(""))
                    {
                        ListarEmpresas.Controls.Clear();
                        lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                        msg.Location = new Point(0, 0);
                        ListarEmpresas.Controls.Add(msg);
                    }
                    else
                    {
                        lista = CompanyList.SearchFiltro(PesquisaBox.Text, Filtro());
                        ListarEmpresas.Controls.Clear();
                        local = 0;
                        foreach (var item in lista)
                        {
                            Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                            exbEmp.Location = new Point(0, local);
                            local = local + exbEmp.Height + 5;
                            ListarEmpresas.Controls.Add(exbEmp);
                        }
                    }
                }
            }            
        }

        private void Top5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RbChurrascaria_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbChurrascaria.Text;            
            if (EvaluationList.selectAll().Count != 0)
            {
                local1 = 42;
                Top5.Controls.Clear();
                foreach (var top in EvaluationList.TopList(CompanyList.SearchCategoria(rbChurrascaria.Text)))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
        }

        private void RbPizzaria_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbPizzaria.Text;            
            if (EvaluationList.selectAll().Count != 0)
            {
                local1 = 42;
                Top5.Controls.Clear();
                foreach (var top in EvaluationList.TopList(CompanyList.SearchCategoria(rbPizzaria.Text)))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
        }

        private void RbPetiscaria_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbPetiscaria.Text;            
            if (EvaluationList.selectAll().Count != 0)
            {
                Top5.Controls.Clear();
                local1 = 42;
                foreach (var top in EvaluationList.TopList(CompanyList.SearchCategoria(rbPetiscaria.Text)))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
        }

        private void RbComidaItaliana_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbComidaItaliana.Text;            
            if (EvaluationList.selectAll().Count != 0)
            {
                local1 = 42;
                Top5.Controls.Clear();
                foreach (var top in EvaluationList.TopList(CompanyList.SearchCategoria(rbComidaItaliana.Text)))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
        }

        private void RbComidaJaponesa_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbComidaJaponesa.Text;            
            if (EvaluationList.selectAll().Count != 0)
            {
                local1 = 42;
                Top5.Controls.Clear();
                foreach (var top in EvaluationList.TopList(CompanyList.SearchCategoria(rbComidaJaponesa.Text)))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
        }

        private void RbSorveteria_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbSorveteria.Text;            
            if (EvaluationList.selectAll().Count != 0)
            {
                local1 = 42;
                Top5.Controls.Clear();
                foreach (var top in EvaluationList.TopList(CompanyList.SearchCategoria(rbSorveteria.Text)))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
        }

        private void RbHambúrgueria_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbHambúrgueria.Text;            
            if (EvaluationList.selectAll().Count != 0)
            {
                local1 = 42;
                Top5.Controls.Clear();
                foreach (var top in EvaluationList.TopList(CompanyList.SearchCategoria(rbHambúrgueria.Text)))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
        }

        private void RbFrutosDoMar_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbFrutosDoMar.Text;            
            if (EvaluationList.selectAll().Count != 0)
            {
                local1 = 42;
                Top5.Controls.Clear();
                foreach (var top in EvaluationList.TopList(CompanyList.SearchCategoria(rbFrutosDoMar.Text)))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
        }

        private void RbOutros_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria())
            {
                remFiltro.Visible = true;
            }
            lbTop5.Text = "Top 5 " + rbOutros.Text;            
            if (EvaluationList.selectAll().Count != 0)
            {
                Top5.Controls.Clear();
                local1 = 42;
                foreach (var top in EvaluationList.TopList(CompanyList.SearchCategoria(rbOutros.Text)))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            remFiltro.Visible = false;
            rbChurrascaria.Checked = false;
            rbPizzaria.Checked = false;
            rbPetiscaria.Checked = false;
            rbSorveteria.Checked = false;
            rbComidaItaliana.Checked = false;
            rbComidaJaponesa.Checked = false;
            rbFrutosDoMar.Checked = false;
            rbHambúrgueria.Checked = false;
            rbOutros.Checked = false;
            lbTop5.Text = "Top 5 Restaurantes";
        }

        private void PesquisaBox_TextChanged(object sender, EventArgs e)
        {
            PesquisaBox.MaxLength = 50;
        }

        public void Listar()
        {
            if (EvaluationList.selectAll().Count != 0)
            {
                foreach (var top in EvaluationList.TopList(CompanyList.selectAll()))
                {
                    TopEmpresa emp = new TopEmpresa(top.NomeFantasia, top.Image);
                    emp.Location = new Point(20, local1);
                    local1 = local1 + emp.Height + 5;
                    Top5.Controls.Add(emp);
                }
            }
            //Listando Empresas
            pagTotal = CompanyList.selectAll().Count;
            if ((pagTotal % pagQuant) != 0)
            {
                pagTotal = (pagTotal / pagQuant);
                pagTotal++;
            }
            else
            {
                pagTotal = pagTotal / pagQuant;
            }
            pagAtual = 1;
            lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;

            int i = 0;

            foreach (var item in lista)
            {
                if (i >= pagQuant)
                    break;
                Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                exbEmp.Location = new Point(0, local);
                local = local + exbEmp.Height + 5;
                ListarEmpresas.Controls.Add(exbEmp);
                i++;
            }
        }

        private void Bt_ant_Click(object sender, EventArgs e)
        {
            GoPag("anterior");
        }

        private void Bt_prox_Click(object sender, EventArgs e)
        {
            GoPag("proxima");
        }

        private void Bt_proxFull_Click(object sender, EventArgs e)
        {
            GoPag("ultima");
        }

        private void Bt_antFull_Click(object sender, EventArgs e)
        {
            GoPag("primeira");
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            if (lbConfig1.Visible == false && lbConfig2.Visible == false)
            {
                lbConfig1.Visible = true;
                lbConfig2.Visible = true;
            }
            else
            {
                lbConfig1.Visible = false;
                lbConfig2.Visible = false;
            }
        }

        private void LbConfig1_MouseMove(object sender, MouseEventArgs e)
        {
            lbConfig1.BackColor = System.Drawing.Color.Red;
        }

        private void LbConfig1_MouseLeave(object sender, EventArgs e)
        {
            lbConfig1.BackColor = System.Drawing.Color.Red;
        }

        private void LbConfig2_MouseMove(object sender, MouseEventArgs e)
        {
            lbConfig2.BackColor = System.Drawing.Color.Red;
        }

        private void LbConfig2_MouseLeave(object sender, EventArgs e)
        {
            lbConfig2.BackColor = System.Drawing.Color.Red;
        }

        private void LbConfig1_Click(object sender, EventArgs e)
        {
            alimentos.Editar_Restaurante editRest = new Editar_Restaurante(result);
            FormPrincipal.MudarForm("alimentos", editRest);
        }

        private void LbConfig2_Click(object sender, EventArgs e)
        {            
                alimentos.Cadastro_Produto gerenProd = new Cadastro_Produto(result);
                FormPrincipal.MudarForm("alimentos", gerenProd);                     
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VerPedidos_Click(object sender, EventArgs e)
        {
            Lista_Pedidos pedidos = new Lista_Pedidos(CompanyList.verifEmp(Session.Cpf), false, -1);
            FormPrincipal.MudarForm("alimentos", pedidos);
        }

        private void PesquisaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(PesquisaBox.Text))
                {
                    MessageBox.Show("Por favor, informe o nome do estabelecimento.", "Aviso!");
                }
                else
                {
                    if (Categoria() == false)
                    {
                        if (PesquisaBox.Text.Equals(""))
                        {
                            ListarEmpresas.Controls.Clear();
                            lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                            msg.Location = new Point(0, 0);
                            ListarEmpresas.Controls.Add(msg);
                        }
                        else
                        {
                            lista = CompanyList.SearchName(PesquisaBox.Text);
                            if (lista.Count == 0)
                            {
                                ListarEmpresas.Controls.Clear();
                                lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                                msg.Location = new Point(0, 0);
                                ListarEmpresas.Controls.Add(msg);
                            }
                            else
                            {
                                ListarEmpresas.Controls.Clear();
                                local = 0;
                                foreach (var item in lista)
                                {
                                    Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                                    exbEmp.Location = new Point(0, local);
                                    local = local + exbEmp.Height + 5;
                                    ListarEmpresas.Controls.Add(exbEmp);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (PesquisaBox.Text.Equals(""))
                        {
                            ListarEmpresas.Controls.Clear();
                            lbMensagem msg = new lbMensagem("Nenhum resultado encontrado");
                            msg.Location = new Point(0, 0);
                            ListarEmpresas.Controls.Add(msg);
                        }
                        else
                        {
                            lista = CompanyList.SearchFiltro(PesquisaBox.Text, Filtro());
                            ListarEmpresas.Controls.Clear();
                            local = 0;
                            foreach (var item in lista)
                            {
                                Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                                exbEmp.Location = new Point(0, local);
                                local = local + exbEmp.Height + 5;
                                ListarEmpresas.Controls.Add(exbEmp);
                            }
                        }
                    }
                }
            }
        }

        public void GoPag(string p)
        {            
            int pagina;

            if (p.Equals("ant") || p.Equals("anterior"))
                pagina = -1;
            else if (p.Equals("prox") || p.Equals("proxima")) 
                pagina = -2;            
            else if (p.Equals("1") || p.Equals("primeira"))
                pagina = 1;
            else if (p.Equals("0") || p.Equals("ultima"))
                pagina = pagTotal;
            else
                pagina = int.Parse(p);


            if (lista.Count > pagQuant)
            {
                if (pagina == 1 && (pagAtual > 1))
                {
                    local = 0;
                    ListarEmpresas.Controls.Clear();

                    int i = 0;
                    foreach (var item in lista)
                    {
                        if (i >= pagQuant)
                            break;
                        Publi exbEmp = new Publi(item.NomeFantasia, item.Rua, item.Bairro, item.Numero, item.TelComercial, item.Categoria, item.Id);
                        exbEmp.Location = new Point(0, local);
                        local = local + exbEmp.Height + 5;
                        ListarEmpresas.Controls.Add(exbEmp);
                        i++;
                    }
                    lb_pag.Text = "Pagina " + 1 + " de " + pagTotal;
                    pagAtual = 1;

                }
                else if (pagina == pagTotal && (pagAtual < pagTotal))
                {
                    local = 0;
                    ListarEmpresas.Controls.Clear();

                    int pg = ((pagTotal - 1) * pagQuant);
                    for (int i = 0; i < pagQuant; i++)
                    {
                        if (pg + i < lista.Count)
                        {
                            Publi exbEmp = new Publi(lista[pg + i].NomeFantasia, lista[pg + i].Rua, lista[pg + i].Bairro, lista[pg + i].Numero, lista[pg + i].TelComercial, lista[pg + i].Categoria, lista[pg + i].Id);
                            exbEmp.Location = new Point(0, local);
                            local = local + exbEmp.Height + 5;
                            ListarEmpresas.Controls.Add(exbEmp);
                        }

                    }

                    pagAtual = pagTotal;
                    lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;

                }
                else if (pagina == -1)
                {
                    if (pagAtual > 1)
                    {
                        local = 0;
                        ListarEmpresas.Controls.Clear();

                        int pg = ((pagAtual - 2) * pagQuant);

                        for (int i = 0; i < pagQuant; i++)
                        {
                            if (pg + i < lista.Count)
                            {
                                Publi exbEmp = new Publi(lista[pg + i].NomeFantasia, lista[pg + i].Rua, lista[pg + i].Bairro, lista[pg + i].Numero, lista[pg + i].TelComercial, lista[pg + i].Categoria, lista[pg + i].Id);
                                exbEmp.Location = new Point(0, local);
                                local = local + exbEmp.Height + 5;
                                ListarEmpresas.Controls.Add(exbEmp);
                            }
                        }
                        pagAtual--;

                        lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
                    }
                }
                else if (pagina == -2)
                {
                    if (pagAtual < pagTotal)
                    {
                        local = 0;
                        ListarEmpresas.Controls.Clear();                        
                        int pg = (pagAtual * pagQuant);

                        for (int i = 0; i < pagQuant; i++)
                        {
                            if (pg + i < lista.Count)
                            {
                                Publi exbEmp = new Publi(lista[pg + i].NomeFantasia, lista[pg + i].Rua, lista[pg + i].Bairro, lista[pg + i].Numero, lista[pg + i].TelComercial, lista[pg + i].Categoria, lista[pg + i].Id);
                                exbEmp.Location = new Point(0, local);
                                local = local + exbEmp.Height + 5;
                                ListarEmpresas.Controls.Add(exbEmp);
                            }

                        }
                        pagAtual++;
                        lb_pag.Text = "Pagina " + pagAtual + " de " + pagTotal;
                    }
                }
            }
        }
    }
}
