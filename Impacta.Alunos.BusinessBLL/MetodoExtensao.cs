﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impacta.Alunos.BusinessBLL
{
    public static class MetodoExtensao
    {
        /// <summary>
        /// Método para validar se o campo texto está vazio
        /// </summary>
        /// <param name="txt"></param>
        /// <returns>Texto já validado</returns>
        public static string ValidarVazio(this string txt)
        {
            if (string.IsNullOrWhiteSpace(txt))
            {
                throw new Exception("Os campos obrigatórios devem ser preenchidos");
            }
            return txt;
        }


    }

    /// <summary>
    /// Método para validar o CPF informado
    /// </summary>
    /// <param name="texto"></param>
    /// <returns></returns>
    //public static bool ValidarCPF(this String cpf)
    //{

    ////Consistir os dados
    //if (string.IsNullOrWhiteSpace(cpf))
    //{
    //    throw new Exception("CPF é obrigatório");
    //}

    ////Definir as variáveis
    ////Tratando o CPF informado
    //string cpfInformado = cpf
    //                        .Replace(".", "")
    //                        .Replace("-", "")
    //                        .Replace(" ", "");

    ////Verificar o número de posições para validação (11 posições)
    //if (cpfInformado.Length != 11)
    //{
    //    throw new Exception("Informe um CPF com 11 posições");
    //}

    ////Separar as primeiras 9 posições (sem os dígitos)
    //string cpf = cpfInformado.Substring(0, 9);
    ////Definir acumulador
    //int soma = 0;
    ////CALCULAR PRIMEIRO DÍGITO VERIFICADOR
    ////Definir o valor de referência para o cálculo
    //int valorRef = 10;

    ////Posição vai de 0 a 8 enquanto valorRef vai de 10 a 2
    //for (int i = 0; i <= 8; i++)
    //{
    //    soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
    //}
    ////Primeiro dígito é o resto do valor acumulado dividido por 11
    //int dv1 = (int)(soma % 11);
    ////Se dv for menor que 2, então dv vale 0
    ////Se dv for maior ou igual a 2, então dv vale 11 menos dv
    //if (dv1 < 2)
    //{
    //    dv1 = 0;
    //}
    //else
    //{
    //    dv1 = 11 - dv1;
    //}

    ////Verificar se o primeiro dígito verificador informado é válido
    //if (!cpfInformado.Substring(9, 1).Equals(dv1.ToString()))
    //{
    //    throw new Exception("Informe um CPF válido");
    //}

    ////CALCULAR SEGUNDO DÍGITO VERIFICADOR
    ////Acrescentando dv1 ao cpf de teste
    //cpf = cpf + dv1.ToString();
    ////"Zerar" as variáveis
    //valorRef = 11;
    //soma = 0;
    ////Posição vai de 0 a 9 enquanto valorRef vai de 11 a 2
    //for (int i = 0; i <= 9; i++)
    //{
    //    soma += Convert.ToInt32(cpf[i].ToString()) * valorRef--;
    //}
    ////Segundo dígito é o resto do valor acumulado dividido por 11
    //int dv2 = (int)(soma % 11);

    ////Se dv for menor que 2, então dv vale 0
    ////Se dv for maior ou igual a 2, então dv vale 11 menos dv
    //if (dv2 < 2)
    //{
    //    dv2 = 0;
    //}
    //else
    //{
    //    dv2 = 11 - dv2;
    //}
    ////Verificar se o segundo dígito verificador informado é válido
    //if (!cpfInformado.Substring(10, 1).Equals(dv2.ToString()))
    //{
    //    throw new Exception("Informe um CPF válido");
    //}

    ////Mensagem exibida caso CPF seja válido
    //return true;
//}
}
