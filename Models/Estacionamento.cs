using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_01___Sistema_de_Estacionamento.Models
{
    public class Estacionamento
    {
        List<string> veiculos = new List<string>();
        decimal valorPrecoInicial = 0;
        decimal valorPrecoPorHora = 0;
        
        public void precoInicial(){
            Console.WriteLine("Digite o preço inicial:");
            string? valorEstacionamento = Console.ReadLine();
            valorPrecoInicial += Convert.ToDecimal(valorEstacionamento);
        }

        public void precoPorHora(){
            Console.WriteLine("Agora digite o preço por hora:");
            string? valorPorHora = Console.ReadLine();
            valorPrecoPorHora += Convert.ToDecimal(valorPorHora);
        }

        public void AdicionarVeiculo(string value){
            veiculos.Add(value);
        }

        public void RemoverVeiculos(string value){
            veiculos.Remove(value);
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            string? horas = Console.ReadLine();
            Console.WriteLine($"O veículo {value} foi removido e o preço total foi de: R$ {valorPrecoInicial + valorPrecoPorHora * Convert.ToDecimal(horas)}");
        }

        public void ListarVeiculos(){
            foreach(string veiculo in veiculos){
                Console.WriteLine(veiculo);
            }
        }
    }
}

