﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder
{
    class Validation
    {
        public static bool Email(string email)
        {
            if (email.Contains("@") && email.Contains(".") && (email.IndexOf("@") < (email.IndexOf("."))))
                return true;
            else
                return false;
        }

        public static bool Cpf(long cpf)
        {
            if (("" + cpf).Length != 11)
            {
                return false;
            }
            else if (cpf == 00000000000 || cpf == 11111111111 || cpf == 22222222222 || cpf == 33333333333 ||
                    cpf == 44444444444 || cpf == 55555555555 || cpf == 66666666666 || cpf == 77777777777 ||
                    cpf == 88888888888 || cpf == 99999999999)
            {
                return false;
            }
            else
            {
                string scpf = cpf.ToString();
                int[] vcpf = new int[11];

                for (int i = 0; i < 11; i++)
                {
                    vcpf[i] = int.Parse(scpf[i].ToString());
                }

                int[] v = new int[2];

                //Calcula o primeiro dígito de verificação.
                v[0] = 1 * vcpf[0] + 2 * vcpf[1] + 3 * vcpf[2];
                v[0] += 4 * vcpf[3] + 5 * vcpf[4] + 6 * vcpf[5];
                v[0] += 7 * vcpf[6] + 8 * vcpf[7] + 9 * vcpf[8];
                v[0] = v[0] % 11;
                v[0] = v[0] % 10;

                //Calcula o segundo dígito de verificação.
                v[1] = 1 * vcpf[1] + 2 * vcpf[2] + 3 * vcpf[3];
                v[1] += 4 * vcpf[4] + 5 * vcpf[5] + 6 * vcpf[6];
                v[1] += 7 * vcpf[7] + 8 * vcpf[8] + 9 * v[0];
                v[1] = v[1] % 11;
                v[1] = v[1] % 10;


                if ((v[0] != vcpf[9]) || (v[1] != vcpf[10]))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public static bool Cnpj(string cnpj)

        {
            string cnpjT;                                                                           //Temporário

            int[] verificardig1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };               //Comparações/multiplicação do primeiro digito

            int[] verificardig2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };             //Comparações/multiplicação do primeiro digito

            int soma;

            string digito;

            cnpj = cnpj.Trim();

            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");                         //Tirar ".","-" e "/" da string a ser utilizada

            if (cnpj.Length != 14)

                return false;

            cnpjT = cnpj.Substring(0, 12);

            soma = 0;

            //Calcular o primeiro digito de verificação

            for (int i = 0; i < 12; i++)

                soma += int.Parse(cnpjT[i].ToString()) * verificardig1[i];


            if (soma % 11 < 2)

                digito = "0";

            else

                digito = (11 - (soma % 11)).ToString();

            cnpjT = cnpjT + digito;

            soma = 0;

            //Calcular o segundo digito de verificação

            for (int i = 0; i < 13; i++)

                soma += int.Parse(cnpjT[i].ToString()) * verificardig2[i];


            if (soma % 11 < 2)

                digito = "0";

            else

                digito = digito + (11 - (soma % 11)).ToString();

            return cnpj.EndsWith(digito);

        }
    }
}
