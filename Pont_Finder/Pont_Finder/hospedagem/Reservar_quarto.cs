﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pont_Finder.hospedagem
{
    public partial class Reservar_quarto : Form
    {
        Form anterior;
        private int id_reserva = 0;
        private int id_quarto, qtd_pessoas, qtd_disponivel;
        private DateTime data_inicial, data_final;
        private double valor_reserva, valor;
        private long cpf_user, telefone_emp;
        private string nome, empresa, servicos, foto, status, tipo, nome_emp, fotos_emp, endereco_emp, descricao_emp, email_emp, logo_emp, metodo;

        classes.Reserva reserva = new classes.Reserva();

        private void bt_finalizar_Click(object sender, EventArgs e)
        {
            if(rb_boleto.Checked || rb_cartao.Checked)
            {
                reserva.Id = classes.reserveList.Tam;
                reserva.IdQuarto = id_quarto;
                reserva.Usuario = cpf_user;
                reserva.Data_inicial = data_inicial;
                reserva.Data_final = data_final;
                reserva.MetodoPagamento = metodo;
                reserva.Valor = valor_reserva;
                reserva.Status = true;

                classes.reserveList.addReserva(reserva);

                if (metodo == "Boleto")
                {
                    Boleto.GerarBoleto bol = new Boleto.GerarBoleto(Session.Cpf, reserva.Valor);
                    bol.ShowDialog();
                }

                MessageBox.Show("Reserva Realizada Com Sucesso");

                FormPrincipal.MudarForm("hospedagem", new List_reservas_user(anterior));
            }
            else
            {
                MessageBox.Show("Você deve selecionar um metodo de pagamento para prosseguir.");
            }
        }

        private void lb_data_saida_Click(object sender, EventArgs e)
        {

        }

        List<string> icones = new List<string>();


        private void pn_icons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
            FormPrincipal.MudarForm("hospedagem", new Vizualizar_quarto(id_quarto,anterior));
        }
        

        private void lb_nome_quarto_Click(object sender, EventArgs e)
        {

        }

        public Reservar_quarto(int id, Form anterior, DateTime data_ini, DateTime data_fim, long cpf_usuario)
        {
            if (Session.Online)
            {
               
                classes.Reserva reserva = new classes.Reserva();

                Quarto quarto = new Quarto();

                quarto = roomList.SelectId(id);

                Empresa emp = hostList.selectCnpj(quarto.Cnpj_Empresa);

                InitializeComponent();

                this.anterior = anterior;

                this.id_quarto = quarto.ID;
                //Long
                this.cpf_user = cpf_usuario;
                this.telefone_emp = emp.Telefone;
                //Strings
                this.nome = quarto.NomeQuarto;
                this.empresa = emp.Nomefantasia;
                this.servicos = quarto.Servicos;
                this.foto = quarto.Foto;
                this.status = quarto.Status;
                this.tipo = quarto.Tipo;
                this.nome_emp = emp.Nomeempresa;
                this.endereco_emp = emp.Endereco;

                //Double
                this.valor = quarto.Valor_Diario;

                //DateTimes
                this.data_inicial = data_ini;
                this.data_final = data_fim;
                //int 
                this.id_quarto = quarto.ID;
                this.id_reserva = id_reserva++;
                this.qtd_pessoas = quarto.Qtd_Pessoas;
                this.qtd_disponivel = quarto.Qtd_Disponivel;

                if (servicos.Contains("Café da tarde") == true)
                {
                    string caminho = "..\\..\\hospedagem\\data\\icones\\cafe.png";
                    icones.Add(caminho);
                }

                if (servicos.Contains("Ar Condicionado") == true)
                {
                    string caminho = "..\\..\\hospedagem\\data\\icones\\Ar_condicionado(1).png";
                    icones.Add(caminho);
                }

                if (servicos.Contains("Café da manhã") == true)
                {
                    string caminho = "..\\..\\hospedagem\\data\\icones\\breakfast.png";
                    icones.Add(caminho);
                }

                if (servicos.Contains("Almoço") == true)
                {

                    string caminho = "..\\..\\hospedagem\\data\\icones\\almoço.png";
                    icones.Add(caminho);
                }

                if (servicos.Contains("TV a cabo") == true)
                {
                    string caminho = "..\\..\\hospedagem\\data\\icones\\tv.png";
                    icones.Add(caminho);
                }

                if (servicos.Contains("Espaço PET") == true)
                {
                    string caminho = "..\\..\\hospedagem\\data\\icones\\pet.png";
                    icones.Add(caminho);
                }
                if (servicos.Contains("Wi-fi") == true)
                {
                    string caminho = "..\\..\\hospedagem\\data\\icones\\wifi.png";
                    icones.Add(caminho);
                }

            }
            else
            {
                MessageBox.Show("Necessario estar logado");
            }
            
        }
        

        
        private void rb_boleto_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (rb_boleto.Checked)
                {
                    metodo = "Boleto";
                    int totalDias = ((DateTime.Parse(lb_data_saida.Text).Subtract(DateTime.Parse(lb_data_entrada.Text))).Days) + 1;
                    valor_reserva = (totalDias * valor);
                    hospedagem.data.inc.Reserva_boleto boleto = new data.inc.Reserva_boleto();
                    boleto.Location = new Point(0, 0);
                    panel_center.Controls.Add(boleto);
                    
                }
                else
                {
                    panel_center.Controls.Clear();
                }
            }
        }

        private void rb_cartao_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_cartao.Checked)
            {
                metodo = "Cartao de Credito";
                int totalDias = ((DateTime.Parse(lb_data_saida.Text).Subtract(DateTime.Parse(lb_data_entrada.Text))).Days) + 1;
                valor_reserva = (totalDias * (valor +  (valor * 0.15)));
                hospedagem.data.inc.Reserva_cartao cartao = new data.inc.Reserva_cartao();
                cartao.Location = new Point(0, 0);
                panel_center.Controls.Add(cartao);
            }
            else
            {
                panel_center.Controls.Clear();
            }
        }

        private void Panel_center_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Reservar_quarto_Load(object sender, EventArgs e)
        {
            int v = 5;
            foreach (var item in icones)
            {
                data.inc.icon icone_uc = new data.inc.icon(item);

                icone_uc.Location = new Point((v), 0);
                v = icone_uc.Width + v + 5;
                pn_icons.Width = pn_icons.Width + 180;
                pn_icons.Controls.Add(icone_uc);
            }

            lb_nome_quarto.Text = nome;
            lb_tipo_quarto.Text = tipo;
            lb_data_entrada.Text = Convert.ToString(data_inicial.ToShortDateString());
            lb_data_saida.Text = Convert.ToString(data_final.ToShortDateString());
            lb_nome_emp.Text = nome_emp;
            lb_endereco_emp.Text = endereco_emp;

            pictureBox3.ImageLocation = foto;
            pictureBox3.Load();

            int totalDias = ((DateTime.Parse(lb_data_saida.Text).Subtract(DateTime.Parse(lb_data_entrada.Text))).Days) + 1;

            lb_rs_cartao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}",(totalDias * (valor + (valor * 0.15))));
            lb_rs_boleto.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", (totalDias * valor));

        }
    }
}
