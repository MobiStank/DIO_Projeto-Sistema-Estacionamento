using Projeto_01___Sistema_de_Estacionamento.Models;


Estacionamento estacionamento = new Estacionamento();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
estacionamento.precoInicial();
estacionamento.precoPorHora();

bool exit = true;

while(exit){

    Console.Clear();
    Console.WriteLine("1.Cadastrar veículo");
    Console.WriteLine("2.Remover veículo");
    Console.WriteLine("3.Listar veículos");
    Console.WriteLine("4.Encerrar");
    string? opcao = Console.ReadLine();

    if(opcao == "1"){
        Console.WriteLine("-Cadastrar Veículo-");
        Console.WriteLine("Placa: \r");
        string? veiculoNovo = Console.ReadLine();
        if (veiculoNovo is not null){
            estacionamento.AdicionarVeiculo(veiculoNovo);
        } else {
            Console.WriteLine("Placa Inválida");
        }

    } else if(opcao == "2"){
        Console.WriteLine("-Remover Veículo-");
        Console.WriteLine("Placa: ");
        string? veiculoRemover = Console.ReadLine();
        if(veiculoRemover is not null){
            estacionamento.RemoverVeiculos(veiculoRemover);
        }
        
    } else if(opcao == "3"){
        Console.WriteLine("Veículos Armazenados: ");
        estacionamento.ListarVeiculos();

    } else if(opcao == "4"){
        Console.WriteLine("Encerrando...");
        exit = false;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");