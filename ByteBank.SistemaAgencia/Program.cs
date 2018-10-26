﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //DateTime dataFimPagamento = new DateTime(2019, 12, 17);
            //DateTime dataCorrente = DateTime.Now;
            //TimeSpan diferenca = dataFimPagamento - dataCorrente;
            //TimeSpan outro = TimeSpan.FromMinutes(40);
            //string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            //Console.WriteLine(dataCorrente);
            //Console.WriteLine(dataFimPagamento);
            //Console.WriteLine(mensagem);
            //Console.WriteLine(outro);

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL url2 = new ExtratorValorDeArgumentosURL(urlParametros);
            string valor = url2.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = url2.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(url2.GetValor("valor"));
            Console.ReadLine();

        }
    }
}
