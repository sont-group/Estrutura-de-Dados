﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.alimentos.classes
{
    class ListPedidos
    {
        private static List<Delivery> pedidos = new List<Delivery>();

        public static void Add(Delivery pedido)
        {
            Delivery del = new Delivery();
            del.Rua = pedido.Rua;
            del.Numero = pedido.Numero;
            del.Nome = pedido.Nome;
            del.Referencia = pedido.Referencia;
            del.Pedidos = pedido.Pedidos;
            del.Observacoes = pedido.Observacoes;
            del.Cpf = pedido.Cpf;
            del.Valor = pedido.Valor;
            del.IdEmpresa = pedido.IdEmpresa;
            del.Pagamento = pedido.Pagamento;
            pedidos.Add(del);
            pedidos[pedidos.IndexOf(del)].IdPedido = pedidos.IndexOf(del);
        }
        public static List<Delivery> selectAll()
        {
            return pedidos;
        }
        public static void Delete(int ID)
        {
            try
            {
                foreach (var rem in pedidos)
                {
                    if (rem.IdPedido == ID)
                    {
                        pedidos.Remove(rem);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
