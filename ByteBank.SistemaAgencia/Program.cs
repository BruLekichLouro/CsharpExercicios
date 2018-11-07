﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente contaDaBru = new ContaCorrente(1111, 1111111);

            lista.Adicionar(contaDaBru);
            lista.Adicionar(new ContaCorrente(453, 234555));
            lista.Adicionar(new ContaCorrente(455, 234855));
            lista.Adicionar(new ContaCorrente(455, 234851));
            lista.Adicionar(new ContaCorrente(495, 234858));
            lista.Adicionar(new ContaCorrente(475, 234859));
            lista.Adicionar(new ContaCorrente(435, 234856));
            lista.Adicionar(new ContaCorrente(425, 234854));
            lista.Adicionar(new ContaCorrente(445, 234853));
            lista.Adicionar(new ContaCorrente(145, 235853));
            lista.Adicionar(new ContaCorrente(545, 234893));
            lista.Adicionar(new ContaCorrente(345, 134853));
            lista.Remover(contaDaBru);

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            Console.ReadLine();

        }
    }
}
