using ProjetoElevador.Models;
using ProjetoElevador.View;
using System;

namespace ProjetoElevador.Controller
{
    internal class ControllerElevador
    {
        //Inicialização
       public void Initial()
        {
            Console.WriteLine("Bem-vindos(as) ao Edifício Ocean");
            Console.WriteLine("Quantos andares o edificio possui?");
            var andares = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Qual a capacidade do elevador?");
            var capacidade = int.Parse(Console.ReadLine());

            Console.Clear();

            var elevador = new Elevador(capacidade, andares);

            var elevadorView = new ViewElevador();

            elevadorView.Projeto(elevador);
        }
    }
}
