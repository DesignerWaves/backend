using System;
using Aula.Controllers;
using Aula.Models;

namespace Aula {
    class Program {
        static void Main (string[] args) {
            CarroController carro = new CarroController ();
            CarroEletricoController carroEletrico = new CarroEletricoController();

            Console.Clear (); //limpar tela antes de executar

            carro.Ligar ();

            carro.Desligar ();

            carro.Acelerar ();
            
            carro.CadastrarMotor();

            carroEletrico.CarregarBateria(120);
            carroEletrico.CarregarBateria(15);

            System.Console.WriteLine("Carga do carro: " + carroEletrico.StatusBateria());
        }
    }
}